using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace BLL
{
    public class Funcionario
    {

        private int _CodigoFunc;
        private string _NomeFuncionario;
        private string _Sexo;
        private string _EmailFuncionario;
        private int _CodigoUsuario;
        private string _CpfFuncionario;
        public string CpfFuncionario
        {
            get
            {
                return _CpfFuncionario;
            }

            set
            {
                _CpfFuncionario = value;
            }
        }

        private DateTime _NascimentoFuncionario;
        public DateTime NascimentoFuncionario
        {
            get
            {
                return _NascimentoFuncionario;
            }

            set
            {
                _NascimentoFuncionario = value;
            }
        }

        public int StatusFuncionario
        {
            get
            {
                return _StatusFuncionario;
            }
            set
            {
                _StatusFuncionario = value;
            }
        }
        public string Logradouro
        {
            get
            {
                return _Logradouro;
            }
            set
            {
                _Logradouro = value.Trim();
            }
        }
        public string Cep
        {
            get
            {
                return _Cep;
            }
            set
            {
                _Cep = value;
            }
        }
        public string UF
        {
            get
            {
                return _UF;
            }
            set
            {
                _UF = value;
            }
        }
        public string Cidade
        {
            get
            {
                return _Cidade;
            }
            set
            {
                _Cidade = value.Trim();
            }
        }
        public string Bairro
        {
            get
            {
                return _Bairro;
            }
            set
            {
                _Bairro = value.Trim();
            }
        }
        public string Numero
        {
            get
            {
                return _Numero;
            }
            set
            {
                _Numero = value.Trim();
            }
        }
        public string Complemento
        {
            get
            {
                return _Complemento;
            }
            set
            {
                _Complemento = value.Trim();
            }
        }
        public int CodigoFunc
        {
            get
            {
                return _CodigoFunc;
            }
            set
            {
                _CodigoFunc = value;
            }
        }
        public string NomeFuncionario
        {
            get
            {
                return _NomeFuncionario;
            }
            set
            {
                _NomeFuncionario = value.Trim().ToUpper();
            }
        }
        public string Sexo
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
        public string EmailFuncionario
        {
            get
            {
                return _EmailFuncionario;
            }
            set
            {
                _EmailFuncionario = value.Trim();
            }
        }

      
        private int _StatusFuncionario;
        private string _Logradouro;
        private string _Cep;
        private string _UF;
        private string _Cidade;
        private string _Bairro;
        private string _Numero;
        private string _Complemento;

        DAO.ClasseParaManipularBancoDeDados c = new DAO.ClasseParaManipularBancoDeDados();
        private static string instrucaoSql;

        public void IncluirComParametro()
        {
            try
            {
                SqlParameter[] listaComParametro =
                {
                    new SqlParameter("@NomeFuncionario",SqlDbType.VarChar) {Value = _NomeFuncionario },
                    new SqlParameter("@StatusFuncionario",SqlDbType.Bit) {Value = _StatusFuncionario },
                    new SqlParameter("@Sexo",SqlDbType.VarChar) {Value = _Sexo },
                    new SqlParameter("@EmailFuncionario",SqlDbType.VarChar) {Value = _EmailFuncionario },
                    new SqlParameter("@CpfFuncionario",SqlDbType.VarChar) {Value = _CpfFuncionario },
                    new SqlParameter("@NascimentoFuncionario",SqlDbType.DateTime) {Value = _NascimentoFuncionario },
                    new SqlParameter("@Logradouro",SqlDbType.VarChar) {Value = _Logradouro },
                    new SqlParameter("@Cep",SqlDbType.VarChar) {Value = _Cep },
                    new SqlParameter("@UF",SqlDbType.Char) {Value = _UF },
                    new SqlParameter("@Cidade",SqlDbType.VarChar) {Value = _Cidade },
                    new SqlParameter("@Bairro",SqlDbType.VarChar) {Value = _Bairro },
                    new SqlParameter("@Numero",SqlDbType.VarChar) {Value = _Numero },
                    new SqlParameter("@Complemento",SqlDbType.VarChar) {Value = _Complemento }
                };
                //Criar o Objeto 'listarComParametro' a partir da classe 'SqlParameter' definida como uma lista'[]'. Foi instanciado 'new' o objeto 'listaComParametros' com 4 itens/parametros. Cada parametro foi definido com a identificação '@.....' + um tipo de dado' SqlDbType' + um valor '{Value = _....}'
                instrucaoSql = "INSERT INTO tbFuncionario (NomeFuncionario, StatusFuncionario,  Sexo, EmailFuncionario, CpfFuncionario, NascimentoFuncionario, Logradouro, Cep, UF, Cidade, Bairro, Numero, Complemento) Values (@NomeFuncionario, @StatusFuncionario, @Sexo, @EmailFuncionario, @CpfFuncionario, @NascimentoFuncionario, @Logradouro, @Cep, @UF, @Cidade, @Bairro, @Numero, @Complemento)";
                c.ExecutarComandoParametro(instrucaoSql, listaComParametro);


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
                SqlParameter[] listaComParametros = { new SqlParameter("@CodigoFunc",SqlDbType.Int) {Value = _CodigoFunc },
                    new SqlParameter("@NomeFuncionario",SqlDbType.VarChar) {Value = _NomeFuncionario },
                    new SqlParameter("@StatusFuncionario",SqlDbType.Bit) {Value = _StatusFuncionario },
                    new SqlParameter("@Sexo",SqlDbType.VarChar) {Value = _Sexo },
                    new SqlParameter("@EmailFuncionario",SqlDbType.VarChar) {Value = _EmailFuncionario },
                    new SqlParameter("@CpfFuncionario",SqlDbType.VarChar) {Value = _CpfFuncionario },
                    new SqlParameter("@NascimentoFuncionario",SqlDbType.DateTime) {Value = _NascimentoFuncionario },
                    new SqlParameter("@Logradouro",SqlDbType.VarChar) {Value = _Logradouro },
                    new SqlParameter("@Cep",SqlDbType.VarChar) {Value = _Cep },
                    new SqlParameter("@UF",SqlDbType.Char) {Value = _UF },
                    new SqlParameter("@Cidade",SqlDbType.VarChar) {Value = _Cidade },
                    new SqlParameter("@Bairro",SqlDbType.VarChar) {Value = _Bairro },
                    new SqlParameter("@Numero",SqlDbType.VarChar) {Value = _Numero },
                    new SqlParameter("@Complemento",SqlDbType.VarChar) {Value = _Complemento }
                };
                instrucaoSql = "UPDATE tbFuncionario SET NomeFuncionario =@NomeFuncionario, StatusFuncionario=@StatusFuncionario, Sexo=@Sexo, EmailFuncionario=@EmailFuncionario, CpfFuncionario=@CpfFuncionario, NascimentoFuncionario=@NascimentoFuncionario, Logradouro=@Logradouro, Cep=@Cep, UF=@UF, Cidade=@Cidade, Bairro=@Bairro, Numero=@Numero, Complemento=@Complemento WHERE CodigoFunc=@CodigoFunc";
                c.ExecutarComandoParametro(instrucaoSql, listaComParametros);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int RetornarFuncionario()
        {
            try
            {
                instrucaoSql = "Select max(CodigoFunc)from tbFuncionario";
                return c.RetornarExecuteScalar(instrucaoSql);

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
                instrucaoSql = "UPDATE tbFuncionario SET StatusFuncionario = 1 WHERE CodigoFunc = " + _CodigoFunc + "";
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
                instrucaoSql = "UPDATE tbFuncionario SET StatusFuncionario = 0 WHERE CodigoFunc = " + _CodigoFunc + "";
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
                instrucaoSql = "DELETE FROM tbFuncionario WHERE CodigoFunc = " + _CodigoFunc + "";
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
                instrucaoSql = "SELECT * FROM tbFuncionario WHERE CodigoFunc= " + _CodigoFunc + "";
                return c.RetornarDataReader(instrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataSet Listar(string parteNomeFuncionario, byte TipoStatusFuncionario)
        {
            try
            {
                instrucaoSql = "SELECT *FROM tbFuncionario";
                if (parteNomeFuncionario.Length != 0)
                {
                    instrucaoSql = instrucaoSql + " WHERE NomeFuncionario LIKE '%" + parteNomeFuncionario + "%'";
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
                instrucaoSql = "SELECT CodigoFunc, NomeFuncionario, StatusFuncionario FROM tbFuncionario WHERE StatusFuncionario=1";
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
                instrucaoSql = "SELECT CodigoFunc, NomeFuncionario, StatusFuncionario FROM tbFuncionario WHERE StatusFuncionario=0";
                return c.RetornarDataSet(instrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }



    }
}
