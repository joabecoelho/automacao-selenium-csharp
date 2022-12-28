using SeleniumAutomationMantis.Bases;
using OpenQA.Selenium;
using System;

namespace SeleniumAutomationMantis.Pages
{
    public class MinhaVisaoPage : PageBase
    {
        #region Actions
        public string RetornaTarefasAtribuidasAMim(string numberTask)
        {
            return GetText(By.XPath("//div[@id='assigned']//a[text()='"+ numberTask +"']"));
        }
        
        public String RetornaTarefaNaoAtribuidaANenhumUsuario(string numberTask)
        {
            return GetText(By.XPath("//div[@id='unassigned']//a[text()='" + numberTask + "']"));
        }

        public string RetornaTarefaMonitorada(string numberTask)
        {
            return GetText(By.XPath("//div[@id='monitored']//a[text()='"+numberTask+"']"));
        }

        public string RetornaNumeroDaTarefaModificada(string numberTask)
        {
            return GetText(By.XPath("//div[@id='recent_mod']//a[text()='" + numberTask + "']"));
        }

        #endregion
    }
}
