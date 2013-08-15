namespace EcodexIntegrationSample.Forms
{
    partial class frmTimbrado
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
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.testXMLButton = new System.Windows.Forms.Button();
            this.barcodeQR = new System.Windows.Forms.PictureBox();
            this.cancelaTimbradoButtom = new System.Windows.Forms.Button();
            this.statusTimbradoButton = new System.Windows.Forms.Button();
            this.obtenerTimbradoButton = new System.Windows.Forms.Button();
            this.btnTimbraXML = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.barcodeQR)).BeginInit();
            this.SuspendLayout();
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(0, -1);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.resultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultTextBox.Size = new System.Drawing.Size(589, 338);
            this.resultTextBox.TabIndex = 0;
            // 
            // testXMLButton
            // 
            this.testXMLButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.testXMLButton.Location = new System.Drawing.Point(2, 343);
            this.testXMLButton.Name = "testXMLButton";
            this.testXMLButton.Size = new System.Drawing.Size(61, 71);
            this.testXMLButton.TabIndex = 2;
            this.testXMLButton.Text = "UniTest XML Timbrado";
            this.testXMLButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.testXMLButton.UseVisualStyleBackColor = true;
            this.testXMLButton.Click += new System.EventHandler(this.testXMLButton_Click);
            // 
            // barcodeQR
            // 
            this.barcodeQR.BackColor = System.Drawing.Color.White;
            this.barcodeQR.Location = new System.Drawing.Point(509, 340);
            this.barcodeQR.Margin = new System.Windows.Forms.Padding(2);
            this.barcodeQR.Name = "barcodeQR";
            this.barcodeQR.Size = new System.Drawing.Size(137, 135);
            this.barcodeQR.TabIndex = 5;
            this.barcodeQR.TabStop = false;
            // 
            // cancelaTimbradoButtom
            // 
            this.cancelaTimbradoButtom.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancelaTimbradoButtom.Location = new System.Drawing.Point(60, 343);
            this.cancelaTimbradoButtom.Name = "cancelaTimbradoButtom";
            this.cancelaTimbradoButtom.Size = new System.Drawing.Size(61, 71);
            this.cancelaTimbradoButtom.TabIndex = 6;
            this.cancelaTimbradoButtom.Text = "Cancela Timbrado";
            this.cancelaTimbradoButtom.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.cancelaTimbradoButtom.UseVisualStyleBackColor = true;
            this.cancelaTimbradoButtom.Click += new System.EventHandler(this.cancelaTimbradoButtom_Click);
            // 
            // statusTimbradoButton
            // 
            this.statusTimbradoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.statusTimbradoButton.Location = new System.Drawing.Point(119, 343);
            this.statusTimbradoButton.Name = "statusTimbradoButton";
            this.statusTimbradoButton.Size = new System.Drawing.Size(61, 71);
            this.statusTimbradoButton.TabIndex = 7;
            this.statusTimbradoButton.Text = "Status Timbrado";
            this.statusTimbradoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.statusTimbradoButton.UseVisualStyleBackColor = true;
            this.statusTimbradoButton.Click += new System.EventHandler(this.statusTimbradoButton_Click);
            // 
            // obtenerTimbradoButton
            // 
            this.obtenerTimbradoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.obtenerTimbradoButton.Location = new System.Drawing.Point(178, 343);
            this.obtenerTimbradoButton.Name = "obtenerTimbradoButton";
            this.obtenerTimbradoButton.Size = new System.Drawing.Size(61, 71);
            this.obtenerTimbradoButton.TabIndex = 8;
            this.obtenerTimbradoButton.Text = "Obtener Timbrado";
            this.obtenerTimbradoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.obtenerTimbradoButton.UseVisualStyleBackColor = true;
            this.obtenerTimbradoButton.Click += new System.EventHandler(this.obtenerTimbradoButton_Click);
            // 
            // btnTimbraXML
            // 
            this.btnTimbraXML.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimbraXML.Location = new System.Drawing.Point(237, 343);
            this.btnTimbraXML.Name = "btnTimbraXML";
            this.btnTimbraXML.Size = new System.Drawing.Size(61, 71);
            this.btnTimbraXML.TabIndex = 9;
            this.btnTimbraXML.Text = "TimbrarXML";
            this.btnTimbraXML.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnTimbraXML.UseVisualStyleBackColor = true;
            this.btnTimbraXML.Click += new System.EventHandler(this.btnTimbraXML_Click);
            // 
            // frmTimbrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 497);
            this.Controls.Add(this.btnTimbraXML);
            this.Controls.Add(this.obtenerTimbradoButton);
            this.Controls.Add(this.statusTimbradoButton);
            this.Controls.Add(this.cancelaTimbradoButtom);
            this.Controls.Add(this.barcodeQR);
            this.Controls.Add(this.testXMLButton);
            this.Controls.Add(this.resultTextBox);
            this.Name = "frmTimbrado";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "frmTimbrado";
            ((System.ComponentModel.ISupportInitialize)(this.barcodeQR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Button testXMLButton;
        private System.Windows.Forms.PictureBox barcodeQR;
        private System.Windows.Forms.Button cancelaTimbradoButtom;
        private System.Windows.Forms.Button statusTimbradoButton;
        private System.Windows.Forms.Button obtenerTimbradoButton;
        private System.Windows.Forms.Button btnTimbraXML;
    }
}