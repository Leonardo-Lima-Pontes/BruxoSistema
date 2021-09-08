using BruxoBiblioteca.DAO;
using BruxoBiblioteca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BruxoBiblioteca.Controllers
{
    public class CadastroUsuarioController
    {
        public static bool ValidarUsuario(string nome, string senha, string senhaConfirma)
        {
            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(senha) || string.IsNullOrWhiteSpace(senhaConfirma))
                return false;

            return true;
        }

        public static void InserirNovoUsuario(string nome, string senha)
        {
            Usuario novoUsuario = new Usuario();
            novoUsuario.NOME = nome;
            novoUsuario.SENHA = senha;

            novoUsuario = CadastroUsuarioDao.InserirNovousuario(novoUsuario);

            UsuarioSessao.IdUsuario = novoUsuario.ID_USUARIO;
            UsuarioSessao.NomeUsuario = novoUsuario.NOME;
        }

        public static bool ValidaSenhasCoicindindo(string senha, string senhaConfirma)
        {
            if (senha != senhaConfirma)
                return false;

            return true;
        }
    }
}
