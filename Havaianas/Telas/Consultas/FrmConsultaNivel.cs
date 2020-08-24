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
    public partial class FrmConsultaNivel : Modelos.FrmModeloConsulta
    {
        public FrmConsultaNivel()
        {
            InitializeComponent();
        }

        public void CarregarDadosGrid()
        {
            try
            {
                BLL.NivelAcesso cat = new BLL.NivelAcesso();
                dataGridView1.DataSource = cat.Listar(textBox1.Text, 1).Tables[0];
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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Telas.Cadastros.FrmCadNivelAcesso n = new Cadastros.FrmCadNivelAcesso();
            n.Text = "Alterando Nivel de acesso";
           n.Codigo  = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
           n.txtNomeNivelAcesso.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
           n.txtAbreviacao.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
           n.button1.Click -= n.CadastrarNivel;
           n.button1.Click += n.AlterarNivel;
            n.button1.Text = "Alterar";
            n.ShowDialog();
        }


        private void Fixar(Object o, EventArgs e)
        {
            try
            {
                //o é objeto que foi clicado
                var b = (Button)o;
                //variávl 'b' é o botão 'o'
                if (MessageBox.Show(b.Text, "Atencao", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2) == DialogResult.No) return;
                BLL.NivelAcesso forn = new BLL.NivelAcesso();
                forn.CodigoNivel = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
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
                    msg = "Nivel de acesso editado com sucesso";


                }
                if (b.Text == "Ativar")

                {
                    msg = "Nivel de acesso  ativado com sucesso";
                }
                if (b.Text == "Desativar")

                {
                    msg = "Nivel de acesso  desativado com sucesso";
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
