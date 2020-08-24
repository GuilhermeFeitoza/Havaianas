using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Havaianas.Telas.Cadastros
{
    public partial class FrmCadLancamento : Modelos.FrmFormDeCadastro
    {
        public FrmCadLancamento()
        {
            InitializeComponent();
        }
        private void Checardata(object o, EventArgs e)
        {


            //Validação da data 
            if (!BLL.FuncoesGerais.IsDataValida(txtData.Text))
            {
                MessageBox.Show("Data invalida");
                txtData.Clear();
                txtData.Focus();
                return;
            }



        }


        private void ValidaNumero(object o, EventArgs e) {

            if (!BLL.FuncoesGerais.IsNumeric(txtValor.Text))
            {
                MessageBox.Show("Digite um valor numerico");
                txtValor.Clear();
                txtValor.Focus();
                return;
            }
            



        }
        private void CarregarCombo(object o, EventArgs e)
        {

            BLL.Titulo c = new BLL.Titulo();
            cbTitulo.DataSource = c.Listar(String.Empty,1).Tables[0];
            cbTitulo.DisplayMember = "DescricaoTitulo";
            cbTitulo.ValueMember = "CodigoTitulo";

            BLL.Usuario u = new BLL.Usuario();
            comboBox1.DataSource = u.Listar(String.Empty, 1).Tables[0];
            comboBox1.DisplayMember = "NomeUsuario";
            comboBox1.ValueMember = "CodigoUsuario";




        }

        private void CadastrarLancamento(object sender, EventArgs e)
        {
            BLL.Lancamento l = new BLL.Lancamento();
            l.CodigoTitulo = Convert.ToInt32(cbTitulo.SelectedValue);
            l.CodigoUsuario = Convert.ToInt32(comboBox1.SelectedValue);
            l.ValorTitulo = Convert.ToDouble(txtValor.Text);
            l.DataVencimento = Convert.ToDateTime(txtData.Text);
            l.Incluir();
            MessageBox.Show("Lançamento efetuado com sucesso");
        }
    }
}
