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
    public partial class FrmConsultaCupom : Modelos.FrmModeloConsulta
    {
        public FrmConsultaCupom()
        {
            InitializeComponent();
        }


        public void CarregarDadosGrid()
        {
            try
            {
                BLL.Cupom cli = new BLL.Cupom();
                dataGridView1.DataSource = cli.Listar().Tables[0];
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
                BLL.Cupom c = new BLL.Cupom();
                dataGridView1.DataSource = c.ListarAtivos().Tables[0];
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
                BLL.Cupom cli = new BLL.Cupom();
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

        private void Fixar(Object o, EventArgs e)
        {
            try
            {
                //o é objeto que foi clicado
                var b = (Button)o;
                //variávl 'b' é o botão 'o'
                if (MessageBox.Show(b.Text, "Atencao", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2) == DialogResult.No) return;
                BLL.Cupom cat = new BLL.Cupom();
                cat.Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                //propriedade '.codigo' do objeto 'usu' recebe '=' o valor 'value' da primeira coluna 'cells[0]' da linha atual 'currentrow' do grid 'datagridview1'
                switch (b.Text)
                {

                    case "Ativar": cat.Ativar(); break;
                    case "Desativar": cat.Desativar(); break;

                }
                String msg = "";

                if (b.Text == "Ativar")

                {
                    msg = "Cupom ativado com sucesso";
                }
                if (b.Text == "Desativar")

                {
                    msg = "Cupom desativado com sucesso";
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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Cadastros.FrmCadastrarCupom c = new Cadastros.FrmCadastrarCupom();
            c.Codigo = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            c.txtCodigoCupom.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
            c.txtDatainicio.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value) ;
            c.txtDataFim.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value) ;
            c.textBox1.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);
            c.Text = "Alterar cupom";
            c.button1.Text = "Alterar";
            c.button1.Click -= c.CadastrarCupom;
            c.button1.Click += c.AlterarCupom;
            c.ShowDialog();


                }
    }
}
