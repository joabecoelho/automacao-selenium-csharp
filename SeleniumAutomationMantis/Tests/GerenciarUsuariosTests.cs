using SeleniumAutomationMantis.Bases;
using SeleniumAutomationMantis.DataBaseSteps;
using SeleniumAutomationMantis.Helpers;
using SeleniumAutomationMantis.Pages;
using SeleniumAutomationMantis.Flows;
using NUnit.Framework;
using System.Collections;

namespace SeleniumAutomationMantis.Tests
{
    [TestFixture]
    public class GerenciarUsuariosTests : TestBase
    {

        #region Pages and Flows Objects
        LoginFlows loginFlows;
        MainPage mainPage;
        GerenciarPage gerenciarPage;
        GerenciarUsuariosPage gerenciarUsuariosPage;
        #endregion

        [Test]
        public void ApagarUsuarioComSucesso()
        {
            loginFlows = new LoginFlows();
            mainPage = new MainPage();
            gerenciarPage = new GerenciarPage();
            gerenciarUsuariosPage = new GerenciarUsuariosPage();

            #region Parameters
            string usuario = "administrator";
            string senha = "root";
            string nomeUsuario = "UsuarioTeste";
            #endregion

            loginFlows.EfetuarLogin(usuario, senha);
            mainPage.ClicarEmGerenciar();
            gerenciarPage.ClicarEmGerenciarUsuarios();
            gerenciarUsuariosPage.ClicarNoUsuario(nomeUsuario);
            gerenciarUsuariosPage.ClicarEmApagar();
            gerenciarUsuariosPage.ClicarEmApagarConta();

            Assert.AreEqual("Operação realizada com sucesso.", gerenciarUsuariosPage.RetornaMensagemDeSucesso());
        }

        [Test]
        public void ValidarCadastrarUsuarioNaoInformandoNomeDeUsuario()
        {
            loginFlows = new LoginFlows();
            mainPage = new MainPage();
            gerenciarPage = new GerenciarPage();
            gerenciarUsuariosPage = new GerenciarUsuariosPage();

            #region Parameters
            string usuario = "administrator";
            string senha = "root";
            #endregion

            loginFlows.EfetuarLogin(usuario, senha);
            mainPage.ClicarEmGerenciar();
            gerenciarPage.ClicarEmGerenciarUsuarios();
            gerenciarUsuariosPage.ClicarEmCriarNovaConta();
            gerenciarUsuariosPage.ClicarEmCriarUsuario();

            Assert.AreEqual("APPLICATION ERROR #805", gerenciarUsuariosPage.RetornaMensagemDeErro());
        }

        [Test]
        public void ValidarCadastrarUsuarioComEmailInvalido()
        {
            loginFlows = new LoginFlows();
            mainPage = new MainPage();
            gerenciarPage = new GerenciarPage();
            gerenciarUsuariosPage = new GerenciarUsuariosPage();

            #region Parameters
            string usuario = "administrator";
            string senha = "root";
            string nomeUsuario = "UsuarioTeste";
            string nomeVerdadeiro = "NomeVerdadeiroUsuarioTeste";
            string email = "emailinvalido.com";
            string nivelAcesso = "atualizador";
            #endregion

            loginFlows.EfetuarLogin(usuario, senha);
            mainPage.ClicarEmGerenciar();
            gerenciarPage.ClicarEmGerenciarUsuarios();
            gerenciarUsuariosPage.ClicarEmCriarNovaConta();
            gerenciarUsuariosPage.PreencherCampoNomeUsuario(nomeUsuario);
            gerenciarUsuariosPage.PreencherCampoNomeVerdadeiro(nomeVerdadeiro);
            gerenciarUsuariosPage.PreencherCampoEmail(email);
            gerenciarUsuariosPage.SelecionarNivelDeAcessoCombobox(nivelAcesso);
            gerenciarUsuariosPage.ClicarEmCriarUsuario();

            Assert.AreEqual("APPLICATION ERROR #800", gerenciarUsuariosPage.RetornaMensagemDeErro());
        }

        [Test]
        public void DesativarUsuario()
        {
            loginFlows = new LoginFlows();
            mainPage = new MainPage();
            gerenciarPage = new GerenciarPage();
            gerenciarUsuariosPage = new GerenciarUsuariosPage();

            #region Parameters
            string usuario = "administrator";
            string senha = "root";
            string nomeUsuario = "UsuarioTeste";
            #endregion

            loginFlows.EfetuarLogin(usuario, senha);
            mainPage.ClicarEmGerenciar();
            gerenciarPage.ClicarEmGerenciarUsuarios();
            gerenciarUsuariosPage.ClicarNoUsuario(nomeUsuario);
            gerenciarUsuariosPage.ClicarNoCheckboxHabilitado();
            gerenciarUsuariosPage.ClicarEmAtualizarUsuario();

            Assert.AreEqual("Operação realizada com sucesso.", gerenciarUsuariosPage.RetornaMensagemDeSucesso());
        }

         [Test]
        public void AlterarNivelDeAcessoDoUsuario()
        {
            loginFlows = new LoginFlows();
            mainPage = new MainPage();
            gerenciarPage = new GerenciarPage();
            gerenciarUsuariosPage = new GerenciarUsuariosPage();

            #region Parameters
            string usuario = "administrator";
            string senha = "root";
            string nomeUsuario = "UsuarioTeste";
            string nivelAcesso = "gerente";
            #endregion

            loginFlows.EfetuarLogin(usuario, senha);
            mainPage.ClicarEmGerenciar();
            gerenciarPage.ClicarEmGerenciarUsuarios();
            gerenciarUsuariosPage.ClicarNoUsuario(nomeUsuario);
            gerenciarUsuariosPage.SelecionarNovoNivelDeAcessoCombobox(nivelAcesso);
            gerenciarUsuariosPage.ClicarEmAtualizarUsuario();

            Assert.AreEqual("Operação realizada com sucesso.", gerenciarUsuariosPage.RetornaMensagemDeSucesso());
        }
    }
}
