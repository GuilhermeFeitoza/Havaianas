namespace Havaianas.Telas.Cadastros
{
    partial class FrmCadastrarCupom
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodigoCupom = new System.Windows.Forms.TextBox();
            this.txtDatainicio = new System.Windows.Forms.MaskedTextBox();
            this.txtDataFim = new System.Windows.Forms.MaskedTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nmrQuant = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrQuant)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(418, 329);
            this.button1.Click += new System.EventHandler(this.CadastrarCupom);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(573, 329);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Código cupom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Data início :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(304, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data fim:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Valor desconto R$:";
            // 
            // txtCodigoCupom
            // 
            this.txtCodigoCupom.Location = new System.Drawing.Point(154, 138);
            this.txtCodigoCupom.Name = "txtCodigoCupom";
            this.txtCodigoCupom.Size = new System.Drawing.Size(100, 27);
            this.txtCodigoCupom.TabIndex = 7;
            // 
            // txtDatainicio
            // 
            this.txtDatainicio.Location = new System.Drawing.Point(154, 204);
            this.txtDatainicio.Mask = "00/00/0000";
            this.txtDatainicio.Name = "txtDatainicio";
            this.txtDatainicio.Size = new System.Drawing.Size(100, 27);
            this.txtDatainicio.TabIndex = 8;
            this.txtDatainicio.ValidatingType = typeof(System.DateTime);
            // 
            // txtDataFim
            // 
            this.txtDataFim.Location = new System.Drawing.Point(392, 204);
            this.txtDataFim.Mask = "00/00/0000";
            this.txtDataFim.Name = "txtDataFim";
            this.txtDataFim.Size = new System.Drawing.Size(100, 27);
            this.txtDataFim.TabIndex = 9;
            this.txtDataFim.ValidatingType = typeof(System.DateTime);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(173, 278);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(92, 27);
            this.textBox1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(304, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Quantidade:";
            // 
            // nmrQuant
            // 
            this.nmrQuant.Location = new System.Drawing.Point(422, 275);
            this.nmrQuant.Name = "nmrQuant";
            this.nmrQuant.Size = new System.Drawing.Size(75, 27);
            this.nmrQuant.TabIndex = 12;
            // 
            // FrmCadastrarCupom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 401);
            this.Controls.Add(this.nmrQuant);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtDataFim);
            this.Controls.Add(this.txtDatainicio);
            this.Controls.Add(this.txtCodigoCupom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmCadastrarCupom";
            this.Text = "Cadastrar Cupom";
            this.Load += new System.EventHandler(this.FrmCadastrarCupom_Load);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtCodigoCupom, 0);
            this.Controls.SetChildIndex(this.txtDatainicio, 0);
            this.Controls.SetChildIndex(this.txtDataFim, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.nmrQuant, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrQuant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtCodigoCupom;
        public System.Windows.Forms.MaskedTextBox txtDatainicio;
        public System.Windows.Forms.MaskedTextBox txtDataFim;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nmrQuant;
    }
}