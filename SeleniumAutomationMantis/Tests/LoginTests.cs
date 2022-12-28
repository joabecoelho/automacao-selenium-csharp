using SeleniumAutomationMantis.Bases;
using SeleniumAutomationMantis.Pages;
using NUnit.Framework;
using SeleniumAutomationMantis.Flows;

namespace SeleniumAutomationMantis.Tests
{
    [TestFixture]
    public class LoginTests : TestBase
    {

        #region Pages and Flows Objects
        LoginPage loginPage;
        LoginFlows loginFlows;
        MainPage mainPage;
        #endregion

        [Test]
        public void RealizarLoginComSucesso()
        {
            loginPage = new LoginPage();
            loginFlows = new LoginFlows();
            mainPage = new MainPage();

            #region Parameters
            string usuario = "administrator";
            string senha = "root";
            #endregion

            loginFlows.EfetuarLogin(usuario, senha);

            Assert.AreEqual(usuario, mainPage.RetornaUsernameDeLogin());
        }

        [Test]
         public void ValidarLoginComUsuarioIncorreto()
        {
            loginPage = new LoginPage();
            loginFlows = new LoginFlows();
            mainPage = new MainPage();

            #region Parameters
            string usuarioIncorreto = "usuarioIncorreto";
            string senha = "senhaincorreta";
            string mensagemDeErroNoUsuario = "Sua conta pode estar desativada ou bloqueada ou o nome de usuário e a senha que você digitou não estão corretos.";
            #endregion

            loginFlows.EfetuarLogin(usuarioIncorreto, senha);

            Assert.AreEqual(mensagemDeErroNoUsuario, loginPage.RetornaMensagemDeErroDeLogin());
        }

        [Test]
        public void ValidarLoginComSenhaIncorreta()
        {
            loginPage = new LoginPage();
            loginFlows = new LoginFlows();
            mainPage = new MainPage();

            #region Parameters
            string usuario = "administrator";
            string senhaIncorreta = "SenhaIncorreta";
            string mensagemDeErroNaSenha = "Sua conta pode estar desativada ou bloqueada ou o nome de usuário e a senha que você digitou não estão corretos.";
            #endregion

            loginFlows.EfetuarLogin(usuario, senhaIncorreta);

            Assert.AreEqual(mensagemDeErroNaSenha, loginPage.RetornaMensagemDeErroDeLogin());
        }

        [Test]
        public void ValidarLoginSemInformarNomeDeUsuario()
        {
            loginPage = new LoginPage();
            mainPage = new MainPage();

            #region Parameters
            string usuarioVazio = "";
            string mensagemDeErroUsuarioNaoInformado = "Sua conta pode estar desativada ou bloqueada ou o nome de usuário e a senha que você digitou não estão corretos.";
            #endregion

            loginPage.PreencherUsuario(usuarioVazio);
            loginPage.ClicarEmEntrar();

            Assert.AreEqual(mensagemDeErroUsuarioNaoInformado, loginPage.RetornaMensagemDeErroDeLogin());
        }

        [Test]
        public void ValidarLoginSemInformarSenha()
        {
            loginPage = new LoginPage();
            loginFlows = new LoginFlows();
            mainPage = new MainPage();

            #region Parameters
            string usuario = "administrator";
            string senhaVazia = "";
            string mensagemDeErroSenhaNaoInformada = "Sua conta pode estar desativada ou bloqueada ou o nome de usuário e a senha que você digitou não estão corretos.";
            #endregion

            loginFlows.EfetuarLogin(usuario, senhaVazia);

            Assert.AreEqual(mensagemDeErroSenhaNaoInformada, loginPage.RetornaMensagemDeErroDeLogin());
        }

    }
}
