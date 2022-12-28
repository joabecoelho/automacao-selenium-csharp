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
    public class GerenciarCamposPersonalizadosTests : TestBase
    {

        #region Pages and Flows Objects
        LoginFlows loginFlows;
        MainPage mainPage;
        GerenciarPage gerenciarPage;
        GerenciarCamposPersonalizadosPage gerenciarCamposPersonalizadosPage;
        #endregion

        [Test]
        public void CriarCampoPersonalizadoComSucesso()
        {
            loginFlows = new LoginFlows();
            mainPage = new MainPage();
            gerenciarPage = new GerenciarPage();
            gerenciarCamposPersonalizadosPage = new GerenciarCamposPersonalizadosPage();

            #region Parameters
            string usuario = "administrator";
            string senha = "root";
            string nomeCampoPersonalizado = "Teste Nome Campo Personalizado";
            #endregion

            loginFlows.EfetuarLogin(usuario, senha);
            mainPage.ClicarEmGerenciar();
            gerenciarPage.ClicarEmGerenciarCamposPersonalizados();
            gerenciarCamposPersonalizadosPage.PreencherCampoNome(nomeCampoPersonalizado);
            gerenciarCamposPersonalizadosPage.ClicarEmNovoCampoPersonalizado();

            Assert.AreEqual("Operação realizada com sucesso.", gerenciarCamposPersonalizadosPage.RetornaMensagemDeSucesso());
        }

        [Test]
        public void ValidarErroAoNaoPreencherNomeDoCampoPersonalizado()
        {
            loginFlows = new LoginFlows();
            mainPage = new MainPage();
            gerenciarPage = new GerenciarPage();
            gerenciarCamposPersonalizadosPage = new GerenciarCamposPersonalizadosPage();

            #region Parameters
            string usuario = "administrator";
            string senha = "root";
            #endregion

            loginFlows.EfetuarLogin(usuario, senha);
            mainPage.ClicarEmGerenciar();
            gerenciarPage.ClicarEmGerenciarCamposPersonalizados();
            gerenciarCamposPersonalizadosPage.ClicarEmNovoCampoPersonalizado();

            Assert.AreEqual("APPLICATION ERROR #11", gerenciarCamposPersonalizadosPage.RetornaMensagemDeErro());
        }

        [Test]
        public void AlterarCampoPersonalizado()
        {
            loginFlows = new LoginFlows();
            mainPage = new MainPage();
            gerenciarPage = new GerenciarPage();
            gerenciarCamposPersonalizadosPage = new GerenciarCamposPersonalizadosPage();

            #region Parameters
            string usuario = "administrator";
            string senha = "root";
            string nomeCampoPersonalizadoAlterado = "Teste do campo personalizado";
            #endregion

            loginFlows.EfetuarLogin(usuario, senha);
            mainPage.ClicarEmGerenciar();
            gerenciarPage.ClicarEmGerenciarCamposPersonalizados();
            gerenciarCamposPersonalizadosPage.ClicarNoCampoPersonalizado();
            gerenciarCamposPersonalizadosPage.PreencherCampoNome(nomeCampoPersonalizadoAlterado);
            gerenciarCamposPersonalizadosPage.ClicarEmAtualizarCampoPersonalizado();

            Assert.AreEqual("Operação realizada com sucesso.", gerenciarCamposPersonalizadosPage.RetornaMensagemDeSucesso());
        }

        [Test]
        public void ApagarCampoPersonalizadoComSucesso()
        {
            loginFlows = new LoginFlows();
            mainPage = new MainPage();
            gerenciarPage = new GerenciarPage();
            gerenciarCamposPersonalizadosPage = new GerenciarCamposPersonalizadosPage();

            #region Parameters
            string usuario = "administrator";
            string senha = "root";
            #endregion

            loginFlows.EfetuarLogin(usuario, senha);
            mainPage.ClicarEmGerenciar();
            gerenciarPage.ClicarEmGerenciarCamposPersonalizados();
            gerenciarCamposPersonalizadosPage.ClicarNoCampoPersonalizado();
            gerenciarCamposPersonalizadosPage.ClicarEmApagarCampoPersonalizado();
            gerenciarCamposPersonalizadosPage.ClicarEmApagarCampo();

            Assert.AreEqual("Operação realizada com sucesso.", gerenciarCamposPersonalizadosPage.RetornaMensagemDeSucessoApagarCampoPersonalizado());
        }

        [Test]
        public void ValidarApagarCampoPersonalizado()
        {
            loginFlows = new LoginFlows();
            mainPage = new MainPage();
            gerenciarPage = new GerenciarPage();
            gerenciarCamposPersonalizadosPage = new GerenciarCamposPersonalizadosPage();

            #region Parameters
            string usuario = "administrator";
            string senha = "root";
            #endregion

            loginFlows.EfetuarLogin(usuario, senha);
            mainPage.ClicarEmGerenciar();
            gerenciarPage.ClicarEmGerenciarCamposPersonalizados();
            gerenciarCamposPersonalizadosPage.ClicarNoCampoPersonalizado();
            gerenciarCamposPersonalizadosPage.ClicarEmApagarCampoPersonalizado();
            gerenciarCamposPersonalizadosPage.ClicarEmApagarCampo();

            Assert.AreEqual("Operação realizada com sucesso.", gerenciarCamposPersonalizadosPage.RetornaMensagemDeSucesso());
        }

        [Test]
        public void ValidarAlterarCampoPersonalizado()
        {
            loginFlows = new LoginFlows();
            mainPage = new MainPage();
            gerenciarPage = new GerenciarPage();
            gerenciarCamposPersonalizadosPage = new GerenciarCamposPersonalizadosPage();

            #region Parameters
            string usuario = "administrator";
            string senha = "root";
            string nomeCampoPersonalizadoAlterado = "Campo personalizado Desafio";
            #endregion

            loginFlows.EfetuarLogin(usuario, senha);
            mainPage.ClicarEmGerenciar();
            gerenciarPage.ClicarEmGerenciarCamposPersonalizados();
            gerenciarCamposPersonalizadosPage.ClicarNoCampoPersonalizado();
            gerenciarCamposPersonalizadosPage.PreencherCampoNome(nomeCampoPersonalizadoAlterado);
            gerenciarCamposPersonalizadosPage.ClicarEmAtualizarCampoPersonalizado();

            Assert.AreEqual(nomeCampoPersonalizadoAlterado, gerenciarCamposPersonalizadosPage.RetornaNomeCampoPersonalizado(nomeCampoPersonalizadoAlterado));
        }

    }
}
