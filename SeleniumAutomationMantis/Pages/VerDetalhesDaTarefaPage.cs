using SeleniumAutomationMantis.Bases;
using OpenQA.Selenium;
using System;

namespace SeleniumAutomationMantis.Pages
{
    public class VerDetalhesDaTarefaPage : PageBase
    {
        #region Mapping
        By atribuidoAText = By.XPath("//td[@class='bug-assigned-to']");
        By enviarUmLembreteButton = By.XPath("//div[@class='btn-group pull-left']/a[text()='Enviar um lembrete']");
        By selecionarUsuarioLembrete = By.XPath("//select[@id='recipient']/option");
        By enviarButton = By.XPath("//input[@value='Enviar']");
        By mensagemSucesso = By.XPath("//p[@class='bold bigger-110']");
        By mensagemErro = By.XPath("//div[@class='alert alert-danger']/p[@class='bold']");
        By irParaAnotacoesButton = By.XPath("//div[@class='btn-group pull-left']/a[text()='Ir para as Anotações']");
        By anotacaoTextField = By.Id("bugnote_text");
        By atividadesText = By.XPath("//div[@id='bugnotes']//h4[@class='widget-title lighter']");
        By adicionarAnotacaoButton = By.XPath("//input[@value='Adicionar Anotação']");
        By descricaoAtividade = By.XPath("//td[@class='bugnote-note bugnote-public']");
        By atividades = By.XPath("//div[@id='bugnotes']//td[@class='bugnote-note bugnote-public']");
        By apagarAtividadesButton = By.XPath("//div[@id='bugnotes']//button[text()='Apagar']");
        By apagarAnotacaoButton = By.XPath("//input[@value='Apagar Anotação']");
        By naoHaAnotacaoText = By.XPath("//div[@id='bugnotes']//tr[@class='bugnotes-empty']");
        By alterarStatusTarefaCombobox = By.XPath("//select[@name='new_status']");
        By alterarStatusTarefaButton = By.XPath("//input[@value='Alterar Status:']");
        By resolucaoTarefaCombobox = By.XPath("//select[@name='resolution']");
        By resolverTarefaButton = By.XPath("//input[@value='Resolver Tarefa']");
        By estadoTarefaText = By.XPath("//td[@class='bug-status']");
        By marcarComoPegajosoButton = By.XPath("//input[@value='Marcar como Pegajoso']");
        By historicoAtividadeText = By.XPath("//div[@id='history']");
        By desmarcarComoPegajosoButton = By.XPath("//input[@value='Desmarcar como Pegajoso']");
        By monitorarTarefaButton = By.XPath("//input[@value='Monitorar']");
        By usuarioMonitorandoLinkText = By.XPath("//div[@id='monitoring']//a[text()='administrator']");
        By numeroTarefaModificada = By.XPath("//td[@class='bug-id']");
        By irParaOHistoricoButton = By.XPath("//div[@class='btn-group pull-left']/a[text()='Ir para o Histórico']");
        By historicoTarefaText = By.XPath("//div[@id='history']//h4[@class='widget-title lighter']");
        By fecharButton = By.XPath("//input[@value='Fechar']");
        By fecharTarefaButton = By.XPath("//input[@value='Fechar Tarefa']");
        By atividadesInformacao = By.XPath("//div[@id='bugnotes']//tbody");
        By atualizarButton = By.XPath("//input[@value='Atualizar Informação']");
        By estadoCombobox = By.Id("status");
        By salvarTarefaButton = By.XPath("//input[@type='submit']");
        By numeroTarefaText = By.XPath("//td[@class='bug-id']");
        By apagarButton = By.XPath("//input[@value='Apagar']");
        By apagarTarefasButton = By.XPath("//input[@value='Apagar Tarefas']");
        By reabrirTarefaButton = By.XPath("//input[@value='Reabrir']");
        By solicitarRetornoButton = By.XPath("//input[@value='Solicitar Retorno']");
        #endregion

        #region Actions
        public String RetornaTextoAtribuidoA()
        {
            return GetText(atribuidoAText);
        }

        public void ClicarEmEnviarUmLembrete()
        {
            Click(enviarUmLembreteButton);
        }

