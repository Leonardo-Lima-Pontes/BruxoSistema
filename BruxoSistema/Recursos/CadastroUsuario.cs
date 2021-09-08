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
    public partial class CadastroUsuario : Form
    {
        public CadastroUsuario()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            SalvarUsuario();
        }

        private void SalvarUsuario()
        {
            string nome = textBoxNome.Text;
            string senha = textBoxSenha.Text;
            string senhaConfirma = textBoxSenhaConfimacao.Text;

            bool usuarioValido = CadastroUsuarioController.ValidarUsuario(nome, senha, senhaConfirma);
            if (!usuarioValido)
            {
                MessageBox.Show("Consagrado favor consagrado preencha os campos corretamente!");
                return;
            }

            bool senhaValida = CadastroUsuarioController.ValidaSenhasCoicindindo(senha, senhaConfirma);
            if (!senhaValida)
            {
                MessageBox.Show("Consagrado as senhas não coincidem!");
                return;
            }

            CadastroUsuarioController.InserirNovoUsuario(nome, senha);

            MessageBox.Show("Novo usuario cadastrado com sucesso");

            Close();
        }

        private void CadastrarUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SalvarUsuario();

            if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}
