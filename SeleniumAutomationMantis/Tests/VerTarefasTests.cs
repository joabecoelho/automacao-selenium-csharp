using SeleniumAutomationMantis.Bases;
using SeleniumAutomationMantis.DataBaseSteps;
using SeleniumAutomationMantis.Pages;
using SeleniumAutomationMantis.Flows;
using NUnit.Framework;

namespace SeleniumAutomationMantis.Tests
{
    [TestFixture]
    public class VerTarefaTests : TestBase
    {

        #region Pages and Flows Objects
        LoginFlows loginFlows;
        MainPage mainPage;
        VerTarefasPage verTarefasPage;
        VerDetalhesDaTarefaPage verDetalhesDaTarefaPage;
        MinhaVisaoPage minhaVisaoPage;

        #endregion

        [Test]
        public void EnviarLembreteComSucesso()
        {
            loginFlows = new LoginFlows();
            mainPage = new MainPage();
            verTarefasPage = new VerTarefasPage();
            verDetalhesDaTarefaPage = new VerDetalhesDaTarefaPage();


            #region Parameters
            string usuario = "administrator";
            string senha = "root";
            #endregion

            loginFlows.EfetuarLogin(usuario, senha);
            mainPage.ClicarEmVerTarefas();
            verTarefasPage.ClicarNaTarefa();
            verDetalhesDaTarefaPage.ClicarEmEnviarUmLembrete();
            verDetalhesDaTarefaPage.SelecionarUsuarioLembrete();
            verDetalhesDaTarefaPage.ClicarEmEnviar();


            Assert.AreEqual("Operação realizada com sucesso.", verDetalhesDaTarefaPage.RetornaTextoOperacaoRealizadaComSucesso());
        }

        [Test]
        public void ValidarEnvioDeLembrete()
        {
            loginFlows = new LoginFlows();
            mainPage = new MainPage();
            verTarefasPage = new VerTarefasPage();
            verDetalhesDaTarefaPage = new VerDetalhesDaTarefaPage();


            #region Parameters
            string usuario = "administrator";
            string senha = "root";
            #endregion

            loginFlows.EfetuarLogin(usuario, senha);
            mainPage.ClicarEmVerTarefas();
            verTarefasPage.ClicarNaTarefa();
            verDetalhesDaTarefaPage.ClicarEmEnviarUmLembrete();
            verDetalhesDaTarefaPage.SelecionarUsuarioLembrete();
            verDetalhesDaTarefaPage.ClicarEmEnviar();


            Assert.IsTrue(verDetalhesDaTarefaPage.RetornaAtividadesInformacao().Contains("Lembrete mandado para: administrator"));
        }

        [Test]
        public void EnviarLembreteSemUsuarioSelecionado()
        {
            loginFlows = new LoginFlows();
            mainPage = new MainPage();
            verTarefasPage = new VerTarefasPage();
            verDetalhesDaTarefaPage = new VerDetalhesDaTarefaPage();


            #region Parameters
            string usuario = "administrator";
            string senha = "root";
            #endregion

            loginFlows.EfetuarLogin(usuario, senha);
            mainPage.ClicarEmVerTarefas();
            verTarefasPage.ClicarNaTarefa();
            verDetalhesDaTarefaPage.ClicarEmEnviarUmLembrete();
            verDetalhesDaTarefaPage.ClicarEmEnviar();


            Assert.AreEqual("APPLICATION ERROR #200", verDetalhesDaTarefaPage.RetornaTextoErroNaAplicacao());
        }

        

        [Test]
        public void ValidarRedirecionamentoDoBotaoIrParaAsAnotacoes()
        {
            loginFlows = new LoginFlows();
            mainPage = new MainPage();
            verTarefasPage = new VerTarefasPage();
            verDetalhesDaTarefaPage = new VerDetalhesDaTarefaPage();


            #region Parameters
            string usuario = "administrator";
            string senha = "root";
            #endregion

            loginFlows.EfetuarLogin(usuario, senha);
            mainPage.ClicarEmVerTarefas();
            verTarefasPage.ClicarNaTarefa();
            verDetalhesDaTarefaPage.ClicarEmIrParaAsAnotacoes();

            Assert.AreEqual("Atividades", verDetalhesDaTarefaPage.RetornaTextoAtividades());
        }

