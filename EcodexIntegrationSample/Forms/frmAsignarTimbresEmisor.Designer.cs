namespace EcodexIntegrationSample.Forms
{
    partial class frmAsignarTimbresEmisor
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
            this.btnAsignarTimbres = new System.Windows.Forms.Button();
            this.txtRFCAsignar = new System.Windows.Forms.TextBox();
            this.txtTimbresAsignar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSaldoNuevo = new System.Windows.Forms.TextBox();
            this.txtSaldoAnterior = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAsignarTimbres
            // 
            this.btnAsignarTimbres.Location = new System.Drawing.Point(193, 91);
            this.btnAsignarTimbres.Name = "btnAsignarTimbres";
            this.btnAsignarTimbres.Size = new System.Drawing.Size(75, 23);
            this.btnAsignarTimbres.TabIndex = 0;
            this.btnAsignarTimbres.Text = "Asignar";
            this.btnAsignarTimbres.UseVisualStyleBackColor = true;
            this.btnAsignarTimbres.Click += new System.EventHandler(this.btnAsignarTimbres_Click);
            // 
            // txtRFCAsignar
            // 
            this.txtRFCAsignar.Location = new System.Drawing.Point(118, 27);
            this.txtRFCAsignar.Name = "txtRFCAsignar";
            this.txtRFCAsignar.Size = new System.Drawing.Size(150, 20);
            this.txtRFCAsignar.TabIndex = 1;
            // 
            // txtTimbresAsignar
            // 
            this.txtTimbresAsignar.Location = new System.Drawing.Point(118, 59);
            this.txtTimbresAsignar.Name = "txtTimbresAsignar";
            this.txtTimbresAsignar.Size = new System.Drawing.Size(150, 20);
            this.txtTimbresAsignar.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "RFC";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(16, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Timbres  a Asignar";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(16, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Saldo Nuevo";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(16, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Saldo Anterior";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtSaldoNuevo
            // 
            this.txtSaldoNuevo.Location = new System.Drawing.Point(118, 143);
            this.txtSaldoNuevo.Name = "txtSaldoNuevo";
            this.txtSaldoNuevo.Size = new System.Drawing.Size(150, 20);
            this.txtSaldoNuevo.TabIndex = 7;
            // 
            // txtSaldoAnterior
            // 
            this.txtSaldoAnterior.Location = new System.Drawing.Point(118, 174);
            this.txtSaldoAnterior.Name = "txtSaldoAnterior";
            this.txtSaldoAnterior.Size = new System.Drawing.Size(150, 20);
            this.txtSaldoAnterior.TabIndex = 8;
            // 
            // frmAsignarTimbresEmisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 238);
            this.Controls.Add(this.txtSaldoAnterior);
            this.Controls.Add(this.txtSaldoNuevo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTimbresAsignar);
            this.Controls.Add(this.txtRFCAsignar);
            this.Controls.Add(this.btnAsignarTimbres);
            this.Name = "frmAsignarTimbresEmisor";
            this.Text = "frmAsignarTimbresEmisor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAsignarTimbres;
        private System.Windows.Forms.TextBox txtRFCAsignar;
        private System.Windows.Forms.TextBox txtTimbresAsignar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSaldoNuevo;
        private System.Windows.Forms.TextBox txtSaldoAnterior;
    }
}