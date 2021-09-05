using BruxoBiblioteca.DAO;
using BruxoBiblioteca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BruxoBiblioteca.Controllers
{
    public static class PDVController
    {
        public static List<Produto> SelecionarProdutosVenda(int codigoProduto)
        {
            List<Produto> produtos = PDVDao.SelecionarProdutoVenda(codigoProduto);

            return produtos;
        }

        public static bool ValidarEntradaUsuario(string entradaUsuario)
        {
            if (string.IsNullOrEmpty(entradaUsuario))
                return true;

            bool validaCodigo = int.TryParse(entradaUsuario, out int codigoProduto);
            if (validaCodigo)
                return true;

            return false;
        }

        public static decimal RecalcularPrecoTotalVendaProduto(decimal novoValorUnitario, decimal novaQuantidade)
        {
            return novoValorUnitario * novaQuantidade;
        }

        public static bool ValidarProdutoParaVenda(Produto produtoParaVenda)
        {
            if (produtoParaVenda.CODIGO == 0 ||
                produtoParaVenda.ID_PRODUTO == 0 ||
                produtoParaVenda.NOME == null ||
                produtoParaVenda.PRECOVENDA == 0)
                return false;

            return true;
        }

        public static bool ValidarUsuario(Usuario usuario)
        {
            if (usuario.ID_USUARIO == 0 || string.IsNullOrWhiteSpace(usuario.NOME))
                return false;

            return true;
        }

        public static bool ValidarPedidoProduto(PedidoProduto produtoDaVenda)
        {
            if (produtoDaVenda.QUANTIDADE == 0 ||
                produtoDaVenda.PRODUTO_ID == 0 ||
                produtoDaVenda.VALOR == 0)
                return false;

            return true;
        }

        public static bool ValidarPedido(Pedido pedidoFinalizado)
        {
            if (pedidoFinalizado.VALORPEDIDO == 0)
                return false;

            return true;
        }

        public static void InserirNovoPedido(Pedido pedidoFinalizado)
        {
            PDVDao.InserirNovoPedido(pedidoFinalizado);
        }
    }
}
