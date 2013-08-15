using System.Windows.Forms;
using System.ComponentModel;
using System;
using System.IO;

namespace EcodexIntegrationSample.Forms
{
    public partial class frmTimbradoXMLFile : Form, View.IXmlFile
    {
        public frmTimbradoXMLFile()
        {
            InitializeComponent();
            var controller = new frmTimbradoXMLFileController(this);
        }

        #region View implementation
        public string[] SelectedSourceFiles
        {
            get
            {
                var filesArr = new String[sourceListBox.SelectedItems.Count];
                sourceListBox.SelectedItems.CopyTo(filesArr, 0);
                return filesArr;
            }
        }

        public string SelectedResultFile
        {
            get { return resultListBox.SelectedItem.ToString(); }
        }

        public event System.EventHandler OnInvoicesProcessStart;

        public event System.EventHandler OnSelectResultFile;

        public event EventHandler OnGetToken;

        public event EventHandler OnSealandStampandStamp;


        public bool AddResultFile(string fileName)
        {
            try
            {
                resultListBox.Items.Add(fileName);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void ShowSessionError(Entity.SessionError error)
        {
            MessageBox.Show(String.Format("Status {0}: {1}", error.Status.ToString(), error.Description), "Ecodex UniTest");
        }

        public void ShowUnknownError(string message)
        {
            MessageBox.Show(String.Format("{0}", message), "Ecodex UniTest");
        }
        #endregion

        private void dirSelectionButton_Click(object sender, EventArgs e)
        {
            this.folderBrowserDialog.ShowNewFolderButton = false;
            this.folderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            DialogResult result = this.folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                sourceListBox.Items.Clear();
                resultListBox.Items.Clear();
                string foldername = this.folderBrowserDialog.SelectedPath;
                foreach (string file in Directory.GetFiles(foldername))
                {
                    if (Path.GetExtension(file).ToUpper() == ".XML")
                        this.sourceListBox.Items.Add(file);
                }

            }
        }

        private void processButton_Click(object sender, EventArgs e)
        {
            if (OnInvoicesProcessStart != null)
                OnInvoicesProcessStart(this, EventArgs.Empty);
        }

        private void resultListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OnSelectResultFile != null)
                OnSelectResultFile(this, EventArgs.Empty);
        }

        private void btnGetToken_Click(object sender, EventArgs e)
        {
            if (OnGetToken != null)
            {
                OnGetToken(this, EventArgs.Empty);
            }
        }

        private void btnSealandStamp_Click(object sender, EventArgs e)
        {
            if (OnSealandStampandStamp != null)
            {
                OnSealandStampandStamp(this, EventArgs.Empty);
            }
        }
    }
}
