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
    public partial class FrmMenuVenda : Form
    {
        public FrmMenuVenda()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Telas.Vender.FrmVender v = new Vender.FrmVender();
            v.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Telas.Vender.FrmConsultaVenda v = new Vender.FrmConsultaVenda();
            v.ShowDialog();
        }
    }
}
