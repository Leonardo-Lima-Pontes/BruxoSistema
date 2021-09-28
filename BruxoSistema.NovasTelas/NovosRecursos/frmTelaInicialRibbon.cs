using System.Windows.Forms;
using BruxoBiblioteca.NovasTelas.Configuracoes;
using BruxoBiblioteca.NovasTelas.Models;
using DevExpress.XtraBars;

namespace BruxoSistema.NovasTelas.NovosRecursos
{
    public partial class FrmTelaInicialRibbon : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmTelaInicialRibbon()
        {
            InitializeComponent();

            ConfiguracoesController.CarregarConfiguracoes();
            lblUsuarioLogado.Caption = UsuarioSessao.NomeUsuario;
        }

        private void btnCadastroProdutos_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmCadastroProduto frm = new FrmCadastroProduto();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnCadastroFormaPagamento_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmCadastroFormaPagamento frm = new FrmCadastroFormaPagamento();
            frm.ShowDialog();
        }

        private void btnVenda_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmPdv frm = new frmPdv();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnConfiguracoes_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmNovasTelasConfig frm = new frmNovasTelasConfig();
            frm.MdiParent = this;
            frm.Show();
        }

        private void lblSairLogin_ItemClick(object sender, ItemClickEventArgs e)
        {
            VoltarParaTeleDeLogin();
        }

        private void VoltarParaTeleDeLogin()
        {
            DialogResult restarAplicacao = MessageBox.Show(@"Deseja realmente sair da conta meu consagrado ?", @"Voltar para login", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (restarAplicacao == DialogResult.Yes)
            {
                Application.Restart();
            }
        }
    }
}