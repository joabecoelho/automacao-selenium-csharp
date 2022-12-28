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
    public class CriarTarefaTests : TestBase
    {

        #region Pages and Flows Objects
        LoginFlows loginFlows;
        MainPage mainPage;
        CriarTarefaPage criarTarefaPage;
        VerDetalhesDaTarefaPage verDetalhesDaTarefaPage;
        MinhaVisaoPage minhaVisaoPage;

        #endregion

        [Test]
        public void CriarTarefaComSucessoPreenchendoTodosOsCampos()
        {
            loginFlows = new LoginFlows();
            mainPage = new MainPage();
            criarTarefaPage = new CriarTarefaPage();

            #region Parameters
            string usuario = "administrator";
            string senha = "root";
            string categoria = "[Todos os Projetos] General";
            string frequencia = "sempre";
            string gravidade = "pequeno";
            string prioridade = "normal";
            string atribuirA = "administrator";
            string resumo = "Criando uma tarefa sem atribuir a usuário";
            string descricao = "Criação de tarefa sem atribuição";
            string passosParaReproduzir = "Passo 1 Passo 2";
            string informacoesAdicionais = "Adicionando Informações Adicionais";
            string visibilidade = "publico";
            #endregion

            loginFlows.EfetuarLogin(usuario, senha);
            mainPage.ClicarEmCriarTarefa();
            criarTarefaPage.SelecionarCategoria(categoria);
            criarTarefaPage.SelecionarFrequencia(frequencia);
            criarTarefaPage.SelecionarGravidade(gravidade);
            criarTarefaPage.SelecionarPrioridade(prioridade);
            criarTarefaPage.SelecionarAtribuirA(atribuirA);
            criarTarefaPage.PreencherResumo(resumo);
            criarTarefaPage.PreencherDescricao(descricao);
            criarTarefaPage.PreencherPassosParaReproduzir(passosParaReproduzir);
            criarTarefaPage.PreencherInformacoesAdicionais(informacoesAdicionais);
            criarTarefaPage.SelecionarVisibilidade(visibilidade);
            criarTarefaPage.ClicarEmCriarNovaTarefa();

            Assert.AreEqual("Operação realizada com sucesso.", criarTarefaPage.PegarTextoOperacaoRealizadaComSucesso());
        }

        [Test]
        public void CriarTarefaSemAtribuirUsuarioEValidarEmDetalhesDaTarefa()
        {
            loginFlows = new LoginFlows();
            mainPage = new MainPage();
            criarTarefaPage = new CriarTarefaPage();
            verDetalhesDaTarefaPage = new VerDetalhesDaTarefaPage();

            #region Parameters
            string usuario = "administrator";
            string senha = "root";
            string categoria = "[Todos os Projetos] General";
            string frequencia = "sempre";
            string gravidade = "pequeno";
            string prioridade = "normal";
            string resumo = "Criando uma tarefa sem atribuir a usuário";
            string descricao = "Criação de tarefa sem atribuição";
            string passosParaReproduzir = "Passo 1 Passo 2";
            string informacoesAdicionais = "Adicionando Informações Adicionais";
            #endregion

            loginFlows.EfetuarLogin(usuario, senha);
            mainPage.ClicarEmCriarTarefa();
            criarTarefaPage.SelecionarCategoria(categoria);
            criarTarefaPage.SelecionarFrequencia(frequencia);
            criarTarefaPage.SelecionarGravidade(gravidade);
            criarTarefaPage.SelecionarPrioridade(prioridade);
            criarTarefaPage.PreencherResumo(resumo);
            criarTarefaPage.PreencherDescricao(descricao);
            criarTarefaPage.PreencherPassosParaReproduzir(passosParaReproduzir);
            criarTarefaPage.PreencherInformacoesAdicionais(informacoesAdicionais);
            criarTarefaPage.ClicarEmCriarNovaTarefa();

            Assert.IsEmpty(verDetalhesDaTarefaPage.RetornaTextoAtribuidoA());
        }
        
        [Test]
        public void CriarTarefaSemAtribuirUsuarioEValidarEmMinhaVisao()
        {
            loginFlows = new LoginFlows();
            mainPage = new MainPage();
            criarTarefaPage = new CriarTarefaPage();
            minhaVisaoPage = new MinhaVisaoPage();

            #region Parameters
            string usuario = "administrator";
            string senha = "root";
            string categoria = "[Todos os Projetos] General";
            string frequencia = "sempre";
            string gravidade = "pequeno";
            string prioridade = "normal";
            string resumo = "Criar tarefa sem atribuir a usuario";
            string descricao = "Criando tarefa sem atribuir a usuario e validando em minha visão";
            string passosParaReproduzir = "Passo 1 Passo 2";
            string informacoesAdicionais = "Adicionando Informações Adicionais";
            #endregion

            loginFlows.EfetuarLogin(usuario, senha);
            mainPage.ClicarEmCriarTarefa();
            criarTarefaPage.SelecionarCategoria(categoria);
            criarTarefaPage.SelecionarFrequencia(frequencia);
            criarTarefaPage.SelecionarGravidade(gravidade);
            criarTarefaPage.SelecionarPrioridade(prioridade);
            criarTarefaPage.PreencherResumo(resumo);
            criarTarefaPage.PreencherDescricao(descricao);
            criarTarefaPage.PreencherPassosParaReproduzir(passosParaReproduzir);
            criarTarefaPage.PreencherInformacoesAdicionais(informacoesAdicionais);
            criarTarefaPage.ClicarEmCriarNovaTarefa();
            mainPage.ClicarEmMinhaVisao();

            Assert.AreEqual(resumo, minhaVisaoPage.RetornaTarefaNaoAtribuidaANenhumUsuario(resumo));
        }

        [Test]
        public void CriarTarefaAtribuirAMimEValidarEmMinhaVisao()
        {
            loginFlows = new LoginFlows();
            mainPage = new MainPage();
            criarTarefaPage = new CriarTarefaPage();
            minhaVisaoPage = new MinhaVisaoPage();

            #region Parameters
            string usuario = "administrator";
            string senha = "root";
            string categoria = "[Todos os Projetos] General";
            string frequencia = "sempre";
            string gravidade = "pequeno";
            string prioridade = "normal";
            string atribuirA = "administrator";
            string resumo = "Criar tarefa atribuida a mim e validar em minha visão";
            string descricao = "Criando Tarefa Atribuida A Mim E Validando Em Minha Visão";
            string passosParaReproduzir = "Passo 1 Passo 2";
            string informacoesAdicionais = "Adicionando Informações Adicionais";
            string visibilidade = "publico";
            #endregion

            loginFlows.EfetuarLogin(usuario, senha);
            mainPage.ClicarEmCriarTarefa();
            criarTarefaPage.SelecionarCategoria(categoria);
            criarTarefaPage.SelecionarFrequencia(frequencia);
            criarTarefaPage.SelecionarGravidade(gravidade);
            criarTarefaPage.SelecionarPrioridade(prioridade);
            criarTarefaPage.SelecionarAtribuirA(atribuirA);
            criarTarefaPage.PreencherResumo(resumo);
            criarTarefaPage.PreencherDescricao(descricao);
            criarTarefaPage.PreencherPassosParaReproduzir(passosParaReproduzir);
            criarTarefaPage.PreencherInformacoesAdicionais(informacoesAdicionais);
            criarTarefaPage.SelecionarVisibilidade(visibilidade);
            criarTarefaPage.ClicarEmCriarNovaTarefa();
            mainPage.ClicarEmMinhaVisao();

            Assert.AreEqual(resumo, minhaVisaoPage.RetornaTarefasAtribuidasAMim(resumo));
        }
    }
}
