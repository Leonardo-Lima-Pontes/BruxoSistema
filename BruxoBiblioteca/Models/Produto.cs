using Dapper;
using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BruxoBiblioteca.Models
{
    public class Produto
    {
        /// <summary>
        /// Identificador unico do produto (já auto incrementado pelo firebird)
        /// </summary>
        public int ID_PRODUTO { get; set; }

        /// <summary>
        /// Nome do produto
        /// </summary>
        public string NOME { get; set; }

        /// <summary>
        /// Codigo do produto, será utilizado para chamar o produto na tela de venda
        /// </summary>
        public int CODIGO{ get; set; }


        /// <summary>
        /// Estoque do produto
        /// </summary>
        public decimal ESTOQUE { get; set; }

        /// <summary>
        /// Preço de venda do produto
        /// </summary>
        public decimal PRECOVENDA { get; set; }

        /// <summary>
        /// Método para inserir um novo usuario
        /// </summary>
        /// <param name="usuario">Objeto usuario a ser passado para inserção no banco de dados</param>
        public static void InserirNovoProduto(Produto produto)
        {
            using (IDbConnection conexao = new FbConnection(ConfigurationManager.ConnectionStrings["Banco"].ConnectionString))
            {
                var resultado = conexao.Execute("insert into produto (nome, codigo, estoque, precovenda) values (@NOME, @CODIGO, @ESTOQUE, @PRECOVENDA)", produto);
            };
        }

        /// <summary>
        /// Método para retornar produto para inserir na venda
        /// </summary>
        /// <param name="usuario">Objeto usuario a ser passado para inserção no banco de dados</param>
        public static List<Produto> SelecionarProdutoVenda(int codigoProduto)
        {
            List<Produto> produtos;

            using (IDbConnection conexao = new FbConnection(ConfigurationManager.ConnectionStrings["Banco"].ConnectionString))
            {
                //produtos = conexao.Query<Produto>("select * from produto p where p.codigo = @CODIGO").ToList();
                produtos = conexao.Query<Produto>("SELECT * FROM produto WHERE codigo = @CODIGO", new { CODIGO = codigoProduto }).ToList();
            };

            return produtos;
        }
    }

}
