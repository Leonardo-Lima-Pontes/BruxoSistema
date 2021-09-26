using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BruxoBiblioteca.NovasTelas.Models;
using Newtonsoft.Json;

namespace BruxoBiblioteca.NovasTelas.Configuracoes
{
    public static class ConfiguracoesController
    {
        public static void GravarConfiguracoes(NovasTelasConfig novasTelasConfig)
        {
            var configuracoesJson = JsonConvert.SerializeObject(novasTelasConfig);
            ConfiguracoesDao.GravarConfiguracoes(configuracoesJson);
        }

        public static void CarregarConfiguracoes()
        {
            string config = ConfiguracoesDao.CarregarConfiguracoes();
            NovasTelasConfig configs = JsonConvert.DeserializeObject<NovasTelasConfig>(config);

            ConfiguracoesGlobais.NovosFluxos.NovoFluxoFaturamento = configs.NovoFluxoFaturamento;
            ConfiguracoesGlobais.NovosFluxos.ModificaQuantidade = configs.ModificaQuantidade;
        }
    }
}
