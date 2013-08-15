using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace EcodexIntegrationSample
{
    class frmComprobanteController
    {
        private View.IfrmComprobante _view;
        //private const string INTEGRATOR_ID = "123";

        public frmComprobanteController(View.IfrmComprobante view)
        {
            _view = view;
            _view.onGetInvoice += View_onGetInvoice;
        }

        void View_onGetInvoice(object sender, EventArgs e)
        {
            using (var Comprobante = new SrvRepository.RepositorioClient())
            {
                Int64 transactionID = _view.transactionID;
                Random _random = new Random();
                Int64 transactionNueva = _random.Next();
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
                    var respuesta = Comprobante.ObtenerComprobante(_view.RFC, token, ref transactionNueva, transactionID, _view.UUID);

                    _view.Invoice = respuesta.DatosXML;
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
