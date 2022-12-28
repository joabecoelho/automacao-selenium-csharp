using SeleniumAutomationMantis.Bases;
using OpenQA.Selenium;

namespace SeleniumAutomationMantis.Pages
{
    public class GerenciarCamposPersonalizadosPage : PageBase
    {
        #region Mapping
        By nomeCampoPersonalizadoTextField = By.XPath("//input[@name='name']");
        By novoCampoPersonalizadoButton = By.XPath("//input[@value='Novo Campo Personalizado']");
        By mensagemSucesso = By.XPath("//p[@class='bold bigger-110']");
        By mensagemErro = By.XPath("//p[@class='bold']");
        By nomeCampoPersonalizadoLinkText = By.XPath("//div[@id='main-container']//td/a");
        By atualizarCampoPersonalizadoButton = By.XPath("//input[@value='Atualizar Campo Personalizado']");
        By apagarCampoPersonalizadoButton = By.XPath("//input[@value='Apagar Campo Personalizado']");
        By apagarCampoButton = By.XPath("//input[@value='Apagar Campo']");
        By informacoesCampoPersonalizadoText = By.XPath("//div[@class='widget-body']//tbody");

        By mensagemDeSucessoApagarCampoPersonalizado = By.XPath("//p[@class='bold bigger-110']");

        #endregion

        #region Actions

        public void PreencherCampoNome(string nome)
        {
            ClearAndSendKeys(nomeCampoPersonalizadoTextField, nome);
        }

        public void ClicarEmNovoCampoPersonalizado()
        {
            Click(novoCampoPersonalizadoButton);
        }

        public string RetornaMensagemDeSucesso()
        {
            return GetText(mensagemSucesso);
        }

        public string RetornaMensagemDeErro()
        {
            return GetText(mensagemErro);
        }

        public void ClicarNoCampoPersonalizado()
        {
            Click(nomeCampoPersonalizadoLinkText);
        }

        public void ClicarEmAtualizarCampoPersonalizado()
        {
            Click(atualizarCampoPersonalizadoButton);
        }

        public void ClicarEmApagarCampoPersonalizado()
        {
            Click(apagarCampoPersonalizadoButton);
        }

        public void ClicarEmApagarCampo()
        {
            Click(apagarCampoButton);
        }

        public string RetornaInformacoesCampoPersonalizado()
        {
            return GetText(informacoesCampoPersonalizadoText);
        }

        public string RetornaNomeCampoPersonalizado(string nome)
        {
            return GetText(By.XPath("//div[@id='main-container']//a[text()='" + nome + "']"));
        }

        public string RetornaMensagemDeSucessoApagarCampoPersonalizado()
        {
            return GetText(mensagemDeSucessoApagarCampoPersonalizado);
        }

        #endregion
    }
}
