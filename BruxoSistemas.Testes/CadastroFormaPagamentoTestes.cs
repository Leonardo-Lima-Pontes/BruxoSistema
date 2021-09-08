using BruxoBiblioteca.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BruxoSistema.Testes
{
    public class CadastroFormaPagamentoTestes
    {
        [Fact]
        public void ValidarFormaPagamento_VerificarSeOsCamposDeFormaPagamentoEstaoCorretas_RetornaBool()
        {
            bool primeiraFormaPagamentoValida = CadastroFormaPagamentoController.ValidarFormaPagamento("Bolacha de agua e Sal", 'S');
            bool segundaFormaPagamentoValida = CadastroFormaPagamentoController.ValidarFormaPagamento("", 'N');

            bool valorEsperadoPrimeiroForma = true;
            bool valorEsperadoSegundoForma = false;

            Assert.Equal(valorEsperadoPrimeiroForma, primeiraFormaPagamentoValida);
            Assert.Equal(valorEsperadoSegundoForma, segundaFormaPagamentoValida);
        }
    }
}
