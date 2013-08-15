namespace EcodexIntegrationSample.Forms
{
    partial class Main
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
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.btnStampService = new System.Windows.Forms.Button();
            this.btnGetAdvices = new System.Windows.Forms.Button();
            this.btnGetStatusClient = new System.Windows.Forms.Button();
            this.btnGetInvoiceStatus = new System.Windows.Forms.Button();
            this.btnGetInvoice = new System.Windows.Forms.Button();
            this.barcodeQR = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.XMLButton = new System.Windows.Forms.Button();
            this.testXMLButton = new System.Windows.Forms.Button();
            this.btnAsignaTimbres = new System.Windows.Forms.Button();
            this.btnAltaEmisor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barcodeQR)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.resultTextBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnAltaEmisor);
            this.splitContainer1.Panel2.Controls.Add(this.btnAsignaTimbres);
            this.splitContainer1.Panel2.Controls.Add(this.btnStampService);
            this.splitContainer1.Panel2.Controls.Add(this.btnGetAdvices);
            this.splitContainer1.Panel2.Controls.Add(this.btnGetStatusClient);
            this.splitContainer1.Panel2.Controls.Add(this.btnGetInvoiceStatus);
            this.splitContainer1.Panel2.Controls.Add(this.btnGetInvoice);
            this.splitContainer1.Panel2.Controls.Add(this.barcodeQR);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.XMLButton);
            this.splitContainer1.Panel2.Controls.Add(this.testXMLButton);
            this.splitContainer1.Size = new System.Drawing.Size(805, 451);
            this.splitContainer1.SplitterDistance = 367;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 1;
            // 
            // resultTextBox
            // 
            this.resultTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultTextBox.Location = new System.Drawing.Point(0, 0);
            this.resultTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.resultTextBox.Size = new System.Drawing.Size(805, 367);
            this.resultTextBox.TabIndex = 1;
            // 
            // btnStampService
            // 
            this.btnStampService.Location = new System.Drawing.Point(719, 0);
            this.btnStampService.Name = "btnStampService";
            this.btnStampService.Size = new System.Drawing.Size(62, 81);
            this.btnStampService.TabIndex = 9;
            this.btnStampService.Text = "Stamp Service";
            this.btnStampService.UseVisualStyleBackColor = true;
            this.btnStampService.Click += new System.EventHandler(this.btnStampService_Click);
            // 
            // btnGetAdvices
            // 
            this.btnGetAdvices.Location = new System.Drawing.Point(300, 0);
            this.btnGetAdvices.Name = "btnGetAdvices";
            this.btnGetAdvices.Size = new System.Drawing.Size(60, 80);
            this.btnGetAdvices.TabIndex = 8;
            this.btnGetAdvices.Text = "Get Advices";
            this.btnGetAdvices.UseVisualStyleBackColor = true;
            this.btnGetAdvices.Click += new System.EventHandler(this.btnGetAdvices_Click);
            // 
            // btnGetStatusClient
            // 
            this.btnGetStatusClient.Location = new System.Drawing.Point(240, 0);
            this.btnGetStatusClient.Name = "btnGetStatusClient";
            this.btnGetStatusClient.Size = new System.Drawing.Size(60, 80);
            this.btnGetStatusClient.TabIndex = 7;
            this.btnGetStatusClient.Text = "Get Status Client";
            this.btnGetStatusClient.UseVisualStyleBackColor = true;
            this.btnGetStatusClient.Click += new System.EventHandler(this.btnGetStatusClient_Click);
            // 
            // btnGetInvoiceStatus
            // 
            this.btnGetInvoiceStatus.Location = new System.Drawing.Point(180, 0);
            this.btnGetInvoiceStatus.Name = "btnGetInvoiceStatus";
            this.btnGetInvoiceStatus.Size = new System.Drawing.Size(60, 80);
            this.btnGetInvoiceStatus.TabIndex = 6;
            this.btnGetInvoiceStatus.Text = "Get Status Invoice";
            this.btnGetInvoiceStatus.UseVisualStyleBackColor = true;
            this.btnGetInvoiceStatus.Click += new System.EventHandler(this.btnGetInvoiceStatus_Click);
            // 
            // btnGetInvoice
            // 
            this.btnGetInvoice.Location = new System.Drawing.Point(120, 1);
            this.btnGetInvoice.Name = "btnGetInvoice";
            this.btnGetInvoice.Size = new System.Drawing.Size(60, 80);
            this.btnGetInvoice.TabIndex = 5;
            this.btnGetInvoice.Text = "Get Invoice";
            this.btnGetInvoice.UseVisualStyleBackColor = true;
            this.btnGetInvoice.Click += new System.EventHandler(this.btnGetInvoice_Click);
            // 
            // barcodeQR
            // 
            this.barcodeQR.BackColor = System.Drawing.Color.White;
            this.barcodeQR.Location = new System.Drawing.Point(578, 2);
            this.barcodeQR.Margin = new System.Windows.Forms.Padding(2);
            this.barcodeQR.Name = "barcodeQR";
            this.barcodeQR.Size = new System.Drawing.Size(75, 76);
            this.barcodeQR.TabIndex = 4;
            this.barcodeQR.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 80);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cancel UUID";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // XMLButton
            // 
            this.XMLButton.Location = new System.Drawing.Point(655, 0);
            this.XMLButton.Margin = new System.Windows.Forms.Padding(2);
            this.XMLButton.Name = "XMLButton";
            this.XMLButton.Size = new System.Drawing.Size(62, 81);
            this.XMLButton.TabIndex = 2;
            this.XMLButton.Text = "Generate XML File";
            this.XMLButton.UseVisualStyleBackColor = true;
            this.XMLButton.Click += new System.EventHandler(this.XMLButton_Click);
            // 
            // testXMLButton
            // 
            this.testXMLButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.testXMLButton.Location = new System.Drawing.Point(0, 0);
            this.testXMLButton.Margin = new System.Windows.Forms.Padding(2);
            this.testXMLButton.Name = "testXMLButton";
            this.testXMLButton.Size = new System.Drawing.Size(60, 81);
            this.testXMLButton.TabIndex = 1;
            this.testXMLButton.Text = "UniTest XML Invoice";
            this.testXMLButton.UseVisualStyleBackColor = true;
            this.testXMLButton.Click += new System.EventHandler(this.testXMLButton_Click);
            // 
            // btnAsignaTimbres
            // 
            this.btnAsignaTimbres.Location = new System.Drawing.Point(363, 0);
            this.btnAsignaTimbres.Name = "btnAsignaTimbres";
            this.btnAsignaTimbres.Size = new System.Drawing.Size(60, 80);
            this.btnAsignaTimbres.TabIndex = 10;
            this.btnAsignaTimbres.Text = "Asigna Timbres";
            this.btnAsignaTimbres.UseVisualStyleBackColor = true;
            this.btnAsignaTimbres.Click += new System.EventHandler(this.btnAsignaTimbres_Click);
            // 
            // btnAltaEmisor
            // 
            this.btnAltaEmisor.Location = new System.Drawing.Point(425, 0);
            this.btnAltaEmisor.Name = "btnAltaEmisor";
            this.btnAltaEmisor.Size = new System.Drawing.Size(60, 80);
            this.btnAltaEmisor.TabIndex = 11;
            this.btnAltaEmisor.Text = "Alta Emisor";
            this.btnAltaEmisor.UseVisualStyleBackColor = true;
            this.btnAltaEmisor.Click += new System.EventHandler(this.btnAltaEmisor_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 451);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ecodex Integration Sample";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barcodeQR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Button XMLButton;
        private System.Windows.Forms.Button testXMLButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox barcodeQR;
        private System.Windows.Forms.Button btnGetInvoice;
        private System.Windows.Forms.Button btnGetInvoiceStatus;
        private System.Windows.Forms.Button btnGetStatusClient;
        private System.Windows.Forms.Button btnGetAdvices;
        private System.Windows.Forms.Button btnStampService;
        private System.Windows.Forms.Button btnAsignaTimbres;
        private System.Windows.Forms.Button btnAltaEmisor;
    }
}