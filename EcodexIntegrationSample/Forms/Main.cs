using System;
using System.Drawing;
using System.Windows.Forms;

namespace EcodexIntegrationSample.Forms
{
    public partial class Main : Form, View.IMain
    {
        public Main()
        {
            InitializeComponent();
            var _controller = new MainController(this);
        }

        #region IMain implementation

        public string ResultStr
        {
            set { this.resultTextBox.Text = value; }
        }

        public Bitmap BarcodeQR
        {
            set { this.barcodeQR.Image = value; }
        }

        public event EventHandler UniTestDunnyInvoice;

        public event EventHandler UniTestDummyXMLString;

        public event EventHandler GenerateXMLFile;

        public event EventHandler CancelUUID;

        public event EventHandler GetInvoice;

        public event EventHandler GetStatus;

        public event EventHandler GetStatusClient;

        public event EventHandler StampService;

        public event EventHandler AsignarTimbres;

        public event EventHandler AltaEmisor;

        public event EventHandler RecuperaAcuse;

        public void ShowSessionError(Entity.SessionError error)
        {
            MessageBox.Show(String.Format("Status {0}: {1}", error.Status.ToString(), error.Description), "Ecodex UniTest");
        }

        public void ShowUnknownError(String message)
        {
            MessageBox.Show(String.Format("Error: {0}", message), "Ecodex UniTest");
        }
        #endregion

        #region Event Handlers
        private void testInvoiceButton_Click(object sender, EventArgs e)
        {
            if (UniTestDunnyInvoice != null)
                UniTestDunnyInvoice(this, EventArgs.Empty);
        }
         
        private void testXMLButton_Click(object sender, EventArgs e)
        {
            if (UniTestDummyXMLString != null)
                UniTestDummyXMLString(this, EventArgs.Empty);
        }

        private void XMLButton_Click(object sender, EventArgs e)
        {
            if (GenerateXMLFile != null)
                GenerateXMLFile(this, EventArgs.Empty);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (CancelUUID != null)
                CancelUUID(this, EventArgs.Empty);
        }

        private void btnGetInvoice_Click(object sender, EventArgs e)
        {
            if (GetInvoice != null)
                GetInvoice(this, EventArgs.Empty);
        }

        private void btnGetInvoiceStatus_Click(object sender, EventArgs e)
        {
            if (GetStatus != null)
                GetStatus(this, EventArgs.Empty);
        }

        private void btnGetStatusClient_Click(object sender, EventArgs e)
        {
            if (GetStatusClient != null)
                GetStatusClient(this, EventArgs.Empty);
        }
        public event EventHandler GetAdvices;
        #endregion

        private void btnGetAdvices_Click(object sender, EventArgs e)
        {
            if (GetAdvices != null)
                GetAdvices(this, EventArgs.Empty);
        }

        private void btnStampService_Click(object sender, EventArgs e)
        {
            if (StampService != null)
                StampService(this, EventArgs.Empty);
        }

        private void btnAsignaTimbres_Click(object sender, EventArgs e)
        {
            if (AsignarTimbres != null)
                AsignarTimbres(this, EventArgs.Empty);
        }

        private void btnAltaEmisor_Click(object sender, EventArgs e)
        {
            if (AltaEmisor != null)
                AltaEmisor(this, EventArgs.Empty);
        }

        private void btnRecuperaAcuse_Click(object sender, EventArgs e)
        {
            if (RecuperaAcuse != null)
                RecuperaAcuse(this, EventArgs.Empty);
        }

      






    }
}
