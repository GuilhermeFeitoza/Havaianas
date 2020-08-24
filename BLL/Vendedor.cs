using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class Vendedor
    {
        DAO.ClasseParaManipularBancoDeDados c = new DAO.ClasseParaManipularBancoDeDados();
        public string instrucaoSql;

        private int _CodigoVendedor;    
        private string _NomeVendedor;
        private int _CodigoFuncionario;
        
        private byte _StatusVendedor;
    

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

        public string NomeVendedor
        {
            get
            {
                return _NomeVendedor;
            }

            set
            {
                _NomeVendedor = value.ToUpper().Trim();
            }
        }
        

        public byte StatusVendedor
        {
            get
            {
                return _StatusVendedor;
            }

            set
            {
                _StatusVendedor = value;
            }
        }

        public int CodigoFuncionario
        {
            get
            {
                return _CodigoFuncionario;
            }

            set
            {
                _CodigoFuncionario = value;
            }
        }




        //metodos
        public void IncluirComParametro()
        {
            try
            {
                SqlParameter[] listaComParametros = {
                    new SqlParameter("@CodigoFuncionario",SqlDbType.Int) {Value = CodigoFuncionario },
                    new SqlParameter("@NomeVendedor",SqlDbType.VarChar) {Value = _NomeVendedor },
                   new SqlParameter("@StatusVendedor",SqlDbType.Bit) {Value = _StatusVendedor }

                };
                //criar o objeto 'listaComParametros' a partir da classe 'sqlparameter' definida como uma lista '[]'. Foi instanciado 'new' o objeto 'listaComParametros' com 4 itens/parametros.  Cada parametro foi definido com a identificação '@....' + um tipo de dado 'SqlDbType' +  um valor '{Value = _.....}'
                instrucaoSql = "INSERT INTO tbVendedor (NomeVendedor,  StatusVendedor,CodigoFunc) VALUES (@NomeVendedor,@StatusVendedor,@CodigoFuncionario)";
                c.ExecutarComandoParametro(instrucaoSql, listaComParametros);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void AlterarComParametro()
        {
            try
            {
                SqlParameter[] listaComParametros = { new SqlParameter("@CodigoVendedor",SqlDbType.Int) {Value = _CodigoVendedor },
                   new SqlParameter("@NomeVendedor",SqlDbType.VarChar) {Value = _NomeVendedor },
                   new SqlParameter("@StatusVendedor",SqlDbType.Bit) {Value = _StatusVendedor }
                };

                instrucaoSql = "UPDATE tbVendedor SET NomeVendedor=@NomeVendedor, StatusVendedor=@StatusVendedor WHERE CodigoVendedor=@CodigoVendedor";
                c.ExecutarComandoParametro(instrucaoSql, listaComParametros);



            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public void Ativar()
        {
            try
            {
                instrucaoSql = "UPDATE tbVendedor SET StatusVendedor=1   WHERE CodigoVendedor=" + _CodigoVendedor;
                c.ExecutarComando(instrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Desativar()
        {
            try
            {
                instrucaoSql = "UPDATE tbVendedor SET StatusVendedor=0   WHERE CodigoVendedor=" + _CodigoVendedor;
                c.ExecutarComando(instrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Excluir()
        {
            try
            {
                instrucaoSql = "DELETE FROM tbVendedor  WHERE CodigoVendedor=" + _CodigoVendedor;
                c.ExecutarComando(instrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public SqlDataReader Consultar()
        {
            try
            {
                instrucaoSql = "SELECT * FROM tbVendedor  WHERE CodigoVendedor=" + _CodigoVendedor;
                return c.RetornarDataReader(instrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataSet Listar(string parteNome, byte tipostatus)
        {
            try
            {
                instrucaoSql = "SELECT CodigoVendedor, NomeVendedor, StatusVendedor FROM tbVendedor";
                if (parteNome.Length != 0)
                {
                    instrucaoSql = instrucaoSql + " WHERE NomeVendedor LIKE '%" + parteNome + "%'"; //avisado sobre comportamento
                }
                return c.RetornarDataSet(instrucaoSql);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataSet ListarAtivos()
        {
            try
            {
                instrucaoSql = "SELECT CodigoVendedor, NomeVendedor, StatusVendedor FROM tbVendedor WHERE StatusVendedor=1 ORDER BY NomeVendedor";
                return c.RetornarDataSet(instrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataSet ListarInativos()
        {
            try
            {
                instrucaoSql = "SELECT CodigoVendedor, NomeVendedor, StatusVendedor FROM tbVendedor WHERE StatusVendedor=0";
                return c.RetornarDataSet(instrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataSet Grafico()
        {
            try
            {
                instrucaoSql = "SELECT tbVendedor.CodigoVendedor ,Count(tbVenda.CodigoVendedor)NumeroDeVendas FROM tbVendedor  INNER JOIN tbVenda ON tbVendedor.CodigoVendedor = tbVenda.CodigoVendedor  GROUP BY tbVendedor.CodigoVendedor ORDER BY 2 DESC";
                return c.RetornarDataSet(instrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        



    }
}
