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
    public static class PDVDao
    {
        /// <summary>
        /// Método para retornar produto para inserir na venda
        /// </summary>
        /// <param name="usuario">Objeto usuario a ser passado para inserção no banco de dados</param>
        public static List<Produto> SelecionarProdutoVenda(int codigoProduto)
        {
            List<Produto> produtos;

            using (IDbConnection conexao = new FbConnection(ConfigurationManager.ConnectionStrings["Banco"].ConnectionString))
            {
                produtos = conexao.Query<Produto>("SELECT * FROM produto WHERE codigo = @CODIGO", new { CODIGO = codigoProduto }).ToList();
            };

            return produtos;
        }
    }
}
