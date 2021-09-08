using Dapper;
using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BruxoBiblioteca.DAO
{
    class CadastroFormaPagamentoDao
    {
        internal static void InserirNovaFormaPagamento(Models.FormaPagamento formaPagamento)
        {
            using (IDbConnection conexao = new FbConnection(ConfigurationManager.ConnectionStrings["Banco"].ConnectionString))
            {
                var resultado = conexao.Execute("insert into forma_pagamento (nome, desabilitado) values (@NOME, @DESABILITADO)", formaPagamento);
            }
        }
    }
}
