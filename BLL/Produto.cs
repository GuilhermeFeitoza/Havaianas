using System;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class Produto
    {
        private static string SQL;
        DAO.ClasseParaManipularBancoDeDados c = new DAO.ClasseParaManipularBancoDeDados();

        private int _CodigoProduto;
        private int _Quantidade;
        public int CodigoProduto
        {
            get { return _CodigoProduto; }
            set { _CodigoProduto = value; }
        }
        private int _CodigoCategoria;

        public int CodigoCategoria
        {
            get { return _CodigoCategoria; }
            set { _CodigoCategoria = value; }
        }

        private string _NomeProduto;

        public string NomeProduto
        {
            get { return _NomeProduto; }
            set { _NomeProduto = value; }
        }

        private int _StatusProduto;

        public int StatusProduto
        {
            get { return _StatusProduto; }
            set { _StatusProduto = value; }
        }

        public double PrecoProduto
        {
            get { return _PrecoProduto; }
            set { _PrecoProduto = value; }
        }

        public string FotoProduto
        {
            get { return _FotoProduto; }
            set { _FotoProduto = value; }
        }

        public string Tamanho
        {
            get { return _Tamanho; }
            set { _Tamanho = value; }
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

        private string _Tamanho;
        private double _PrecoProduto;

        private string _FotoProduto;

        public void IncluirComParametro()
        {
            try
            {
                SqlParameter[] listaComParametros = {
                   new SqlParameter("@NomeProduto",SqlDbType.VarChar) {Value = _NomeProduto },
                   new SqlParameter("@StatusProduto",SqlDbType.Int) {Value = _StatusProduto }
                   ,
                   new SqlParameter("@Tamanho",SqlDbType.VarChar) {Value = _Tamanho }
                   ,
                   new SqlParameter("@CodigoCategoria",SqlDbType.Int) {Value = _CodigoCategoria },


                   new SqlParameter("@PrecoProduto",SqlDbType.Decimal) {Value = _PrecoProduto },
                   new SqlParameter("@FotoDoProduto",SqlDbType.VarChar) {Value = _FotoProduto }

                };

                SQL = "INSERT INTO tbProduto (NomeProduto,  StatusProduto, Tamanho, CategoriaID,PrecoProduto,FotoDoProduto) VALUES (@NomeProduto,  @StatusProduto, @Tamanho, @CodigoCategoria,@PrecoProduto, @FotoDoProduto)";
                c.ExecutarComandoParametro(SQL, listaComParametros);
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
                     new SqlParameter("@CodigoProduto",SqlDbType.Int) {Value = _CodigoProduto },

                   new SqlParameter("@CodigoCategoria",SqlDbType.Int) {Value = _CodigoCategoria },
                   new SqlParameter("@StatusProduto",SqlDbType.Int) {Value = _StatusProduto }
                   ,
                   new SqlParameter("@NomeProduto",SqlDbType.VarChar) {Value = _NomeProduto },
                   new SqlParameter("@Tamanho",SqlDbType.Int) {Value = _Tamanho },
                   new SqlParameter("@FotoDoProduto",SqlDbType.VarChar) {Value = _FotoProduto },
                   new SqlParameter("@PrecoProduto",SqlDbType.Decimal) {Value = _PrecoProduto }

                };

                SQL = "UPDATE tbProduto SET CategoriaID=@CodigoCategoria, StatusProduto=@StatusProduto, NomeProduto=@NomeProduto,  Tamanho=@Tamanho,FotoDoProduto=@FotoDoProduto, PrecoProduto=@PrecoProduto WHERE CodigoProduto=@CodigoProduto";
                c.ExecutarComandoParametro(SQL, listaComParametros);



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
                SQL = "UPDATE TBPRODUTO SET StatusProduto = 0  WHERE CodigoProduto=" + _CodigoProduto;
                c.ExecutarComando(SQL);
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
                SQL = "UPDATE TBPRODUTO SET StatusProduto =1   WHERE CodigoProduto=" + _CodigoProduto;
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
                SQL = "DELETE FROM TBPRODUTO WHERE CodigoProduto = " + _CodigoProduto + " ";
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
                SQL = "SELECT * FROM TBPRODUTO WHERE CodigoProduto = " + _CodigoProduto + " ";
                return c.RetornarDataReader(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet Listar(string parteNome)
        {
            try
            {
                SQL = "SELECT * FROM tbProduto";

                if (parteNome.Length != 0)
                {
                    if (BLL.FuncoesGerais.IsNumeric(parteNome))
                    {
                        _CodigoProduto = Convert.ToInt32(parteNome);
                        SQL = "SELECT * FROM tbProduto WHERE CodigoProduto =" + _CodigoProduto;
                    }
                    else
                    {
                        SQL = SQL + " WHERE NomeProduto LIKE '%" + parteNome + "%'"; //avisado sobre comportamento
                    }
                }

                return c.RetornarDataSet(SQL);

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
                SQL = "SELECT CodigoProduto, NomeProduto, StatusProduto FROM tbProduto WHERE StatusProduto= 1 ORDER BY NomeProduto";
                return c.RetornarDataSet(SQL);
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
                SQL = "SELECT CodigoProduto, NomeProduto, StatusProduto FROM tbProduto WHERE StatusProduto= 0 ORDER BY NomeProduto";
                return c.RetornarDataSet(SQL);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataSet ObterSituacaoEstoque()
        {
            try
            {

                SQL = "SELECT CodigoProduto, NomeProduto, QuantEstoque, (100-(QuantMaximaEstoque-QuantEstoque)*100/QuantMaximaEstoque) As PercMaximo FROM tbProduto";

                return c.RetornarDataSet(SQL);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public SqlDataReader ListarProdComQuant(int Codigo, byte tipostatus)
        {


            SQL = "SELECT CodigoProduto,NomeProduto,PrecoProduto FROM tbProduto where CodigoProduto = " + Codigo;
            return c.RetornarDataReader(SQL);



        }

        public int RetornarProduto()
        {
            try
            {
                SQL = "Select max(CodigoProduto)from tbProduto";
                return c.RetornarExecuteScalar(SQL);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void NovoEstoque()
        {

            try
            {
                SqlParameter[] listaComParametros = {
                   new SqlParameter("@CodigoProduto",SqlDbType.Int) {Value = RetornarProduto() },
                   new SqlParameter("@Quantidade",SqlDbType.Int) {Value = Quantidade }


                };

                SQL = "INSERT INTO tbEstoque (CodigoProduto, QuantidadeAtual) VALUES (@CodigoProduto, @Quantidade)";
                c.ExecutarComandoParametro(SQL, listaComParametros);
            }
            catch (Exception ex)
            {

                throw ex;
            }





        }
        public DataSet ListarProdDisponiveis() {

            try
            {
                SQL = "Select*from tbProduto inner join tbEstoque ON tbProduto.CodigoProduto = tbEstoque.CodigoProduto Where tbEstoque.QuantidadeAtual > 0";
               return c.RetornarDataSet(SQL);
            }
            catch (Exception ex)
            {

                throw ex;
            }




        }
    }
}
