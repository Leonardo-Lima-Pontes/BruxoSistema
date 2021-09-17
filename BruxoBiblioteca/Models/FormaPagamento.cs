namespace BruxoBiblioteca.Models
{
    public class FormaPagamento
    {
        /// <summary>
        /// Identificador unico de pagamento (já auto incrementado pelo firebird)
        /// </summary>
        public int ID_FORMAPAGAMENTO { get; set; }

        /// <summary>
        /// Noma da forma de pagamento, constara na tela de venda e no historico de venda
        /// </summary>
        public string NOME { get; set; }

        /// <summary>
        /// Este campo determina se a forma de pagamento está habilitada nas vendas ou não
        /// </summary>
        public char DESABILITADO { get; set; }
    }
}
