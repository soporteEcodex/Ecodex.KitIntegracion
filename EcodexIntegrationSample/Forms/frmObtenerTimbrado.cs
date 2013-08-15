using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EcodexIntegrationSample.Forms
{
    public partial class frmObtenerTimbrado : Form, View.IfrmObtenerTimbrado
    {
        public frmObtenerTimbrado()
        {
            InitializeComponent();
            var controller = new Controllers.frmObtenerTimbradoController(this);
        }

        private void obtenerTimbradoButton_Click(object sender, EventArgs e)
        {
            if (onObtenerTimbrado != null)
                onObtenerTimbrado(this, EventArgs.Empty);
        }
        #region Interfaz
        public string UUID
        {
            get { return txtUUID.Text; }
        }

        public string RFC
        {
            get { return txtRFC.Text; }
        }

        public event EventHandler onObtenerTimbrado;

        public void ShowSessionError(Entity.SessionError error)
        {
            MessageBox.Show(String.Format("Status {0}: {1}", error.Status.ToString(), error.Description), "Ecodex UniTest");
        }

        public void ShowUnknownError(string message)
        {
            MessageBox.Show(String.Format("Error: {0}", message), "Ecodex UniTest");
        }
        
        public string stringTimbrado
        {
            set { txtResult.Text = value; }
        }
        
        long View.IfrmObtenerTimbrado.transactionID
        {
            get 
            {  
                Int64 result = 0;
                Int64.TryParse(txtTransactionID.Text, out result);
                return result;
            }
        }
        #endregion

    }
}
