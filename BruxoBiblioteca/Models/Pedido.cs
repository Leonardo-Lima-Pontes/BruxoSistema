using System.Collections.Generic;

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
    }
}
