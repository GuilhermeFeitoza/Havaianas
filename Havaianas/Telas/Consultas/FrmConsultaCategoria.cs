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
    public partial class FrmConsultaCategoria : Modelos.FrmModeloConsulta
    {
        public FrmConsultaCategoria()
        {
            InitializeComponent();
        }

        public void CarregarDadosGrid()
        {
            try
            {
                BLL.Categoria cat = new BLL.Categoria();
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
            Cadastros.FrmCadCategoria f = new Cadastros.FrmCadCategoria();
            f.button1.Visible = false;


        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Cadastros.FrmCadCategoria f = new Cadastros.FrmCadCategoria();
            f.Text = "Alterar categoria";
            f.txtDesc.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
          
            f.button1.Text = "Alterar";
            f.button1.Click -= f.CadastrarCat;
            f.button1.Click += f.AlterarCat;
            f.Codigo =  Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            f.ShowDialog();
            
        }

        private void Fixar(Object o, EventArgs e)
        {
            try
            {
                //o é objeto que foi clicado
                var b = (Button)o;
                //variávl 'b' é o botão 'o'
                if (MessageBox.Show(b.Text, "Atencao", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2) == DialogResult.No) return;
                BLL.Categoria cat = new BLL.Categoria();
                cat.CodigoCategoria = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                //propriedade '.codigo' do objeto 'usu' recebe '=' o valor 'value' da primeira coluna 'cells[0]' da linha atual 'currentrow' do grid 'datagridview1'
                switch (b.Text)
                {
                    case "Excluir": cat.Excluir(); break;
                    case "Ativar": cat.Ativar(1); break;
                    case "Desativar": cat.Ativar(0); break;

                }
                String msg = "";
               
                if (b.Text == "Ativar")

                {
                    msg = "Categoria ativada com sucesso";
                }
                if (b.Text == "Desativar")

                {
                    msg = "Categoria desativado com sucesso";
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

