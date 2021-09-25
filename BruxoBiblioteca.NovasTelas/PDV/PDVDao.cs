using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using BruxoBiblioteca.NovasTelas.Models;
using Dapper;
using FirebirdSql.Data.FirebirdClient;

namespace BruxoBiblioteca.NovasTelas.PDV
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

        public static void InserirNovoPedido(Pedido pedidoFinalizado)
        {
            using (IDbConnection conexao = new FbConnection(ConfigurationManager.ConnectionStrings["Banco"].ConnectionString))
            {
                conexao.Open();

                using (var transaction = conexao.BeginTransaction())
                {
                    DynamicParameters parametrosPedido = new DynamicParameters();

                    parametrosPedido.Add("@USUARIO_ID", pedidoFinalizado.USUARIO_ID.ID_USUARIO);
                    parametrosPedido.Add("@FORMAPAGAMENTO_ID", pedidoFinalizado.FORMAPAMENTO_ID.ID_FORMAPAGAMENTO);
                    parametrosPedido.Add("@VALORPEDIDO", pedidoFinalizado.VALORPEDIDO);
                    parametrosPedido.Add("@ID_PEDIDO", dbType: DbType.Int32, direction: ParameterDirection.Output);

                    var linhasAfetadas = conexao.Execute("insert into pedido (usuario_id, formapagamento_id, valorpedido) values (@USUARIO_ID, @FORMAPAGAMENTO_ID, @VALORPEDIDO) returning pedido.ID_PEDIDO", parametrosPedido, transaction: transaction);

                    pedidoFinalizado.ID_PEDIDO = parametrosPedido.Get<int>("@ID_PEDIDO");

                    foreach (Produto produto in pedidoFinalizado.PRODUTOS)
                    {
                        DynamicParameters parametrosPedidoProduto = new DynamicParameters();

                        parametrosPedidoProduto.Add("@QUANTIDADE", produto.QUANTIDADE);
                        parametrosPedidoProduto.Add("@VALOR", produto.VALORTOTAL);
                        parametrosPedidoProduto.Add("@PEDIDO_ID", pedidoFinalizado.ID_PEDIDO);
                        parametrosPedidoProduto.Add("@PRODUTO_ID", produto.ID_PRODUTO);

                        linhasAfetadas = conexao.Execute("insert into pedido_produto (quantidade, valor, pedido_id, produto_id) values (@QUANTIDADE, @VALOR, @PEDIDO_ID, @PRODUTO_ID)", parametrosPedidoProduto, transaction: transaction);
                    }

                    transaction.Commit();
                }
            }
        }
    }
}
