using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class Cupom
    {

        public static string instrucaoSql;
        DAO.ClasseParaManipularBancoDeDados c = new DAO.ClasseParaManipularBancoDeDados();
        private string _CodigoCupom;
        private DateTime _DataInicio;
        private DateTime _DataFim;
        private decimal _Valor;
        private byte _StatusCupom;
        private int _Quantidade;

        public string CodigoCupom
        {
            get
            {
                return _CodigoCupom;
            }

            set
            {
                _CodigoCupom = value;
            }
        }

        public DateTime DataInicio
        {
            get
            {
                return _DataInicio;
            }

            set
            {
                _DataInicio = value;
            }
        }

        public DateTime DataFim
        {
            get
            {
                return _DataFim;
            }

            set
            {
                _DataFim = value;
            }
        }

        public decimal Valor
        {
            get
            {
                return _Valor;
            }

            set
            {
                _Valor = value;
            }
        }

        public byte StatusCupom
        {
            get
            {
                return _StatusCupom;
            }

            set
            {
                _StatusCupom = value;
            }
        }
        private int _Id;
        public int Id
        {
            get
            {
                return _Id;
            }

            set
            {
                _Id = value;
            }
        }

        public int Quantidade
        {
            get
            {
                return _Quantidade;
            }

            set
            {
                _Quantidade = value;
            }
        }

        public void IncluirComParametro()
        {
            try
            {
                SqlParameter[] listaComParametros = {
                   new SqlParameter("@CodigoCupom",SqlDbType.VarChar) {Value = _CodigoCupom },
                   new SqlParameter("@DataInicio",SqlDbType.DateTime) {Value = _DataInicio },
                   new SqlParameter("@DataFim",SqlDbType.DateTime) {Value = _DataFim },
                   new SqlParameter("@StatusCupom",SqlDbType.Bit) {Value = _StatusCupom },
                   new SqlParameter("@Valor",SqlDbType.Decimal) {Value = _Valor },
                   new SqlParameter("@Quantidade",SqlDbType.Int) { Value = _Quantidade}

                };
                //criar o objeto 'listaComParametros' a partir da classe 'sqlparameter' definida como uma lista '[]'. Foi instanciado 'new' o objeto 'listaComParametros' com 4 itens/parametros.  Cada parametro foi definido com a identificação '@....' + um tipo de dado 'SqlDbType' +  um valor '{Value = _.....}'
                instrucaoSql = "INSERT INTO tbCupom (CodigoCupom, DataInicio, DataFim, ValorDesconto,StatusCupom,QuantidadeCupom) VALUES (@CodigoCupom, @DataInicio, @DataFim, @Valor,@StatusCupom,@Quantidade)";

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
                SqlParameter[] listaComParametros = {
                   new SqlParameter("@Id",SqlDbType.Int) {Value = Id },
                   new SqlParameter("@CodigoCupom",SqlDbType.VarChar) {Value = _CodigoCupom },
                   new SqlParameter("@DataInicio",SqlDbType.DateTime) {Value = _DataInicio },
                   new SqlParameter("@DataFim",SqlDbType.DateTime) {Value = _DataFim },
                   new SqlParameter("@StatusCupom",SqlDbType.Bit) {Value = _StatusCupom },
                   new SqlParameter("@Valor",SqlDbType.Decimal) {Value = _Valor },
                   new SqlParameter("@Quantidade",SqlDbType.Int) { Value = _Quantidade}


                };

                instrucaoSql = "UPDATE tbCupom SET CodigoCupom=@CodigoCupom, DataInicio=@DataInicio,DataFim=@DataFim,ValorDesconto=@Valor,QuantidadeCupom=@Quantidade WHERE Id=@Id";
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
                instrucaoSql = "UPDATE tbCupom SET StatusCupom=1   WHERE Id=" + _Id;
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
                instrucaoSql = "UPDATE tbCupom SET StatusCupom=0   WHERE Id=" + _Id;
                c.ExecutarComando(instrucaoSql);
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
                instrucaoSql = "SELECT * FROM tbCupom WHERE StatusCupom=1";
                return c.RetornarDataSet(instrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataSet Listar()
        {
            try
            {
                instrucaoSql = "SELECT * FROM tbCupom";
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
                instrucaoSql = "SELECT * FROM tbCupom WHERE StatusCupom=0 ";
                return c.RetornarDataSet(instrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }



        public bool VerificarCupom()
        {


            int CupomValido = 0;
            CupomValido = c.RetornarExecuteScalar("SELECT COUNT(Id)FROM tbCupom where CodigoCupom ='" + _CodigoCupom + "'");

            if (CupomValido > 0)
            {

                return true;
            }

            return false;

        }

        public decimal RetornarValorCupom(string CodigoCupom)
        {
            System.Data.SqlClient.SqlDataReader ddr;
            ddr = c.RetornarDataReader("SELECT ValorDesconto FROM tbCupom WHERe CodigoCupom =" +"'"+ CodigoCupom+"'");
            ddr.Read();
            if (ddr.HasRows)
            {
                return Convert.ToDecimal(ddr[0]);
            }
            return 0;

        }
        public void BaixarCupom() {

            try
            {
                SqlParameter[] listaComParametros = {
                   new SqlParameter("@CodigoCupom",SqlDbType.VarChar) {Value = CodigoCupom }
                    };
                instrucaoSql = "BaixarCupom";
                c.ExecutarComandoStoredProcedure(instrucaoSql,listaComParametros);

            }
            catch (Exception ex)
            {

                throw ex ;
            }

        }
    }
}
