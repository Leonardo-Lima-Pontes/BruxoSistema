using System;
using BruxoBiblioteca.NovasTelas.Configuracoes;
using BruxoBiblioteca.NovasTelas.Models;

namespace BruxoSistema.NovasTelas.Recursos
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
                novaTelaVenda: tgsPdv.IsOn,
                novaTelaCadastroProduto: tgsCadastroProduto.IsOn,
                novaTelaCadastroFormaPagamento: tgsCadastroFormaPagamento.IsOn,
                novaTelaCadastroUsuario: tgsCadastroUsuario.IsOn,
                novaTelaConsultaProdutoVenda: tgsConsultaProdutoVenda.IsOn,
                novaTelaFaturamento: tgsFaturamento.IsOn,
                novaTelaInicial: tgsTelaInicial.IsOn
            );

            ConfiguracoesController.GravarConfiguracoes(novasTelasConfig);

            ConfiguracoesGlobais.NovasTelas.NovaTelaInicial = tgsTelaInicial.IsOn;

            Close();
        }

        private void frmNovasTelasConfig_Load(object sender, EventArgs e)
        {
            tgsTelaInicial.IsOn = ConfiguracoesGlobais.NovasTelas.NovaTelaInicial;
        }
    }
}