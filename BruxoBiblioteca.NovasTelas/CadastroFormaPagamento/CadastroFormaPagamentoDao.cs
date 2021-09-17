using System.Configuration;
using System.Data;
using Dapper;
using FirebirdSql.Data.FirebirdClient;

namespace BruxoBiblioteca.NovasTelas.CadastroFormaPagamento
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
