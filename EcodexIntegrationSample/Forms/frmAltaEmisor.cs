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
    public partial class frmAltaEmisor : Form, View.IAltaEmisor
    {
        public frmAltaEmisor()
        {
            InitializeComponent();
            var controller = new frmAltaEmisorController(this);
        }

        # region Implementacion IAltaEmisor

        public string RFCIntegrador
        {
            get 
            {
                return txtRFCIntegrador.Text;
            }
        }

        public string RFCEmisor
        {
            get
            {
                return txtRFCEmisor.Text;
            }
            set
            {
                txtRFCEmisorR.Text = value;
            }
        }

        public string RazonSocial
        {
            get
            {
                return txtRazonSocial.Text;
            }
        }

        public string CorreoElectronico
        {
            get 
            {
                return txtCorreoElectronico.Text;
            }
        }

        public long TransaccionId
        {
            get
            {
                Int64 result = 0;
                Int64.TryParse("1234", out result);
                return result;
            }
        }

       
        public event EventHandler onAltaEmisor;

        public void ShowSessionError(Entity.SessionError error)
        {
            MessageBox.Show(String.Format("Status {0}: {1}", error.Status.ToString(), error.Description), "Ecodex UniTest");
        }

        public void ShowUnknownError(String message)
        {
            MessageBox.Show(String.Format("Error: {0}", message), "Ecodex UniTest");
        }

        

        public string ClaveCertificado
        { 
            set
            {
                txtClaveCertificado.Text = value;
            }
        }

        public string Estatus
        {
            set 
            {
                txtEstatus.Text = value;
            }
        }

        #endregion



        private void btnAlta_Click(object sender, EventArgs e)
        {
            if(onAltaEmisor!= null)
                onAltaEmisor(this,EventArgs.Empty);
        }
    }
}
