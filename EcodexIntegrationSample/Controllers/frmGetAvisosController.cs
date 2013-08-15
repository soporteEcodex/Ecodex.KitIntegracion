using System;
using System.ServiceModel;
using System.Windows.Forms;

namespace EcodexIntegrationSample
{
    class frmGetAvisosController
    {
        private View.IfrmGetAvisos _view;
        //private const string INTEGRATOR_ID = "123";

        public frmGetAvisosController(View.IfrmGetAvisos view)
        {
            _view = view;
            _view.onGetAdvices += _view_onGetAdvices;
        }

        void _view_onGetAdvices(object sender, EventArgs e)
        {
            using (var Avisos = new SrvClients.ClientesClient())
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
                    var respuesta = Avisos.AvisosNuevos(_view.RFC, token, ref transactionID);
                    ListViewItem[] Items = new ListViewItem[0];
                    foreach (var item in respuesta)
                    {
                        ListViewItem lsvItem = new ListViewItem(item.Mensaje);
                        lsvItem.SubItems.Add(item.Vigencia.ToShortDateString());
                        if (Items.Length == 0 || Items[0] != null)
                        {
                            Array.Resize<ListViewItem>(ref Items, Items.Length + 1);
                        }
                        Items[Items.Length - 1] = lsvItem;
                    }
                    _view.itemsAdvices = Items;
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
