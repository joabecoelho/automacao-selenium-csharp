using SeleniumAutomationMantis.Bases;
using OpenQA.Selenium;

namespace SeleniumAutomationMantis.Pages
{
    public class GerenciarProjetosPage : PageBase
    {
        #region Mapping
        By criarNovoProjetoButton = By.XPath("//button[text()='Criar Novo Projeto']");
        By nomeProjetoTextField = By.Id("project-name");
        By adicionarProjetoButton = By.XPath("//input[@value='Adicionar projeto']");
        By mensagemSucesso = By.XPath("//p[@class='bold bigger-110']");
        By nomeProjetoLinkText = By.XPath("//div[@id='main-container']//td/a");
        By apagarProjetoButton = By.XPath("//input[@value='Apagar Projeto']");
        By informacoesProjetoText = By.XPath("//div[@id='main-container']//tbody");
        By estadoCheckbox = By.Id("project-status");
        By atualizarProjetoButton = By.XPath("//input[@value='Atualizar Projeto']");
        By alterarCategoriaButton = By.XPath("//button[text()='Alterar']");
        By categoriaTextField = By.Id("proj-category-name");
        By atualizarCategoriaButton = By.XPath("//input[@value='Atualizar Categoria']");
        By nomeCategoriaTextField = By.XPath("//input[@name='name']");
        By adicionarCategoriaButton = By.XPath("//input[@value='Adicionar Categoria']");
        By mensagemErro = By.XPath("//p[@class='bold']");
        By apagarCategoriaButton = By.XPath("//button[text()='Apagar']");
        By confirmarApagarCategoriaButton = By.XPath("//input[@value='Apagar Categoria']");
        By adicionarEEditarCategoriaButton = By.XPath("//input[@value='Adicionar e editar Categoria']");


        #endregion

        #region Actions
        public void ClicarEmCriarNovoProjeto()
        {
            Click(criarNovoProjetoButton);
        }

        public void PreencherCampoNomeDoProjeto(string nome)
        {
            ClearAndSendKeys(nomeProjetoTextField, nome);
        }

        public void ClicarEmAdicionarProjeto()
        {
            Click(adicionarProjetoButton);
        }

        public string RetornaMensagemDeSucesso()
        {
            return GetText(mensagemSucesso);
        }

        public void ClicarNoProjeto()
        {
            Click(nomeProjetoLinkText);
        }

        public void ClicarEmApagarProjeto()
        {
            Click(apagarProjetoButton);
        }

        public string RetornaInformacoesDoProjeto()
        {
            return GetText(informacoesProjetoText);
        }

        public void SelecionarEstadoDoProjeto(string estado)
        {
            ComboBoxSelectByVisibleText(estadoCheckbox, estado);
        }

        public void ClicarEmAtualizarProjeto()
        {
            Click(atualizarProjetoButton);
        }

        public string RetornaNomeDoProjeto(string nomeProjeto)
        {
            return GetText(By.XPath("//td/a[text()='"+ nomeProjeto +"']"));
        }

        public void ClicarEmAlterarCategoria()
        {
            Click(alterarCategoriaButton);
        }

        public void PreencherCategoria(string categoria)
        {
            ClearAndSendKeys(categoriaTextField, categoria);
        }

        public void ClicarEmAtualizarCategoria()
        {
            Click(atualizarCategoriaButton);
        }

        public string RetornaNomeDaCategoria(string nomeCategoria)
        {
            return GetText(By.XPath("//div[@id='categories']//td[text()='" + nomeCategoria + "']"));
        }

        public void PreencherNomeCategoria(string categoria)
        {
            ClearAndSendKeys(nomeCategoriaTextField, categoria);
        }

        public void ClicarEmAdicionarCategoria()
        {
            Click(adicionarCategoriaButton);
        }

        public string RetornaMensagemDeErro()
        {
            return GetText(mensagemErro);
        }

        public void ClicarEmApagarCategoria()
        {
            Click(apagarCategoriaButton);
        }

        public void ClicarEmConfirmarApagarCategoria()
        {
            Click(confirmarApagarCategoriaButton);
        }

        public void ClicarEmAdicionarEEditarCategoria()
        {
            Click(adicionarEEditarCategoriaButton);
        }

        #endregion
    }
}