using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Havaianas.Telas.Menus
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void CarregarGrafico(object o, EventArgs e)
        {

            DAO.ClasseParaManipularBancoDeDados c = new DAO.ClasseParaManipularBancoDeDados();
            System.Data.SqlClient.SqlDataReader ddr;
            ddr = c.RetornarDataReader("SELECT tbProduto.NomeProduto,COUNT(tbItem_Venda.CodigoItem_Venda)AS Numero_Vendas FROM tbProduto INNER JOIN tbItem_Venda ON tbItem_Venda.CodigoProduto =  tbProduto.CodigoProduto GROUP BY NomeProduto ORDER BY Numero_Vendas desc");
            ddr.Read();
            if (ddr.HasRows)
            {
                while (ddr.Read())
                {
                    chart1.Series["Vendas"].Points.AddXY(ddr[0], ddr[1]);
                }
               
                   
                
                

            }
        }
    }
}
