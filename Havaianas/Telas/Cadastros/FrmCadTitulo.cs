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
    public partial class FrmCadTitulo : Modelos.FrmFormDeCadastro
    {
        public FrmCadTitulo()
        {
            InitializeComponent();
        }

        private void CadastrarTitulo(object o, EventArgs e) {
            BLL.Titulo t = new BLL.Titulo();
            t.DescricaoTitulo = txtDesc.Text;
            t.StatusTitulo = 1;
            t.Incluir();
            MessageBox.Show("Titulo cadastrado");




        }
    }
}
