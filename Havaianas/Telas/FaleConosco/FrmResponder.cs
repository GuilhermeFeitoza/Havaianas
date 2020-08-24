using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Havaianas.Telas.FaleConosco
{
    public partial class FrmResponder : Form
    {
        public int CodigoMensagem;
        public FrmResponder()
        {
            InitializeComponent();
        }

        private void btnResponder_Click(object sender, EventArgs e)
        {
            BLL.FaleConosco fale = new BLL.FaleConosco();
            fale.CodigoMensagem = CodigoMensagem;
            fale.Resposta = txtResposta.Text;
            fale.StatusMensagem = 1;
            fale.Responder();
            MessageBox.Show("Mensagem respondida !!!");
            Close();
        }
    }
}
