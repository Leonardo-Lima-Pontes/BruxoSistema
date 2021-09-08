using BruxoBiblioteca.DAO;
using BruxoBiblioteca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BruxoBiblioteca.Controllers
{
    public class CadastroFormaPagamentoController
    {
        public static bool ValidarFormaPagamento(string nome, char desabilitado)
        {
            if (string.IsNullOrWhiteSpace(nome) || char.IsWhiteSpace(desabilitado))
                return false;

            return true;
        }

        public static void InserirNovaFormaPagamento(string nome, char desabilitado)
        {
            FormaPagamento formaPagamento = new FormaPagamento();
            formaPagamento.NOME = nome;
            formaPagamento.DESABILITADO = desabilitado;

            CadastroFormaPagamentoDao.InserirNovaFormaPagamento(formaPagamento);
        }
    }
}
