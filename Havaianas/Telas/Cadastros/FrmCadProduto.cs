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
    public partial class FrmCadProduto : Modelos.FrmFormDeCadastro
    {
        public FrmCadProduto()
        {
            InitializeComponent();
        }

        public int Codigo;
        public void SalvarFoto(object o, EventArgs e)
        {


            if (txtNomeProduto.Text == "")
            {

                MessageBox.Show("Insira um nome para o produto");
                txtNomeProduto.Focus();
                return;


            }

            try
            {
                openFileDialog1.ShowDialog();
                Bitmap bmp = new Bitmap(openFileDialog1.FileName);
                Bitmap bmp2 = new Bitmap(bmp, pictureBox1.Size);
                pbFoto.Image = bmp2;
                pbFoto.Image.Save(Application.StartupPath.ToString() + "\\ImagensProdutos\\" + txtNomeProduto.Text + ".png", System.Drawing.Imaging.ImageFormat.Png);
                imagem = openFileDialog1.FileName;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Inserir imagem : " + erro);
            }
        }

        public String imagem;
        public void CadastrarProduto(object o, EventArgs e) {
            //imagem = "\\Havaianas\\Havaianas\\bin\\Debug\\ImagensProdutos\Havaianas.png" + txtNomeProduto.Text + ".png";
            imagem = Application.StartupPath.ToString() + "\\ImagensProdutos\\" + txtNomeProduto.Text + ".png";
            BLL.Produto p = new BLL.Produto();
            p.CodigoCategoria = Convert.ToInt32(cbCat.SelectedValue);
            p.NomeProduto = txtNomeProduto.Text+" " + Convert.ToString(comboBox1.SelectedItem);
          
            p.StatusProduto = 1;
            p.PrecoProduto = Convert.ToDouble(txtPreco.Text);
            p.FotoProduto = imagem;
            p.Tamanho = Convert.ToString(comboBox1.SelectedItem.ToString());
            p.IncluirComParametro();
            p.Quantidade = Convert.ToInt32(numericEstqQuant.Value);
            p.NovoEstoque();
            MessageBox.Show("Produto cadastrado com suceeso");
            

        }
        
        private void CarregarCombo(object o, EventArgs e)
        {

            BLL.Categoria c = new BLL.Categoria();
            cbCat.DataSource = c.Listar(String.Empty).Tables[0];
            cbCat.DisplayMember = "Descricao";
            cbCat.ValueMember = "CategoriaID";


          

        }
        public void AlterarProduto(object o, EventArgs e)
        {


          //imagem = "\\Havaianas\\Havaianas\\bin\\Debug\\ImagensProdutos\\Havaianas.png" + txtNomeProduto.Text + ".png";
            imagem = Application.StartupPath.ToString() + "\\ImagensProdutos\\" + txtNomeProduto.Text + ".png";
            BLL.Produto p = new BLL.Produto();
            p.CodigoCategoria = Convert.ToInt32(cbCat.SelectedValue);
            p.NomeProduto = txtNomeProduto.Text + " " + Convert.ToString(comboBox1.SelectedText);
            p.StatusProduto = 1;
            p.PrecoProduto = Convert.ToDouble(txtPreco.Text);
            p.FotoProduto = imagem;
            p.Tamanho = Convert.ToString(comboBox1.SelectedItem);
            p.CodigoProduto = Codigo;
            p.AlterarComParametro();
            MessageBox.Show("Produto alterado com suceeso");


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
