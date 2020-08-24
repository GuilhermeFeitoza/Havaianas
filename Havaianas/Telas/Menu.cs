using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data;
namespace Havaianas.Telas
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            //AbrirHome();
      
        }

        private void AbrirHome() {

            AbrirFormInPanel(new Telas.Menus.FrmMenuPrincipal());


        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void AbrirFormInPanel(object Formhijo)
        {
            if (this.pnConteudo.Controls.Count > 0)
                this.pnConteudo.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnConteudo.Controls.Add(fh);
            this.pnConteudo.Tag = fh;
            fh.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Telas.Menus.FrmMenuCadastros());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Telas.Menus.FrmMenuConsultas());

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Telas.Menus.FrmMenuContasApagar());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Telas.Menus.FrmMenuVenda());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Telas.Menus.FrmEstoque());

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Telas.Menus.FrmMenuPrincipal());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Telas.FaleConosco.FrmFaleConosco f = new FaleConosco.FrmFaleConosco();
            f.ShowDialog();
        }
    }
    }

