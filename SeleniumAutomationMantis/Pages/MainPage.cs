using SeleniumAutomationMantis.Bases;
using OpenQA.Selenium;

namespace SeleniumAutomationMantis.Pages
{
    public class MainPage : PageBase
    {
        #region Mapping
        By minhaVisao = By.XPath("//a/span[text()=' Minha Visão ']");
        By verTarefas = By.XPath("//a/span[text()=' Ver Tarefas ']");
        By criarTarefa = By.XPath("//a/span[text()=' Criar Tarefa ']");
        By registroDeMudancas = By.XPath("//a/span[text()=' Registro de Mudanças ']");
        By planejamento = By.XPath("//a/span[text()=' Planejamento ']");
        By resumo = By.XPath("//a/span[text()=' Resumo ']");
        By gerenciar = By.XPath("//a/span[text()=' Gerenciar ']");
        By usernameLoginLink = By.LinkText("administrator");
        #endregion

        #region Actions
       
        public void ClicarEmMinhaVisao()
        {
            Click(minhaVisao);
        }
        public void ClicarEmVerTarefas()
        {
            Click(verTarefas);
        }
        public void ClicarEmCriarTarefa()
        {
            Click(criarTarefa);
        }
        public void ClicarEmRegistroDeMudancas()
        {
            Click(registroDeMudancas);
        }
        public void ClicarEmPlanejamento()
        {
            Click(planejamento);
        }
        public void ClicarEmResumo()
        {
            Click(registroDeMudancas);
        }
        public void ClicarEmGerenciar()
        {
            Click(gerenciar);
        }

         public string RetornaUsernameDeLogin()
        {
            return GetText(usernameLoginLink);
        }
        #endregion
    }
}
