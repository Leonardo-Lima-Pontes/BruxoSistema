using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BruxoBiblioteca.NovasTelas.CadastroProduto;
using Xunit;

namespace BruxoSistema.Testes
{
    public class CadastroProdutoTestes
    {
        [Fact]
        public void ValidarProduto_VerificarCadaCampoDoProdutoParaValidalo_RetornaBool()
        {
            bool primeiroProdutoValido = CadastroProdutoController.ValidarProduto("Bolacha de agua e Sal", "15", "20", "19,99");
            bool segundoProdutoValido = CadastroProdutoController.ValidarProduto("Bolacha de agua e Sal", "15", "20", "c");

            bool valorEsperadoPrimeiroProduto = true;
            bool valorEsperadoSegundoProduto = false;

            Assert.Equal(valorEsperadoPrimeiroProduto, primeiroProdutoValido);
            Assert.Equal(valorEsperadoSegundoProduto, segundoProdutoValido);
        }
    }
}
