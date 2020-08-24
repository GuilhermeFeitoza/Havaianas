using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;



namespace BLL
{
    public class Cliente
    {
        DAO.ClasseParaManipularBancoDeDados  c = new DAO.ClasseParaManipularBancoDeDados();
        public static string instrucaoSql;

        private int _CodigoCliente;
        private String _NomeCliente;
        private char _Sexo;
        private String _EmailCliente;
        private string _CpfCliente;
        private string _Telefone;
        private DateTime _DataNascimento;
      
        private byte _StatusCliente;

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

        public string NomeCliente
        {
            get
            {
                return _NomeCliente;
            }

            set
            {
                _NomeCliente = value;
            }
        }

        public char Sexo
        {
            get
            {
                return _Sexo;
            }

            set
            {
                _Sexo = value;
            }
        }

        public string EmailCliente
        {
            get
            {
                return _EmailCliente;
            }

            set
            {
                _EmailCliente = value;
            }
        }

        public string CpfCliente
        {
            get
            {
                return _CpfCliente;
            }

            set
            {
                _CpfCliente = value;
            }
        }

        public string Telefone
        {
            get
            {
                return _Telefone;
            }

            set
            {
                _Telefone = value;
            }
        }

        public DateTime DataNascimento
        {
            get
            {
                return _DataNascimento;
            }

            set
            {
                _DataNascimento = value;
            }
        }

       
        public byte StatusCliente
        {
            get
            {
                return _StatusCliente;
            }

            set
            {
                _StatusCliente = value;
            }
        }

        public void IncluirComParametro()
        {
            try
            {
                SqlParameter[] listaComParametros = {
                   new SqlParameter("@NomeCliente",SqlDbType.VarChar) {Value = NomeCliente },
                   new SqlParameter("@DataNascimento",SqlDbType.DateTime) {Value = DataNascimento },
    
                   new SqlParameter("@EmailCliente",SqlDbType.VarChar) {Value = EmailCliente },
                   new SqlParameter("@Sexo",SqlDbType.Char) {Value = Sexo },
                   new SqlParameter("@CpfCliente",SqlDbType.VarChar) {Value = CpfCliente },
                   new SqlParameter("@StatusCliente",SqlDbType.Bit) {Value = StatusCliente },
                   new SqlParameter("@Telefone",SqlDbType.VarChar) {Value = Telefone }
                  
                };
                //criar o objeto 'listaComParametros' a partir da classe 'sqlparameter' definida como uma lista '[]'. Foi instanciado 'new' o objeto 'listaComParametros' com 4 itens/parametros.  Cada parametro foi definido com a identificação '@....' + um tipo de dado 'SqlDbType' +  um valor '{Value = _.....}'
                instrucaoSql = "INSERT INTO tbCliente (nomecliente, datanascimento, EmailCliente, Sexo, CpfCliente, statuscliente, Telefone) VALUES (@NomeCliente, @DataNascimento, @EmailCliente, @Sexo, @CpfCliente, @StatusCliente, @Telefone)";
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
                SqlParameter[] listaComParametros = { new SqlParameter("@CodigoCliente",SqlDbType.Int) {Value = _CodigoCliente },
                   new SqlParameter("@NomeCliente",SqlDbType.VarChar) {Value = NomeCliente },
                   new SqlParameter("@DataNascimento",SqlDbType.DateTime) {Value = DataNascimento },

                   new SqlParameter("@EmailCliente",SqlDbType.VarChar) {Value = EmailCliente },
                   new SqlParameter("@Sexo",SqlDbType.Char) {Value = Sexo },
                   new SqlParameter("@CpfCliente",SqlDbType.VarChar) {Value = CpfCliente },
                   new SqlParameter("@StatusCliente",SqlDbType.Bit) {Value = StatusCliente },
                   new SqlParameter("@Telefone",SqlDbType.VarChar) {Value = Telefone }
                 
                };


                instrucaoSql = "UPDATE tbCliente SET nomecliente=@NomeCliente, datanascimento=@DataNascimento, EmailCliente=@EmailCliente, Sexo=@Sexo, CpfCliente=@CpfCliente, statuscliente=@StatusCliente, Telefone=@Telefone WHERE codigocliente=@CodigoCliente";
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
                instrucaoSql = "UPDATE tbCliente SET statuscliente=1   WHERE CodigoCliente=" + CodigoCliente;
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
                instrucaoSql = "UPDATE tbCliente SET statuscliente=0   WHERE CodigoCliente=" + CodigoCliente;
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
                instrucaoSql = "DELETE FROM tbCliente  WHERE CodigoCliente=" + CodigoCliente;
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
                instrucaoSql = "SELECT * FROM tbCliente  WHERE codigocliente=" + CodigoCliente;
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
                instrucaoSql = "SELECT*FROM tbCliente";
                if (parteNome.Length != 0)
                {
                    instrucaoSql = instrucaoSql + " WHERE nomecliente LIKE '%" + parteNome + "%'"; //avisado sobre comportamento
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
                instrucaoSql = "SELECT codigocliente, nomecliente, statuscliente FROM tbCliente WHERE statuscliente=1 ORDER BY nomecliente";
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
                instrucaoSql = "SELECT codigocliente, nomecliente, statuscliente FROM tbCliente WHERE statuscliente=0";
                return c.RetornarDataSet(instrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
















    }
}
