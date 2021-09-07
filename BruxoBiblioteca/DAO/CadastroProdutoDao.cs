using BruxoBiblioteca.Models;
using Dapper;
using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BruxoBiblioteca.DAO
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
