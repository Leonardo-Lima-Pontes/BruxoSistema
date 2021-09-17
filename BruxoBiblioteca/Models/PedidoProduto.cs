namespace BruxoBiblioteca.Models
{
    public class PedidoProduto
    {
        /// <summary>
        /// Identificador unico do produto (já auto incrementado pelo firebird)
        /// </summary>
        public int ID_PEDIDOPRODUTO { get; set; }

        /// <summary>
        /// Quantidade que este pedido teve deste produto
        /// </summary>
        public decimal QUANTIDADE { get; set; }

        /// <summary>
        /// Valor do produto que foi vendido nesta venda
        /// </summary>
        public decimal VALOR { get; set; }

        /// <summary>
        /// Produto que este pedidoproduto contem
        /// </summary>
        public int PRODUTO_ID { get; set; } //retirei o Produto como tipo (aninhado ver qual é a melhor forma)

    }
}
