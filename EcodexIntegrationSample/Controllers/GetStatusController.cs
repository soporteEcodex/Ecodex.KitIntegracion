using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace EcodexIntegrationSample
{
    class GetStatusController
    {
        private View.IGetStatus _view;
        //private const string INTEGRATOR_ID = "123";

        public GetStatusController(View.IGetStatus view)
        {
            _view = view;
            _view.onGetStatus += _view_onGetStatus;

        }

        void _view_onGetStatus(object sender, EventArgs e)
        {
            using (var Comprobante = new SrvRepository.RepositorioClient())
            {
                Random _random = new Random();
                Int64 transactionNueva = _random.Next();
                Int64 transactionID = _view.transactionID;
                string token = string.Empty;

                string Error;
                Utils.Utilerias Util = new Utils.Utilerias(_view);
                Error = Util.CreateToken(_view.RFC, transactionID, ref token);
                if (!string.IsNullOrEmpty(Error))
                {
                    _view.ShowUnknownError(Error);
                    return;
                }
                try
                {
                    var respuesta = Comprobante.EstatusComprobante(_view.RFC, token, ref transactionNueva, transactionID, _view.UUID);
                    _view.code = respuesta.Codigo.ToString();
                    _view.description = respuesta.Descripcion;
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