        [Test]
        public void AdicionarAnotacaoComSucesso()
        {
            loginFlows = new LoginFlows();
            mainPage = new MainPage();
            verTarefasPage = new VerTarefasPage();
            verDetalhesDaTarefaPage = new VerDetalhesDaTarefaPage();


            #region Parameters
            string usuario = "administrator";
            string senha = "root";
            string anotacao = "Adicionando Anotação Teste";
            #endregion

            loginFlows.EfetuarLogin(usuario, senha);
            mainPage.ClicarEmVerTarefas();
            verTarefasPage.ClicarEmRedefinir();
            verTarefasPage.ClicarNaTarefa();
            verDetalhesDaTarefaPage.ClicarEmIrParaAsAnotacoes();
            verDetalhesDaTarefaPage.PreencherCampoAnotacao(anotacao);
            verDetalhesDaTarefaPage.ClicarEmAdicionarAnotacao();
            verDetalhesDaTarefaPage.ClicarEmIrParaAsAnotacoes();

            Assert.AreEqual(anotacao, verDetalhesDaTarefaPage.RetornaDescriçãoAtividade());
        }

        [Test]
        public void ApagarAnotacaoComSucesso()
        {
            loginFlows = new LoginFlows();
            mainPage = new MainPage();
            verTarefasPage = new VerTarefasPage();
            verDetalhesDaTarefaPage = new VerDetalhesDaTarefaPage();


            #region Parameters
            string usuario = "administrator";
            string senha = "root";
            #endregion

            loginFlows.EfetuarLogin(usuario, senha);
            mainPage.ClicarEmVerTarefas();
            verTarefasPage.ClicarEmRedefinir();
            verTarefasPage.ClicarNaTarefa();
            verDetalhesDaTarefaPage.ClicarEmApagarAtividade();
            verDetalhesDaTarefaPage.ClicarEmApagarAnotacao();
            verDetalhesDaTarefaPage.RetornaTextoNaoHaAnotacao();

            Assert.AreEqual("Não há anotações anexadas a esta tarefa.", verDetalhesDaTarefaPage.RetornaTextoNaoHaAnotacao());

        }

        [Test]
        public void ValidarAdicaoDeAnotacaoSemPreenchimentoDoCampo()
        {
            loginFlows = new LoginFlows();
            mainPage = new MainPage();
            verTarefasPage = new VerTarefasPage();
            verDetalhesDaTarefaPage = new VerDetalhesDaTarefaPage();


            #region Parameters
            string usuario = "administrator";
            string senha = "root";
            #endregion

            loginFlows.EfetuarLogin(usuario, senha);
            mainPage.ClicarEmVerTarefas();
            verTarefasPage.ClicarEmRedefinir();
            verTarefasPage.ClicarNaTarefa();
            verDetalhesDaTarefaPage.ClicarEmIrParaAsAnotacoes();
            verDetalhesDaTarefaPage.ClicarEmAdicionarAnotacao();

            Assert.AreEqual("APPLICATION ERROR #11", verDetalhesDaTarefaPage.RetornaTextoErroNaAplicacao());
        }

        [Test]
        public void MarcarTarefaComoResolvidaComSucesso()
        {
            loginFlows = new LoginFlows();
            mainPage = new MainPage();
            verTarefasPage = new VerTarefasPage();
            verDetalhesDaTarefaPage = new VerDetalhesDaTarefaPage();


            #region Parameters
            string usuario = "administrator";
            string senha = "root";
            string status = "resolvido";
            string resolucao = "corrigido";
            #endregion

            loginFlows.EfetuarLogin(usuario, senha);
            mainPage.ClicarEmVerTarefas();
            verTarefasPage.ClicarEmRedefinir();
            verTarefasPage.ClicarNaTarefa();
            verDetalhesDaTarefaPage.SelecionarAlterarStatusTerafaCombobox(status);
            verDetalhesDaTarefaPage.ClicarEmAlterarStatusTarefaButton();
            verDetalhesDaTarefaPage.SelecionarResolucaoTarefaCombobox(resolucao);
            verDetalhesDaTarefaPage.ClicarEmResolverTarefaButton();

            Assert.AreEqual(status, verDetalhesDaTarefaPage.RetornaTextoEstadoTarefa());
        }

