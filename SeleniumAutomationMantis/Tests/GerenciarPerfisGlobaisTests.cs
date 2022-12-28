using SeleniumAutomationMantis.Bases;
using SeleniumAutomationMantis.Pages;
using SeleniumAutomationMantis.Flows;
using NUnit.Framework;

namespace SeleniumAutomationMantis.Tests
{
    [TestFixture]
    public class GerenciarPerfisGlobaisTests : TestBase
    {

        #region Pages and Flows Objects
        LoginFlows loginFlows;
        MainPage mainPage;
        GerenciarPage gerenciarPage;
        GerenciarPerfisGlobaisPage gerenciarPerfisGlobaisPage;

        #endregion

        [Test]
        public void CriarPerfilGlobalComSucesso()
        {
            loginFlows = new LoginFlows();
            mainPage = new MainPage();
            gerenciarPage = new GerenciarPage();
            gerenciarPerfisGlobaisPage = new GerenciarPerfisGlobaisPage();

            #region Parameters
            string usuario = "administrator";
            string senha = "root";
            string plataforma = "Chrome";
            string so = "Windows";
            string versaoSO = "2019";
            string descricao = "Adicionando Descrição";
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

        [Test]
        public void CriarEAlterarPerfilGlobalComSucesso()
        {
            loginFlows = new LoginFlows();
            mainPage = new MainPage();
            gerenciarPage = new GerenciarPage();
            gerenciarPerfisGlobaisPage = new GerenciarPerfisGlobaisPage();

            #region Parameters
            string usuario = "administrator";
            string senha = "root";
            string plataforma = "Safari";
            string so = "Mac OS";
            string versaoSO = "2020";
            string descricao = "Adicionando Descrição";
            string plataformaAlterado = "Safari";
            string soAlterado = "Mac OS";
            string versaoSOAlterado = "2020";
            string nomePerfilAlterado = plataformaAlterado + " " + soAlterado + " " + versaoSOAlterado;
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
            gerenciarPerfisGlobaisPage.ClicarEmAlterarPerfil();
            gerenciarPerfisGlobaisPage.SelecionarPerfil(nomePerfil);
            gerenciarPerfisGlobaisPage.ClicarEmEnviar();
            gerenciarPerfisGlobaisPage.PreencherEditarCampoPlataforma(plataformaAlterado);
            gerenciarPerfisGlobaisPage.PreencherEditarCampoSO(soAlterado);
            gerenciarPerfisGlobaisPage.PreencherEditarVersaoSO(versaoSOAlterado);
            gerenciarPerfisGlobaisPage.CliclarEmAtualizarPerfil();

            Assert.AreEqual(nomePerfil, gerenciarPerfisGlobaisPage.RetornaNomeDoPerfilCriado(nomePerfilAlterado));
        }

        [Test]
        public void ApagarPerfilGlobalComSucesso()
        {
            loginFlows = new LoginFlows();
            mainPage = new MainPage();
            gerenciarPage = new GerenciarPage();
            gerenciarPerfisGlobaisPage = new GerenciarPerfisGlobaisPage();

            #region Parameters
            string usuario = "administrator";
            string senha = "root";
            string plataforma = "Firefox";
            string so = "Linux";
            string versaoSO = "2015";
            string descricao = "Adicionando Descrição";
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
            gerenciarPerfisGlobaisPage.ClicarEmApagarPerfil();
            gerenciarPerfisGlobaisPage.SelecionarPerfil(nomePerfil);
            gerenciarPerfisGlobaisPage.ClicarEmEnviar();

            Assert.IsFalse(gerenciarPerfisGlobaisPage.RetornaSeOFormularioDePefilEExibido());
        }
    }
}
