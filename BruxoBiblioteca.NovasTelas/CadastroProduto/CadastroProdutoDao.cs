using System.Configuration;
using System.Data;
using BruxoBiblioteca.NovasTelas.Models;
using Dapper;
using FirebirdSql.Data.FirebirdClient;

namespace BruxoBiblioteca.NovasTelas.CadastroProduto
{
    class CadastroProdutoDao
    {
        /// <summary>
        /// Método para inserir um novo usuario
        /// </summary>
        /// <param name="usuario">Objeto usuario a ser passado para inserção no banco de dados</param>
        internal static void InserirNovProduto(Produto produto)
        {
                using (IDbConnection conexao = new FbConnection(ConfigurationManager.ConnectionStrings["Banco"].ConnectionString))
                {
                    var resultado = conexao.Execute("insert into produto (nome, codigo, estoque, precovenda) values (@NOME, @CODIGO, @ESTOQUE, @PRECOVENDA)", produto);
                };
        }
    }
}
