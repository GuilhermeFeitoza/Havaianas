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
    public partial class FrmCadFornecedor : Modelos.FrmFormDeCadastro
    {
        public FrmCadFornecedor()
        {
            InitializeComponent();
        }


        private void ChecarEmail(object o, EventArgs e)
        {


            if (!BLL.FuncoesGerais.ValidarEmailRegEx(txtEmail.Text))
            {
                MessageBox.Show("Email Invalido!!!");
                txtEmail.Clear();
                txtEmail.Focus();
            }








        }
        public void CadastrarFornecedor(object o, EventArgs e)
        {
            BLL.Fornecedor f = new BLL.Fornecedor();
            f.NomeFantasia = txtFantasia.Text;
            f.CNPJ = txtCnpj.Text;
            f.RazaoSocial = txtRazao.Text;
            f.Email = txtEmail.Text;
            f.Tel = txtTel.Text;
            f.CEP = txtCep.Text;
            f.Complemento = txtComplemento.Text;
            f.Numero = Convert.ToInt32(txtNumero.Text);
            f.StatusFornecedor = 1;
            f.IncluirComParametro();
            MessageBox.Show("Fornecedor cadastrado com sucesso !!");

            DialogResult dr = MessageBox.Show("Deseja Cadastrar outro Fornecedor ?", "Fornecedor", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                txtFantasia.Clear();
                txtEndereco.Clear();
                txtBairro.Clear();
                txtCidade.Clear();
                txtEmail.Clear();
                txtTel.Clear();
                txtComplemento.Clear();
                txtCnpj.Clear();
                txtRazao.Clear();
                txtCep.Clear();
                txtNumero.Clear();
                cbUF.SelectedText = "";
                txtFantasia.Focus();

                //Limpar text e colocar foco no txt nome
            }
    
        }


        private void BuscarEndereco(Object o, EventArgs e)
        {

            BLL.CEP Correios = new BLL.CEP();
            try
            {
                if (txtCep.Text.Length == 0)
                {
                    MessageBox.Show("Por favor digite o cep");
                    return;
                }
                Correios.NumeroCep = txtCep.Text;
                System.Data.SqlClient.SqlDataReader ddr;
                ddr = Correios.ConsultarCEP();
                ddr.Read();
                if (ddr.HasRows)
                {
                    txtEndereco.Text = Convert.ToString(ddr["Logradouro"]);
                    txtBairro.Text = Convert.ToString(ddr["Bairro"]);
                    txtCidade.Text = Convert.ToString(ddr["Cidade"]);
                    cbUF.Text = Convert.ToString(ddr["UF"]);

                }
                else
                {
                    MessageBox.Show("Cep incorreto");
                    txtCep.Clear();
                    txtCep.Focus();
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }
        public int Codigo;
        public void AlterarFornecedor(object o, EventArgs e)
        {
            BLL.Fornecedor f = new BLL.Fornecedor();
            f.NomeFantasia = txtFantasia.Text;
            f.CNPJ = txtCnpj.Text;
            f.RazaoSocial = txtRazao.Text;
            f.Email = txtEmail.Text;
            f.Tel = txtTel.Text;
            f.CEP = txtCep.Text;
            f.Complemento = txtComplemento.Text;
            f.Numero = Convert.ToInt32(txtNumero.Text);
            f.StatusFornecedor = 1;
            f.AlterarComParametro();
            f.CodigoFornecedor = Codigo;

            MessageBox.Show("Fornecedor alterado com sucesso !!");

           

        }




    }
}
