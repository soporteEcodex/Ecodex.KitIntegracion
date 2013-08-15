namespace EcodexIntegrationSample.Forms
{
    partial class frmCancelaTimbrado
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtUUID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRFC = new System.Windows.Forms.TextBox();
            this.cancelarTimbradoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "UUID";
            // 
            // txtUUID
            // 
            this.txtUUID.Location = new System.Drawing.Point(38, 17);
            this.txtUUID.Name = "txtUUID";
            this.txtUUID.Size = new System.Drawing.Size(240, 20);
            this.txtUUID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "RFC";
            // 
            // txtRFC
            // 
            this.txtRFC.Location = new System.Drawing.Point(38, 58);
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Size = new System.Drawing.Size(240, 20);
            this.txtRFC.TabIndex = 3;
            // 
            // cancelarTimbradoButton
            // 
            this.cancelarTimbradoButton.Location = new System.Drawing.Point(103, 101);
            this.cancelarTimbradoButton.Name = "cancelarTimbradoButton";
            this.cancelarTimbradoButton.Size = new System.Drawing.Size(74, 42);
            this.cancelarTimbradoButton.TabIndex = 4;
            this.cancelarTimbradoButton.Text = "Cancelar Timbrado";
            this.cancelarTimbradoButton.UseVisualStyleBackColor = true;
            this.cancelarTimbradoButton.Click += new System.EventHandler(this.cancelarTimbradoButton_Click);
            // 
            // frmCancelaTimbrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 159);
            this.Controls.Add(this.cancelarTimbradoButton);
            this.Controls.Add(this.txtRFC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUUID);
            this.Controls.Add(this.label1);
            this.Name = "frmCancelaTimbrado";
            this.Text = "frmCancelaTimbrado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUUID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRFC;
        private System.Windows.Forms.Button cancelarTimbradoButton;
    }
}