        [Test]
        public void MarcarTarefaComoPegajosoComSucesso()
        {
            loginFlows = new LoginFlows();
            mainPage = new MainPage();
            verTarefasPage = new VerTarefasPage();
            verDetalhesDaTarefaPage = new VerDetalhesDaTarefaPage();


            #region Parameters
            string usuario = "administrator";
            string senha = "root";
            #endregion

            loginFlows.EfetuarLogin(usuario, senha);
            mainPage.ClicarEmVerTarefas();
            verTarefasPage.ClicarEmRedefinir();
            verTarefasPage.ClicarNaTarefa();
            verDetalhesDaTarefaPage.ClicarEmMarcarComoPegajosoButton();

            Assert.IsTrue(verDetalhesDaTarefaPage.RetornaTextoHistoricoAtividade().Contains("Tarefa \"Pegajosa\""));
        }

        [Test]
        public void DesmarcarTarefaComoPegajosoComSucesso()
        {
            loginFlows = new LoginFlows();
            mainPage = new MainPage();
            verTarefasPage = new VerTarefasPage();
            verDetalhesDaTarefaPage = new VerDetalhesDaTarefaPage();


            #region Parameters
            string usuario = "administrator";
            string senha = "root";
            #endregion

            loginFlows.EfetuarLogin(usuario, senha);
            mainPage.ClicarEmVerTarefas();
            verTarefasPage.ClicarEmRedefinir();
            verTarefasPage.ClicarNaTarefa();
            verDetalhesDaTarefaPage.ClicarEmMarcarComoPegajosoButton();
            verDetalhesDaTarefaPage.ClicarEmDesmarcarComoPegajosoButton();

            Assert.IsTrue(verDetalhesDaTarefaPage.RetornaTextoHistoricoAtividade().Contains("Tarefa \"Pegajosa\""));
        }

        [Test]
        public void MonitorarTarefaComSucesso()
        {
            loginFlows = new LoginFlows();
            mainPage = new MainPage();
            verTarefasPage = new VerTarefasPage();
            verDetalhesDaTarefaPage = new VerDetalhesDaTarefaPage();


            #region Parameters
            string usuario = "administrator";
            string senha = "root";
            #endregion

            loginFlows.EfetuarLogin(usuario, senha);
            mainPage.ClicarEmVerTarefas();
            verTarefasPage.ClicarEmRedefinir();
            verTarefasPage.ClicarNaTarefa();
            verDetalhesDaTarefaPage.ClicarEmMonitorarTarefaButton();

            Assert.AreEqual(usuario, verDetalhesDaTarefaPage.RetornaTextoUsuarioMonitorando());
        }

        [Test]
        public void MonitorarTarefaValidandoEmMinhaVisao()
        {
            loginFlows = new LoginFlows();
            mainPage = new MainPage();
            verTarefasPage = new VerTarefasPage();
            verDetalhesDaTarefaPage = new VerDetalhesDaTarefaPage();
            minhaVisaoPage = new MinhaVisaoPage();


            #region Parameters
            string usuario = "administrator";
            string senha = "root";
            #endregion

            loginFlows.EfetuarLogin(usuario, senha);
            mainPage.ClicarEmVerTarefas();
            verTarefasPage.ClicarEmRedefinir();
            verTarefasPage.ClicarNaTarefa();
            verDetalhesDaTarefaPage.ClicarEmMonitorarTarefaButton();
            string numeroTarefaMonitorada = verDetalhesDaTarefaPage.RetornaNumeroTarefaModificada();
            mainPage.ClicarEmMinhaVisao();

            Assert.AreEqual(numeroTarefaMonitorada, minhaVisaoPage.RetornaTarefaMonitorada(numeroTarefaMonitorada));
        }

        [Test]
        public void FecharTarefaComSucesso()
        {
            loginFlows = new LoginFlows();
            mainPage = new MainPage();
            verTarefasPage = new VerTarefasPage();
            verDetalhesDaTarefaPage = new VerDetalhesDaTarefaPage();

            #region Parameters
            string usuario = "administrator";
            string senha = "root";
            #endregion

            loginFlows.EfetuarLogin(usuario, senha);
            mainPage.ClicarEmVerTarefas();
            verTarefasPage.ClicarEmRedefinir();
            verTarefasPage.ClicarNaTarefa();
            verDetalhesDaTarefaPage.ClicarEmFechar();
            verDetalhesDaTarefaPage.ClicarEmFecharTarefa();

            Assert.AreEqual("fechado", verDetalhesDaTarefaPage.RetornaTextoEstadoTarefa());
        }

