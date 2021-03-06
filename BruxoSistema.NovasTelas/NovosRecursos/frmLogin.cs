using BruxoBiblioteca.NovasTelas.Login;
using BruxoBiblioteca.NovasTelas.Models;
using FirebirdSql.Data.FirebirdClient;
using System;
using System.Windows.Forms;

namespace BruxoSistema.NovasTelas.NovosRecursos
{
    public partial class FrmLogin : DevExpress.XtraEditors.XtraForm
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            RealizarLogin();
        }

        private void RealizarLogin()
        {
            try
            {
                Usuario usuario = new Usuario();
                usuario.NOME = txtUsuario.Text;
                usuario.SENHA = txtSenha.Text;

                bool loginInformacoesValidas = LoginController.ValidarLoginSenha(usuario);

                if (!loginInformacoesValidas)
                {
                    MessageBox.Show(@"Por gentileza consagrado infome os dados corretamente !!");
                    return;
                }


                bool loginEfetuado = LoginController.LogarSigeBruxo(usuario);

                if (!loginEfetuado)
                {
                    MessageBox.Show(@"Usuario ou senha incorretos");
                    return;
                }

                Hide();
                FrmTelaInicialRibbon telaInicial = new FrmTelaInicialRibbon();
                telaInicial.Closed += (s, args) => Close();
                telaInicial.ShowDialog();
            }
            catch (FbException ex)
            {
                MessageBox.Show($@"Não foi possivel se conectar ao banco de dados, por getileza verifique se o serviço" +
                                $@"FirebirdGuardianDefaultInstance está em execução! {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($@"Ocorreu um erro por favor entre em contato com o Bruxo! {ex.Message} {ex.StackTrace}");
            }
        }

        private void btnAdicionarUsuario_Click(object sender, EventArgs e)
        {
            CadastrarUsuario();
        }

        private void CadastrarUsuario()
        {
            FrmCadastroUsuario cadastroUsuario = new FrmCadastroUsuario();
            cadastroUsuario.ShowDialog();

            if (!LoginController.VerificarExisteUsuarioSessao(UsuarioSessao.IdUsuario, UsuarioSessao.NomeUsuario))
                return;

            Hide();
            FrmTelaInicialRibbon telaInicial = new FrmTelaInicialRibbon();
            telaInicial.Closed += (s, args) => Close();
            telaInicial.ShowDialog();
        }

        private void FrmLogar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                RealizarLogin();
        }
    }
}