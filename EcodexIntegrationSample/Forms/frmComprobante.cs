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
    public partial class frmComprobante : Form, View.IfrmComprobante
    {
        public frmComprobante()
        {
            InitializeComponent();
            var controller = new frmComprobanteController(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (onGetInvoice != null)
                onGetInvoice(this, EventArgs.Empty);
        }
        #region Interface Implementation

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

        public string Invoice
        {
            set { txtInvoice.Text = value; }
        }
        public event EventHandler onGetInvoice;

        public void ShowSessionError(Entity.SessionError error)
        {
            MessageBox.Show(String.Format("Status {0}: {1}", error.Status.ToString(), error.Description), "Ecodex UniTest");
        }

        public void ShowUnknownError(String message)
        {
            MessageBox.Show(String.Format("Error: {0}", message), "Ecodex UniTest");
        }
        #endregion

    }
}