        [Test]
        public void ValidarRedirecionamentoDoBotaoIrParaHistorico()
        {
            loginFlows = new LoginFlows();
            mainPage = new MainPage();
            verTarefasPage = new VerTarefasPage();
            verDetalhesDaTarefaPage = new VerDetalhesDaTarefaPage();

            #region Parameters
            string usuario = "administrator";
            string senha = "root";
            #endregion

            loginFlows.EfetuarLogin(usuario, senha);
            mainPage.ClicarEmVerTarefas();
            verTarefasPage.ClicarEmRedefinir();
            verTarefasPage.ClicarNaTarefa();
            verDetalhesDaTarefaPage.ClicarEmIrParaOHistorico();

            Assert.IsTrue(verDetalhesDaTarefaPage.RetornaTextoHistoricoTarefa().Contains("Histórico da Tarefa"));
        }


        [Test]
        public void EditarTarefaComSucesso()
        {
            loginFlows = new LoginFlows();
            mainPage = new MainPage();
            verTarefasPage = new VerTarefasPage();
            verDetalhesDaTarefaPage = new VerDetalhesDaTarefaPage();

            #region Parameters
            string usuario = "administrator";
            string senha = "root";
            string estado = "admitido";
            #endregion

            loginFlows.EfetuarLogin(usuario, senha);
            mainPage.ClicarEmVerTarefas();
            verTarefasPage.ClicarEmRedefinir();
            verTarefasPage.ClicarEmEditarTarefa();
            verDetalhesDaTarefaPage.SelecionarEstadoTarefaCombobox(estado);
            verDetalhesDaTarefaPage.ClicarEmAtualizarTarefa();

            Assert.AreEqual(estado, verDetalhesDaTarefaPage.RetornaTextoEstadoTarefa());
        }

        [Test]
        public void ReabrirTarefaComSucesso()
        {
            CriarTarefaDBSteps.CriarTarefaFechada();

            loginFlows = new LoginFlows();
            mainPage = new MainPage();
            verTarefasPage = new VerTarefasPage();
            verDetalhesDaTarefaPage = new VerDetalhesDaTarefaPage();

            #region Parameters
            string usuario = "administrator";
            string senha = "root";
            string estado = "fechado";
            #endregion

            loginFlows.EfetuarLogin(usuario, senha);
            mainPage.ClicarEmVerTarefas();
            verTarefasPage.ClicarNoFiltroEstadoDaTarefa();
            verTarefasPage.SelecionarEstadoDaTarefa(estado);
            verTarefasPage.ClicarEmAplicarFiltro();
            verTarefasPage.ClicarNaTarefa();
            verDetalhesDaTarefaPage.ClicarEmReabrirTarefa();
            verDetalhesDaTarefaPage.ClicarEmSolicitarRetorno();

            Assert.AreEqual("retorno", verDetalhesDaTarefaPage.RetornaTextoEstadoTarefa());
        }

        [Test]
        public void ApagarTarefaComSucesso()
        {
            loginFlows = new LoginFlows();
            mainPage = new MainPage();
            verTarefasPage = new VerTarefasPage();
            verDetalhesDaTarefaPage = new VerDetalhesDaTarefaPage();
            minhaVisaoPage = new MinhaVisaoPage();

            #region Parameters
            string usuario = "administrator";
            string senha = "root";
            #endregion

            loginFlows.EfetuarLogin(usuario, senha);
            mainPage.ClicarEmVerTarefas();
            verTarefasPage.ClicarEmRedefinir();
            verTarefasPage.ClicarNaTarefa();
            verDetalhesDaTarefaPage.ClicarEmApagar();
            verDetalhesDaTarefaPage.ClicarEmApagarTarefas();

            Assert.AreEqual("", verTarefasPage.RetornaInformacoesDaTarefaNaTabela());
        }

    }
}