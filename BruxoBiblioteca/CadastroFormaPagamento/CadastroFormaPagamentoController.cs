using BruxoBiblioteca.Models;

namespace BruxoBiblioteca.CadastroFormaPagamento
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
