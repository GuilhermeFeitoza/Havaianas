using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Havaianas.Telas
{
    public partial class FrmLogin2 : Form
    {
        public FrmLogin2()
        {
            InitializeComponent();
        }

        private void Sair(Object o, EventArgs e)
        {
            Application.Exit();
        }


        DAO.ClasseParaManipularBancoDeDados c = new DAO.ClasseParaManipularBancoDeDados();

        private void Confirmar(Object o, EventArgs e)
        {



            try
            {

                if (VerificarDigitacao() == false)
                {
                    return;
                }



                BLL.Usuario usu = new BLL.Usuario();
                usu.NomeUsuario = txtNome.Text;
                usu.SenhaUsuario = txtSenha.Text;
                if (usu.Logar() != 0)
                {

                    // MessageBox.Show("Seja bem-vindo !!!");


                    // f.NivelAcesso = usu.CodigoNivelAcesso;


                    // f.NivelAcesso = 0;
                    Telas.Menu m = new Telas.Menu();
                    //m.lblUsuarioLogado.Text = txtNome.Text;
                    //m.lblNivel.Text = Convert.ToString(usu.CodigoNivelAcesso);
                    //m.CodigoUsuario = usu.CodigoUsuario;

                    /*pega o valor da classe session que é uma classe 
                    que mantem um valor armazenado durante toda a execução do programa podendo ser usado em outros forms */
                    m.lblUsu.Text = txtNome.Text;
                    m.ShowDialog();
                    Close();


                }
                else
                {
                    MessageBox.Show("Erro Usuário/Senha");
                    txtSenha.Clear();
                    txtNome.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }


        }


        private bool VerificarDigitacao()
        {
            bool Situacao = true;

            if (txtNome.Text.Trim().Length == 0)
            {
                erro.SetError(txtNome, "Digite um nome");
                Situacao = false;
            }
            else
            {
                erro.SetError(txtNome, "");

            }

            if (txtSenha.Text.Trim().Length == 0)
            {
                erro.SetError(txtSenha, "Digite uma senha");
                Situacao = false;
            }
            else
            {
                erro.SetError(txtSenha, "");

            }


            return Situacao;
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }










    }
}
