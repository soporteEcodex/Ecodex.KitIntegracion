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
    public partial class frmTimbrado : Form, View.IfrmTimbrado
    {
        public frmTimbrado()
        {
            InitializeComponent();
            var _controller = new EcodexIntegrationSample.Controllers.frmTimbradoController(this);
        }

        #region Interfaz
        public string ResultStr
        {
            set { this.resultTextBox.Text = value; }
        }

        public Bitmap BarcodeQR
        {
            set { this.barcodeQR.Image = value; }
        }

        public event EventHandler UniTestDummyXMLString;

        public event EventHandler CancelaTimbrado;

        public event EventHandler GetStatus;

        public event EventHandler GetTimbrado;

        public event EventHandler TimbraXML;

        public void ShowSessionError(Entity.SessionError error)
        {
            MessageBox.Show(String.Format("Status {0}: {1}", error.Status.ToString(), error.Description), "Ecodex UniTest");
        }

        public void ShowUnknownError(string message)
        {
            MessageBox.Show(String.Format("Error: {0}", message), "Ecodex UniTest");
        }
        #endregion

        private void testXMLButton_Click(object sender, EventArgs e)
        {
            if (UniTestDummyXMLString != null)
                UniTestDummyXMLString(this, EventArgs.Empty);
        }

        private void cancelaTimbradoButtom_Click(object sender, EventArgs e)
        {
            if (CancelaTimbrado != null)
                CancelaTimbrado(this, EventArgs.Empty);
        }

        private void statusTimbradoButton_Click(object sender, EventArgs e)
        {
            if (GetStatus != null)
                GetStatus(this, EventArgs.Empty);
        }

        private void obtenerTimbradoButton_Click(object sender, EventArgs e)
        {
            if (GetTimbrado != null)
                GetTimbrado(this, EventArgs.Empty);
        }

        private void btnTimbraXML_Click(object sender, EventArgs e)
        {
            if (TimbraXML != null)
                TimbraXML(this, EventArgs.Empty);
        }
    }
}
