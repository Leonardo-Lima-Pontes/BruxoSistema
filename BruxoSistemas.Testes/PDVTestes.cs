using System;
using Xunit;
using BruxoBiblioteca.Controllers;
using BruxoBiblioteca.Models;

namespace BruxoSistemas.Testes
{
    public class PDVTestes
    {
        [Theory]
        [InlineData("", true)]
        [InlineData("c", false)]
        [InlineData("cd", false)]
        [InlineData("1", true)]
        [InlineData("0", true)]
        [InlineData(" ", false)]
        public void ValidarEntradaUsuario_ConsultaProdutoId_RetornaBool(string entradaUsuario, bool valorEsperado)
        {
            bool entradaUsuarioValida = PDVController.ValidarEntradaUsuario(entradaUsuario);

            Assert.Equal(valorEsperado, entradaUsuarioValida);
        }

        [Theory]
        [InlineData(1.060, 1.45, 1.537)]
        [InlineData(2, 27.75, 55.5)]
        [InlineData(2, 8, 16)]
        public void RecalcularPrecoTotalVendaProduto_ValorTotalProduto_RetornaDecimal(decimal novoValorUnitario, 
            decimal novaQuantidade, 
            decimal valorEsperado)
        {
            decimal precoTotalProduto = PDVController.RecalcularPrecoTotalVendaProduto(novoValorUnitario, novaQuantidade);

            Assert.Equal(valorEsperado, precoTotalProduto);
            Assert.True(precoTotalProduto > 0);
        }

        [Fact]
        public void ValidarProdutoParaVenda_Produto_RetornaBool()
        {
            Produto produto = new Produto();
            produto.CODIGO = 1;
            produto.ID_PRODUTO = 1;
            produto.NOME = "Bolhacha";
            produto.PRECOVENDA = 15.78m;

            bool valorEsperado = true;

            bool validaProduto = PDVController.ValidarProdutoParaVenda(produto);

            Assert.Equal(validaProduto, valorEsperado);
        }

        [Fact]
        public void ValidarUsuario_Usuario_RetornaBool()
        {
            Usuario usuario = new Usuario();
            usuario.ID_USUARIO = 1;
            usuario.NOME = "Leonardo";

            bool valorEsperado = true;

            bool validaUsuario = PDVController.ValidarUsuario(usuario);

            Assert.Equal(validaUsuario, valorEsperado);
        }

        [Fact]
        public void ValidarPedidoProduto_ProdutoDoPedido__RetornaBool()
        {
            PedidoProduto pedidoProduto = new PedidoProduto();
            pedidoProduto.QUANTIDADE = 2;
            pedidoProduto.PRODUTO_ID = 2;
            pedidoProduto.VALOR = 89.56m;

            bool valorEsperado = true;

            bool validaPedidoProduto = PDVController.ValidarPedidoProduto(pedidoProduto);

            Assert.Equal(validaPedidoProduto, valorEsperado);
        }

        [Fact]
        public void ValidarPedido_ValidarPedido__RetornaBool()
        {
            Pedido pedido = new Pedido();
            pedido.VALORPEDIDO = 58.78m;

            bool valorEsperado = true;

            bool validaPedido = PDVController.ValidarPedido(pedido);

            Assert.Equal(validaPedido, valorEsperado);
        }


    }
}
