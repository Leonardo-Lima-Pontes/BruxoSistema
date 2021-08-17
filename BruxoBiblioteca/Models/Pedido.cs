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
    public class Pedido
    {
        /// <summary>
        /// Identificador unico do pedido (já auto incrementado pelo firebird)
        /// </summary>
        public int ID_PEDIDO { get; set; }

        /// <summary>
        /// Valor total do pedido
        /// </summary>
        public decimal VALORPEDIDO { get; set; }

        /// <summary>
        /// Nome do usuario logado no sistema que efetivou a venda
        /// </summary>
        public Usuario USUARIO_ID { get; set; }

        /// <summary>
        /// Qual a forma de pagamento utilizada nesta Venda
        /// </summary>
        public FormaPagamento FORMAPAMENTO_ID { get; set; }

        /// <summary>
        /// Todos produtos que foram vendido nesta venda
        /// </summary>
        public List<PedidoProduto> PRODUTOSVENDIDOS { get; set; }

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

                    foreach (PedidoProduto pedidoProduto in pedidoFinalizado.PRODUTOSVENDIDOS)
                    {
                        DynamicParameters parametrosPedidoProduto = new DynamicParameters();

                        parametrosPedidoProduto.Add("@QUANTIDADE", pedidoProduto.QUANTIDADE);
                        parametrosPedidoProduto.Add("@VALOR", pedidoProduto.VALOR);
                        parametrosPedidoProduto.Add("@PEDIDO_ID", pedidoFinalizado.ID_PEDIDO);
                        parametrosPedidoProduto.Add("@PRODUTO_ID", pedidoProduto.PRODUTO_ID);

                        linhasAfetadas = conexao.Execute("insert into pedido_produto (quantidade, valor, pedido_id, produto_id) values (@QUANTIDADE, @VALOR, @PEDIDO_ID, @PRODUTO_ID)", parametrosPedidoProduto, transaction: transaction);
                    }

                    transaction.Commit();
                }
            }
        }
    }
}
