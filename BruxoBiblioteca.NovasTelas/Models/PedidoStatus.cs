namespace BruxoBiblioteca.NovasTelas.Models
{
    class PedidoStatus
    {
        /// <summary>
        /// Identificador unico do estados do pedido (já auto incrementado pelo firebird)
        /// </summary>
        public int ID_PEDIDOSTATUS { get; set; }

        /// <summary>
        /// Este campo indicado o estatus do pedido se foi faturado cancelado etc
        /// </summary>
        public string NOME { get; set; }
    }
}
