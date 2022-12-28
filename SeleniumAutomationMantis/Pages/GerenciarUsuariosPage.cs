using SeleniumAutomationMantis.Bases;
using OpenQA.Selenium;

namespace SeleniumAutomationMantis.Pages
{
    public class GerenciarUsuariosPage : PageBase
    {
        #region Mapping
        By criarNovaContaButton = By.XPath("//a[@class='btn btn-primary btn-white btn-round btn-sm']");
        By criarUsuarioButton = By.XPath("//input[@value='Criar Usuário']");
        By mensagemErro = By.XPath("//p[@class='bold']");
        By nomeUsuarioTextField = By.Id("user-username");
        By nomeVerdadeiroTextField = By.Id("user-realname");
        By emailTextField = By.Id("email-field");
        By nivelAcessoCombobox = By.Id("user-access-level");
        By apagarUsuarioButton = By.XPath("//input[@value='Apagar Usuário']");
        By apagarContaButton = By.XPath("//input[@value='Apagar Conta']");
        By mensagemSucesso = By.XPath("//p[@class='bold bigger-110']");
        By habilitadoCheckbox = By.XPath("//form[@id='edit-user-form']//span[@class='lbl']");
        By atualizarUsuarioButton = By.XPath("//input[@value='Atualizar Usuário']");
        By alterarNomeUsuarioTextField = By.Id("edit-username");
        By alterarNivelAcessoUsuario = By.Id("edit-access-level");
        By mostrarDesativadosCheckbox = By.XPath("//span[text()='Mostrar desativados']");
        By aplicarFiltroButton = By.XPath("//input[@value='Aplicar Filtro']");
        #endregion

        #region Actions
        public void ClicarEmCriarNovaConta()
        {
            Click(criarNovaContaButton);
        }

        public void ClicarEmCriarUsuario()
        {
            Click(criarUsuarioButton);
        }

        public string RetornaMensagemDeErro()
        {
            return GetText(mensagemErro);
        }

        public void PreencherCampoNomeUsuario(string nomeUsuario)
        {
            SendKeys(nomeUsuarioTextField, nomeUsuario);
        }

        public void PreencherCampoNomeVerdadeiro(string nomeVerdadeiro)
        {
            SendKeys(nomeVerdadeiroTextField, nomeVerdadeiro);
        }

        public void PreencherCampoEmail(string email)
        {
            SendKeys(emailTextField, email);
        }

        public void SelecionarNivelDeAcessoCombobox(string nivelAcesso)
        {
            ComboBoxSelectByVisibleText(nivelAcessoCombobox, nivelAcesso);
        }

        public void ClicarEmApagar()
        {
            Click(apagarUsuarioButton);
        }

        public void ClicarEmApagarConta()
        {
            Click(apagarContaButton);
        }

        public void ClicarNoUsuario(string usuario)
        {
            Click(By.XPath("//a[text()='" + usuario + "']"));
        }

        public string RetornaMensagemDeSucesso()
        {
            return GetText(mensagemSucesso);
        }

        public void ClicarNoCheckboxHabilitado()
        {
            Click(habilitadoCheckbox);
        }

        public void ClicarEmAtualizarUsuario()
        {
            Click(atualizarUsuarioButton);
        }

        public void SelecionarNovoNivelDeAcessoCombobox(string nivelAcesso)
        {
            ComboBoxSelectByVisibleText(alterarNivelAcessoUsuario, nivelAcesso);
        }

        public void ClicarNoCheckboxMostrarDesativados()
        {
            Click(mostrarDesativadosCheckbox);
        }

        public void ClicarEmAplicarFiltro()
        {
            Click(aplicarFiltroButton);
        }

        public string RetornaUsuario(string usuario)
        {
            return GetText(By.XPath("//a[text()='" + usuario + "']"));
        }

        #endregion
    }
}
