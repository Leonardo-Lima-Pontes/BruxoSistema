using System.Collections.Generic;
using BruxoBiblioteca.NovasTelas.Models;

namespace BruxoBiblioteca.NovasTelas.Faturamento
{
    public class FaturamentoController
    {
        public static List<FormaPagamento> SelecionarFormasDePagamentoHabilitadas()
        {
            return FaturamentoDao.SelecionarFormasDePagamentoHabilitadas();
        }
    }
}
