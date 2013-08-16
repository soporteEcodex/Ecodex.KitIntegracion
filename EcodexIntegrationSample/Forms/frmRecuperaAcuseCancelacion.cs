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
    public partial class frmRecuperaAcuseCancelacion : Form, View.IfrmRecuperaAcuseCancelacion
    {
        public frmRecuperaAcuseCancelacion()
        {
            InitializeComponent();
            var controller = new frmRecuperaAcuseCancelacionController(this);
        }

        #region Implementa Interfaz


        public string RFCEmisor
        {
            get 
            {
                return txtRFCEmisor.Text;
            }
        }

        public string RFCReceptor
        {
            get 
            {
                return txtRFCReceptor.Text;
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

        public Guid UUID
        {
            get 
            {
                return Guid.Parse(txtUUIDEntrada.Text);
            }
            set
            {
                txtUUIDSalida.Text = value.ToString();
            }
        }

        public event EventHandler onRecuperaAcuseCancelacion;

        public string Estatus
        {
            set
            {
                txtEstatus.Text = value;
            }
        }

        public string AcuseXML
        {
            set
            {
                txtAcuseCancelacion.Text = value;
            }
        }


        public void ShowSessionError(Entity.SessionError error)
        {
            MessageBox.Show(String.Format("Status {0}: {1}", error.Status.ToString(), error.Description), "Ecodex UniTest");
        }

        public void ShowUnknownError(String message)
        {
            MessageBox.Show(String.Format("Error: {0}", message), "Ecodex UniTest");
        }

        #endregion


        private void btnRecuperarAcuse_Click(object sender, EventArgs e)
        {
            if (onRecuperaAcuseCancelacion != null)
                onRecuperaAcuseCancelacion(this, EventArgs.Empty);
        }
    }
}
