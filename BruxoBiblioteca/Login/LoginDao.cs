using BruxoBiblioteca.Models;
using Dapper;
using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BruxoBiblioteca.DAO
{
    class LoginDao
    {
        internal static Usuario VerificarExisteUsuarioCadastradoSigeBruxo(Usuario usuario)
        {
            using (IDbConnection conexao = new FbConnection(ConfigurationManager.ConnectionStrings["Banco"].ConnectionString))
            {
                conexao.Open();

                usuario = conexao.Query<Usuario>("select * from usuario u where u.Nome = @NOME and u.senha = @SENHA", usuario).FirstOrDefault();
            }

            return usuario;
        }

    }
}
