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

        // Chama tela de cadastro de novo usuario
        private void buttonCadastrarUsuario_Click(object sender, EventArgs e)
        {
            CadastroUsuario cadastroUsuario = new CadastroUsuario();
            cadastroUsuario.ShowDialog();

            // caso realmente seja inserido um novo usuario já entra na sessão
            // dele e fecha este formulario
            if (UsuarioSessao.Nomeusuario != null)
            {
                this.Hide();
                TelaInicial telaInicial = new TelaInicial();
                telaInicial.Closed += (s, args) => this.Close();
                telaInicial.ShowDialog();
            }
        }

        // Logar no sistema
        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                Usuario usuario = new Usuario();
                usuario.NOME = textBoxNome.Text;
                usuario.SENHA = textBoxSenha.Text;

                //encontra usuario no banco
                usuario = Usuario.Logar(usuario);

                //valida se usuario foi encontrado e inicia sessao
                if (usuario != null)
                {
                    UsuarioSessao.IniciarSessao(usuario);

                    this.Hide();
                    TelaInicial telaInicial = new TelaInicial();
                    telaInicial.Closed += (s, args) => this.Close(); //fecha formulario de login e inicia o sistema
                    telaInicial.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Usuario ou senha incorretos");
                }
            }
        }

        // valida campos do formulario
        private bool ValidarCampos()
        {
            bool validacao = true;

            if (string.IsNullOrWhiteSpace(textBoxNome.Text) || string.IsNullOrWhiteSpace(textBoxSenha.Text))
            {
                validacao = false;
            }

            return validacao;
        }
    }
}
