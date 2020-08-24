using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace BLL
{
    public class Venda
    {

        private int _CodigoVenda;
        private int _CodigoCliente;
        private int _CodigoVendedor;
        private DateTime _DataVenda;
        private Double _ValorTotal;
        private String _Pagamento;
        private String _Pagamento2;
        public int CodigoVenda
        {
            get
            {
                return _CodigoVenda;
            }

            set
            {
                _CodigoVenda = value;
            }
        }

        public int CodigoCliente
        {
            get
            {
                return _CodigoCliente;
            }

            set
            {
                _CodigoCliente = value;
            }
        }

        public int CodigoVendedor
        {
            get
            {
                return _CodigoVendedor;
            }

            set
            {
                _CodigoVendedor = value;
            }
        }

        public DateTime DataVenda
        {
            get
            {
                return _DataVenda;
            }

            set
            {
                _DataVenda = value;
            }
        }

        public double ValorTotal
        {
            get
            {
                return _ValorTotal;
            }

            set
            {
                _ValorTotal = value;
            }
        }

        public string Pagamento
        {
            get
            {
                return _Pagamento;
            }

            set
            {
                _Pagamento = value;
            }
        }

        public string Pagamento2
        {
            get
            {
                return _Pagamento2;
            }

            set
            {
                _Pagamento2 = value;
            }
        }

        DAO.ClasseParaManipularBancoDeDados c = new DAO.ClasseParaManipularBancoDeDados();

        public static String instrucaoSql;

        public void IncluirComParametro()
        {
            try
            {
                SqlParameter[] listaComParametros = {
                   new SqlParameter("@CodigoCliente",SqlDbType.Int) {Value = _CodigoCliente },
                   new SqlParameter("@CodigoVendedor",SqlDbType.Int) {Value = _CodigoVendedor },
                   new SqlParameter("@DataVenda",SqlDbType.DateTime) {Value = _DataVenda },
                   new SqlParameter("@Pagamento",SqlDbType.VarChar) {Value = _Pagamento },

                   new SqlParameter("@ValorTotal",SqlDbType.Decimal) {Value = _ValorTotal }

                };
                //criar o objeto 'listaComParametros' a partir da classe 'sqlparameter' definida como uma lista '[]'. Foi instanciado 'new' o objeto 'listaComParametros' com 4 itens/parametros.  Cada parametro foi definido com a identificação '@....' + um tipo de dado 'SqlDbType' +  um valor '{Value = _.....}'
                instrucaoSql = "INSERT INTO tbVenda (CodigoCliente, CodigoVendedor, DataVenda, ValorTotal,FormaPgto) VALUES (@CodigoCliente, @CodigoVendedor, @DataVenda, @ValorTotal,@Pagamento)";
                c.ExecutarComandoParametro(instrucaoSql, listaComParametros);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void IncluirComParametroDuasFormas()
        {
            try
            {
                SqlParameter[] listaComParametros = {
                   new SqlParameter("@CodigoCliente",SqlDbType.Int) {Value = _CodigoCliente },
                   new SqlParameter("@CodigoVendedor",SqlDbType.Int) {Value = _CodigoVendedor },
                   new SqlParameter("@DataVenda",SqlDbType.DateTime) {Value = _DataVenda },
                   new SqlParameter("@Pagamento",SqlDbType.VarChar) {Value = _Pagamento },
                   new SqlParameter("@Pagamento2",SqlDbType.VarChar) {Value = _Pagamento },
                   new SqlParameter("@ValorTotal",SqlDbType.Decimal) {Value = _ValorTotal }

                };
                //criar o objeto 'listaComParametros' a partir da classe 'sqlparameter' definida como uma lista '[]'. Foi instanciado 'new' o objeto 'listaComParametros' com 4 itens/parametros.  Cada parametro foi definido com a identificação '@....' + um tipo de dado 'SqlDbType' +  um valor '{Value = _.....}'
                instrucaoSql = "INSERT INTO tbVenda (CodigoCliente, CodigoVendedor, DataVenda, ValorTotal,FormaPgto,FormaPgto2) VALUES (@CodigoCliente, @CodigoVendedor, @DataVenda, @ValorTotal,@Pagamento,@Pagamento2)";
                c.ExecutarComandoParametro(instrucaoSql, listaComParametros);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataSet ListarVendas(string parteNome)
        {
            try
            {
                instrucaoSql = "SELECT  tbVenda.CodigoVenda,Cliente.CodigoCliente, Cliente.NomeCliente As  Nome_cliente, tbVendedor.CodigoVendedor, tbVendedor.NomeVendedor AS FuncionarioResponsavel,tbVenda.ValorTotal,tbVenda.FormaPgto FROM tbCliente as Cliente INNER JOIN tbVenda ON tbVenda.CodigoCliente = Cliente.CodigoCliente INNER JOIN tbVendedor ON tbVenda.CodigoVendedor = tbVendedor.CodigoVendedor Order by CodigoVenda";
                if (parteNome.Length != 0)
                {
                    instrucaoSql = instrucaoSql + " WHERE Cliente.NomeCliente LIKE '%" + parteNome + "%'"; //avisado sobre comportamento
                }
                return c.RetornarDataSet(instrucaoSql);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public int RetornarVenda()
        {
            try
            {
                instrucaoSql = "Select max(CodigoVenda)from tbVenda";
                return c.RetornarExecuteScalar(instrucaoSql);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataSet ListarItensVenda(int CodigoVenda)
        {

            try
            {

                instrucaoSql = "SELECT tbItem_Venda.CodigoProduto , tbProduto.NomeProduto, PrecoProduto FROM tbVenda  INNER JOIN tbItem_Venda ON tbVenda.CodigoVenda=tbItem_Venda.CodigoVenda INNER JOIN tbProduto  ON tbItem_Venda.CodigoProduto = tbProduto.CodigoProduto   WHERE  tbVenda.CodigoVenda = " + CodigoVenda;
                return c.RetornarDataSet(instrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }



        }

        public SqlDataReader MostrarParcela()
        {

            try
            {
                instrucaoSql = "SELECT*FROM tbParcelamentoVenda WHERE CodigoVenda =" + RetornarVenda();
                return c.RetornarDataReader(instrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }







        }





    }
}
