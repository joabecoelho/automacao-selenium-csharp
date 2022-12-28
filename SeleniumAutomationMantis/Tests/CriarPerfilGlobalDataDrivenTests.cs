using SeleniumAutomationMantis.Bases;
using SeleniumAutomationMantis.Helpers;
using SeleniumAutomationMantis.Pages;
using SeleniumAutomationMantis.Flows;
using NUnit.Framework;


namespace SeleniumAutomationMantis.Tests
{
    [TestFixture]
    public class CriarPerfilGlobalDataDrivenTests : TestBase
    {

        #region Pages and Flows Objects
        LoginFlows loginFlows;
        MainPage mainPage;
        GerenciarPage gerenciarPage;
        GerenciarPerfisGlobaisPage gerenciarPerfisGlobaisPage;
        #endregion

        [TestCaseSource(typeof(DataDrivenHelpers), "ReturnDadosPerfisGlobais_CSV")]
        public void CriarPerfilGlobalComSucesso(string plataforma, string so, string versaoSO, string descricao)
        {
            loginFlows = new LoginFlows();
            mainPage = new MainPage();
            gerenciarPage = new GerenciarPage();
            gerenciarPerfisGlobaisPage = new GerenciarPerfisGlobaisPage();

            #region Parameters
            string usuario = "administrator";
            string senha = "root";
            string nomePerfil = plataforma + " " + so + " " + versaoSO;
            #endregion

            loginFlows.EfetuarLogin(usuario, senha);
            mainPage.ClicarEmGerenciar();
            gerenciarPage.ClicarEmGerenciarPerfisGlobais();
            gerenciarPerfisGlobaisPage.PreencherCampoPlataforma(plataforma);
            gerenciarPerfisGlobaisPage.PreencherCampoSO(so);
            gerenciarPerfisGlobaisPage.PreencherVersaoSO(versaoSO);
            gerenciarPerfisGlobaisPage.PreencherDescricao(descricao);
            gerenciarPerfisGlobaisPage.ClicarEmAdicionarPerfil();

            Assert.AreEqual(nomePerfil, gerenciarPerfisGlobaisPage.RetornaNomeDoPerfilCriado(nomePerfil));
        }
    }
}