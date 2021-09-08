using BruxoBiblioteca.DAO;
using BruxoBiblioteca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BruxoBiblioteca.Controllers
{
    public class FaturamentoController
    {
        public static List<FormaPagamento> SelecionarFormasDePagamentoHabilitadas()
        {
            return FaturamentoDao.SelecionarFormasDePagamentoHabilitadas();
        }
    }
}
