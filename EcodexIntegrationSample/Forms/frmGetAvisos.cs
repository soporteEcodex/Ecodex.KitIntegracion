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
    public partial class frmGetAvisos : Form, View.IfrmGetAvisos
    {
        public frmGetAvisos()
        {
            InitializeComponent();
            var controller = new frmGetAvisosController(this);
        }
        #region Implent IfrmGetAvisos
        public string RFC
        {
            get { return txtRFC.Text; }
        }

        public ListViewItem[] itemsAdvices
        {
            set
            {
                lsvAdvices.Items.Clear();
                lsvAdvices.Items.AddRange(value);
            }
        }

        public event EventHandler onGetAdvices;

        public void ShowSessionError(Entity.SessionError error)
        {
            MessageBox.Show(String.Format("Status {0}: {1}", error.Status.ToString(), error.Description), "Ecodex UniTest");
        }

        public void ShowUnknownError(String message)
        {
            MessageBox.Show(String.Format("Error: {0}", message), "Ecodex UniTest");
        }
        #endregion

        private void btnGetAdvices_Click(object sender, EventArgs e)
        {
            if (onGetAdvices != null)
                onGetAdvices(this, EventArgs.Empty);
        }



    }
}
