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
    public partial class CadastroUsuario : Form
    {
        public CadastroUsuario()
        {
            InitializeComponent();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonGravar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                // Instacia usuario
                Usuario novoUsuario = new Usuario();
                novoUsuario.NOME = textBoxNome.Text;
                novoUsuario.SENHA = textBoxSenha.Text;

                // Salva usuario
                novoUsuario = Usuario.InserirNovoUsuario(novoUsuario);

                // Inicia Sessão com a classe estatica
                UsuarioSessao.IniciarSessao(novoUsuario);

                this.Close();
            }
            else
            {
                MessageBox.Show("Preencha corretamentes os campos!");
            }
        }

        /// <summary>
        /// Valida os campos do formulario cadastro de usuario
        /// </summary>
        /// <returns></returns>
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
