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
    public partial class FrmCadNivelAcesso : Modelos.FrmFormDeCadastro
    {
        public FrmCadNivelAcesso()
        {
            InitializeComponent();
        }
        public int Codigo;
        public void CadastrarNivel(object o ,EventArgs e) {
            BLL.NivelAcesso n = new BLL.NivelAcesso();
            n.NomeNivel = txtNomeNivelAcesso.Text.ToUpper();
            n.AbreviacaoNivel = txtAbreviacao.Text.ToUpper();
            n.StatusNivel = 1;
            n.IncluirComParametro();
            MessageBox.Show("Cadastrado com sucesso");


        }

        public void AlterarNivel(object o, EventArgs e)
        {
            BLL.NivelAcesso n = new BLL.NivelAcesso();
            n.NomeNivel = txtNomeNivelAcesso.Text.ToUpper();
            n.AbreviacaoNivel = txtAbreviacao.Text.ToUpper();


            n.StatusNivel = 1;
            n.CodigoNivel = Codigo;
            n.AlterarComParametro();
            MessageBox.Show("Alterado com sucesso");


        }






    }
}
