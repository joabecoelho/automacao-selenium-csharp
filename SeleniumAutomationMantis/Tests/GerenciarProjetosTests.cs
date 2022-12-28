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
    public class GerenciarProjetosTests : TestBase
    {

        #region Pages and Flows Objects
        LoginFlows loginFlows;
        MainPage mainPage;
        GerenciarPage gerenciarPage;
        GerenciarProjetosPage gerenciarProjetosPage;
        #endregion

        [Test]
        public void CriarProjetoComSucesso()
        {
            loginFlows = new LoginFlows();
            mainPage = new MainPage();
            gerenciarPage = new GerenciarPage();
            gerenciarProjetosPage = new GerenciarProjetosPage();

            #region Parameters
            string usuario = "administrator";
            string senha = "root";
            string nomeDoProjeto = "Projeto Teste Selenium";
            #endregion

            loginFlows.EfetuarLogin(usuario, senha);
            mainPage.ClicarEmGerenciar();
            gerenciarPage.ClicarEmGerenciarProjetos();
            gerenciarProjetosPage.ClicarEmCriarNovoProjeto();
            gerenciarProjetosPage.PreencherCampoNomeDoProjeto(nomeDoProjeto);
            gerenciarProjetosPage.ClicarEmAdicionarProjeto();

            Assert.AreEqual("Operação realizada com sucesso.", gerenciarProjetosPage.RetornaMensagemDeSucesso());
        }

        [Test]
        public void ApagarProjetoComSucesso()
        {
            loginFlows = new LoginFlows();
            mainPage = new MainPage();
            gerenciarPage = new GerenciarPage();
            gerenciarProjetosPage = new GerenciarProjetosPage();

            #region Parameters
            string usuario = "administrator";
            string senha = "root";
            #endregion

            loginFlows.EfetuarLogin(usuario, senha);
            mainPage.ClicarEmGerenciar();
            gerenciarPage.ClicarEmGerenciarProjetos();
            gerenciarProjetosPage.ClicarNoProjeto();
            gerenciarProjetosPage.ClicarEmApagarProjeto();
            gerenciarProjetosPage.ClicarEmApagarProjeto();

            Assert.AreEqual("", gerenciarProjetosPage.RetornaInformacoesDoProjeto());
        }

        [Test]
        public void AlterarProjetoComSucesso()
        {
            loginFlows = new LoginFlows();
            mainPage = new MainPage();
            gerenciarPage = new GerenciarPage();
            gerenciarProjetosPage = new GerenciarProjetosPage();

            #region Parameters
            string usuario = "administrator";
            string senha = "root";
            string nomeProjetoAlterado = "Nome Projeto Teste";
            string estado = "estável";
            #endregion

            loginFlows.EfetuarLogin(usuario, senha);
            mainPage.ClicarEmGerenciar();
            gerenciarPage.ClicarEmGerenciarProjetos();
            gerenciarProjetosPage.ClicarNoProjeto();
            gerenciarProjetosPage.PreencherCampoNomeDoProjeto(nomeProjetoAlterado);
            gerenciarProjetosPage.SelecionarEstadoDoProjeto(estado);
            gerenciarProjetosPage.ClicarEmAtualizarProjeto();

            Assert.AreEqual(nomeProjetoAlterado, gerenciarProjetosPage.RetornaNomeDoProjeto(nomeProjetoAlterado));
        }

        [Test]
        public void CriarCategoriaComSucesso()
        {
            loginFlows = new LoginFlows();
            mainPage = new MainPage();
            gerenciarPage = new GerenciarPage();
            gerenciarProjetosPage = new GerenciarProjetosPage();

            #region Parameters
            string usuario = "administrator";
            string senha = "root";
            string nomeCategoria = "Categoria Teste";
            #endregion

            loginFlows.EfetuarLogin(usuario, senha);
            mainPage.ClicarEmGerenciar();
            gerenciarPage.ClicarEmGerenciarProjetos();
            gerenciarProjetosPage.PreencherNomeCategoria(nomeCategoria);
            gerenciarProjetosPage.ClicarEmAdicionarCategoria();

            Assert.AreEqual(nomeCategoria, gerenciarProjetosPage.RetornaNomeDaCategoria(nomeCategoria));
        }

        [Test]
        public void AlterarCategoria()
        {
            loginFlows = new LoginFlows();
            mainPage = new MainPage();
            gerenciarPage = new GerenciarPage();
            gerenciarProjetosPage = new GerenciarProjetosPage();

            #region Parameters
            string usuario = "administrator";
            string senha = "root";
            string nomeCategoriaAlterado = "Categoria Desafio";
            #endregion

            loginFlows.EfetuarLogin(usuario, senha);
            mainPage.ClicarEmGerenciar();
            gerenciarPage.ClicarEmGerenciarProjetos();
            gerenciarProjetosPage.ClicarEmAlterarCategoria();
            gerenciarProjetosPage.PreencherCategoria(nomeCategoriaAlterado);
            gerenciarProjetosPage.ClicarEmAtualizarCategoria();

            Assert.AreEqual("Operação realizada com sucesso.", gerenciarProjetosPage.RetornaMensagemDeSucesso());
        }

        [Test]
        public void ApagarCategoria()
        {
            loginFlows = new LoginFlows();
            mainPage = new MainPage();
            gerenciarPage = new GerenciarPage();
            gerenciarProjetosPage = new GerenciarProjetosPage();

            #region Parameters
            string usuario = "administrator";
            string senha = "root";
            #endregion

            loginFlows.EfetuarLogin(usuario, senha);
            mainPage.ClicarEmGerenciar();
            gerenciarPage.ClicarEmGerenciarProjetos();
            gerenciarProjetosPage.ClicarEmApagarCategoria();
            gerenciarProjetosPage.ClicarEmConfirmarApagarCategoria();

            Assert.AreEqual("Operação realizada com sucesso.", gerenciarProjetosPage.RetornaMensagemDeSucesso());
        }
    }
}
