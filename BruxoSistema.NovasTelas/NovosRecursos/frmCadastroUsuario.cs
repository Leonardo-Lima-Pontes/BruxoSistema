using BruxoBiblioteca.NovasTelas.CadastroUsuario;
using System;
using System.Windows.Forms;

namespace BruxoSistema.NovasTelas.NovosRecursos
{
    public partial class FrmCadastroUsuario : DevExpress.XtraEditors.XtraForm
    {
        public FrmCadastroUsuario()
        {
            InitializeComponent();
        }

        private void btnCancelarCadastro_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            SalvarUsuario();
        }

        private void SalvarUsuario()
        {
            string nome = txtUsuario.Text;
            string senha = txtSenha.Text;
            string senhaConfirma = txtSenhaConfirma.Text;

            bool usuarioValido = CadastroUsuarioController.ValidarUsuario(nome, senha, senhaConfirma);
            if (!usuarioValido)
            {
                MessageBox.Show(@"Consagrado favor consagrado preencha os campos corretamente!");
                return;
            }

            bool senhaValida = CadastroUsuarioController.ValidaSenhasCoicindindo(senha, senhaConfirma);
            if (!senhaValida)
            {
                MessageBox.Show(@"Consagrado as senhas não coincidem!");
                return;
            }

            CadastroUsuarioController.InserirNovoUsuario(nome, senha);

            MessageBox.Show(@"Novo usuario cadastrado com sucesso");

            Close();
        }

        private void frmCadastroUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SalvarUsuario();

            if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}