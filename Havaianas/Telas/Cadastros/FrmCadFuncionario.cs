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
    public partial class FrmCadFuncionario : Modelos.FrmFormDeCadastro
    {
        public FrmCadFuncionario()
        {
            InitializeComponent();
        }
        public int Codigo;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        public void BuscarEndereco(Object o, EventArgs e)
        {
            try
            {
                if (txtCep.Text.Length == 0)
                {
                    MessageBox.Show("Por favor digite o cep");
                    return;
                }
                BLL.CEP Correios = new BLL.CEP();
                Correios.NumeroCep = txtCep.Text;
                System.Data.SqlClient.SqlDataReader ddr;
                ddr = Correios.ConsultarCEP();
                ddr.Read();
                if (ddr.HasRows)
                {
                    txtEnd.Text = Convert.ToString(ddr["Logradouro"]);
                    txtBairro.Text = Convert.ToString(ddr["Bairro"]);
                    txtCidade.Text = Convert.ToString(ddr["Cidade"]);
                    txtUF.Text = Convert.ToString(ddr["UF"]);

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
        public void CadastrarFuncionario(object o, EventArgs e)
        {
            BLL.Funcionario func = new BLL.Funcionario();
            func.NomeFuncionario = txtNome.Text;
            if (rbMasc.Checked)
            {
                func.Sexo = "M";

            }
            if (rbFem.Checked)
            {
                func.Sexo = "F";
            }
            func.EmailFuncionario = txtEmail.Text;
            func.CpfFuncionario = txtCpf.Text;
            
            func.NascimentoFuncionario = Convert.ToDateTime(txtData.Text);
            func.Cep = txtCep.Text;
            func.Logradouro = txtEnd.Text;
            func.Bairro = txtBairro.Text;
            func.Cidade = txtCidade.Text;
            func.UF = "SP";
            func.Numero = txtNum.Text;
            func.Complemento = txtComplemento.Text;
            func.StatusFuncionario = 1;

            if (checkVendedor.Checked)
            {
                func.IncluirComParametro();
                BLL.Vendedor v = new BLL.Vendedor();
                v.NomeVendedor = txtNome.Text;
                v.StatusVendedor = 1;
                v.CodigoFuncionario = func.RetornarFuncionario();
                v.IncluirComParametro();
                MessageBox.Show("Funcionário cadastrado como vendedor!!");    
            }
            else
            {
                func.IncluirComParametro();
                MessageBox.Show("Funcionario cadastrado");
            }
           
                       
        }

        public void AlterarFuncionario(object o, EventArgs e)
        {
            BLL.Funcionario c = new BLL.Funcionario();
            c.NomeFuncionario = txtNome.Text;
            if (rbMasc.Checked)
            {
                c.Sexo = "M";

            }
            if (rbFem.Checked)
            {
                c.Sexo = "F";
            }
            c.EmailFuncionario = txtEmail.Text;
            c.CpfFuncionario = txtCpf.Text;

            c.NascimentoFuncionario = Convert.ToDateTime(txtData.Text);
            c.Cep = txtCep.Text;
            c.Logradouro = txtEnd.Text;
            c.Bairro = txtBairro.Text;
            c.Cidade = txtCidade.Text;
            c.UF = "SP";
            c.Numero = txtNum.Text;
            c.Complemento = txtComplemento.Text;
            c.StatusFuncionario = 1;
            c.CodigoFunc = Codigo;
            c.AlterarComParametro();
            MessageBox.Show("Alterado com sucesso");

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
        private void ChecarCPF(object o, EventArgs e)
        {




            if (!BLL.FuncoesGerais.IsCpf(txtCpf.Text))
            {
                MessageBox.Show("CPF invalido");
                txtCpf.Clear();
                txtCpf.Focus();

            }





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

        private void rbMasc_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
