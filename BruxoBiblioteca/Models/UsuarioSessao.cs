using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BruxoBiblioteca.Models
{
    public static class UsuarioSessao
    {
        public static int IdUsuario { get; set; }
        public static string Nomeusuario { get; set; }

        public static void IniciarSessao(Usuario usuario)
        {
            IdUsuario = usuario.ID_USUARIO;
            Nomeusuario = usuario.NOME;
        }
    }
}
