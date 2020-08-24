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
    public partial class FrmConsultaUsuario :Modelos.FrmModeloConsulta
    {
        public FrmConsultaUsuario()
        {
            InitializeComponent();
        }




        public void CarregarDadosGrid()
        {
            try
            {
                BLL.Usuario cat = new BLL.Usuario();
                dataGridView1.DataSource = cat.Listar(textBox1.Text,1).Tables[0];
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

        private void Fixar(Object o, EventArgs e)
        {
            try
            {
                //o é objeto que foi clicado
                var b = (Button)o;
                //variávl 'b' é o botão 'o'
                if (MessageBox.Show(b.Text, "Atencao", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2) == DialogResult.No) return;
                BLL.Usuario usu = new BLL.Usuario();
                usu.CodigoUsuario = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                //propriedade '.codigo' do objeto 'usu' recebe '=' o valor 'value' da primeira coluna 'cells[0]' da linha atual 'currentrow' do grid 'datagridview1'
                switch (b.Text)
                {
                    case "Excluir": usu.Excluir(); break;
                    case "Ativar": usu.Ativar(); break;
                    case "Desativar": usu.Desativar(); break;

                }
                MessageBox.Show(b.Text, "Sucesso");
                CarregarDadosGrid();



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
            Telas.Cadastros.FrmCadUsuario u = new Cadastros.FrmCadUsuario();
            u.Text = "Alterando Usuário";
            u.Codigo = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            u.txtUsuario.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
            u.txtSenha.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
            u.cbFunc.SelectedValue = -1;
            u.button1.Click -= u.CadUsu;
            u.button1.Click += u.AlterarUsu;
            u.button1.Text = "Alterar";
            u.ShowDialog();
        }
    }
}
