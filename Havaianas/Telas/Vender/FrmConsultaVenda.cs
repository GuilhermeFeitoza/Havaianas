using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Havaianas.Telas.Vender
{
    public partial class FrmConsultaVenda : Modelos.FrmModeloConsulta
    {
        public FrmConsultaVenda()
        {
            InitializeComponent();

        }


        public void CarregarDadosGrid()
        {
            try
            {
                BLL.Venda forn = new BLL.Venda();
                dataGridView1.DataSource = forn.ListarVendas(String.Empty).Tables[0];
                // textBox1.Focus();
                //a propriedade DATASOURCE do datagrid é a fonte de dados. Esta propriedade recebe (=) do objeto USU o método LISTAR usando como parametro o texto TEXT.TRIM().TOUPPER() digitado no TEXTBOX1. Esse DATASOURCE usará a tabela zero TABLES[0] do método LISTAR

                if (dataGridView1.Rows.Count == 0)
                {
                    btnAlterar.Enabled = false;
                    btnConsultar.Enabled = false;
                    btnAtivar.Enabled = false;
                    btnDesativar.Enabled = false;




                }
                else
                {
                    btnAlterar.Enabled = true;
                    btnConsultar.Enabled = true;
                    btnAtivar.Enabled = true;
                    btnDesativar.Enabled = true;

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }



        private void Exibir(Object o, EventArgs e)
        {
            CarregarDadosGrid();



        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Telas.Vender.FrmVender f = new FrmVender();
            f.button2.Visible = false;
            f.Text = "Consultando Venda";

            f.button1.Visible = false;

            f.lblProd.Visible = false;
            f.lblQuant.Visible = false;
            f.lblValor.Visible = false;
            f.label4.Visible = false;
            f.cbForma.Visible = false;
            f.cbProduto.Visible = false;
            f.txtQuantidade.Visible = false;
            f.txtValor.Visible = false;
            f.CarregarCombo(sender,e);
            f.lblCli.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
            f.lblVendedor.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);
            f.lblVendedor.Visible = true;
            f.lblCli.Visible = true;
            BLL.Venda v = new BLL.Venda();

            f.dataGridView1.Columns["CodProd"].Visible = false;
            f.dataGridView1.Columns["NomeProd"].Visible = false;
            f.dataGridView1.Columns["QuantProd"].Visible = false;
            f.dataGridView1.Columns["ValorTot"].Visible = false;


            f.dataGridView1.DataSource = v.ListarItensVenda(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value)).Tables[0];
            f.cbCliente.Visible = false;
            f.cbVendedor.Visible = false;
            f.lblFormaPagamento2.Visible = true;
            f.lblValorTotal.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[5].Value);
            f.lblFormapgto2.Text = "Cartão";
            f.lblFormapgto2.Visible = true;




            f.MostrarNumeroDeParcelas();
            f.ShowDialog();
            




        }
    }
}
