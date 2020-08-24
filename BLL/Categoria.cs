using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace BLL
{
    public class Categoria
    {
        DAO.ClasseParaManipularBancoDeDados c = new DAO.ClasseParaManipularBancoDeDados();


        public static string SQL;
        private int _CodigoCategoria;
        private string _Descricao;
        private byte _StatusCategoria;

        public int CodigoCategoria
        {
            get
            {
                return _CodigoCategoria;
            }

            set
            {
                _CodigoCategoria = value;
            }
        }

        public string Descricao
        {
            get
            {
                return _Descricao;
            }

            set
            {
                _Descricao = value;
            }
        }

        public byte StatusCategoria
        {
            get
            {
                return _StatusCategoria;
            }

            set
            {
                _StatusCategoria = value;
            }
        }

        public void IncluirComParametro()
        {
            DAO.ClasseParaManipularBancoDeDados c = new DAO.ClasseParaManipularBancoDeDados();

             
            try
            {
                SqlParameter[] listaComParametro =
                {
                    new SqlParameter("@Descricao",SqlDbType.VarChar) {Value = Descricao },
                    new SqlParameter("@StatusCategoria",SqlDbType.VarChar) {Value = StatusCategoria }
                };
                //Criar o Objeto 'listarComParametro' a partir da classe 'SqlParameter' definida como uma lista'[]'. Foi instanciado 'new' o objeto 'listaComParametros' com 4 itens/parametros. Cada parametro foi definido com a identificação '@.....' + um tipo de dado' SqlDbType' + um valor '{Value = _....}'
                SQL = "INSERT INTO tbCategoria (Descricao, StatusCategoria) Values (@Descricao, @StatusCategoria)";
                c.ExecutarComandoParametro(SQL, listaComParametro);


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
                SqlParameter[] listaComParametros = { new SqlParameter("@CategoriaID",SqlDbType.Int) {Value = _CodigoCategoria },
                    new SqlParameter("@Descricao",SqlDbType.VarChar) {Value = _Descricao },
                    new SqlParameter("@StatusCategoria",SqlDbType.VarChar) {Value = _StatusCategoria }
                };
                SQL = "UPDATE tbCategoria SET Descricao =@Descricao, StatusCategoria=@StatusCategoria WHERE CategoriaID=@CategoriaID";
                c.ExecutarComandoParametro(SQL, listaComParametros);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Ativar(Byte Valor)
        { //Valor 1 = Reativar    Valor 0 = Desativar
            try
            {
                SQL = "UPDATE TBCATEGORIA SET StatusCategoria = '" + Valor + "' WHERE CATEGORIAID = " + _CodigoCategoria + " ";
                c.ExecutarComando(SQL);

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
                SQL = "DELETE FROM TBCATEGORIA WHERE CATEGORIAID = " + _CodigoCategoria + " ";
                c.ExecutarComando(SQL);

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
                SQL = "SELECT * FROM TBCATEGORIA WHERE CODIGOCATEGORIA = " + _CodigoCategoria + " ";
                return c.RetornarDataReader(SQL);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet Listar(string texto)
        {
            SQL = "SELECT CategoriaID, Descricao FROM TbCategoria ORDER BY Descricao";
            if (texto.Length != 0) // texto == null || texto == ""
            {
                SQL = "SELECT CategoriaID, DESCRICAO FROM TBCATEGORIA WHERE DESCRICAO LIKE '%" + texto + "%' ORDER BY DESCRICAO";
            }
            return c.RetornarDataSet(SQL);
        }



    }
}
