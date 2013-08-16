namespace EcodexIntegrationSample.Forms
{
    partial class frmRecuperaAcuseCancelacion
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
            this.btnRecuperarAcuse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRFCEmisor = new System.Windows.Forms.TextBox();
            this.txtUUIDSalida = new System.Windows.Forms.TextBox();
            this.txtEstatus = new System.Windows.Forms.TextBox();
            this.txtRFCReceptor = new System.Windows.Forms.TextBox();
            this.txtUUIDEntrada = new System.Windows.Forms.TextBox();
            this.txtAcuseCancelacion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRecuperarAcuse
            // 
            this.btnRecuperarAcuse.Location = new System.Drawing.Point(624, 63);
            this.btnRecuperarAcuse.Name = "btnRecuperarAcuse";
            this.btnRecuperarAcuse.Size = new System.Drawing.Size(75, 23);
            this.btnRecuperarAcuse.TabIndex = 0;
            this.btnRecuperarAcuse.Text = "Recuperar";
            this.btnRecuperarAcuse.UseVisualStyleBackColor = true;
            this.btnRecuperarAcuse.Click += new System.EventHandler(this.btnRecuperarAcuse_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(48, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "RFC Emisor";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(48, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "RFC Receptor";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(332, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "UUID";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(332, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "UUID";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(48, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Estatus";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtRFCEmisor
            // 
            this.txtRFCEmisor.Location = new System.Drawing.Point(165, 36);
            this.txtRFCEmisor.Name = "txtRFCEmisor";
            this.txtRFCEmisor.Size = new System.Drawing.Size(150, 20);
            this.txtRFCEmisor.TabIndex = 6;
            // 
            // txtUUIDSalida
            // 
            this.txtUUIDSalida.Location = new System.Drawing.Point(449, 119);
            this.txtUUIDSalida.Name = "txtUUIDSalida";
            this.txtUUIDSalida.Size = new System.Drawing.Size(250, 20);
            this.txtUUIDSalida.TabIndex = 7;
            // 
            // txtEstatus
            // 
            this.txtEstatus.Location = new System.Drawing.Point(165, 119);
            this.txtEstatus.Name = "txtEstatus";
            this.txtEstatus.Size = new System.Drawing.Size(150, 20);
            this.txtEstatus.TabIndex = 8;
            // 
            // txtRFCReceptor
            // 
            this.txtRFCReceptor.Location = new System.Drawing.Point(165, 63);
            this.txtRFCReceptor.Name = "txtRFCReceptor";
            this.txtRFCReceptor.Size = new System.Drawing.Size(150, 20);
            this.txtRFCReceptor.TabIndex = 9;
            // 
            // txtUUIDEntrada
            // 
            this.txtUUIDEntrada.Location = new System.Drawing.Point(449, 36);
            this.txtUUIDEntrada.Name = "txtUUIDEntrada";
            this.txtUUIDEntrada.Size = new System.Drawing.Size(250, 20);
            this.txtUUIDEntrada.TabIndex = 10;
            // 
            // txtAcuseCancelacion
            // 
            this.txtAcuseCancelacion.Location = new System.Drawing.Point(51, 181);
            this.txtAcuseCancelacion.Multiline = true;
            this.txtAcuseCancelacion.Name = "txtAcuseCancelacion";
            this.txtAcuseCancelacion.Size = new System.Drawing.Size(648, 199);
            this.txtAcuseCancelacion.TabIndex = 11;
            // 
            // frmRecuperaAcuseCancelacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 402);
            this.Controls.Add(this.txtAcuseCancelacion);
            this.Controls.Add(this.txtUUIDEntrada);
            this.Controls.Add(this.txtRFCReceptor);
            this.Controls.Add(this.txtEstatus);
            this.Controls.Add(this.txtUUIDSalida);
            this.Controls.Add(this.txtRFCEmisor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRecuperarAcuse);
            this.Name = "frmRecuperaAcuseCancelacion";
            this.Text = "frmRecuperaAcuseCancelacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRecuperarAcuse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRFCEmisor;
        private System.Windows.Forms.TextBox txtUUIDSalida;
        private System.Windows.Forms.TextBox txtEstatus;
        private System.Windows.Forms.TextBox txtRFCReceptor;
        private System.Windows.Forms.TextBox txtUUIDEntrada;
        private System.Windows.Forms.TextBox txtAcuseCancelacion;
    }
}