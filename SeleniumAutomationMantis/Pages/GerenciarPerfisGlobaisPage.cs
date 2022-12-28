using SeleniumAutomationMantis.Bases;
using OpenQA.Selenium;
namespace SeleniumAutomationMantis.Pages
{
    public class GerenciarPerfisGlobaisPage : PageBase
    {
        #region Mapping
        By plataformaTextField = By.Id("platform");

        By platformaEdicaoTextField = By.Name("platform");

        By soTextField = By.Id("os");

        By soEdicaoTextField = By.Name("os");

        By versaoSOTextField = By.Id("os-version");

        By versaoSOEdicaoTextField = By.Name("os_build");

        By descricaoDoSistemaTextField = By.Id("description");

        By adicionarPerfilButton = By.XPath("//input[@value='Adicionar Perfil']");

        By alterarPerfilButton = By.XPath("//tr[1]/td[2]/label/span");

        By atualizarPerfilButton = By.XPath("//div[2]/div[2]/input");

        By apagarPerfilButton = By.XPath("//tr[2]/td[2]/label/span");

        By enviarButton = By.XPath("//input[@value='Enviar']");

        By selecionarPerfilComboBox = By.Id("select-profile");

        By operacaoRealizadaComSucessoText = By.XPath("//p[@class='bold bigger-110']");

        #endregion

        #region Actions

        public void PreencherCampoPlataforma(string plataforma)
        {
            SendKeys(plataformaTextField, plataforma);
        }

        public void PreencherEditarCampoPlataforma(string plataformaEdicao)
        {
            ClearAndSendKeys(platformaEdicaoTextField, plataformaEdicao);
        }

        public void PreencherCampoSO(string so)
        {
            SendKeys(soTextField, so);
        }

        public void PreencherEditarCampoSO(string so)
        {
            ClearAndSendKeys(soEdicaoTextField, so);
        }

        public void PreencherVersaoSO(string versaoSO)
        {
            SendKeys(versaoSOTextField, versaoSO);
        }

        public void PreencherEditarVersaoSO(string versaoSO)
        {
            ClearAndSendKeys(versaoSOEdicaoTextField, versaoSO);
        }

        public void PreencherDescricao(string descricao)
        {
            SendKeys(descricaoDoSistemaTextField, descricao);
        }

        public void ClicarEmAdicionarPerfil()
        {
            Click(adicionarPerfilButton);
        }

        public void CliclarEmAtualizarPerfil()
        {
            Click(atualizarPerfilButton);
        }

        public void ClicarEmAlterarPerfil()
        {
            Click(alterarPerfilButton);
        }

        public void ClicarEmApagarPerfil()
        {
            Click(apagarPerfilButton);
        }

        public void ClicarEmEnviar()
        {
            Click(enviarButton);
        }

        public void SelecionarPerfil(string perfil)
        {
            ComboBoxSelectByVisibleText(selecionarPerfilComboBox, perfil);
        }

        public string RetornaNomeDoPerfilCriado(string nomePerfil)
        {
            return GetText(By.XPath("//option[text()='"+ nomePerfil +"']"));
        }

        public string RetornaMensagemDeOperacaoRealizadaComSucesso()
        {
            return GetText(operacaoRealizadaComSucessoText);
        }

        public bool RetornaSeOFormularioDePefilEExibido()
        {
            return ReturnIfElementIsVisible(By.Id("account-profile-update-form"));
        }

        #endregion
    }
}
