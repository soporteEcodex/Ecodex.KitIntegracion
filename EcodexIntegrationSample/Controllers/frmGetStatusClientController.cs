using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace EcodexIntegrationSample
{
    class frmGetStatusClientController
    {
        private View.IfrmGetStatusClient _view;
        //private const string INTEGRATOR_ID = "af0bfdd7-4b7d-43f0-9b06-a196ff6da78b";

        public frmGetStatusClientController(View.IfrmGetStatusClient view)
        {
            _view = view;
            _view.onGetStatusClient += View_onGetStatusClient;
        }

        void View_onGetStatusClient(object sender, EventArgs e)
        {
            using (var Client = new SrvClients.ClientesClient())
            {
                Random _random = new Random();
                Int64 transactionID = _random.Next();
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
                    var respuesta = Client.EstatusCuenta(_view.RFC, token, ref transactionID);
                    _view.InvoicesAsigned = respuesta.TimbresAsignados.ToString();
                    _view.InvoicesRemaining = respuesta.TimbresDisponibles.ToString();
                    //_view.InvoicesUsed=respuesta.TimbresEmitidos;
                    _view.DateStart = respuesta.FechaInicio;
                    _view.DateEnd = respuesta.FechaFin;
                    _view.Description = respuesta.Descripcion;
                }
                catch (FaultException<SrvClients.FallaServicio> fallaServicio)
                {
                    using (var errorForm = new Forms.Error(TranslateFault.ToServiceError(fallaServicio.Detail)))
                    {
                        errorForm.ShowDialog();
                    }
                }
                catch (FaultException<SrvClients.FallaSesion> fallaSesion)
                {
                    _view.ShowSessionError(TranslateFault.ToSessionError(fallaSesion.Detail));
                }
                catch (Exception ex)
                { _view.ShowUnknownError(ex.Message); }
            }
        }
    }
}
