using SeleniumAutomationMantis.Bases;
using OpenQA.Selenium;

namespace SeleniumAutomationMantis.Pages
{
    public class LoginPage : PageBase
    {
       #region Mapping

       By usuario = By.Id("username");

       By senha = By.Id("password");

       By manterConexao = By.XPath("//span[text()='Mantenha-me conectado(a)']");

       By permtirConexaoSomenteComEsteIP = By.XPath("//span[text()='Somente permitir que sua sessão seja utilizada a partir deste endereço IP.']");

       By entrar = By.XPath("//input[@value='Entrar']");

       By mensagemErroLogin = By.XPath("//div[@class='alert alert-danger']");

       #endregion

       #region Actions

       public void PreencherUsuario(string usuario)
       {
         SendKeysJavaScript(this.usuario, usuario);
       }

       public void PreencherSenha(string senha)
       {
        SendKeysJavaScript(this.senha, senha);
       }

       public void ClicarEmEntrar()
       {
        ClickJavaScript(entrar);
       }

       public void ClicarEmManterConexao()
       {
        ClickJavaScript(manterConexao);
       }

       public void ClicarEmPermitirConexaoSomenteComEsteIP()
       {
        ClickJavaScript(permtirConexaoSomenteComEsteIP);
       }

       public string RetornaMensagemDeErroDeLogin()
        {
            return GetText(mensagemErroLogin);
        }

        #endregion
    }
}