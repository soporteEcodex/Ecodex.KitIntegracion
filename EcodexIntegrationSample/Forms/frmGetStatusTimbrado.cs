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
    public partial class frmGetStatusTimbrado : Form,View.IfrmGetStatusTimbrado
    {
        public frmGetStatusTimbrado()
        {
            InitializeComponent();
            var controller =new Controllers.frmGetStatusTimbradoController(this);
        }

        private void cancelarTimbradoButton_Click(object sender, EventArgs e)
        {
            if(onGetStatusTimbrado != null)
                onGetStatusTimbrado(this, EventArgs.Empty);
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

        public long transactionID
        {
            get 
            {
                Int64 result = 0;
                Int64.TryParse(txtTransactionID.Text, out result);
                return result;
            }
        }

        public string description
        {
            set { txtDescription.Text = value; }
        }

        public string code
        {
            set { txtCode.Text = value; }
        }

        public event EventHandler onGetStatusTimbrado;

        public void ShowSessionError(Entity.SessionError error)
        {
            MessageBox.Show(String.Format("Status {0}: {1}", error.Status.ToString(), error.Description), "Ecodex UniTest");
        }

        public void ShowUnknownError(string message)
        {
            MessageBox.Show(String.Format("Error: {0}", message), "Ecodex UniTest");
        }
        #endregion.
    }
}
