using SeleniumAutomationMantis.Bases;
using OpenQA.Selenium;

namespace SeleniumAutomationMantis.Pages
{
    public class VerTarefasPage : PageBase
    {
        #region Mapping
        By redefinirButton = By.XPath("//div[@class='btn-group pull-left']/a[@href='view_all_set.php?type=0']");
        By tarefaLinkText = By.XPath("//td[@class='column-id']/a");
        By editarTarefaButton = By.XPath("//i[@title='Atualizar']");
        By estadoTarefaLinkText = By.Id("show_status_filter");
        By estadoCombobox = By.XPath("//select[@name='status[]']");
        By aplicarFiltroButton = By.XPath("//input[@value='Aplicar Filtro']");
        By tarefasInfomacoesTable = By.XPath("//table[@id='buglist']/tbody");
        #endregion

        #region Actions
        public void ClicarEmRedefinir()
        {
            Click(redefinirButton);
        }

        public void ClicarNaTarefa()
        {
            Click(tarefaLinkText);
        }

        public void ClicarEmAplicarFiltro()
        {
            Click(aplicarFiltroButton);
        }

        public void ClicarNoFiltroEstadoDaTarefa()
        {
            Click(estadoTarefaLinkText);
        }

        public void SelecionarEstadoDaTarefa(string estado)
        {
            ComboBoxSelectByVisibleText(estadoCombobox, estado);
        }

        public void ClicarEmEditarTarefa()
        {
            Click(editarTarefaButton);
        }

        public string RetornaInformacoesDaTarefaNaTabela()
        {
            return GetText(tarefasInfomacoesTable);
        }
        #endregion
    }
}
