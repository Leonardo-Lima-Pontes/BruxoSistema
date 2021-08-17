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
    public class FormaPagamento
    {
        /// <summary>
        /// Identificador unico de pagamento (já auto incrementado pelo firebird)
        /// </summary>
        public int ID_FORMAPAGAMENTO { get; set; }

        /// <summary>
        /// Noma da forma de pagamento, constara na tela de venda e no historico de venda
        /// </summary>
        public string NOME { get; set; }

        /// <summary>
        /// Este campo determina se a forma de pagamento está habilitada nas vendas ou não
        /// </summary>
        public char DESABILITADO { get; set; }

        public static void InserirNovaFormaPagamento(FormaPagamento formaPagamento)
        {
            using (IDbConnection conexao =  new FbConnection(ConfigurationManager.ConnectionStrings["Banco"].ConnectionString))
            {
                var resultado = conexao.Execute("insert into forma_pagamento (nome, desabilitado) values (@NOME, @DESABILITADO)", formaPagamento);
            }
        }

        /// <summary>
        /// Método para retornar todas as formas de pagamentos habilitadas no sistema
        /// </summary>
        /// <returns>Lista de formas de pagamentos habilitadas</returns>
        public static List<FormaPagamento> SelecionarFormasDePagamentoHabilitadas()
        {
            List<FormaPagamento> formas;

            using (IDbConnection conexao = new FbConnection(ConfigurationManager.ConnectionStrings["Banco"].ConnectionString))
            {
                //produtos = conexao.Query<Produto>("select * from produto p where p.codigo = @CODIGO").ToList();
                formas = conexao.Query<FormaPagamento>("SELECT * FROM forma_pagamento WHERE desabilitado = 'N'").ToList();
            };

            return formas;
        }
    }
}
