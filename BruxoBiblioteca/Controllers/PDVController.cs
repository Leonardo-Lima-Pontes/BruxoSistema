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
            if (string.IsNullOrWhiteSpace(entradaUsuario))
            {
                return true;
            }

            bool validaCodigo = int.TryParse(entradaUsuario, out int codigoProduto);
            if (validaCodigo)
            {
                return true;
            }

            return false;
        }
    }
}
