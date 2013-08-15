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
    public partial class frmGetStatusClient : Form, View.IfrmGetStatusClient
    {
        public frmGetStatusClient()
        {
            InitializeComponent();
            var controller = new frmGetStatusClientController(this);
        }
        #region Implementacion IfrmGetStatusClient
        public string RFC
        {
            get { return txtRFC.Text; }
        }

        public string InvoicesAsigned
        {
            set { txtInvoicesAsigned.Text = value; }
        }

        public string InvoicesRemaining
        {
            set { txtInvoicesRemaining.Text = value; }
        }

        public string InvoicesUsed
        {
            set { txtInvoicesUsed.Text = value; }
        }

        public DateTime DateStart
        {
            set { txtDateStart.Text = value.ToShortDateString(); }
        }

        public DateTime DateEnd
        {
            set { txtDateEnd.Text = value.ToShortDateString(); }
        }

        public string Description
        {
            set { txtDescription.Text = value; }
        }

        public event EventHandler onGetStatusClient;

        public void ShowSessionError(Entity.SessionError error)
        {
            MessageBox.Show(String.Format("Status {0}: {1}", error.Status.ToString(), error.Description), "Ecodex UniTest");
        }

        public void ShowUnknownError(String message)
        {
            MessageBox.Show(String.Format("Error: {0}", message), "Ecodex UniTest");
        }
        #endregion

        private void btnRetrive_Click(object sender, EventArgs e)
        {
            if (onGetStatusClient != null)
                onGetStatusClient(this, EventArgs.Empty);
        }

    }
}
