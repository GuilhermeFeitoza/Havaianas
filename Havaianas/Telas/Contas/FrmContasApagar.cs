using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Havaianas.Telas.Contas
{
    public partial class FrmContasApagar : Form
    {
        public FrmContasApagar()
        {
           
            InitializeComponent();
           
            RecuperarDatasInicializar();
            cbPagar.Checked = true;
            cbPagas.Checked = true;
        }






        BLL.Lancamento lcm = new BLL.Lancamento();
        private byte _TipoStatus;

        public byte TipoStatus
        {
            get
            {
                return _TipoStatus;
            }

            set
            {
                _TipoStatus = value;
            }
        }




        private void ChecarDigitacaoDatas()
        {
            try
            {
                if (Convert.ToDateTime(mskDataInicial.Text) > Convert.ToDateTime(mskDataFinal.Text))
                {
                    mskDataInicial.Text = mskDataFinal.Text;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void CarregarDadosGrid(Object o, EventArgs e)
        {

            // mskDataInicial.Text = "01/01/2019";
            //mskDataFinal.Text = "31/12/2019";
            ChecarDigitacaoDatas();
            if (cbPagar.Checked && cbPagas.Checked)
            {
                TipoStatus = (byte)BLL.FuncoesGerais.TipoStatus.Todos;
            }
            else if (cbPagar.Checked && !cbPagas.Checked)
            {
                TipoStatus = (byte)BLL.FuncoesGerais.TipoStatus.Inativo;
            }
            else
            {
                TipoStatus = (byte)BLL.FuncoesGerais.TipoStatus.Ativo;
            }

            dataGridView1.DataSource = lcm.ListarContas(TipoStatus, Convert.ToDateTime(mskDataInicial.Text), Convert.ToDateTime(mskDataFinal.Text)).Tables[0];


            dataGridView1.AutoResizeColumns();

            dataGridView1.Columns["Codigotitulo"].Visible = false;
            dataGridView1.Columns["CodigoLancamento"].Visible = false;
            dataGridView1.Columns["StatusPagTitulo"].Visible = true;
            dataGridView1.Columns["ValorTitulo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;


            if (o == btnFiltrar)
            {
                txtPesquisaTitulo.Clear();
            }


            //AtualizaLblPagas();
            //AtualizarLblSaldo();
            //AtualizaLblAPagar();
            AtualizarLblInformativo();
        }



        public double ValorDigitadoPagamento;

        Form fValor = new Form();
        TextBox txtDigitarValor = new TextBox();
        private void CriarFormularioDigitarValorPago()
        {
            fValor.Text = "Informe valor com juros e multa da conta vencida desde " + String.Format("{0:d}", dataGridView1.CurrentRow.Cells["DataVencimento"].Value);
            fValor.FormBorderStyle = FormBorderStyle.FixedSingle;
            fValor.AutoSize = false;
            fValor.KeyPreview = true;
            fValor.MinimizeBox = false;
            fValor.MaximizeBox = false;
            fValor.Size = new Size(500, 190);
            fValor.ShowIcon = false;
            fValor.StartPosition = FormStartPosition.CenterParent;

            Label lblTitulo = new Label();
            lblTitulo.Location = new Point(12, 4);
            lblTitulo.Font = new System.Drawing.Font(lblTitulo.Font.FontFamily, 16);
            lblTitulo.AutoSize = true;
            lblTitulo.Text = dataGridView1.CurrentRow.Cells["DescricaoTitulo"].Value.ToString();
            fValor.Controls.Add(lblTitulo);

            Label lblValorOriginal = new Label();
            lblValorOriginal.Location = new Point(12, 34);
            lblValorOriginal.Font = new System.Drawing.Font(lblValorOriginal.Font.FontFamily, 12);
            lblValorOriginal.AutoSize = true;
            lblValorOriginal.Text = "Valor Original " + String.Format("{0:c}", dataGridView1.CurrentRow.Cells["ValorTitulo"].Value);
            fValor.Controls.Add(lblValorOriginal);

            // TextBox txtDigitarValor = new TextBox();
            txtDigitarValor.Clear();
            txtDigitarValor.Location = new Point(12, 64);
            txtDigitarValor.Font = new System.Drawing.Font(txtDigitarValor.Font.FontFamily, 16);
            txtDigitarValor.TextAlign = HorizontalAlignment.Right;
            txtDigitarValor.Text = String.Format("{0:n2}", dataGridView1.CurrentRow.Cells["ValorTitulo"].Value);
            fValor.Controls.Add(txtDigitarValor);

            Button btnOk = new Button();
            btnOk.Location = new Point(12, 104);
            btnOk.Font = new System.Drawing.Font(txtDigitarValor.Font.FontFamily, 16);
            btnOk.Size = new Size(94, 37);
            btnOk.Visible = true;
            btnOk.Text = "OK";
            btnOk.ForeColor = System.Drawing.Color.Black;
            btnOk.Click += new System.EventHandler(this.ConfirmarValor);
            fValor.Controls.Add(btnOk);
            fValor.ShowDialog();
            if (Convert.ToDouble(txtDigitarValor.Text) < Convert.ToDouble(dataGridView1.CurrentRow.Cells["ValorTitulo"].Value))
            {
                MessageBox.Show("Valor para pagamento informado não pode ser menor que o valor do título.");
            }
            ValorDigitadoPagamento = Convert.ToDouble(txtDigitarValor.Text);
        }



        private void Fixar(Object o, EventArgs e)
        {
            try
            {
                var b = (Button)o;

                if (MessageBox.Show(dataGridView1.CurrentRow.Cells["DescricaoTitulo"].Value.ToString() + "\n" + "Vencimento " + String.Format("{0:d}", dataGridView1.CurrentRow.Cells["DataVencimento"].Value) + "\n" + "Valor " + String.Format("{0:C}", dataGridView1.CurrentRow.Cells["ValorTitulo"].Value), b.Text + "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.No) return;

                lcm.CodigoLancamento = Convert.ToInt32(dataGridView1.CurrentRow.Cells["CodigoLancamento"].Value);

                switch (b.Text)
                {

                    case "Excluir":
                        if (Convert.ToInt32(dataGridView1.CurrentRow.Cells["StatusPagTitulo"].Value) == 1)
                        {
                            MessageBox.Show("Não é possível excluir uma conta com pagamento já efetuado.");
                            return;
                        }
                        lcm.Excluir();
                        break;

                    case "Pagar":

                        if (Convert.ToByte(dataGridView1.CurrentRow.Cells["StatusPagTitulo"].Value) == 1)
                        {
                            MessageBox.Show("Conta já estava paga.");
                            return;
                        }

                        lcm.ValorPagamento = Convert.ToDouble(dataGridView1.CurrentRow.Cells["ValorTitulo"].Value);

                        if (Convert.ToDateTime(dataGridView1.CurrentRow.Cells["DataVencimento"].Value) < DateTime.Today)
                        {
                            MessageBox.Show("Conta encontra-se vencida.");

                            CriarFormularioDigitarValorPago();

                            if (ValorDigitadoPagamento < Convert.ToDouble(dataGridView1.CurrentRow.Cells["ValorTitulo"].Value))
                            {
                                ValorDigitadoPagamento = 0;
                                return;
                            }
                            else
                            {
                                lcm.ValorPagamento = ValorDigitadoPagamento;
                            }
                        }

                        lcm.CodigoTitulo = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Codigotitulo"].Value);
                        lcm.StatusPagTitulo = 1;
                        //lcm.CodigoUsuario = Codigo;
                        lcm.ValorTitulo = Convert.ToDouble(dataGridView1.CurrentRow.Cells["ValorTitulo"].Value);
                        lcm.DataPagamento = DateTime.Today;
                        lcm.DataVencimento = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["DataVencimento"].Value);
                        lcm.Pagar();
                        break;

                    case "Cancelar":
                        if (Convert.ToInt32(dataGridView1.CurrentRow.Cells["StatusPagTitulo"].Value) == 0)
                        {
                            MessageBox.Show("Não é possível cancelar uma conta que não foi paga.");
                            return;
                        }
                        lcm.CancelarPagamento();
                        break;
                }
                MessageBox.Show("Procedimento " + b.Text + " realizado com sucesso!");
                CarregarDadosGrid(o, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso");
            }
        }







        public void ConfirmarValor(Object o, EventArgs e)
        {
            fValor.Close();
        }


        private void AtualizarLblInformativo()
        {
            try
            {
                txtInformativo.Clear();
                System.Data.SqlClient.SqlDataReader ddr;
                ddr = lcm.ObterTituloEmAberto(DateTime.Today);
                ddr.Read();
                if (ddr.HasRows)
                {

                    if (ddr["ValorTotal"] != DBNull.Value &&
                        ddr["PrimeiraData"] != DBNull.Value &&
                        ddr["Qtde"] != DBNull.Value)
                    {




                        if (Convert.ToInt32(ddr["Qtde"]) == 1)
                        {
                            txtInformativo.Text = "Desde " + Convert.ToDateTime(ddr["PrimeiraData"]).ToShortDateString() + " até " + DateTime.Today.AddDays(-1).ToShortDateString() + " existe " + Convert.ToInt32(ddr["Qtde"]).ToString() + " conta";
                        }
                        else
                        {
                            txtInformativo.Text = "Desde " + Convert.ToDateTime(ddr["PrimeiraData"]).ToShortDateString() + " até " + DateTime.Today.AddDays(-1).ToShortDateString() + " existem " + Convert.ToInt32(ddr["Qtde"]).ToString() + " contas";
                        }

                        txtInformativo.Text = txtInformativo.Text + " sem pagamento totalizando " + String.Format("{0:c}", Convert.ToDouble(ddr["ValorTotal"])) + " sem juros ou correção.";
                    }
                    else
                    {
                        txtInformativo.Text = "Sem Mensagem";
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

    
 


        private void button1_Click(object sender, EventArgs e)
        {

            Telas.Cadastros.FrmCadLancamento f = new Telas.Cadastros.FrmCadLancamento();

            f.ShowDialog();
            this.Dispose();
        }



        private void RecuperarDatasInicializar()
        {


            mskDataInicial.Text = DateTime.Today.ToShortDateString();
            mskDataFinal.Text = DateTime.Today.AddMonths(1).ToShortDateString();















        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
