namespace Havaianas.Telas.Cadastros
{
    partial class FrmCadNivelAcesso
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeNivelAcesso = new System.Windows.Forms.TextBox();
            this.txtAbreviacao = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Click += new System.EventHandler(this.CadastrarNivel);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome nivel acesso :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Abreviação:";
            // 
            // txtNomeNivelAcesso
            // 
            this.txtNomeNivelAcesso.Location = new System.Drawing.Point(180, 154);
            this.txtNomeNivelAcesso.Name = "txtNomeNivelAcesso";
            this.txtNomeNivelAcesso.Size = new System.Drawing.Size(312, 27);
            this.txtNomeNivelAcesso.TabIndex = 6;
            // 
            // txtAbreviacao
            // 
            this.txtAbreviacao.Location = new System.Drawing.Point(126, 215);
            this.txtAbreviacao.MaxLength = 3;
            this.txtAbreviacao.Name = "txtAbreviacao";
            this.txtAbreviacao.Size = new System.Drawing.Size(70, 27);
            this.txtAbreviacao.TabIndex = 7;
            // 
            // FrmCadNivelAcesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 469);
            this.Controls.Add(this.txtAbreviacao);
            this.Controls.Add(this.txtNomeNivelAcesso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmCadNivelAcesso";
            this.Text = "Cadastrar nivel acesso ";
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtNomeNivelAcesso, 0);
            this.Controls.SetChildIndex(this.txtAbreviacao, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtNomeNivelAcesso;
        public System.Windows.Forms.TextBox txtAbreviacao;
    }
}