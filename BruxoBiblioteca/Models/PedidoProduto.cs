using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public double QUANTIDADE { get; set; }

        /// <summary>
        /// Valor do produto que foi vendido nesta venda
        /// </summary>
        public double VALOR { get; set; }

        /// <summary>
        /// Produto que este pedidoproduto contem
        /// </summary>
        public Produto PRODUTO_ID { get; set; }

    }
}
