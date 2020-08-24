using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Havaianas.Telas
{
    public partial class FrmSplahScreen : Form
    {
        public FrmSplahScreen()
        {
            InitializeComponent();  
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (bunifuCircleProgressbar1.Value <100)
            {
                bunifuCircleProgressbar1.Value += 2;
            }
            else
            {
                timer1.Enabled = false;
                Telas.FrmLogin2 l = new FrmLogin2();
                l.ShowDialog();
                this.Close();
            }
        }
    }
}
