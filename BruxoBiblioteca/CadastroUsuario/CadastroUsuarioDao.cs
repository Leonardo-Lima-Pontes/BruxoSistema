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
    class CadastroUsuarioDao
    {
        internal static Usuario InserirNovousuario(Usuario usuario)
        {
            using (IDbConnection conexao = new FbConnection(ConfigurationManager.ConnectionStrings["Banco"].ConnectionString))
            {
                DynamicParameters parametros = new DynamicParameters();

                parametros.Add("@NOME", usuario.NOME);
                parametros.Add("@SENHA", usuario.SENHA);
                parametros.Add("@ID_USUARIO", dbType: DbType.Int32, direction: ParameterDirection.Output);

                var id = conexao.Execute("insert into usuario (nome, senha) values (@NOME, @SENHA) returning usuario.ID_USUARIO", parametros);

                usuario.ID_USUARIO = parametros.Get<int>("@ID_USUARIO");
            }

            return usuario;
        }
    }
}
