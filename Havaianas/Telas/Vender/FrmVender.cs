using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Havaianas.Telas.Vender
{
    public partial class FrmVender : Form
    {
        public FrmVender()
        {

            InitializeComponent();

            dataGridView1.Columns["ValorTot"].DefaultCellStyle.Format = "C2";
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;


            try
            {
                BLL.Produto c = new BLL.Produto();
                if (cbProduto.SelectedIndex > -1)
                {
                    System.Data.SqlClient.SqlDataReader ddr;
                    ddr = c.ListarProdComQuant(Convert.ToInt16(cbProduto.SelectedValue), (byte)BLL.FuncoesGerais.TipoStatus.Ativo);
                    if (ddr.HasRows)
                    {
                        ddr.Read();
                        txtValor.Text = Convert.ToString(ddr["PrecoProduto"]);
                        txtQuantidade.Text = "1";
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }


        }
        public Decimal totalVenda = 0;
        private static int codigoVendedor;

        public static int CodigoVendedor
        {
            get
            {
                return codigoVendedor;
            }

            set
            {
                codigoVendedor = value;
            }
        }



        public void CarregarCombo(object o, EventArgs e)
        {

            BLL.Produto c = new BLL.Produto();
            cbProduto.DataSource = c.ListarProdDisponiveis().Tables[0];
            cbProduto.DisplayMember = "NomeProduto";
            cbProduto.ValueMember = "CodigoProduto";
            cbProduto.SelectedIndex = -1;

            BLL.Vendedor n = new BLL.Vendedor();
            cbVendedor.DataSource = n.Listar(String.Empty, (byte)BLL.FuncoesGerais.TipoStatus.Ativo).Tables[0];
            cbVendedor.DisplayMember = "NomeVendedor";
            cbVendedor.ValueMember = "CodigoVendedor";



            BLL.Cliente cl = new BLL.Cliente();
            cbCliente.DataSource = cl.Listar(String.Empty, (byte)BLL.FuncoesGerais.TipoStatus.Ativo).Tables[0];
            cbCliente.DisplayMember = "NomeCliente";
            cbCliente.ValueMember = "CodigoCliente";



        }
        private void PreencherQuantidade(object o, EventArgs e)
        {

            try
            {
                BLL.Produto c = new BLL.Produto();
                if (cbProduto.SelectedIndex > -1)
                {
                    System.Data.SqlClient.SqlDataReader ddr;
                    ddr = c.ListarProdComQuant(Convert.ToInt16(cbProduto.SelectedValue), (byte)BLL.FuncoesGerais.TipoStatus.Ativo);
                    if (ddr.HasRows)
                    {
                        ddr.Read();
                        txtValor.Text = Convert.ToString(ddr["PrecoProduto"]);
                        txtQuantidade.Text = "1";
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }



        }
        private void AdicionarProduto(object o, EventArgs e)
        {

            try
            {

                if (cbProduto.SelectedIndex > -1)

                {

                    Double ValorTotal;

                    BLL.Produto p = new BLL.Produto();
                    System.Data.SqlClient.SqlDataReader ddr;
                    p.CodigoProduto = Convert.ToInt16(cbProduto.SelectedValue);
                    ddr = p.Consultar();
                    String ProdutoSelecionado = "";
                    ddr.Read();
                    if (ddr.HasRows)
                    {

                        ProdutoSelecionado = Convert.ToString(ddr["NomeProduto"]);
                    }

                    if (Convert.ToInt16(txtQuantidade.Text) > 0)
                    {
                        //Mais de um produto
                        ValorTotal = Convert.ToDouble(txtValor.Text) * Convert.ToDouble(txtQuantidade.Text);
                        dataGridView1.Rows.Add(cbProduto.SelectedValue, ProdutoSelecionado, txtQuantidade.Text, ValorTotal);
                        txtQuantidade.Clear();
                        txtValor.Clear();
                        cbProduto.SelectedIndex = -1;
                        cbProduto.Focus();
                        dataGridView1.AutoResizeColumns();
                    }
                    else
                    {
                        //Somente um produto
                        dataGridView1.Rows.Add(cbProduto.SelectedValue, Convert.ToString(cbProduto.SelectedText), txtQuantidade.Text, txtValor.Text);
                        txtQuantidade.Clear();
                        cbProduto.SelectedIndex = -1;
                        cbProduto.Focus();
                        dataGridView1.AutoResizeColumns();
                    }

                    Decimal total = 0;
                    foreach (DataGridViewRow row in dataGridView1.Rows.Cast<DataGridViewRow>()
                    .Where(t => !string.IsNullOrEmpty(t.Cells["ValorTot"].Value?.ToString())))
                    {

                        total += Convert.ToDecimal(row.Cells["ValorTot"].Value);


                        lblValorTotal.Text = string.Format("{0:C}", total);
                        totalVenda = total;

                    }
                    


                }
                else
                {
                    MessageBox.Show("Escolha um produto para adicionar à venda!!");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }





        }

        private void SalvarProdutos()
        {

            BLL.Venda v = new BLL.Venda();
            int CodigoUltimaVenda = v.RetornarVenda();
            int CodigoProdutoGrid = 0;
            //foreachzinho para pegar linha por linha e depois ir inserindo na tabela linha por linha
            foreach (DataGridViewRow row in dataGridView1.Rows.Cast<DataGridViewRow>()
                    .Where(t => !string.IsNullOrEmpty(t.Cells["CodProd"].Value?.ToString())))
            {

                try
                {
                    CodigoProdutoGrid = Convert.ToInt32(row.Cells["CodProd"].Value);
                    DAO.ClasseParaManipularBancoDeDados c = new DAO.ClasseParaManipularBancoDeDados();

                    string comando;

                    SqlParameter[] listaComParametros = {
                   new SqlParameter("@CodigoVenda",SqlDbType.Int) {Value = CodigoUltimaVenda },
                   new SqlParameter("@CodigoProduto",SqlDbType.Int) {Value = CodigoProdutoGrid },

                };

                    comando = "INSERT INTO tbItem_Venda(CodigoVenda,CodigoProduto) Values (@CodigoVenda,@CodigoProduto)";
                    c.ExecutarComandoParametro(comando, listaComParametros);


                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }



        }


   
        private void CalcularValorVenda()
        {

            foreach (DataGridViewRow row in dataGridView1.Rows.Cast<DataGridViewRow>()
             .Where(t => !string.IsNullOrEmpty(t.Cells["ValorTot"].Value?.ToString())))
            {
                totalVenda += Convert.ToDecimal(row.Cells["ValorTot"].Value);
                


            }

            


        }
     



        public void FinalizarVenda(object o, EventArgs e)
        {
            try
            {
                BLL.Venda v = new BLL.Venda();
                v.CodigoCliente = Convert.ToInt32(cbCliente.SelectedValue);
                v.CodigoVendedor = Convert.ToInt32(cbVendedor.SelectedValue);
                v.DataVenda = DateTime.Today;

                BLL.Cupom cup = new BLL.Cupom();


                v.ValorTotal = Convert.ToDouble(totalVenda);

                
                v.Pagamento = Convert.ToString(cbForma.SelectedItem);
                if (chkDuasFormas.Checked==true)
                {
                    v.IncluirComParametroDuasFormas();
                    v.Pagamento2 = Convert.ToString(cbForma2.SelectedItem);
                }
                else
                {
                    v.IncluirComParametro();
                }
             
                SalvarProdutos();
                AtualizarEstoque();
                SalvarParcelas();
                if (txtCupom.Text.Length==0)
                {
                    MessageBox.Show("Venda finalizada com sucesso");
                }
                if (pictureBox1.ImageLocation=="c.png")
                {
                    MessageBox.Show("Venda finalizada com sucesso.O cupom "+txtCupom.Text.ToUpper() +" foi adicionado a venda gerando um desconto de "+cup.RetornarValorCupom(txtCupom.Text)+" á compra");
                }
                
                Close();

            }
            catch (Exception ex)

            {

                throw ex;
            }








        }

        private void AtualizarEstoque()
        {




            BLL.Estoque est = new BLL.Estoque();
            int CodigoProdutoGrid = 0;
            int QuantidadeProdutoGrid = 0;
            //foreachzinho para pegar linha por linha e depois ir inserindo na tabela linha por linha
            foreach (DataGridViewRow row in dataGridView1.Rows.Cast<DataGridViewRow>()
                    .Where(t => !string.IsNullOrEmpty(t.Cells["CodProd"].Value?.ToString())))
            {

                try
                {
                    CodigoProdutoGrid = Convert.ToInt32(row.Cells["CodProd"].Value);
                    QuantidadeProdutoGrid = Convert.ToInt32(row.Cells["QuantProd"].Value);
                    DAO.ClasseParaManipularBancoDeDados c = new DAO.ClasseParaManipularBancoDeDados();

                    string comando;

                    SqlParameter[] listaComParametros = {

                   new SqlParameter("@CodigoProduto",SqlDbType.Int) {Value = CodigoProdutoGrid },
                    new SqlParameter("@Quantidade",SqlDbType.Int) {Value = QuantidadeProdutoGrid },

                };

                    comando = "UPDATE tbEstoque SET QuantidadeAtual=QuantidadeAtual-@Quantidade WHERE CodigoProduto=@CodigoProduto";
                    c.ExecutarComandoParametro(comando, listaComParametros);


                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }


        }


        public void MostrarNumeroDeParcelas() {
            System.Data.SqlClient.SqlDataReader ddr;
            BLL.Venda v = new BLL.Venda();
            ddr = v.MostrarParcela();
            ddr.Read();
            if (ddr.HasRows)
            {
                lblNumeroParcelasVenda.Text = Convert.ToString(ddr[2]) +"Vezes";
                lblParceladoEm.Visible = true;
                lblNumeroParcelasVenda.Visible = true;
            }


            
        }

        private void cbForma_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (Convert.ToString(cbForma.SelectedItem) == "Cartão Crédito")
             {
                gbParcela.Visible = true;
                gbTroco.Visible = false;
            }

            if (Convert.ToString(cbForma.SelectedItem)== "Dinheiro")
            {
                gbTroco.Visible = true;
                gbParcela.Visible = false;
            }
            if (Convert.ToString(cbForma.SelectedItem)=="Cartão Débito")
            {
                gbTroco.Visible = false;
                gbParcela.Visible = false;
            }


        }




        private void SalvarParcelas() {

            if (gbParcela.Visible == true)
            {
                try
                {
                    BLL.Venda v = new BLL.Venda();
                    DAO.ClasseParaManipularBancoDeDados c = new DAO.ClasseParaManipularBancoDeDados();

                    string comando;

                    SqlParameter[] listaComParametros = {

                   new SqlParameter("@CodigoVenda",SqlDbType.Int) {Value = v.RetornarVenda() },
                    new SqlParameter("@NumeroParcelas",SqlDbType.Int) {Value = Convert.ToInt32(cbParcela.SelectedItem) }

                };

                    comando = "INSERT INTO tbParcelamentoVenda(CodigoVenda,NumeroParcelas)VALUES(@CodigoVenda,@NumeroParcelas)";
                    c.ExecutarComandoParametro(comando, listaComParametros);





                }
                catch (Exception ex )
                {

                    throw ex;
                }



            }







        }


        private void ValidarCupom(object o, EventArgs e) {

            BLL.Cupom cup = new BLL.Cupom();
            cup.CodigoCupom = txtCupom.Text;
            if (cup.VerificarCupom() ==true)
            {
                pictureBox1.ImageLocation = "c.png";
                txtCupom.ReadOnly = true;
                if (pictureBox1.ImageLocation == "c.png")
                {
                    totalVenda -= cup.RetornarValorCupom(txtCupom.Text);
                    lblValorTotal.Text = string.Format("{0:C}", totalVenda);
                    btnAplicar.Enabled = false;
                    cup.CodigoCupom = txtCupom.Text;
                    cup.BaixarCupom();
                }


            }
            else
            {
                pictureBox1.ImageLocation = "e.png";

            }



        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked = true)
            {
                label7.Visible = false;
                cbCliente.Visible = false;

            }
            else
            {
                label7.Visible = true;
                cbCliente.Visible = true;
            }
        }

        private void txtValorPago_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtValorPago_TextChanged(object sender, EventArgs e)
        {
            lblTroco.Text = "";
           

            if (txtValorPago.TextLength > 0)
            {
                decimal ValorPago = Convert.ToDecimal(txtValorPago.Text);
                decimal Troco = ValorPago - totalVenda;
                lblTroco.Text = Troco.ToString("C");

            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtCupom_TextChanged(object sender, EventArgs e)
        {

        }
        private void DuasFormas(object o , EventArgs e)
        {

            if (chkDuasFormas.Checked == true)
            {
                cbForma2.Visible = true;

            }
            else
            {
                cbForma2.Visible = false;
            }


        }

        private void cbForma2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (Convert.ToString(cbForma.SelectedItem) == "Cartão Crédito")
            {
                gbParcela.Visible = true;
                gbTroco.Visible = false;
            }

            if (Convert.ToString(cbForma.SelectedItem) == "Dinheiro")
            {
                gbTroco.Visible = true;
                gbParcela.Visible = false;
            }
            if (Convert.ToString(cbForma.SelectedItem) == "Cartão Débito")
            {
                gbTroco.Visible = false;
                gbParcela.Visible = false;
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Tiro do grid
            decimal ValorProdRemovido = Convert.ToDecimal(dataGridView1.CurrentRow.Cells["ValorTot"].Value);
            this.dataGridView1.Rows.Remove(this.dataGridView1.CurrentRow);
            //subtraiu da variavel global
           
            totalVenda -= ValorProdRemovido;
            //Atualiza o label
            lblValorTotal.Text = string.Format("{0:C}", totalVenda);

        }
    }
    }
