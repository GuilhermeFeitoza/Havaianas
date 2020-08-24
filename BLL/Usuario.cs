using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class Usuario
    {
        private int _CodigoUsuario;
        private String _NomeUsuario;
        private String _SenhaUsuario;
        
        private byte _StatusUsuario;
        private int  _CodigoFunc;

          




        DAO.ClasseParaManipularBancoDeDados c = new DAO.ClasseParaManipularBancoDeDados();
  
        private static string instrucaoSql;

        public int CodigoUsuario
        {
            get
            {
                return _CodigoUsuario;
            }

            set
            {
                _CodigoUsuario = value;
            }
        }

        public string NomeUsuario
        {
            get
            {
                return _NomeUsuario;
            }

            set
            {
                _NomeUsuario = value;
            }
        }

        public string SenhaUsuario
        {
            get
            {
                return _SenhaUsuario;
            }

            set
            {
                _SenhaUsuario = value;
            }
        }

       

        public byte StatusUsuario
        {
            get
            {
                return _StatusUsuario;
            }

            set
            {
                _StatusUsuario = value;
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

        public int CodigoLogado()
        {
            try
            {
                SqlDataReader dr;
                dr = c.RetornarDataReader("Select CodigoUsuario, NomeUsuario FROM tbUsuario WHERE nomesistema='" + NomeUsuario + "' AND senhasistema = '" + SenhaUsuario + "'");
                dr.Read();
                if (dr.HasRows)
                {
                    NomeUsuario = Convert.ToString(dr["nomeusuario"]);
          
                    return Convert.ToInt32(dr["CodigoUsuario"]);
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

      

        public void IncluirComParametro()
        {
            try
            {
                SqlParameter[] listaComParametro =
                {
                    new SqlParameter("@NomeUsuario",SqlDbType.VarChar) {Value = NomeUsuario },
                    new SqlParameter("@SenhaUsuario",SqlDbType.VarChar) {Value = SenhaUsuario },
                    new SqlParameter("@StatusUsuario",SqlDbType.Bit) {Value = StatusUsuario },
                    new SqlParameter("@CodigoFunc",SqlDbType.Int) {Value = CodigoFunc }
                };
                //Criar o Objeto 'listarComParametro' a partir da classe 'SqlParameter' definida como uma lista'[]'. Foi instanciado 'new' o objeto 'listaComParametros' com 4 itens/parametros. Cada parametro foi definido com a identificação '@.....' + um tipo de dado' SqlDbType' + um valor '{Value = _....}'
                instrucaoSql = "INSERT INTO tbusuario (NomeUsuario, SenhaUsuario, StatusUsuario,CodigoFunc) Values (@NomeUsuario, @SenhaUsuario, @StatusUsuario, @CodigoFunc)";
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
                 SqlParameter[] listaComParametro =
                {   new SqlParameter("@CodigoUsuario",SqlDbType.Int) {Value = _CodigoUsuario },
                    new SqlParameter("@NomeUsuario",SqlDbType.VarChar) {Value = NomeUsuario },
                    new SqlParameter("@SenhaUsuario",SqlDbType.VarChar) {Value = SenhaUsuario },
                    new SqlParameter("@StatusUsuario",SqlDbType.Bit) {Value = StatusUsuario },
                    new SqlParameter("@CodigoFunc",SqlDbType.Int) {Value = CodigoFunc }

                };












                instrucaoSql = "UPDATE tbUsuario SET NomeUsuario=@NomeUsuario, SenhaUsuario=@SenhaUsuario,StatusUsuario=@StatusUsuario, CodigoFunc=@CodigoFunc WHERE CodigoUsuario=@CodigoUsuario";
                c.ExecutarComandoParametro(instrucaoSql, listaComParametro);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void TrocarSenhaComParametro()
        {
            try
            {
                SqlParameter[] listaComParametro =
                {
                    new SqlParameter("@CodigoUsuario",SqlDbType.Int) {Value = CodigoUsuario },
                    new SqlParameter("@SenhaUsuario",SqlDbType.VarChar) {Value = SenhaUsuario }
                };
                instrucaoSql = "UPDATE tbUsuario SET SenhaUsuario=@SenhaUsuario WHERE CodigoUsuario=@CodigoUsuario";
                c.ExecutarComandoParametro(instrucaoSql, listaComParametro);
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
                instrucaoSql = "UPDATE TbUsuario SET StatusUsuario = 1 WHERE CodigoUsuario = " + CodigoUsuario + "";
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
                instrucaoSql = "UPDATE TbUsuario SET StatusUsuario = 0 WHERE CodigoUsuario = " + CodigoUsuario + "";
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
                instrucaoSql = "DELETE FROM TbUsuario WHERE CodigoUsuario = " + CodigoUsuario + "";
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
                instrucaoSql = "SELECT * FROM TbUsuario WHERE CodigoUsuario= " + CodigoUsuario + "";
                return c.RetornarDataReader(instrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataSet Listar(string parteNomeUsuario, byte TipoStatusUsuario)
        {
            try
            {
                instrucaoSql = "SELECT* FROM TbUsuario";
                if (parteNomeUsuario.Length != 0)
                {
                    instrucaoSql = instrucaoSql + " WHERE NomeUsuario LIKE '%" + parteNomeUsuario + "%'";
                }
                return c.RetornarDataSet(instrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataSet ListaVendedorAtivo()
        {
            try
            {
                instrucaoSql = "SELECT CodigoUsuario, NomeUsuario, StatusUsuario FROM TbUsuario WHERE  StatusUsuario = 1";
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
                instrucaoSql = "SELECT CodigoUsuario, NomeUsuario, StatusUsuario FROM TbUsuario WHERE StatusUsuario=1";
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
                instrucaoSql = "SELECT CodigoUsuario, NomeUsuario, StatusUsuario FROM TbUsuario WHERE StatusUsuario=0";
                return c.RetornarDataSet(instrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int Logar()
        {
            try
            {
               
                instrucaoSql = "SELECT NomeUsuario,SenhaUsuario,CodigoUsuario FROM tbUsuario WHERE NomeUsuario ='" + NomeUsuario+ "'AND SenhaUsuario='" + SenhaUsuario + "' AND StatusUsuario = 1";
                SqlDataReader dr;
                dr = c.RetornarDataReader(instrucaoSql);
                dr.Read();
                if (dr.HasRows)
                {
                    CodigoUsuario = Convert.ToInt32(dr["CodigoUsuario"]);
                     return Convert.ToInt32(dr["CodigoUsuario"]);
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
