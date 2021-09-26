using Newtonsoft.Json;

namespace BruxoBiblioteca.NovasTelas.Models
{
    public class NovasTelasConfig
    {
        public bool NovoFluxoFaturamento { get; set; }

        public bool ModificaQuantidade { get; set; }

        public NovasTelasConfig(bool novoFluxoFaturamento, bool modificaQuantidade)
        {
            NovoFluxoFaturamento = novoFluxoFaturamento;
            ModificaQuantidade = modificaQuantidade;
        }
    }
}
