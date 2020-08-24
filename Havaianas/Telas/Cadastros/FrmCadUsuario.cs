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
    public partial class FrmCadUsuario : Modelos.FrmFormDeCadastro
    {
        public FrmCadUsuario()
        {
            InitializeComponent();
        }
        public int Codigo;
        public void CadUsu(object o, EventArgs e) {
            BLL.Usuario usu = new BLL.Usuario();
            usu.CodigoFunc = Convert.ToInt16(cbFunc.SelectedValue);
            usu.NomeUsuario = txtUsuario.Text;
            usu.SenhaUsuario = txtSenha.Text;
            usu.StatusUsuario = 1;
            usu.IncluirComParametro();
            MessageBox.Show("Usuario Cadastrado");


        }
        private void CarregarCombo(object o, EventArgs e)
        {

            BLL.Vendedor c = new BLL.Vendedor();
            cbFunc.DataSource = c.Listar(String.Empty, (byte)BLL.FuncoesGerais.TipoStatus.Ativo).Tables[0];
            cbFunc.DisplayMember = "NomeVendedor";
            cbFunc.ValueMember = "CodigoVendedor";




        }


        public void AlterarUsu(object o , EventArgs e) {

            BLL.Usuario usu = new BLL.Usuario();
            usu.CodigoFunc = Convert.ToInt16(cbFunc.SelectedValue);
            usu.NomeUsuario = txtUsuario.Text;
            usu.SenhaUsuario = txtSenha.Text;
            usu.CodigoUsuario = Codigo;
            usu.StatusUsuario = 1;
            usu.AlterarComParametro();
            MessageBox.Show("Alterado");
            this.Close();

        }
    }
}
