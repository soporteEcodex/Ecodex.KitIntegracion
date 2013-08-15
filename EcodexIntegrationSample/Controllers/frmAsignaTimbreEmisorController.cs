using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace EcodexIntegrationSample
{
    class frmAsignaTimbreEmisorController
    {
        private View.IfrmAsignarTimbreEmisor _view;

        public frmAsignaTimbreEmisorController(View.IfrmAsignarTimbreEmisor view)
        {
            _view = view;
            _view.onAsignarTimbreEmisor += View_onAsignarTimbresEmisor;
        }

        void View_onAsignarTimbresEmisor(object sender, EventArgs e)
        {
            using (var AsignaTimbre = new SrvClients.ClientesClient())
            {
                long trsID = _view.trsID;
                string token = string.Empty;
                int SaldoNuevo = 0;

                string Error;
                Utils.Utilerias Util = new Utils.Utilerias(_view);
                Error = Util.CreateToken(_view.RFCAsignar, trsID, ref token);
                if (!string.IsNullOrEmpty(Error))
                {
                    _view.ShowUnknownError(Error);
                    return;
                }
                try
                {
                    var respuesta = AsignaTimbre.AsignacionTimbres(_view.RFCAsignar, _view.TimbresAsignar, ref token, ref trsID,out SaldoNuevo);
                    _view.SaldoAnterior = respuesta;
                    _view.SaldoNuevo = SaldoNuevo;
                    
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
