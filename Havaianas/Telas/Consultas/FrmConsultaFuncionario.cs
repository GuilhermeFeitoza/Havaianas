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
    public partial class FrmConsultaFuncionario : Modelos.FrmModeloConsulta
    {
        public FrmConsultaFuncionario()
        {
            InitializeComponent();
        }


        public void CarregarDadosGrid()
        {
            try
            {
                BLL.Funcionario func = new BLL.Funcionario();
                dataGridView1.DataSource = func.Listar(textBox1.Text, 1).Tables[0];
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
            Telas.Cadastros.FrmCadFuncionario fcu = new Cadastros.FrmCadFuncionario();
            fcu.Text = "Detalhando o funcionário";
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
            fcu.txtData.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[5].Value);
            fcu.txtCep.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[8].Value);
            fcu.BuscarEndereco(sender, e);
            fcu.txtNum.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[11].Value);
            fcu.txtComplemento.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[12].Value);







            fcu.checkAtivo.Visible = false;
            fcu.checkVendedor.Visible = false;
            fcu.button1.Visible = false;
            fcu.txtNome.ReadOnly = true;
            fcu.txtData.ReadOnly = true;
            fcu.txtEnd.ReadOnly = true;
            fcu.txtBairro.ReadOnly = true;
            fcu.txtCidade.ReadOnly = true;
            fcu.txtComplemento.ReadOnly = true;
            fcu.txtUF.ReadOnly = true;
            fcu.txtCpf.ReadOnly = true;
          //  fcu.txtTel.ReadOnly = true;
            fcu.txtEmail.ReadOnly = true;
            fcu.txtCep.ReadOnly = true;
            fcu.txtNum.ReadOnly = true;


            fcu.ShowDialog();

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Telas.Cadastros.FrmCadFuncionario fcu = new Cadastros.FrmCadFuncionario();
            fcu.Text = "Alterando o funcionario";
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
            fcu.txtData.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[5].Value);
            fcu.txtCep.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[8].Value);
            fcu.BuscarEndereco(sender, e);
            fcu.txtNum.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[11].Value);
            fcu.txtComplemento.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[12].Value);

            fcu.button1.Text = "Alterar";
            fcu.button1.Click -= fcu.CadastrarFuncionario;
            fcu.button1.Click += fcu.AlterarFuncionario;
            fcu.checkAtivo.Visible = false;
            fcu.checkVendedor.Visible = false;
            fcu.ShowDialog();

        }

        private void Fixar(Object o, EventArgs e)
        {
            try
            {
                //o é objeto que foi clicado
                var b = (Button)o;
                //variávl 'b' é o botão 'o'
                if (MessageBox.Show("Deseja " + b.Text + " o funcionário ?", "Atencao", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2) == DialogResult.No) return;
                BLL.Funcionario fuc = new BLL.Funcionario();
                fuc.CodigoFunc = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                //propriedade '.codigo' do objeto 'usu' recebe '=' o valor 'value' da primeira coluna 'cells[0]' da linha atual 'currentrow' do grid 'datagridview1'
                switch (b.Text)
                {
                    case "Excluir": fuc.Excluir(); break;
                    case "Ativar": fuc.Ativar(); break;
                    case "Desativar": fuc.Desativar(); break;

                }
                MessageBox.Show("Sucesso em " + b.Text + "o funcionário", "Sucesso");
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
