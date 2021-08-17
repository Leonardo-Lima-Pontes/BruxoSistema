using Dapper;
using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BruxoBiblioteca.Models
{
    public class Usuario
    {
        /// <summary>
        /// Identificador unico do produto (já auto incrementado pelo firebird)
        /// </summary>
        public int ID_USUARIO { get; set; }

        /// <summary>
        /// Nome do usuario
        /// </summary>
        public string NOME { get; set; }

        /// <summary>
        /// Senha que será utilizada para entrar no sistema
        /// </summary>
        public string SENHA { get; set; }

        /// <summary>
        /// Método para inserir um novo usuario
        /// </summary>
        /// <param name="usuario">Objeto usuario a ser passado para inserção no banco de dados</param>
        public static Usuario InserirNovoUsuario(Usuario usuario)
        {
            using (IDbConnection conexao = new FbConnection(ConfigurationManager.ConnectionStrings["Banco"].ConnectionString))
            {
                // neste caso não consegui retornar o id
                //var resultado = conexao.Execute("insert into usuario (nome, senha) values (@NOME, @SENHA)", usuario); 

                DynamicParameters parametros = new DynamicParameters();

                parametros.Add("@NOME", usuario.NOME);
                parametros.Add("@SENHA", usuario.SENHA);
                parametros.Add("@ID_USUARIO", dbType: DbType.Int32, direction: ParameterDirection.Output);

                var id = conexao.Execute("insert into usuario (nome, senha) values (@NOME, @SENHA) returning usuario.ID_USUARIO", parametros);

                usuario.ID_USUARIO = parametros.Get<int>("@ID_USUARIO");
            }

            return usuario;
        }

        //Verifica se o usuario informado na tela de login realmente exite no sitema caso existe retorna o bjeto usuario se não retorna null
        public static Usuario Logar(Usuario usuario)
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
