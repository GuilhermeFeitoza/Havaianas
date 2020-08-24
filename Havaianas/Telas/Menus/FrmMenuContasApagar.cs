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
    public partial class FrmMenuContasApagar : Form
    {
        public FrmMenuContasApagar()
        {
            InitializeComponent();
        }

        private void btnFunc_Click(object sender, EventArgs e)
        {
            Telas.Contas.FrmContasApagar c = new Contas.FrmContasApagar();
            c.ShowDialog();
        }

        private void btnNova_Click(object sender, EventArgs e)
        {
            Telas.Cadastros.FrmCadLancamento l = new Cadastros.FrmCadLancamento();
            l.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Telas.Cadastros.FrmCadTitulo t = new Cadastros.FrmCadTitulo();
            t.ShowDialog();
        }
    }
}
