using SeleniumAutomationMantis.Bases;
using OpenQA.Selenium;

namespace SeleniumAutomationMantis.Pages
{
    public class GerenciarPage : PageBase
    {
        #region Mapping
        By gerenciarUsuariosTab = By.XPath("//a[text()='Gerenciar Usuários']");
        By gerenciarMarcadoresTab = By.XPath("//a[text()='Gerenciar Marcadores']");
        By gerenciarCamposPersonalizadosTab = By.XPath("//a[text()='Gerenciar Campos Personalizados']");
        By gerenciarProjetosTab = By.XPath("//a[text()='Gerenciar Projetos']");
        By gerenciarPerfisGlobaisTab = By.XPath("//a[text()='Gerenciar Perfís Globais']");
        #endregion

        #region Actions
        public void ClicarEmGerenciarUsuarios()
        {
            Click(gerenciarUsuariosTab);
        }

        public void ClicarEmGerenciarMarcadores()
        {
            Click(gerenciarMarcadoresTab);
        }

        public void ClicarEmGerenciarCamposPersonalizados()
        {
            Click(gerenciarCamposPersonalizadosTab);
        }

        public void ClicarEmGerenciarProjetos()
        {
            Click(gerenciarProjetosTab);
        }

        public void ClicarEmGerenciarPerfisGlobais()
        {
            Click(gerenciarPerfisGlobaisTab);
        }

        #endregion
    }
}
