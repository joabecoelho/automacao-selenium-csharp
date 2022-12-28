using SeleniumAutomationMantis.Bases;
using OpenQA.Selenium;
namespace SeleniumAutomationMantis.Pages
{
    public class GerenciarMarcadoresPage : PageBase
    {
        #region Mapping
        By nomeMarcadorTextField = By.Id("tag-name");
        By criarMarcadorButton = By.XPath("//input[@type='submit']");
        By nomeMarcadorLinkText = By.XPath("//div[@id='main-container']//td/a");
        By apagarMarcadorButton = By.XPath("//input[@value='Apagar Marcador']");
        By informacoesMarcadorText = By.XPath("//div[@id='main-container']//tbody");
        By atualizarMarcadorButton = By.XPath("//input[@value='Atualizar Marcador']");

        #endregion

        #region Actions

        public void PreencherCampoNome(string nome)
        {
            ClearAndSendKeys(nomeMarcadorTextField, nome);
        }

        public void ClicarEmCriarMarcador()
        {
            Click(criarMarcadorButton);
        }

        public string RetornaNomeMarcador(string nomeMarcador)
        {
            return GetText(By.XPath("//a[text()='" + nomeMarcador + "']"));
        }

        public void ClicarNoMarcador()
        {
            Click(nomeMarcadorLinkText);
        }

        public void ClicarEmApagarMarcador()
        {
            Click(apagarMarcadorButton);
        }

        public string RetornaInformacoesMarcador()
        {
            return GetText(informacoesMarcadorText);
        }

        public void ClicarEmAtualizarMarcador()
        {
            Click(atualizarMarcadorButton);
        }

        public string RetornaNomeMarcadorAlterado(string nomeMarcador)
        {
            return GetText(By.XPath("//div[@id='main-container']//td[text()='" + nomeMarcador + "']"));
        }

        #endregion
    }
}
