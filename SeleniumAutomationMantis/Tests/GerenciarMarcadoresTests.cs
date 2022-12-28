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
    public class GerenciarMarcadoresTests : TestBase
    {

        #region Pages and Flows Objects
        LoginFlows loginFlows;
        MainPage mainPage;
        GerenciarPage gerenciarPage;
        GerenciarMarcadoresPage gerenciarMarcadoresPage;
        #endregion

        [Test]
        public void CriarMarcadorComSucesso()
        {
            loginFlows = new LoginFlows();
            mainPage = new MainPage();
            gerenciarPage = new GerenciarPage();
            gerenciarMarcadoresPage = new GerenciarMarcadoresPage();

            #region Parameters
            string usuario = "administrator";
            string senha = "root";
            string nomeMarcador = "Teste de Marcador Mantis";
            #endregion

            loginFlows.EfetuarLogin(usuario, senha);
            mainPage.ClicarEmGerenciar();
            gerenciarPage.ClicarEmGerenciarMarcadores();
            gerenciarMarcadoresPage.PreencherCampoNome(nomeMarcador);
            gerenciarMarcadoresPage.ClicarEmCriarMarcador();

            Assert.AreEqual(nomeMarcador, gerenciarMarcadoresPage.RetornaNomeMarcador(nomeMarcador));
        }

        [Test]
        public void AlterarMarcadorComSucesso()
        {
            loginFlows = new LoginFlows();
            mainPage = new MainPage();
            gerenciarPage = new GerenciarPage();
            gerenciarMarcadoresPage = new GerenciarMarcadoresPage();

            #region Parameters
            string usuario = "administrator";
            string senha = "root";
            string nomeMarcadorAlterado = "Teste de Marcador Mantis";
            #endregion

            loginFlows.EfetuarLogin(usuario, senha);
            mainPage.ClicarEmGerenciar();
            gerenciarPage.ClicarEmGerenciarMarcadores();
            gerenciarMarcadoresPage.ClicarNoMarcador();
            gerenciarMarcadoresPage.ClicarEmAtualizarMarcador();
            gerenciarMarcadoresPage.PreencherCampoNome(nomeMarcadorAlterado);
            gerenciarMarcadoresPage.ClicarEmAtualizarMarcador();

            Assert.AreEqual(nomeMarcadorAlterado, gerenciarMarcadoresPage.RetornaNomeMarcadorAlterado(nomeMarcadorAlterado));
        }

        [Test]
        public void ApagarMarcadorComSucesso()
        {
            loginFlows = new LoginFlows();
            mainPage = new MainPage();
            gerenciarPage = new GerenciarPage();
            gerenciarMarcadoresPage = new GerenciarMarcadoresPage();

            #region Parameters
            string usuario = "administrator";
            string senha = "root";
            #endregion

            loginFlows.EfetuarLogin(usuario, senha);
            mainPage.ClicarEmGerenciar();
            gerenciarPage.ClicarEmGerenciarMarcadores();
            gerenciarMarcadoresPage.ClicarNoMarcador();
            gerenciarMarcadoresPage.ClicarEmApagarMarcador();
            gerenciarMarcadoresPage.ClicarEmApagarMarcador();

            Assert.IsEmpty(gerenciarMarcadoresPage.RetornaInformacoesMarcador());
        }


    }
}
