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
    public partial class FrmFaleConosco : Form
    {
        public FrmFaleConosco()
        {
            InitializeComponent();
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        public int CodigoMensagem;
        private void ExibirMensagens()
        {
         
            BLL.FaleConosco fale = new BLL.FaleConosco();
            dataGridView1.DataSource = fale.ListarMensagens(textBox1.Text).Tables[0];
            if (Convert.ToInt16(dataGridView1.CurrentRow.Cells[5].Value) == 0)
            {
                btnResponder.Visible = true;
            }
            if (Convert.ToInt16(dataGridView1.CurrentRow.Cells[5].Value) == 1)
            {
                btnResponder.Visible = false;
            }


            if (dataGridView1.Rows.Count > 1)
            {
            CodigoMensagem = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            lblNome.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
            lblEmail.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
            lblAssunto.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
            txtMsg.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);
            lblData.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[6].Value);
            }






        }
        private void CarregarDados(object o, EventArgs e) {
            ExibirMensagens();
            if (o == btnFiltrar)
            {
                textBox1.Text = String.Empty;
            }
            textBox1.Focus();



        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Convert.ToInt16(dataGridView1.CurrentRow.Cells[5].Value)==0)
            {
                btnResponder.Visible = true;
            }
            if (Convert.ToInt16(dataGridView1.CurrentRow.Cells[5].Value) == 1)
            {
                btnResponder.Visible = false;
            }
            CodigoMensagem = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            lblNome.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
            lblEmail.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
            lblAssunto.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
            txtMsg.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);

            lblData.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[6].Value);

        }

        private void btnResponder_Click(object sender, EventArgs e)
        {
            FrmResponder f = new FrmResponder();
            f.CodigoMensagem = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            f.lblNome.Text= Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
            f.lblEmail.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
            f.lblAssunto.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
            f.txtMsg.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);
            f.lblData.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[6].Value);
            f.ShowDialog();
            ExibirMensagens();
        }
    }
}
