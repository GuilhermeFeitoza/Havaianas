using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Havaianas.Telas.Consultas
{
    public partial class FrmConsultaProduto : Modelos.FrmModeloConsulta
    {
        public FrmConsultaProduto()
        {
            InitializeComponent();
        }


        public void CarregarDadosGrid()
        {
            try
            {
                BLL.Produto cat = new BLL.Produto();
                dataGridView1.DataSource = cat.Listar(textBox1.Text).Tables[0];
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
            if (o == btnFiltrar)
            {
                textBox1.Text = String.Empty;
            }
            textBox1.Focus();



        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
          
            try
            {
                Telas.Cadastros.FrmCadProduto p = new Cadastros.FrmCadProduto();
              
                p.txtNomeProduto.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
                p.txtPreco.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);
                p.imagem = Convert.ToString(dataGridView1.CurrentRow.Cells[5].Value);
                p.pbFoto.ImageLocation = p.imagem;
                p.pbFoto.Click -= p.SalvarFoto;
                p.comboBox1.SelectedText = Convert.ToString(dataGridView1.CurrentRow.Cells[6].Value);
                p.button1.Visible = true;
                p.Text = "Consultando Produto";
                p.button1.Visible = false;
                p.ShowDialog();






            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                throw ex;
            }


        }

        
        private void Fixar(Object o, EventArgs e)
        {
            try
            {
                //o é objeto que foi clicado
                var b = (Button)o;
                //variávl 'b' é o botão 'o'
                if (MessageBox.Show("Deseja " + b.Text + " o produto ?", "Atencao", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2) == DialogResult.No) return;
                BLL.Produto prod = new BLL.Produto();
                prod.CodigoProduto = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                //propriedade '.codigo' do objeto 'usu' recebe '=' o valor 'value' da primeira coluna 'cells[0]' da linha atual 'currentrow' do grid 'datagridview1'
                switch (b.Text)
                {
                    case "Excluir": prod.Excluir(); break;
                    case "Ativar": prod.Ativar(); break;
                    case "Desativar": prod.Desativar(); break;

                }
                MessageBox.Show("Sucesso em  " + b.Text + " o produto", "Sucesso");
                CarregarDadosGrid();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

            try
            {
                Telas.Cadastros.FrmCadProduto p = new Cadastros.FrmCadProduto();
                p.Codigo = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                p.txtNomeProduto.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
                p.txtPreco.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[7].Value);
                p.imagem = Convert.ToString(dataGridView1.CurrentRow.Cells[8].Value);
                p.pbFoto.ImageLocation = p.imagem;
                p.comboBox1.SelectedText = Convert.ToString(dataGridView1.CurrentRow.Cells[9].Value);
                p.button1.Visible = true;
             
                p.Text = "alterando Produto";
                p.button1.Click -= p.CadastrarProduto;
                p.button1.Click += p.AlterarProduto;
                p.button1.Text = "Alterar";
                p.ShowDialog();
                                            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                throw ex;
            }



        }
    }
}
