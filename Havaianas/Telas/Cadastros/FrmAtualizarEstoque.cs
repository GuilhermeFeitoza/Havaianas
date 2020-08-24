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
    public partial class FrmAtualizarEstoque : Modelos.FrmFormDeCadastro
    {
        public FrmAtualizarEstoque()
        {
            InitializeComponent();
        }

        public int Codigo;

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            BLL.Estoque f = new BLL.Estoque();
            f.QuantidadeAtual = Convert.ToInt32(numericUpDown1.Value);
            f.CodigoProduto = Codigo;
            f.AtualizarEstoque();
            MessageBox.Show("Estoque atualizado");
            Close();
        }






    }
}
