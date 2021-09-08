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
    public class Usuario
    {
        /// <summary>
        /// Identificador unico do produto (já auto incrementado pelo firebird)
        /// </summary>
        public int ID_USUARIO { get; set; }

        /// <summary>
        /// Nome do usuario
        /// </summary>
        public string NOME { get; set; }

        /// <summary>
        /// Senha que será utilizada para entrar no sistema
        /// </summary>
        public string SENHA { get; set; }        
    }

}
