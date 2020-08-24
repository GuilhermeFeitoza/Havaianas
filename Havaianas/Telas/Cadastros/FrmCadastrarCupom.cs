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
    public partial class FrmCadastrarCupom : Modelos.FrmFormDeCadastro
    {
        public FrmCadastrarCupom()
        {
            InitializeComponent();
        }
        public int Codigo;
        public void CadastrarCupom(object o,EventArgs e)
        {
            BLL.Cupom c = new BLL.Cupom();
            c.CodigoCupom = txtCodigoCupom.Text;
            c.DataInicio = Convert.ToDateTime(txtDatainicio.Text);
            c.DataFim = Convert.ToDateTime(txtDataFim.Text);
            c.Valor = Convert.ToDecimal(textBox1.Text);
            c.StatusCupom = 1;
            c.Quantidade = Convert.ToInt16(nmrQuant.Value);
            c.IncluirComParametro();
            MessageBox.Show("Cupom cadastrado com sucesso valido de :"+txtDatainicio.Text + " até "+txtDataFim.Text+".");

            




        }
        public void AlterarCupom(object o, EventArgs e)
        {
            BLL.Cupom c = new BLL.Cupom();
            c.CodigoCupom = txtCodigoCupom.Text;
            c.DataInicio = Convert.ToDateTime(txtDatainicio.Text);
            c.DataFim = Convert.ToDateTime(txtDataFim.Text);
            c.Valor = Convert.ToDecimal(textBox1.Text);
            c.StatusCupom = 1;
            c.Quantidade = Convert.ToInt16(nmrQuant.Value);
            c.AlterarComParametro();
            MessageBox.Show("Cupom alterado com sucesso valido de :" + txtDatainicio.Text + " até " + txtDataFim.Text + ".");






        }
        private void FrmCadastrarCupom_Load(object sender, EventArgs e)
        {

        }
    }
}
