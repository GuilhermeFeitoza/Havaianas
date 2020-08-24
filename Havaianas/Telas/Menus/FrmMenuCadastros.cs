using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Havaianas.Telas.Menus
{
    public partial class FrmMenuCadastros : Form
    {
        public FrmMenuCadastros()
        {
            InitializeComponent();
        }

        private void FrmMenuCadastros_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Telas.Cadastros.FrmCadProduto n = new Cadastros.FrmCadProduto();
            n.ShowDialog();
        }

        private void btnForn_Click(object sender, EventArgs e)
        {
            Telas.Cadastros.FrmCadFornecedor n = new Cadastros.FrmCadFornecedor();
            n.ShowDialog();

        }

        private void btnCli_Click(object sender, EventArgs e)
        {
            Telas.Cadastros.FrmCadCliente n = new Cadastros.FrmCadCliente();
            n.ShowDialog();
        }

         private void btnCat_Click(object sender, EventArgs e)
        {
            Telas.Cadastros.FrmCadCategoria n = new Cadastros.FrmCadCategoria();
            n.ShowDialog();

        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            Telas.Cadastros.FrmCadUsuario n = new Cadastros.FrmCadUsuario();
            n.ShowDialog();
        }

        private void btnFunc_Click(object sender, EventArgs e)
        {
            Telas.Cadastros.FrmCadFuncionario n = new Cadastros.FrmCadFuncionario();
            n.ShowDialog();
        }

        private void btnNivel_Click(object sender, EventArgs e)
        {
            Telas.Cadastros.FrmCadNivelAcesso n = new Cadastros.FrmCadNivelAcesso();
            n.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cadastros.FrmCadastrarCupom c = new Cadastros.FrmCadastrarCupom();
            c.ShowDialog();
        }
    }
}
