using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class Titulo
    {
        private int _CodigoTitulo;
        private string _DescricaoTitulo;
        private byte _StatusTitulo;

        DAO.ClasseParaManipularBancoDeDados c = new DAO.ClasseParaManipularBancoDeDados();

        public string instrucaoSql;

        public int CodigoTitulo
        {
            get
            {
                return _CodigoTitulo;
            }

            set
            {
                _CodigoTitulo = value;
            }
        }

        public string DescricaoTitulo
        {
            get
            {
                return _DescricaoTitulo;
            }

            set
            {
                _DescricaoTitulo = value;
            }
        }

        public byte StatusTitulo
        {
            get
            {
                return _StatusTitulo;
            }

            set
            {
                _StatusTitulo = value;
            }
        }


        public void Incluir()
        {
            try
            {
                SqlParameter[] listaComParametros = {
                   new SqlParameter("@DescricaoTitulo",SqlDbType.VarChar) {Value = DescricaoTitulo },
                   new SqlParameter("@StatusTitulo",SqlDbType.Bit) {Value = StatusTitulo }
                };
                instrucaoSql = "INSERT INTO tbTipoTitulo (DescricaoTitulo, StatusTitulo) VALUES (@DescricaoTitulo, @StatusTitulo)";
                c.ExecutarComandoParametro(instrucaoSql, listaComParametros);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Atualizar()
        {
            try
            {
                //pin não é atualizado
                SqlParameter[] listaComParametros = {
                   new SqlParameter("@CodigoTitulo",SqlDbType.Int) {Value = CodigoTitulo },
                   new SqlParameter("@DescricaoTitulo",SqlDbType.VarChar) {Value = DescricaoTitulo },
                   new SqlParameter("@StatusTitulo",SqlDbType.Bit) {Value = StatusTitulo }
                };


                instrucaoSql = "UPDATE tbTipoTitulo SET DescricaoTitulo=@DescricaoTitulo, StatusTitulo=@StatusTitulo WHERE CodigoTitulo=@CodigoTitulo";
                c.ExecutarComandoParametro(instrucaoSql, listaComParametros);

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
                SqlParameter[] listaComParametros = {new SqlParameter("@CodigoTitulo",SqlDbType.Int) {Value = CodigoTitulo }
                };
                instrucaoSql = "DELETE FROM tbTipoTitulo WHERE CodigoTitulo=@CodigoTitulo";
                c.ExecutarComandoParametro(instrucaoSql, listaComParametros);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ModificarStatus(byte novostatus)
        {
            try
            {
                SqlParameter[] listaComParametros = {
                   new SqlParameter("@CodigoTitulo",SqlDbType.Int) {Value = CodigoTitulo },
                   new SqlParameter("@StatusTitulo",SqlDbType.Bit) {Value = novostatus }
                };
                instrucaoSql = "UPDATE tbTipoTitulo SET StatusTitulo=@StatusTitulo WHERE CodigoTitulo=@CodigoTitulo";
                c.ExecutarComandoParametro(instrucaoSql, listaComParametros);
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
                SqlParameter[] listaComParametros = {new SqlParameter("@CodigoTitulo",SqlDbType.Int) {Value = CodigoTitulo }
                };
                instrucaoSql = "SELECT * FROM tbTipoTitulo WHERE CodigoTitulo=" + CodigoTitulo;
                return c.RetornarDataReader(instrucaoSql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet Listar(string parteNomeUsuario, byte tipoStatus)
        {
            try
            {
                instrucaoSql = "SELECT CodigoTitulo, DescricaoTitulo, StatusTitulo FROM tbTipoTitulo";
                if (parteNomeUsuario.Length != 0)
                {
                    instrucaoSql = instrucaoSql + " WHERE DescricaoTitulo LIKE '%" + parteNomeUsuario + "%'";
                }
                return c.RetornarDataSet(instrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }







    }
}
