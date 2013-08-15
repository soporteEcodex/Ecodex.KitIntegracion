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
    public partial class frmAsignarTimbresEmisor : Form,View.IfrmAsignarTimbreEmisor
    {
        public frmAsignarTimbresEmisor()
        {
            InitializeComponent();
            var controller = new frmAsignaTimbreEmisorController(this);
        }

        #region Implementacion IfrmAsignarTimbreEmisor

        public string RFCAsignar 
        {
            get { return txtRFCAsignar.Text; }
        }

        public int TimbresAsignar
        {
            get { return int.Parse(txtTimbresAsignar.Text); }
        }

        public long trsID
        {
            get
            {
                Int64 result = 0;
                Int64.TryParse("1234", out result);
                return result;
            }
        }

        public event EventHandler onAsignarTimbreEmisor;

        public void ShowSessionError(Entity.SessionError error)
        {
            MessageBox.Show(String.Format("Status {0}: {1}", error.Status.ToString(), error.Description), "Ecodex UniTest");
        }

        public void ShowUnknownError(String message)
        {
            MessageBox.Show(String.Format("Error: {0}", message), "Ecodex UniTest");
        }

        public int SaldoNuevo 
        {
            set
            {
                txtSaldoNuevo.Text = value.ToString();
            }
        }

        public long SaldoAnterior
        {
            set
            {
                txtSaldoAnterior.Text = value.ToString();
            }
        }

        #endregion

        private void btnAsignarTimbres_Click(object sender, EventArgs e)
        {
            if (onAsignarTimbreEmisor != null)
                onAsignarTimbreEmisor(this, EventArgs.Empty);
               
        }


    }
}
