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
    public partial class FrmConsultaCliente : Modelos.FrmModeloConsulta
    {
        public FrmConsultaCliente()
        {
            InitializeComponent();
        }



        private void Fixar(Object o, EventArgs e)
        {
            try
            {
                //o é objeto que foi clicado
                var b = (Button)o;
                //variávl 'b' é o botão 'o'
                if (MessageBox.Show(b.Text, "Atencao", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2) == DialogResult.No) return;
                BLL.Cliente cat = new BLL.Cliente();
                cat.CodigoCliente = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                //propriedade '.codigo' do objeto 'usu' recebe '=' o valor 'value' da primeira coluna 'cells[0]' da linha atual 'currentrow' do grid 'datagridview1'
                switch (b.Text)
                {
                    case "Excluir": cat.Excluir(); break;
                    case "Ativar": cat.Ativar(); break;
                    case "Desativar": cat.Desativar(); break;

                }
                String msg = "";

                if (b.Text == "Ativar")

                {
                    msg = " ativado com sucesso";
                }
                if (b.Text == "Desativar")

                {
                    msg = " desativado com sucesso";
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




        public void CarregarDadosGrid()
        {
            try
            {
                BLL.Cliente cli = new BLL.Cliente();
                dataGridView1.DataSource = cli.Listar(textBox1.Text, 1).Tables[0];
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

        public void ExibirAtivos()
        {
            try
            {
                BLL.Cliente cli = new BLL.Cliente();
                dataGridView1.DataSource = cli.ListarAtivos().Tables[0];
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
        public void ExibirInativos()
        {
            try
            {
                BLL.Cliente cli = new BLL.Cliente();
                dataGridView1.DataSource = cli.ListarInativos().Tables[0];
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
            Telas.Cadastros.FrmCadCliente fcu = new Cadastros.FrmCadCliente();   
            fcu.Text = "Detalhando o Cliente";
            fcu.txtNome.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
            if (Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value) == "f")
            {
                fcu.rbFem.Checked = true;
                fcu.rbFem.Enabled = false;
                fcu.rbMasc.Enabled = false;
            }
            else
            {
                fcu.rbMasc.Checked = true;
                fcu.rbMasc.Enabled = false;
                fcu.rbFem.Enabled = false;

            }
            fcu.txtEmail.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
            fcu.txtCpf.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);
            fcu.txtTel.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[5].Value);
            fcu.txtData.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[6].Value);
           

          
            
           
           
            
         

            fcu.button1.Visible = false;
            fcu.txtNome.ReadOnly = true;
            fcu.txtData.ReadOnly = true;
           
            fcu.txtCpf.ReadOnly = true;
            fcu.txtTel.ReadOnly = true;
            fcu.txtEmail.ReadOnly = true;
     
         
            
            fcu.ShowDialog();

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

            Telas.Cadastros.FrmCadCliente fcu = new Cadastros.FrmCadCliente();
            fcu.Text = "Alterando o Cliente";
            fcu.button1.Text = "Alterar";
            fcu.Codigo = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            fcu.txtNome.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
            if (Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value) == "f")
            {
                fcu.rbFem.Checked = true;
                fcu.rbFem.Enabled = false;
                fcu.rbMasc.Enabled = false;
            }
            else
            {
                fcu.rbMasc.Checked = true;
                fcu.rbMasc.Enabled = false;
                fcu.rbFem.Enabled = false;

            }
            fcu.txtEmail.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
            fcu.txtCpf.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);
            fcu.txtTel.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[5].Value);
            fcu.txtData.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[6].Value);
           
            
            fcu.button1.Click -= fcu.CadastrarCliente;
            fcu.button1.Click += fcu.AlterarCliente;
                                

            fcu.ShowDialog();
        }
    }
}