        public void SelecionarUsuarioLembrete()
        {
            Click(selecionarUsuarioLembrete);
        }

        public void ClicarEmEnviar()
        {
            Click(enviarButton);
        }

        public string RetornaTextoOperacaoRealizadaComSucesso()
        {
            return GetText(mensagemSucesso);
        }

        public string RetornaTextoErroNaAplicacao()
        {
            return GetText(mensagemErro);
        }

        public void ClicarEmIrParaAsAnotacoes()
        {
            Click(irParaAnotacoesButton);
        }

        public string RetornaTextoAtividades()
        {
            return GetText(atividadesText);
        }


        public void PreencherCampoAnotacao(string textoAnotacao)
        {
            SendKeys(anotacaoTextField, textoAnotacao);
        }

        public void ClicarEmAdicionarAnotacao()
        {
            Click(adicionarAnotacaoButton);
        }

        public void ClicarEmApagarAtividade()
        {
            Click(atividades);
            Click(apagarAtividadesButton);
        }

        public void ClicarEmApagarAnotacao()
        {
            Click(apagarAnotacaoButton);
        }

        public string RetornaTextoNaoHaAnotacao()
        {
            return GetText(naoHaAnotacaoText);
        }


        public string RetornaDescriçãoAtividade()
        {
            return GetText(descricaoAtividade);
        }

        public void SelecionarAlterarStatusTerafaCombobox(string status)
        {
            ComboBoxSelectByVisibleText(alterarStatusTarefaCombobox, status);
        }

        public void ClicarEmAlterarStatusTarefaButton()
        {
            Click(alterarStatusTarefaButton);
        }

        public void SelecionarResolucaoTarefaCombobox(string resolucao)
        {
            ComboBoxSelectByVisibleText(resolucaoTarefaCombobox, resolucao);
        }

        public void ClicarEmResolverTarefaButton()
        {
            Click(resolverTarefaButton);
        }

        public string RetornaTextoEstadoTarefa()
        {
            return GetText(estadoTarefaText);
        }

        public void ClicarEmMarcarComoPegajosoButton()
        {
            Click(marcarComoPegajosoButton);
        }

        public string RetornaTextoHistoricoAtividade()
        {
            return GetText(historicoAtividadeText);
        }

        public void ClicarEmDesmarcarComoPegajosoButton()
        {
            Click(desmarcarComoPegajosoButton);
        }

        public void ClicarEmMonitorarTarefaButton()
        {
            Click(monitorarTarefaButton);
        }

        public string RetornaTextoUsuarioMonitorando()
        {
            return GetText(usuarioMonitorandoLinkText);
        }

        public String RetornaNumeroTarefaModificada()
        {
            return GetText(numeroTarefaModificada);
        }

        public void ClicarEmIrParaOHistorico()
        {
            Click(irParaOHistoricoButton);
        }

        public string RetornaTextoHistoricoTarefa()
        {
            return GetText(historicoTarefaText);
        }

        public void ClicarEmFechar()
        {
            Click(fecharButton);
        }

        public void ClicarEmFecharTarefa()
        {
            Click(fecharTarefaButton);
        }

        public string RetornaAtividadesInformacao()
        {
            return GetText(atividadesInformacao);
        }

        public void ClicarEmAtualizarTarefa()
        {
            Click(atualizarButton);
        }

        public void SelecionarEstadoTarefaCombobox(string estado)
        {
            ComboBoxSelectByVisibleText(estadoCombobox, estado);
        }

        public void ClicarEmSalvarTarefa()
        {
            Click(salvarTarefaButton);
        }

        public string RetornaNumeroTarefa()
        {
            return GetText(numeroTarefaText);
        }

        public void ClicarEmApagar()
        {
            Click(apagarButton);
        }

        public void ClicarEmApagarTarefas()
        {
            Click(apagarTarefasButton);
        }

        public void ClicarEmReabrirTarefa()
        {
            Click(reabrirTarefaButton);
        }

        public void ClicarEmSolicitarRetorno()
        {
            Click(solicitarRetornoButton);
        }

        #endregion
    }
}