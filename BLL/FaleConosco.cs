using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BLL
{
   public class FaleConosco
    {
        public static string instrucaosql;
        DAO.ClasseParaManipularBancoDeDados c = new DAO.ClasseParaManipularBancoDeDados();
        private int _CodigoMensagem;
        private string _Nome;
        private string _Email;
        private string _Assunto;
        private string _Mensagem;
        private byte _StatusMensagem;

        public int CodigoMensagem
        {
            get
            {
                return _CodigoMensagem;
            }

            set
            {
                _CodigoMensagem = value;
            }
        }

        public string Nome
        {
            get
            {
                return _Nome;
            }

            set
            {
                _Nome = value;
            }
        }

        public string Email
        {
            get
            {
                return _Email;
            }

            set
            {
                _Email = value;
            }
        }

        public string Assunto
        {
            get
            {
                return _Assunto;
            }

            set
            {
                _Assunto = value;
            }
        }

        public string Mensagem
        {
            get
            {
                return _Mensagem;
            }

            set
            {
                _Mensagem = value;
            }
        }

        public byte StatusMensagem
        {
            get
            {
                return _StatusMensagem;
            }

            set
            {
                _StatusMensagem = value;
            }
        }

        public DateTime Data
        {
            get
            {
                return _Data;
            }

            set
            {
                _Data = value;
            }
        }

        public string Resposta { get => _Resposta; set => _Resposta = value; }

        private DateTime _Data;
        private string _Resposta;
        public DataSet ListarMensagens(string parteNome)
        {

            try
            {
                instrucaosql = "SELECT*FROM tbMensagem ";
                if (parteNome.Length != 0)
                {
                    instrucaosql= instrucaosql + " WHERE Assunto LIKE '%" + parteNome + "% ORDER BY Data ASC'"; //avisado sobre comportamento
                }


                return c.RetornarDataSet(instrucaosql);

              

            }
            catch ( Exception ex)
            {

                throw ex;
            }



        }

        public void Responder()
        {
            try
            {
                SqlParameter[] listaComParametro =
                 {
                    new SqlParameter("@CodigoMensagem",SqlDbType.Int) {Value = _CodigoMensagem },
                    new SqlParameter("@Resposta",SqlDbType.VarChar) {Value = _Resposta },
                    new SqlParameter("@StatusMensagem",SqlDbType.Bit){Value=_StatusMensagem }
                };
                instrucaosql = "UPDATE tbMensagem SET Resposta=@Resposta,StatusMensagem=@StatusMensagem WHERE CodigoMensagem="+_CodigoMensagem;
                c.ExecutarComandoParametro(instrucaosql, listaComParametro);
            }
            catch (Exception ex)
            {

                throw ex;
            }



        }

      }
}
