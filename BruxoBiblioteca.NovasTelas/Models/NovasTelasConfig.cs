using Newtonsoft.Json;

namespace BruxoBiblioteca.NovasTelas.Models
{
    public class NovasTelasConfig
    {
        
        public bool NovaTelaVenda { get; set; }
        
        public bool NovaTelaCadastroProduto { get; set; }
        
        public bool NovaTelaCadastroFormaPagamento { get; set; }
        
        public bool NovaTelaCadastroUsuario { get; set; }
        
        public bool NovaTelaConsultaProdutoVenda { get; set; }
        
        public bool NovaTelaFaturamento { get; set; }

        public bool NovaTelaInicial { get; set; }

        public NovasTelasConfig(bool novaTelaVenda, bool novaTelaCadastroProduto, bool novaTelaCadastroFormaPagamento,
            bool novaTelaCadastroUsuario, bool novaTelaConsultaProdutoVenda, bool novaTelaFaturamento, bool novaTelaInicial)
        {
            NovaTelaVenda = novaTelaVenda;
            NovaTelaCadastroProduto = novaTelaCadastroProduto;
            NovaTelaCadastroFormaPagamento = novaTelaCadastroFormaPagamento;
            NovaTelaCadastroUsuario = novaTelaCadastroUsuario;
            NovaTelaConsultaProdutoVenda = novaTelaConsultaProdutoVenda;
            NovaTelaFaturamento = novaTelaFaturamento;
            NovaTelaInicial = novaTelaInicial;
        }
    }
}
