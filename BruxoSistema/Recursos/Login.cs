using BruxoBiblioteca.Controllers;
using BruxoBiblioteca.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BruxoSistema
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnCadastrarUsuario_Click(object sender, EventArgs e)
        {
            CadastrarUsuario();
        }

        private void CadastrarUsuario()
        {
            CadastroUsuario cadastroUsuario = new CadastroUsuario();
            cadastroUsuario.ShowDialog();

            if (!LoginController.VerificarExisteUsuarioSessao(UsuarioSessao.IdUsuario, UsuarioSessao.Nomeusuario))
                return;

            this.Hide();
            TelaInicial telaInicial = new TelaInicial();
            telaInicial.Closed += (s, args) => this.Close();
            telaInicial.ShowDialog();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            RealizarLogin();
        }

        public void RealizarLogin()
        {
            Usuario usuario = new Usuario();
            usuario.NOME = textBoxNome.Text;
            usuario.SENHA = textBoxSenha.Text;

            bool loginInformacoesValidas = LoginController.ValidarLoginSenha(usuario);

            if (!loginInformacoesValidas)
            {
                MessageBox.Show("Por gentileza consagrado infome os dados corretamente !!");
                return;
            }


            bool loginEfetuado = LoginController.LogarSigeBruxo(usuario);

            if (!loginEfetuado)
            {
                MessageBox.Show("Usuario ou senha incorretos");
                return;
            }

            this.Hide();
            TelaInicial telaInicial = new TelaInicial();
            telaInicial.Closed += (s, args) => this.Close();
            telaInicial.ShowDialog();
        }

        private void Login_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                RealizarLogin();
        }
    }
}
