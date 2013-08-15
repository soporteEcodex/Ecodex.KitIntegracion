namespace EcodexIntegrationSample.Forms
{
    partial class frmTimbradoXMLFile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.sourceListBox = new System.Windows.Forms.ListBox();
            this.dirSelectionButton = new System.Windows.Forms.Button();
            this.btnSealandStamp = new System.Windows.Forms.Button();
            this.resultListBox = new System.Windows.Forms.ListBox();
            this.processButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnGetToken = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.sourceListBox);
            this.splitContainer1.Panel1.Controls.Add(this.dirSelectionButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnSealandStamp);
            this.splitContainer1.Panel2.Controls.Add(this.resultListBox);
            this.splitContainer1.Panel2.Controls.Add(this.processButton);
            this.splitContainer1.Size = new System.Drawing.Size(470, 293);
            this.splitContainer1.SplitterDistance = 135;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 1;
            // 
            // sourceListBox
            // 
            this.sourceListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sourceListBox.FormattingEnabled = true;
            this.sourceListBox.Location = new System.Drawing.Point(0, 23);
            this.sourceListBox.Margin = new System.Windows.Forms.Padding(2);
            this.sourceListBox.Name = "sourceListBox";
            this.sourceListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.sourceListBox.Size = new System.Drawing.Size(470, 112);
            this.sourceListBox.TabIndex = 4;
            // 
            // dirSelectionButton
            // 
            this.dirSelectionButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.dirSelectionButton.Location = new System.Drawing.Point(0, 0);
            this.dirSelectionButton.Margin = new System.Windows.Forms.Padding(2);
            this.dirSelectionButton.Name = "dirSelectionButton";
            this.dirSelectionButton.Size = new System.Drawing.Size(470, 23);
            this.dirSelectionButton.TabIndex = 1;
            this.dirSelectionButton.Text = "Select Directory";
            this.dirSelectionButton.UseVisualStyleBackColor = true;
            this.dirSelectionButton.Click += new System.EventHandler(this.dirSelectionButton_Click);
            // 
            // btnSealandStamp
            // 
            this.btnSealandStamp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSealandStamp.Location = new System.Drawing.Point(0, 28);
            this.btnSealandStamp.Name = "btnSealandStamp";
            this.btnSealandStamp.Size = new System.Drawing.Size(470, 23);
            this.btnSealandStamp.TabIndex = 4;
            this.btnSealandStamp.Text = "Seal and Stamp";
            this.btnSealandStamp.UseVisualStyleBackColor = true;
            this.btnSealandStamp.Click += new System.EventHandler(this.btnSealandStamp_Click);
            // 
            // resultListBox
            // 
            this.resultListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.resultListBox.FormattingEnabled = true;
            this.resultListBox.Location = new System.Drawing.Point(0, 47);
            this.resultListBox.Margin = new System.Windows.Forms.Padding(2);
            this.resultListBox.Name = "resultListBox";
            this.resultListBox.Size = new System.Drawing.Size(468, 108);
            this.resultListBox.TabIndex = 3;
            this.resultListBox.SelectedIndexChanged += new System.EventHandler(this.resultListBox_SelectedIndexChanged);
            // 
            // processButton
            // 
            this.processButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.processButton.Location = new System.Drawing.Point(0, 0);
            this.processButton.Margin = new System.Windows.Forms.Padding(2);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(470, 28);
            this.processButton.TabIndex = 2;
            this.processButton.Text = "Stamp Invoices";
            this.processButton.UseVisualStyleBackColor = true;
            this.processButton.Click += new System.EventHandler(this.processButton_Click);
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.RootFolder = System.Environment.SpecialFolder.CommonDocuments;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.btnGetToken);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainer2.Size = new System.Drawing.Size(470, 322);
            this.splitContainer2.SplitterDistance = 25;
            this.splitContainer2.TabIndex = 2;
            // 
            // btnGetToken
            // 
            this.btnGetToken.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGetToken.Location = new System.Drawing.Point(0, 0);
            this.btnGetToken.Name = "btnGetToken";
            this.btnGetToken.Size = new System.Drawing.Size(470, 25);
            this.btnGetToken.TabIndex = 0;
            this.btnGetToken.Text = "Get Token";
            this.btnGetToken.UseVisualStyleBackColor = true;
            this.btnGetToken.Click += new System.EventHandler(this.btnGetToken_Click);
            // 
            // frmTimbradoXMLFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 322);
            this.Controls.Add(this.splitContainer2);
            this.Name = "frmTimbradoXMLFile";
            this.Text = "frmTimbradoXMLFile";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox sourceListBox;
        private System.Windows.Forms.Button dirSelectionButton;
        private System.Windows.Forms.ListBox resultListBox;
        private System.Windows.Forms.Button processButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btnGetToken;
        private System.Windows.Forms.Button btnSealandStamp;
    }
}