namespace BruxoBiblioteca.NovasTelas.Models
{
    public class UsuarioSessao
    {
        public static int IdUsuario { get; set; }
        public static string NomeUsuario { get; set; }

        public static void IniciarSessao(Usuario usuario)
        {
            IdUsuario = usuario.ID_USUARIO;
            NomeUsuario = usuario.NOME;
        }
    }
}
