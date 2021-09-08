using Dapper;
using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BruxoBiblioteca.Models
{
    public class Produto
    {
        /// <summary>
        /// Identificador unico do produto (já auto incrementado pelo firebird)
        /// </summary>
        public int ID_PRODUTO { get; set; }

        /// <summary>
        /// Nome do produto
        /// </summary>
        public string NOME { get; set; }

        /// <summary>
        /// Codigo do produto, será utilizado para chamar o produto na tela de venda
        /// </summary>
        public int CODIGO{ get; set; }


        /// <summary>
        /// Estoque do produto
        /// </summary>
        public decimal ESTOQUE { get; set; }

        /// <summary>
        /// Preço de venda do produto
        /// </summary>
        public decimal PRECOVENDA { get; set; }

        public Produto(int iD_PRODUTO = 0, string nOME = "", int cODIGO = 0, decimal eSTOQUE = 0, decimal pRECOVENDA = 0)
        {
            ID_PRODUTO = iD_PRODUTO;
            NOME = nOME;
            CODIGO = cODIGO;
            ESTOQUE = eSTOQUE;
            PRECOVENDA = pRECOVENDA;
        }
    }

}
