using System.Configuration;
using System.Data;
using BruxoBiblioteca.NovasTelas.Models;
using Dapper;
using FirebirdSql.Data.FirebirdClient;

namespace BruxoBiblioteca.NovasTelas.Configuracoes
{
    class ConfiguracoesDao
    {
        public static void GravarConfiguracoes(string configuracoesJson)
        {
            using (IDbConnection conexao = new FbConnection(ConfigurationManager.ConnectionStrings["Banco"].ConnectionString))
            {
                conexao.Execute("update config c set c.feature_toggles = @configuracoesJson where id_config = 1", new { configuracoesJson = configuracoesJson });
            }
        }

        public static string CarregarConfiguracoes()
        {
            string configs;

            using (IDbConnection conexao = new FbConnection(ConfigurationManager.ConnectionStrings["Banco"].ConnectionString))
            {
                configs = conexao.QueryFirstOrDefault<string>("SELECT c.feature_toggles FROM config c WHERE id_config = 1");
            };

            return configs;
        }
    }
}
