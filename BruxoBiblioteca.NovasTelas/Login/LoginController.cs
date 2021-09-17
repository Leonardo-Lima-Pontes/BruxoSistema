using BruxoBiblioteca.NovasTelas.Models;

namespace BruxoBiblioteca.NovasTelas.Login
{
    public static class LoginController
    {
        public static bool VerificarExisteUsuarioSessao(int id, string nome)
        {
            if (id != 0 && !string.IsNullOrWhiteSpace(nome))
                return true;

            return false;
        }

        public static bool ValidarLoginSenha(Usuario usuario)
        {
            if (string.IsNullOrWhiteSpace(usuario.NOME) || string.IsNullOrWhiteSpace(usuario.SENHA))
                return false;

            return true;
        }

        public static bool LogarSigeBruxo(Usuario usuario)
        {
            usuario = LoginDao.VerificarExisteUsuarioCadastradoSigeBruxo(usuario);

            if (usuario != null)
            {
                UsuarioSessao.IniciarSessao(usuario);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
