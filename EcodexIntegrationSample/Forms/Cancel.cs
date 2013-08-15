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
    public partial class Cancel : Form, View.ICancel
    {
        public Cancel()
        {
            InitializeComponent();
            var controller = new CancelController(this);
            Utils.Utilerias util = new Utils.Utilerias(this);
            txtRFC.Text = util.RFC;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (OnCancelProcessStart != null)
                OnCancelProcessStart(this, EventArgs.Empty);
        }

        public string[] SelectedSourceUUID
        {
            get
            {
                throw new NotImplementedException("");
            }
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


        public string SourceUUID
        {
            get { return txtUUID.Text; }
        }

       

        
    }
}
