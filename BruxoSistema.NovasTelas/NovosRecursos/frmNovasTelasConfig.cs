using System;
using BruxoBiblioteca.NovasTelas.Configuracoes;
using BruxoBiblioteca.NovasTelas.Models;

namespace BruxoSistema.NovasTelas.NovosRecursos
{
    public partial class frmNovasTelasConfig : DevExpress.XtraEditors.XtraForm
    {
        public frmNovasTelasConfig()
        {
            InitializeComponent();
        }

        private void btnGravarConfiguracoes_Click(object sender, EventArgs e)
        {
            NovasTelasConfig novasTelasConfig = new NovasTelasConfig(
                novoFluxoFaturamento: tgsNovoFluxoFaturamento.IsOn,
                modificaQuantidade: tgsModificarQuantidade.IsOn
            );

            ConfiguracoesController.GravarConfiguracoes(novasTelasConfig);

            ConfiguracoesGlobais.NovosFluxos.NovoFluxoFaturamento = tgsNovoFluxoFaturamento.IsOn;
            ConfiguracoesGlobais.NovosFluxos.ModificaQuantidade = tgsModificarQuantidade.IsOn;

            Close();
        }

        private void frmNovasTelasConfig_Load(object sender, EventArgs e)
        {
            tgsNovoFluxoFaturamento.IsOn = ConfiguracoesGlobais.NovosFluxos.NovoFluxoFaturamento;
            tgsModificarQuantidade.IsOn = ConfiguracoesGlobais.NovosFluxos.ModificaQuantidade;

        }
    }
}