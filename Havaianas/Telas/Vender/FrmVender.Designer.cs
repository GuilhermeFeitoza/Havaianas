namespace Havaianas.Telas.Vender
{
    partial class FrmVender
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbVendedor = new System.Windows.Forms.ComboBox();
            this.lblProd = new System.Windows.Forms.Label();
            this.cbProduto = new System.Windows.Forms.ComboBox();
            this.lblQuant = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CodProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorTot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblCli = new System.Windows.Forms.Label();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.lblFormaPagamento2 = new System.Windows.Forms.Label();
            this.lblFormapgto2 = new System.Windows.Forms.Label();
            this.cbForma = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbTroco = new System.Windows.Forms.GroupBox();
            this.lblTroco = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtValorPago = new System.Windows.Forms.TextBox();
            this.gbParcela = new System.Windows.Forms.GroupBox();
            this.cbParcela = new System.Windows.Forms.ComboBox();
            this.lblParceladoEm = new System.Windows.Forms.Label();
            this.lblNumeroParcelasVenda = new System.Windows.Forms.Label();
            this.txtCupom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbForma2 = new System.Windows.Forms.ComboBox();
            this.chkDuasFormas = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbTroco.SuspendLayout();
            this.gbParcela.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(120)))), ((int)(((byte)(124)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2130, 88);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 210);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 21);
            this.label1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cliente:";
            // 
            // cbCliente
            // 
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(20, 122);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(340, 29);
            this.cbCliente.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(393, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vendedor:";
            // 
            // cbVendedor
            // 
            this.cbVendedor.FormattingEnabled = true;
            this.cbVendedor.Location = new System.Drawing.Point(397, 122);
            this.cbVendedor.Name = "cbVendedor";
            this.cbVendedor.Size = new System.Drawing.Size(382, 29);
            this.cbVendedor.TabIndex = 6;
            // 
            // lblProd
            // 
            this.lblProd.AutoSize = true;
            this.lblProd.Location = new System.Drawing.Point(16, 191);
            this.lblProd.Name = "lblProd";
            this.lblProd.Size = new System.Drawing.Size(76, 21);
            this.lblProd.TabIndex = 7;
            this.lblProd.Text = "Produto:";
            // 
            // cbProduto
            // 
            this.cbProduto.FormattingEnabled = true;
            this.cbProduto.Location = new System.Drawing.Point(20, 215);
            this.cbProduto.Name = "cbProduto";
            this.cbProduto.Size = new System.Drawing.Size(340, 29);
            this.cbProduto.TabIndex = 8;
            this.cbProduto.SelectionChangeCommitted += new System.EventHandler(this.PreencherQuantidade);
            // 
            // lblQuant
            // 
            this.lblQuant.AutoSize = true;
            this.lblQuant.Location = new System.Drawing.Point(403, 191);
            this.lblQuant.Name = "lblQuant";
            this.lblQuant.Size = new System.Drawing.Size(108, 21);
            this.lblQuant.TabIndex = 9;
            this.lblQuant.Text = "Quantidade";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(421, 217);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(74, 27);
            this.txtQuantidade.TabIndex = 10;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(560, 191);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(81, 21);
            this.lblValor.TabIndex = 11;
            this.lblValor.Text = "Valor R$: ";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(564, 215);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(113, 27);
            this.txtValor.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodProd,
            this.NomeProd,
            this.QuantProd,
            this.ValorTot});
            this.dataGridView1.Location = new System.Drawing.Point(20, 360);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(687, 259);
            this.dataGridView1.TabIndex = 14;
            // 
            // CodProd
            // 
            this.CodProd.HeaderText = "Código produto";
            this.CodProd.Name = "CodProd";
            this.CodProd.ReadOnly = true;
            this.CodProd.Width = 147;
            // 
            // NomeProd
            // 
            this.NomeProd.HeaderText = "Nome do produto";
            this.NomeProd.Name = "NomeProd";
            this.NomeProd.ReadOnly = true;
            this.NomeProd.Width = 159;
            // 
            // QuantProd
            // 
            this.QuantProd.HeaderText = "Quantidade";
            this.QuantProd.Name = "QuantProd";
            this.QuantProd.ReadOnly = true;
            this.QuantProd.Width = 133;
            // 
            // ValorTot
            // 
            this.ValorTot.HeaderText = "Valor total";
            this.ValorTot.Name = "ValorTot";
            this.ValorTot.ReadOnly = true;
            this.ValorTot.Width = 107;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(785, 360);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(333, 56);
            this.label8.TabIndex = 17;
            this.label8.Text = "VALOR TOTAL";
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.Location = new System.Drawing.Point(805, 416);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(281, 78);
            this.lblValorTotal.TabIndex = 18;
            this.lblValorTotal.Text = "R$ 00,00";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(120)))), ((int)(((byte)(124)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(728, 600);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 63);
            this.button2.TabIndex = 19;
            this.button2.Text = "Finalizar Venda";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.FinalizarVenda);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(700, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 51);
            this.button1.TabIndex = 13;
            this.button1.Text = "Adicionar produto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AdicionarProduto);
            // 
            // lblCli
            // 
            this.lblCli.AutoSize = true;
            this.lblCli.Location = new System.Drawing.Point(92, 98);
            this.lblCli.Name = "lblCli";
            this.lblCli.Size = new System.Drawing.Size(66, 21);
            this.lblCli.TabIndex = 20;
            this.lblCli.Text = "Cliente";
            this.lblCli.Visible = false;
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Location = new System.Drawing.Point(491, 98);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(66, 21);
            this.lblVendedor.TabIndex = 21;
            this.lblVendedor.Text = "Cliente";
            this.lblVendedor.Visible = false;
            // 
            // lblFormaPagamento2
            // 
            this.lblFormaPagamento2.AutoSize = true;
            this.lblFormaPagamento2.Location = new System.Drawing.Point(16, 154);
            this.lblFormaPagamento2.Name = "lblFormaPagamento2";
            this.lblFormaPagamento2.Size = new System.Drawing.Size(167, 21);
            this.lblFormaPagamento2.TabIndex = 22;
            this.lblFormaPagamento2.Text = "Forma pagamento :";
            this.lblFormaPagamento2.Visible = false;
            // 
            // lblFormapgto2
            // 
            this.lblFormapgto2.AutoSize = true;
            this.lblFormapgto2.Location = new System.Drawing.Point(189, 154);
            this.lblFormapgto2.Name = "lblFormapgto2";
            this.lblFormapgto2.Size = new System.Drawing.Size(38, 21);
            this.lblFormapgto2.TabIndex = 23;
            this.lblFormapgto2.Text = "dsd";
            this.lblFormapgto2.Visible = false;
            // 
            // cbForma
            // 
            this.cbForma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbForma.FormattingEnabled = true;
            this.cbForma.Items.AddRange(new object[] {
            "Dinheiro",
            "Cartão Débito",
            "Cartão Crédito"});
            this.cbForma.Location = new System.Drawing.Point(811, 122);
            this.cbForma.Name = "cbForma";
            this.cbForma.Size = new System.Drawing.Size(209, 29);
            this.cbForma.TabIndex = 25;
            this.cbForma.SelectionChangeCommitted += new System.EventHandler(this.cbForma_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(807, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 21);
            this.label4.TabIndex = 24;
            this.label4.Text = "Forma de pagamento:";
            // 
            // gbTroco
            // 
            this.gbTroco.Controls.Add(this.lblTroco);
            this.gbTroco.Controls.Add(this.label5);
            this.gbTroco.Controls.Add(this.txtValorPago);
            this.gbTroco.Location = new System.Drawing.Point(805, 210);
            this.gbTroco.Name = "gbTroco";
            this.gbTroco.Size = new System.Drawing.Size(281, 88);
            this.gbTroco.TabIndex = 26;
            this.gbTroco.TabStop = false;
            this.gbTroco.Text = "Valor Pago R$";
            this.gbTroco.Visible = false;
            // 
            // lblTroco
            // 
            this.lblTroco.AutoSize = true;
            this.lblTroco.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTroco.Location = new System.Drawing.Point(133, 24);
            this.lblTroco.Name = "lblTroco";
            this.lblTroco.Size = new System.Drawing.Size(0, 19);
            this.lblTroco.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(133, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Troco R$: ";
            // 
            // txtValorPago
            // 
            this.txtValorPago.Location = new System.Drawing.Point(16, 26);
            this.txtValorPago.Name = "txtValorPago";
            this.txtValorPago.Size = new System.Drawing.Size(97, 27);
            this.txtValorPago.TabIndex = 1;
            this.txtValorPago.TextChanged += new System.EventHandler(this.txtValorPago_TextChanged);
            // 
            // gbParcela
            // 
            this.gbParcela.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbParcela.Controls.Add(this.cbParcela);
            this.gbParcela.Location = new System.Drawing.Point(1036, 144);
            this.gbParcela.Name = "gbParcela";
            this.gbParcela.Size = new System.Drawing.Size(106, 53);
            this.gbParcela.TabIndex = 27;
            this.gbParcela.TabStop = false;
            this.gbParcela.Text = "Parcelas";
            this.gbParcela.Visible = false;
            // 
            // cbParcela
            // 
            this.cbParcela.FormattingEnabled = true;
            this.cbParcela.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cbParcela.Location = new System.Drawing.Point(6, 24);
            this.cbParcela.Name = "cbParcela";
            this.cbParcela.Size = new System.Drawing.Size(86, 29);
            this.cbParcela.TabIndex = 0;
            // 
            // lblParceladoEm
            // 
            this.lblParceladoEm.AutoSize = true;
            this.lblParceladoEm.Location = new System.Drawing.Point(16, 179);
            this.lblParceladoEm.Name = "lblParceladoEm";
            this.lblParceladoEm.Size = new System.Drawing.Size(127, 21);
            this.lblParceladoEm.TabIndex = 28;
            this.lblParceladoEm.Text = "Parcelado em :";
            this.lblParceladoEm.Visible = false;
            // 
            // lblNumeroParcelasVenda
            // 
            this.lblNumeroParcelasVenda.AutoSize = true;
            this.lblNumeroParcelasVenda.Location = new System.Drawing.Point(149, 180);
            this.lblNumeroParcelasVenda.Name = "lblNumeroParcelasVenda";
            this.lblNumeroParcelasVenda.Size = new System.Drawing.Size(0, 21);
            this.lblNumeroParcelasVenda.TabIndex = 29;
            this.lblNumeroParcelasVenda.Visible = false;
            // 
            // txtCupom
            // 
            this.txtCupom.Location = new System.Drawing.Point(837, 305);
            this.txtCupom.Name = "txtCupom";
            this.txtCupom.Size = new System.Drawing.Size(113, 27);
            this.txtCupom.TabIndex = 31;
            this.txtCupom.TextChanged += new System.EventHandler(this.txtCupom_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(663, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 21);
            this.label6.TabIndex = 30;
            this.label6.Text = "Cupom Promocional:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnAplicar
            // 
            this.btnAplicar.Location = new System.Drawing.Point(998, 299);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(103, 38);
            this.btnAplicar.TabIndex = 33;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.ValidarCupom);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 21);
            this.label7.TabIndex = 34;
            this.label7.Text = "Cliente:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(173, 153);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(187, 25);
            this.checkBox1.TabIndex = 35;
            this.checkBox1.Text = "Não informar cliente";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::Havaianas.Properties.Resources.Cancel_48px;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(956, 307);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cbForma2
            // 
            this.cbForma2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbForma2.FormattingEnabled = true;
            this.cbForma2.Items.AddRange(new object[] {
            "Dinheiro",
            "Cartão Débito",
            "Cartão Crédito"});
            this.cbForma2.Location = new System.Drawing.Point(811, 168);
            this.cbForma2.Name = "cbForma2";
            this.cbForma2.Size = new System.Drawing.Size(209, 29);
            this.cbForma2.TabIndex = 36;
            this.cbForma2.Visible = false;
            this.cbForma2.SelectionChangeCommitted += new System.EventHandler(this.cbForma2_SelectionChangeCommitted);
            // 
            // chkDuasFormas
            // 
            this.chkDuasFormas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkDuasFormas.AutoSize = true;
            this.chkDuasFormas.Location = new System.Drawing.Point(1001, 94);
            this.chkDuasFormas.Name = "chkDuasFormas";
            this.chkDuasFormas.Size = new System.Drawing.Size(213, 25);
            this.chkDuasFormas.TabIndex = 37;
            this.chkDuasFormas.Text = "Pagar com duas formas";
            this.chkDuasFormas.UseVisualStyleBackColor = true;
            this.chkDuasFormas.CheckedChanged += new System.EventHandler(this.DuasFormas);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(495, 314);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 40);
            this.button3.TabIndex = 38;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FrmVender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1217, 675);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.chkDuasFormas);
            this.Controls.Add(this.cbForma2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnAplicar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtCupom);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblNumeroParcelasVenda);
            this.Controls.Add(this.lblParceladoEm);
            this.Controls.Add(this.gbTroco);
            this.Controls.Add(this.gbParcela);
            this.Controls.Add(this.cbForma);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblFormapgto2);
            this.Controls.Add(this.lblFormaPagamento2);
            this.Controls.Add(this.lblVendedor);
            this.Controls.Add(this.lblCli);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.lblQuant);
            this.Controls.Add(this.cbProduto);
            this.Controls.Add(this.lblProd);
            this.Controls.Add(this.cbVendedor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmVender";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venda";
            this.Load += new System.EventHandler(this.CarregarCombo);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbTroco.ResumeLayout(false);
            this.gbTroco.PerformLayout();
            this.gbParcela.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cbCliente;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox cbVendedor;
        public System.Windows.Forms.Label lblProd;
        public System.Windows.Forms.ComboBox cbProduto;
        public System.Windows.Forms.Label lblQuant;
        public System.Windows.Forms.TextBox txtQuantidade;
        public System.Windows.Forms.Label lblValor;
        public System.Windows.Forms.TextBox txtValor;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label lblValorTotal;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label lblCli;
        public System.Windows.Forms.Label lblVendedor;
        public System.Windows.Forms.Label lblFormaPagamento2;
        public System.Windows.Forms.Label lblFormapgto2;
        public System.Windows.Forms.ComboBox cbForma;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbTroco;
        private System.Windows.Forms.GroupBox gbParcela;
        private System.Windows.Forms.ComboBox cbParcela;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label lblTroco;
        private System.Windows.Forms.Label lblParceladoEm;
        private System.Windows.Forms.Label lblNumeroParcelasVenda;
        public System.Windows.Forms.TextBox txtCupom;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAplicar;
        public System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txtValorPago;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorTot;
        public System.Windows.Forms.ComboBox cbForma2;
        private System.Windows.Forms.CheckBox chkDuasFormas;
        private System.Windows.Forms.Button button3;
    }
}