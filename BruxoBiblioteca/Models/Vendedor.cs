using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BruxoBiblioteca.Models
{
    public class Vendedor
    {
        /// <summary>
        /// Identificador unico do vendedor (já auto incrementado pelo firebird)
        /// </summary>
        public int ID_VENDEDOR { get; set; }

        /// <summary>
        /// Nome do vendedor, as vendas terão um vendedor no caso este nome
        /// </summary>
        public string NOME { get; set; }
    }
}
