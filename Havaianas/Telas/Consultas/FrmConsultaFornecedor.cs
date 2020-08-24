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
    public partial class FrmConsultaFornecedor : Modelos.FrmModeloConsulta
    {
        public FrmConsultaFornecedor()
        {
            InitializeComponent();
        }
        public void CarregarDadosGrid()
        {
            try
            {
                BLL.Fornecedor forn = new BLL.Fornecedor();
                dataGridView1.DataSource = forn.Listar(textBox1.Text, 1).Tables[0];
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
            Telas.Cadastros.FrmCadFornecedor fcu = new Cadastros.FrmCadFornecedor();
            fcu.Text = "Consultando o Fornecedor";
            fcu.txtFantasia.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
            fcu.txtRazao.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
            fcu.txtCnpj.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
            fcu.txtCep.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);
            fcu.txtComplemento.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[5].Value);
            fcu.txtNumero.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[6].Value);
            fcu.txtTel.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[7].Value);
            fcu.txtEmail.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[8].Value);
            fcu.button1.Visible = false;
            BLL.CEP Correios = new BLL.CEP();
            if (fcu.txtCep.Text.Length == 0)
            {
                MessageBox.Show("Por favor digite o cep");
                return;
            }
            Correios.NumeroCep = fcu.txtCep.Text;
            System.Data.SqlClient.SqlDataReader ddr;
            ddr = Correios.ConsultarCEP();
            ddr.Read();
            if (ddr.HasRows)
            {
                fcu.txtEndereco.Text = Convert.ToString(ddr["Logradouro"]);
                fcu.txtBairro.Text = Convert.ToString(ddr["Bairro"]);
                fcu.txtCidade.Text = Convert.ToString(ddr["Cidade"]);
                fcu.cbUF.Text = Convert.ToString(ddr["UF"]);

            }
            else
            {
                MessageBox.Show("Cep incorreto");
                fcu.txtCep.Clear();
                fcu.txtCep.Focus();
            }



            fcu.txtFantasia.ReadOnly = true;
            fcu.txtRazao.ReadOnly = true;
            fcu.txtCnpj.ReadOnly = true;
            fcu.txtCep.ReadOnly = true;
            fcu.txtComplemento.ReadOnly = true;
            fcu.txtNumero.ReadOnly = true;
            fcu.txtTel.ReadOnly = true;
            fcu.txtEmail.ReadOnly = true;
            fcu.txtBairro.ReadOnly = true;
            fcu.txtCidade.ReadOnly = true;
            fcu.txtEndereco.ReadOnly = true;
            fcu.cbUF.Enabled = false;
            fcu.button1.Visible = false;

            fcu.Text = "Consultando Fornecedor";




            fcu.ShowDialog();





        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Telas.Cadastros.FrmCadFornecedor fcu = new Cadastros.FrmCadFornecedor();
            fcu.Text = "Alterar o Fornecedor";
            fcu.txtFantasia.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
            fcu.txtRazao.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
            fcu.txtCnpj.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
            fcu.txtCep.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);
            fcu.txtComplemento.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[5].Value);
            fcu.txtNumero.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[6].Value);
            fcu.txtTel.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[7].Value);
            fcu.txtEmail.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[8].Value);
           
            BLL.CEP Correios = new BLL.CEP();
            if (fcu.txtCep.Text.Length == 0)
            {
                MessageBox.Show("Por favor digite o cep");
                return;
            }
            Correios.NumeroCep = fcu.txtCep.Text;
            System.Data.SqlClient.SqlDataReader ddr;
            ddr = Correios.ConsultarCEP();
            ddr.Read();
            if (ddr.HasRows)
            {
                fcu.txtEndereco.Text = Convert.ToString(ddr["Logradouro"]);
                fcu.txtBairro.Text = Convert.ToString(ddr["Bairro"]);
                fcu.txtCidade.Text = Convert.ToString(ddr["Cidade"]);
                fcu.cbUF.Text = Convert.ToString(ddr["UF"]);

            }
            else
            {
                MessageBox.Show("Cep incorreto");
                fcu.txtCep.Clear();
                fcu.txtCep.Focus();
            }
            fcu.button1.Click -= fcu.CadastrarFornecedor;
            fcu.button1.Click += fcu.AlterarFornecedor;
            fcu.button1.Text = "Alterar";
            fcu.ShowDialog();



        }

        private void Fixar(Object o, EventArgs e)
        {
            try
            {
                //o é objeto que foi clicado
                var b = (Button)o;
                //variávl 'b' é o botão 'o'
                if (MessageBox.Show(b.Text, "Atencao", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2) == DialogResult.No) return;
                BLL.Fornecedor forn = new BLL.Fornecedor();
                forn.CodigoFornecedor = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                //propriedade '.codigo' do objeto 'usu' recebe '=' o valor 'value' da primeira coluna 'cells[0]' da linha atual 'currentrow' do grid 'datagridview1'
                switch (b.Text)
                {
                    case "Excluir": forn.Excluir(); break;
                    case "Ativar": forn.Ativar(); break;
                    case "Desativar": forn.Desativar(); break;

                }
                String msg = "";
                if (b.Text == "Editar")
                {
                    msg = "Fornecedor editado com sucesso";


                }
                if (b.Text == "Ativar")

                {
                    msg = "Fornecedor ativado com sucesso";
                }
                if (b.Text == "Desativar")

                {
                    msg = "Fornecedor desativado com sucesso";
                }
                MessageBox.Show(msg, "Sucesso");
                CarregarDadosGrid();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }





    }
}
