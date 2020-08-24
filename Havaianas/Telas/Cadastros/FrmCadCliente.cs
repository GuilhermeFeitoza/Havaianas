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
    public partial class FrmCadCliente : Modelos.FrmFormDeCadastro
    {
        public FrmCadCliente()
        {
            InitializeComponent();
        }
        public int Codigo;

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
       

     
        public void CadastrarCliente(object o, EventArgs e)
        {
            BLL.Cliente c = new BLL.Cliente();
            c.NomeCliente = txtNome.Text;
            if (rbMasc.Checked)
            {
                c.Sexo = 'M';

            }
            if (rbFem.Checked)
            {
                c.Sexo = 'F';
            }
            c.EmailCliente = txtEmail.Text;
            c.CpfCliente = txtCpf.Text;
            c.Telefone = txtTel.Text;
            c.DataNascimento = Convert.ToDateTime(txtData.Text);
            c.StatusCliente = 1;
            c.IncluirComParametro();
            MessageBox.Show("Cliente cadastrado");
            Close();





        }

        public void AlterarCliente(object o, EventArgs e)
        {
            BLL.Cliente c = new BLL.Cliente();
            c.NomeCliente = txtNome.Text;
            if (rbMasc.Checked)
            {
                c.Sexo = 'M';

            }
            if (rbFem.Checked)
            {
                c.Sexo = 'F';
            }
            c.EmailCliente = txtEmail.Text;
            c.CpfCliente = txtCpf.Text;
            c.Telefone = txtTel.Text;
            c.DataNascimento = Convert.ToDateTime(txtData.Text);
            c.StatusCliente = 1;
            c.CodigoCliente = Codigo;
            c.AlterarComParametro();
            MessageBox.Show("Cliente alterado");






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













    }
}
