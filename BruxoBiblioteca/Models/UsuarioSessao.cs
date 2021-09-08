using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BruxoBiblioteca.Models
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
