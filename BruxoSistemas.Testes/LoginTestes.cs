using BruxoBiblioteca.Controllers;
using BruxoBiblioteca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BruxoSistema.Testes
{
    public class LoginTestes
    {
        [Theory]
        [InlineData(1, "Leonardo", true)]
        [InlineData(0, "Leonardo", false)]
        [InlineData(1, " ", false)]
        [InlineData(1, "", false)]
        [InlineData(0, " ", false)]
        [InlineData(1, null, false)]
        public void VerificarExisteUsuarioSessao_VerificarSeOUsuarioJaSeCadastrouNoSigeBruxo_RetornaBool(int id, string nome, bool valorEsperado)
        {
            bool validaInformacoesUsuarioLogin = LoginController.VerificarExisteUsuarioSessao(id, nome);

            Assert.Equal(valorEsperado, validaInformacoesUsuarioLogin);
        }

        [Fact]
        public void ValidarLoginSenha_VerificarSeOsCamposDeLoginESenhaSaoValidos_RetornaBool()
        {
            Usuario usuario = new Usuario();
            usuario.ID_USUARIO = 1;
            usuario.NOME = "Leonardo";
            usuario.SENHA = "123";

            bool valorEsperado = true;

            bool validaProduto = LoginController.ValidarLoginSenha(usuario);

            Assert.Equal(validaProduto, valorEsperado);
        }
    }
}
