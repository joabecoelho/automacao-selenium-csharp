using SeleniumAutomationMantis.Pages;

namespace SeleniumAutomationMantis.Flows
{
    public class LoginFlows
    {
        #region Page Object and Constructor
        LoginPage loginPage;

        public LoginFlows()
        {
            loginPage = new LoginPage();
        }
        #endregion

        public void EfetuarLogin(string usuario, string senha)
        {
            loginPage.PreencherUsuario(usuario);
            loginPage.ClicarEmEntrar();
            loginPage.PreencherSenha(senha);
            loginPage.ClicarEmEntrar();
        }

        public void EfetuarLoginComManterConexao(string usuario, string senha)
        {
            loginPage.PreencherUsuario(usuario);
            loginPage.ClicarEmEntrar();
            loginPage.PreencherSenha(senha);
            loginPage.ClicarEmManterConexao();
            loginPage.ClicarEmEntrar();
        }

        public void EfetuarLoginComPermitirConexaoSomenteComEsteIP(string usuario, string senha)
        {
            loginPage.PreencherUsuario(usuario);
            loginPage.ClicarEmEntrar();
            loginPage.PreencherSenha(senha);
            loginPage.ClicarEmPermitirConexaoSomenteComEsteIP();
            loginPage.ClicarEmEntrar();
        }

        public void EfetuarLoginComManterConexaoEPermitirConexaoSomenteComEsteIP(string usuario, string senha)
        {
            loginPage.PreencherUsuario(usuario);
            loginPage.ClicarEmEntrar();
            loginPage.PreencherSenha(senha);
            loginPage.ClicarEmManterConexao();
            loginPage.ClicarEmPermitirConexaoSomenteComEsteIP();
            loginPage.ClicarEmEntrar();
        }
    }
}
