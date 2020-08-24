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
    public partial class FrmCadCategoria : Modelos.FrmFormDeCadastro
    {
        public FrmCadCategoria()
        {
            InitializeComponent();
        }
        public int Codigo;
        public void CadastrarCat(object o, EventArgs e) {
            BLL.Categoria c = new BLL.Categoria();
            c.Descricao = txtDesc.Text.ToUpper();
            c.StatusCategoria = 1;


            c.IncluirComParametro();
            MessageBox.Show("Cadastrado com sucesso!!");

        }


        public void AlterarCat(object o, EventArgs e)
        {
            BLL.Categoria c = new BLL.Categoria();
            c.Descricao = txtDesc.Text.ToUpper();
            c.CodigoCategoria = Codigo;

            c.AlterarComParametro();
            MessageBox.Show("Alterado com sucesso!!");
            Telas.Consultas.FrmConsultaCategoria f = new Consultas.FrmConsultaCategoria();
            f.ShowDialog();

        }
    }
}
