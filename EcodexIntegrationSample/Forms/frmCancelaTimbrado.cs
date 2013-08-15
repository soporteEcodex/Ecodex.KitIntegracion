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
    public partial class frmCancelaTimbrado : Form, View.ICancelaTimbrado
    {
        public frmCancelaTimbrado()
        {
            InitializeComponent();
            var _controller = new Controllers.frmCancelaTimbradoController(this);
        }
        #region Interfaz

        public string SourceUUID
        {
            get { return txtUUID.Text; }
        }

        public string SourceRFC
        {
            get { return txtRFC.Text; }
        }

        public event EventHandler OnCancelProcessStart;

        public void ShowSessionError(Entity.SessionError error)
        {
            MessageBox.Show(String.Format("Status {0}: {1}", error.Status.ToString(), error.Description), "Ecodex UniTest");
        }

        public void ShowUnknownError(string message)
        {
            MessageBox.Show(String.Format("Error: {0}", message), "Ecodex UniTest");
        }

        public void ShowResult(string message)
        {
            MessageBox.Show(String.Format("{0}", message), "Ecodex UniTest");
        }
        #endregion

        private void cancelarTimbradoButton_Click(object sender, EventArgs e)
        {
            if (OnCancelProcessStart != null)
                OnCancelProcessStart(this, EventArgs.Empty);

        }
    }
}
