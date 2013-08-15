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
    public partial class Error : Form
    {
        public Error()
        {
            InitializeComponent();
        }

        public Error(Entity.ServiceError error) : this()
        {
            this.eventTextBox.Text = error.EventID ?? String.Empty;
            this.numberTextBox.Text = error.Number.ToString();
            this.descriptionTextBox.Text = error.Description ?? String.Empty; ;
        }

        public Error(Entity.ValidationError error): this()
        {
            this.eventTextBox.Text = error.EventID ?? String.Empty; ;
            this.numberTextBox.Text = error.Number.ToString();
            this.descriptionTextBox.Text = error.Description ?? String.Empty; ;
            // Node...
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
