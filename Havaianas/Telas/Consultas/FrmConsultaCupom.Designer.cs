namespace Havaianas.Telas.Consultas
{
    partial class FrmConsultaCupom
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(106, 644);
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(-88, 644);
            this.btnConsultar.Visible = false;
            // 
            // btnAtivar
            // 
            this.btnAtivar.Location = new System.Drawing.Point(310, 644);
            this.btnAtivar.Click += new System.EventHandler(this.Fixar);
            // 
            // btnDesativar
            // 
            this.btnDesativar.Location = new System.Drawing.Point(496, 644);
            this.btnDesativar.Click += new System.EventHandler(this.Fixar);
            // 
            // FrmConsultaCupom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 714);
            this.Name = "FrmConsultaCupom";
            this.Text = "FrmConsultaCupom";
            this.Load += new System.EventHandler(this.Exibir);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}