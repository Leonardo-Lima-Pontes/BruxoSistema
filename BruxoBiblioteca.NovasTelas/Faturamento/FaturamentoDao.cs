using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using BruxoBiblioteca.NovasTelas.Models;
using Dapper;
using FirebirdSql.Data.FirebirdClient;

namespace BruxoBiblioteca.NovasTelas.Faturamento
{
    class FaturamentoDao
    {
        internal static List<FormaPagamento> SelecionarFormasDePagamentoHabilitadas()
        {
            List<FormaPagamento> formas;

            using (IDbConnection conexao = new FbConnection(ConfigurationManager.ConnectionStrings["Banco"].ConnectionString))
            {
                //produtos = conexao.Query<Produto>("select * from produto p where p.codigo = @CODIGO").ToList();
                formas = conexao.Query<FormaPagamento>("SELECT FIRST 9 * FROM forma_pagamento WHERE desabilitado = 'N'").ToList();
            };

            return formas;
        }
    }
}

