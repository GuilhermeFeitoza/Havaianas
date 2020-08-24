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
    public partial class FrmMenuConsultas : Form
    {
        public FrmMenuConsultas()
        {
            InitializeComponent();
        }

        private void FrmMenuConsultas_Load(object sender, EventArgs e)
        {

        }

        private void btnNivel_Click(object sender, EventArgs e)
        {
            Telas.Consultas.FrmConsultaNivel n = new Consultas.FrmConsultaNivel();
            n.ShowDialog();

        }

        private void btnFunc_Click(object sender, EventArgs e)
        {
            Telas.Consultas.FrmConsultaFuncionario n = new Consultas.FrmConsultaFuncionario();
            n.ShowDialog();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            Telas.Consultas.FrmConsultaUsuario n = new Consultas.FrmConsultaUsuario();
            n.ShowDialog();
        }

        private void btnVendedor_Click(object sender, EventArgs e)
        {
            Telas.Consultas.FrmConsultaFuncionario n = new Consultas.FrmConsultaFuncionario();
            n.ShowDialog();

        }

        private void btnCat_Click(object sender, EventArgs e)
        {
            Telas.Consultas.FrmConsultaCategoria n = new Consultas.FrmConsultaCategoria();
            n.ShowDialog();
        }

        private void btnForn_Click(object sender, EventArgs e)
        {
            Telas.Consultas.FrmConsultaFornecedor n = new Consultas.FrmConsultaFornecedor();
            n.ShowDialog();
        }

        private void btnCli_Click(object sender, EventArgs e)
        {
            Telas.Consultas.FrmConsultaCliente n = new Consultas.FrmConsultaCliente();
            n.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Telas.Consultas.FrmConsultaProduto n = new Consultas.FrmConsultaProduto();
            n.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Telas.Consultas.FrmConsultaCupom c = new Telas.Consultas.FrmConsultaCupom();
            c.ShowDialog();
        }
    }
}
