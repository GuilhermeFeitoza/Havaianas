namespace Havaianas.Telas.FaleConosco
{
    partial class FrmResponder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmResponder));
            this.gbMensagem = new System.Windows.Forms.GroupBox();
            this.lblData = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.btnResponder = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblAssunto = new MaterialSkin.Controls.MaterialLabel();
            this.lblEmail = new MaterialSkin.Controls.MaterialLabel();
            this.lblNome = new MaterialSkin.Controls.MaterialLabel();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtResposta = new System.Windows.Forms.TextBox();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.gbMensagem.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMensagem
            // 
            this.gbMensagem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbMensagem.Controls.Add(this.txtResposta);
            this.gbMensagem.Controls.Add(this.lblData);
            this.gbMensagem.Controls.Add(this.materialLabel6);
            this.gbMensagem.Controls.Add(this.materialLabel5);
            this.gbMensagem.Controls.Add(this.lblAssunto);
            this.gbMensagem.Controls.Add(this.lblEmail);
            this.gbMensagem.Controls.Add(this.lblNome);
            this.gbMensagem.Controls.Add(this.txtMsg);
            this.gbMensagem.Controls.Add(this.materialLabel4);
            this.gbMensagem.Controls.Add(this.materialLabel3);
            this.gbMensagem.Controls.Add(this.materialLabel2);
            this.gbMensagem.Controls.Add(this.materialLabel1);
            this.gbMensagem.Location = new System.Drawing.Point(12, 12);
            this.gbMensagem.Name = "gbMensagem";
            this.gbMensagem.Size = new System.Drawing.Size(850, 371);
            this.gbMensagem.TabIndex = 14;
            this.gbMensagem.TabStop = false;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Depth = 0;
            this.lblData.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblData.Location = new System.Drawing.Point(56, 135);
            this.lblData.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(0, 19);
            this.lblData.TabIndex = 16;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(6, 135);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(44, 19);
            this.materialLabel5.TabIndex = 15;
            this.materialLabel5.Text = "Data:";
            // 
            // btnResponder
            // 
            this.btnResponder.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnResponder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(120)))), ((int)(((byte)(124)))));
            this.btnResponder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnResponder.BorderRadius = 0;
            this.btnResponder.ButtonText = "Enviar";
            this.btnResponder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResponder.DisabledColor = System.Drawing.Color.Gray;
            this.btnResponder.Iconcolor = System.Drawing.Color.Transparent;
            this.btnResponder.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnResponder.Iconimage")));
            this.btnResponder.Iconimage_right = null;
            this.btnResponder.Iconimage_right_Selected = null;
            this.btnResponder.Iconimage_Selected = null;
            this.btnResponder.IconMarginLeft = 0;
            this.btnResponder.IconMarginRight = 0;
            this.btnResponder.IconRightVisible = true;
            this.btnResponder.IconRightZoom = 0D;
            this.btnResponder.IconVisible = true;
            this.btnResponder.IconZoom = 90D;
            this.btnResponder.IsTab = false;
            this.btnResponder.Location = new System.Drawing.Point(595, 407);
            this.btnResponder.Name = "btnResponder";
            this.btnResponder.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(120)))), ((int)(((byte)(124)))));
            this.btnResponder.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(122)))), ((int)(((byte)(216)))));
            this.btnResponder.OnHoverTextColor = System.Drawing.Color.White;
            this.btnResponder.selected = false;
            this.btnResponder.Size = new System.Drawing.Size(193, 48);
            this.btnResponder.TabIndex = 14;
            this.btnResponder.Text = "Enviar";
            this.btnResponder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResponder.Textcolor = System.Drawing.Color.White;
            this.btnResponder.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResponder.Click += new System.EventHandler(this.btnResponder_Click);
            // 
            // lblAssunto
            // 
            this.lblAssunto.AutoSize = true;
            this.lblAssunto.Depth = 0;
            this.lblAssunto.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblAssunto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAssunto.Location = new System.Drawing.Point(81, 98);
            this.lblAssunto.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAssunto.Name = "lblAssunto";
            this.lblAssunto.Size = new System.Drawing.Size(0, 19);
            this.lblAssunto.TabIndex = 7;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Depth = 0;
            this.lblEmail.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEmail.Location = new System.Drawing.Point(67, 63);
            this.lblEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(0, 19);
            this.lblEmail.TabIndex = 6;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Depth = 0;
            this.lblNome.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNome.Location = new System.Drawing.Point(66, 23);
            this.lblNome.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(0, 19);
            this.lblNome.TabIndex = 5;
            // 
            // txtMsg
            // 
            this.txtMsg.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMsg.Location = new System.Drawing.Point(12, 213);
            this.txtMsg.Multiline = true;
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.ReadOnly = true;
            this.txtMsg.Size = new System.Drawing.Size(411, 179);
            this.txtMsg.TabIndex = 4;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(6, 183);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(87, 19);
            this.materialLabel4.TabIndex = 3;
            this.materialLabel4.Text = "Mensagem:";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(6, 98);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(69, 19);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Assunto:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(6, 63);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(55, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "E-mail:";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(6, 23);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(54, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Nome:";
            // 
            // txtResposta
            // 
            this.txtResposta.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResposta.Location = new System.Drawing.Point(435, 213);
            this.txtResposta.Multiline = true;
            this.txtResposta.Name = "txtResposta";
            this.txtResposta.Size = new System.Drawing.Size(384, 152);
            this.txtResposta.TabIndex = 16;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(431, 183);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(72, 19);
            this.materialLabel6.TabIndex = 15;
            this.materialLabel6.Text = "Resposta";
            // 
            // FrmResponder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 481);
            this.Controls.Add(this.gbMensagem);
            this.Controls.Add(this.btnResponder);
            this.Name = "FrmResponder";
            this.Text = "Responder";
            this.gbMensagem.ResumeLayout(false);
            this.gbMensagem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox gbMensagem;
        public System.Windows.Forms.TextBox txtResposta;
        public MaterialSkin.Controls.MaterialLabel lblData;
        public MaterialSkin.Controls.MaterialLabel materialLabel6;
        public MaterialSkin.Controls.MaterialLabel materialLabel5;
        public MaterialSkin.Controls.MaterialLabel lblAssunto;
        public MaterialSkin.Controls.MaterialLabel lblEmail;
        public MaterialSkin.Controls.MaterialLabel lblNome;
        public System.Windows.Forms.TextBox txtMsg;
        public MaterialSkin.Controls.MaterialLabel materialLabel4;
        public MaterialSkin.Controls.MaterialLabel materialLabel3;
        public MaterialSkin.Controls.MaterialLabel materialLabel2;
        public MaterialSkin.Controls.MaterialLabel materialLabel1;
        public Bunifu.Framework.UI.BunifuFlatButton btnResponder;
    }
}