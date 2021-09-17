using System.Collections.Generic;
using BruxoBiblioteca.Models;

namespace BruxoBiblioteca.Faturamento
{
    public class FaturamentoController
    {
        public static List<FormaPagamento> SelecionarFormasDePagamentoHabilitadas()
        {
            return FaturamentoDao.SelecionarFormasDePagamentoHabilitadas();
        }
    }
}
