using System.Collections.Generic;
using BruxoBiblioteca.Models;

namespace BruxoBiblioteca.PDV
{
    public static class PdvController
    {
        public static List<Produto> SelecionarProdutosVenda(int codigoProduto)
        {
            var produtos = PDVDao.SelecionarProdutoVenda(codigoProduto);

            return produtos;
        }

        public static bool ValidarEntradaUsuario(string entradaUsuario)
        {
            if (string.IsNullOrEmpty(entradaUsuario))
                return true;

            var validaCodigo = int.TryParse(entradaUsuario, out _);
            return validaCodigo;
        }

        public static decimal RecalcularPrecoTotalVendaProduto(decimal novoValorUnitario, decimal novaQuantidade)
        {
            return novoValorUnitario * novaQuantidade;
        }

        public static bool ValidarProdutoParaVenda(Produto produtoParaVenda)
        {
            return produtoParaVenda.CODIGO != 0
                   && produtoParaVenda.ID_PRODUTO != 0 
                   && produtoParaVenda.NOME != null
                   && produtoParaVenda.PRECOVENDA != 0;
        }

        public static bool ValidarUsuario(Usuario usuario)
        {
            return usuario.ID_USUARIO != 0 && !string.IsNullOrWhiteSpace(usuario.NOME);
        }

        public static bool ValidarPedidoProduto(PedidoProduto produtoDaVenda)
        {
            return produtoDaVenda.QUANTIDADE != 0 && produtoDaVenda.PRODUTO_ID != 0 && produtoDaVenda.VALOR != 0;
        }

        public static bool ValidarPedido(Pedido pedidoFinalizado)
        {
            return pedidoFinalizado.VALORPEDIDO != 0;
        }

        public static void InserirNovoPedido(Pedido pedidoFinalizado)
        {
            PDVDao.InserirNovoPedido(pedidoFinalizado);
        }
    }
}
