using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BruxoBiblioteca.NovasTelas.CadastroUsuario;
using Xunit;

namespace BruxoSistema.Testes
{
    public class CadastroUsuarioTestes
    {
        [Theory]
        [InlineData("Leonardo", "123", "123", true)]
        [InlineData("", "123", "123", false)]
        [InlineData("Leonardo", "", "123", false)]
        [InlineData("Leonardo", "123", "", false)]
        public void ValidarUsuario_VerificarSeOsCamposDeUsuariosEstaoCorretos_RetornaBool(string nome, string senha, string senhaConfirma, bool valorEsperado)
        {
            bool usuarioValido = CadastroUsuarioController.ValidarUsuario(nome, senha, senhaConfirma);

            Assert.Equal(valorEsperado, usuarioValido);
        }

        [Theory]
        [InlineData("123", "123", true)]
        [InlineData("Leonardo", "Leonardo", true)]
        [InlineData("Leonardo", "123", false)]
        public void ValidaSenhasCoicindindo_VerificaSeAconfirmacaoDeSenhaEstaCorreta_RetornaBool(string senha, string senhaConfirma, bool valorEsperado)
        {
            bool usuarioValido = CadastroUsuarioController.ValidaSenhasCoicindindo(senha, senhaConfirma);

            Assert.Equal(valorEsperado, usuarioValido);
        }
    }
}
