using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace EcodexIntegrationSample
{
    class frmRecuperaAcuseCancelacionController
    {
        private View.IfrmRecuperaAcuseCancelacion _view;

        public frmRecuperaAcuseCancelacionController(View.IfrmRecuperaAcuseCancelacion view)
        {
            _view = view;
            _view.onRecuperaAcuseCancelacion += View_onRecuperaAcuseCancelacion;
        }

        void View_onRecuperaAcuseCancelacion(object sender, EventArgs e)
        {
            using (var Cancelacion = new SrvCancelacion.CancelacionesClient())
            {
                long trsId = _view.TransaccionId;
                string token = string.Empty;
                string Estatus=string.Empty;
                string Error;
                Utils.Utilerias Util = new Utils.Utilerias(_view);
                Error = Util.CreateToken(_view.RFCEmisor, trsId, ref token);
                if (!string.IsNullOrEmpty(Error))
                {
                    _view.ShowUnknownError(Error);
                    return;
                }
                try
                {
                    var respuesta = Cancelacion.RecuperarAcuses(_view.RFCEmisor, token, ref trsId, _view.UUID, out Estatus);
                    _view.AcuseXML = respuesta;
                    _view.Estatus = Estatus;
                    _view.UUID = _view.UUID;
                }
                catch (FaultException<SrvRepository.FallaServicio> serviceFault)
                {
                    using (var errorForm = new Forms.Error(TranslateFault.ToServiceError(serviceFault.Detail)))
                    {
                        errorForm.ShowDialog();
                    }
                }
                catch (FaultException<SrvRepository.FallaSesion> sessionFault)
                {
                    _view.ShowSessionError(TranslateFault.ToSessionError(sessionFault.Detail));
                }
                catch (Exception ex)
                { _view.ShowUnknownError(ex.Message); }
            }
        }
    }
}
