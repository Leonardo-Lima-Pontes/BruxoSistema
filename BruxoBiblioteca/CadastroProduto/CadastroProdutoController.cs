using BruxoBiblioteca.Models;

namespace BruxoBiblioteca.CadastroProduto
{
    public class CadastroProdutoController
    {
        public static bool ValidarProduto(string nome, string codigo, string estoque, string precoVenda)
        {
            if (string.IsNullOrWhiteSpace(nome)
                || string.IsNullOrWhiteSpace(codigo)
                || string.IsNullOrWhiteSpace(estoque)
                || string.IsNullOrWhiteSpace(precoVenda))
                return false;

            bool validaCodigo = int.TryParse(codigo, out int resultadoCodigo);
            bool validaEstoque = decimal.TryParse(estoque, out decimal resultadoEstoque);
            bool validaPrecoVenda = decimal.TryParse(precoVenda, out decimal resultadoPrecoVenda);

            if (validaCodigo == false
                || validaEstoque == false
                || validaPrecoVenda == false)
                return false;

            return true;
        }

        public static void InserirNovoProduto(string nome, string codigo, string estoque, string precoVenda)
        {
            Produto novoProduto = new Produto();
            novoProduto.NOME = nome;
            novoProduto.CODIGO = int.Parse(codigo);
            novoProduto.ESTOQUE = decimal.Parse(estoque);
            novoProduto.PRECOVENDA = decimal.Parse(precoVenda);

            CadastroProdutoDao.InserirNovProduto(novoProduto);
        }
    }
}
