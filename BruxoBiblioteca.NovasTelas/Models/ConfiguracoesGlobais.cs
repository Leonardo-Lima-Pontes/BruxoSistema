using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BruxoBiblioteca.NovasTelas.Models
{
    public static class ConfiguracoesGlobais
    {
        public static class NovasTelas
        {
            public static bool NovaTelaVenda { get; set; }

            public static bool NovaTelaCadastroProduto { get; set; }

            public static bool NovaTelaCadastroFormaPagamento { get; set; }

            public static bool NovaTelaCadastroUsuario { get; set; }

            public static bool NovaTelaConsultaProdutoVenda { get; set; }

            public static bool NovaTelaFaturamento { get; set; }

            public static bool NovaTelaInicial { get; set; }
        }
    }
}
