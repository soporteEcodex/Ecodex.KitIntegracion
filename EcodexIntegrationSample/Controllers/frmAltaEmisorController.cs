using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace EcodexIntegrationSample
{
    class frmAltaEmisorController
    {
        private View.IAltaEmisor _view;

        public frmAltaEmisorController(View.IAltaEmisor view)
        {
            _view = view;
            _view.onAltaEmisor += View_onAltaEmisor;
        }

        void View_onAltaEmisor(object sender, EventArgs e)
        {
            using (var Cliente = new SrvClients.ClientesClient())
            {
                long trsId = _view.TransaccionId;
                long trsIdO=0;
                string token = string.Empty;

                string Error;
                Utils.Utilerias Util = new Utils.Utilerias(_view);
                Error = Util.CreateTokenAlta(_view.RFCIntegrador, trsId, ref token);
                if (!string.IsNullOrEmpty(Error))
                {
                    _view.ShowUnknownError(Error);
                    return;
                }
                try 
                {
                    var Emisor = new SrvClients.AltaEmisor();
                    Emisor.RFC = _view.RFCEmisor;
                    Emisor.RazonSocial = _view.RazonSocial;
                    Emisor.CorreoElectronico = _view.CorreoElectronico;
                    var respuesta = Cliente.Registrar(Emisor, _view.RFCIntegrador, token, trsId, out trsIdO);
                    _view.RFCEmisor = respuesta.RFC;
                    _view.Estatus = respuesta.Estatus;
                    _view.ClaveCertificado = respuesta.ClaveCertificado;
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
