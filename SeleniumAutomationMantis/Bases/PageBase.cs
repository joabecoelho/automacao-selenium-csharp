using SeleniumAutomationMantis.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace SeleniumAutomationMantis.Bases
{
    public class PageBase
    {
        #region Objects and constructor
        protected OpenQA.Selenium.Support.UI.WebDriverWait wait { get; private set; }
        protected IWebDriver driver { get; private set; }  
        protected IJavaScriptExecutor javaScript { get; private set; }

        public PageBase()
        {
            wait = new OpenQA.Selenium.Support.UI.WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(Convert.ToInt32(BuilderJson.ReturnParameterAppSettings("DEFAULT_TIMEOUT_IN_SECONDS"))));
            driver = DriverFactory.INSTANCE;
            javaScript = (IJavaScriptExecutor)driver;
        }
        #endregion

        #region Custom Actions
        protected IWebElement WaitForElement(By locator)
        {
            wait.Until(ExpectedConditions.ElementExists(locator));
            IWebElement element = driver.FindElement(locator);
            wait.Until(ExpectedConditions.ElementToBeClickable(element));
            return element;
        }

        protected IList<IWebElement> WaitForElements(By locator)
        {
            wait.Until(ExpectedConditions.ElementExists(locator));
            IList<IWebElement> elements = driver.FindElements(locator);
            return elements;
        }

        protected void Click(By locator)
        {
            Stopwatch timeOut = new Stopwatch();
            timeOut.Start();

            while (timeOut.Elapsed.Seconds <= Convert.ToInt32(BuilderJson.ReturnParameterAppSettings("DEFAULT_TIMEOUT_IN_SECONDS")))
            {
                try
                {
                    WaitForElement(locator).Click();
                    timeOut.Stop();
                    ExtentReportHelpers.AddTestInfo(3, "");
                    return;
                }
                catch (System.Reflection.TargetInvocationException)
                {

                }
                catch (StaleElementReferenceException)
                {

                }
                catch (System.InvalidOperationException)
                {

                }
                catch (WebDriverException e)
                {
                    if (e.Message.Contains("Other element would receive the click"))
                    {
                        continue;
                    }

                    if (e.Message.Contains("Element is not clickable at point"))
                    {
                        continue;
                    }

                    throw e;
                }
            }

            throw new Exception("Given element isn't visible");
        }

        protected void SendKeys(By locator, string text)
        {
            WaitForElement(locator).SendKeys(text);
            ExtentReportHelpers.AddTestInfo(3, "PARAMETER: " + text);
        }

        protected void ClearAndSendKeys(By locator, string text)
        {
            IWebElement element = WaitForElement(locator);
            element.SendKeys(Keys.Control + "a");
            element.SendKeys(Keys.Delete);
            element.SendKeys(text);
        }

        protected void SendKeysWithoutWaitVisible(By locator, string text)
        {
            wait.Until(ExpectedConditions.ElementExists(locator));
            IWebElement element = driver.FindElement(locator);
            element.SendKeys(text);
            ExtentReportHelpers.AddTestInfo(3, "PARAMETER: " + text);
        }

        protected void ComboBoxSelectByVisibleText(By locator, string text)
        {
            OpenQA.Selenium.Support.UI.SelectElement comboBox = new OpenQA.Selenium.Support.UI.SelectElement(WaitForElement(locator));
            comboBox.SelectByText(text);
            ExtentReportHelpers.AddTestInfo(3, "PARAMETER: " + text);
        }

        protected void MouseOver(By locator)
        {
            Actions action = new Actions(driver);
            action.MoveToElement(WaitForElement(locator)).Build().Perform();
            ExtentReportHelpers.AddTestInfo(3, "");
        }

        protected string GetText(By locator)
        {
            string text = WaitForElement(locator).Text;
            ExtentReportHelpers.AddTestInfo(3, "RETURN: " + text);
            return text;
        }

        protected string GetValue(By locator)
        {
            string text = WaitForElement(locator).GetAttribute("value");
            ExtentReportHelpers.AddTestInfo(3, "RETURN: " + text);
            return text;
        }

        protected bool ReturnIfElementIsDisplayed(By locator)
        {
            wait.Until(ExpectedConditions.ElementExists(locator));
            bool result = driver.FindElement(locator).Displayed;
            ExtentReportHelpers.AddTestInfo(3, "RETURN: " + result);
            return result;
        }

        protected bool ReturnIfElementIsEnabled(By locator)
        {
            wait.Until(ExpectedConditions.ElementExists(locator));
            bool result = driver.FindElement(locator).Enabled;
            ExtentReportHelpers.AddTestInfo(3, "RETURN: " + result);
            return result;
        }

        protected bool ReturnIfElementIsVisible(By locator)
        {
            try
            {
                driver.FindElement(locator);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }

        protected bool ReturnIfElementIsSelected(By locator)
        {
            wait.Until(ExpectedConditions.ElementExists(locator));
            bool result = driver.FindElement(locator).Selected;
            ExtentReportHelpers.AddTestInfo(3, "RETURN: " + result);
            return result;
        }
        #endregion

        #region JavaScript Actions
        protected void SendKeysJavaScript(By locator, string value)
        {
            wait.Until(ExpectedConditions.ElementExists(locator));
            IWebElement element = driver.FindElement(locator);
            javaScript.ExecuteScript("arguments[0].value='" + value + "';", element);
            ExtentReportHelpers.AddTestInfo(3, "PARAMETER: " + value);
        }

        protected void ClickJavaScript(By locator)
        {
            wait.Until(ExpectedConditions.ElementExists(locator));
            IWebElement element = driver.FindElement(locator);
            javaScript.ExecuteScript("arguments[0].click();", element);
            ExtentReportHelpers.AddTestInfo(3, "");
        }

        protected void ScrollToElementJavaScript(By locator)
        {
            wait.Until(ExpectedConditions.ElementExists(locator));
            IWebElement element = driver.FindElement(locator);
            javaScript.ExecuteScript("arguments[0].scrollIntoView(true);", element);
            ExtentReportHelpers.AddTestInfo(3, "");
        }

        protected void ScrollToTop()
        {
            javaScript.ExecuteScript("window.scrollTo(0, 0);");
            ExtentReportHelpers.AddTestInfo(3, "");
        }
        #endregion

        #region Default Actions
        public void Refresh()
        {
            DriverFactory.INSTANCE.Navigate().Refresh();
            ExtentReportHelpers.AddTestInfo(2, "");
        }

        public void NavigateTo(string url)
        {
            DriverFactory.INSTANCE.Navigate().GoToUrl(url);
            ExtentReportHelpers.AddTestInfo(2, "PARAMETER: " + url);
        }

        public void OpenNewTab()
        {
            javaScript.ExecuteScript("window.open();");
            ExtentReportHelpers.AddTestInfo(2, "");
        }

        public void SetFocusToLastTab()
        {
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            ExtentReportHelpers.AddTestInfo(2, "");
        }

        public void SetFocusToFirstTab()
        {
            driver.SwitchTo().Window(driver.WindowHandles.First());
            ExtentReportHelpers.AddTestInfo(2, "");
        }

        public string GetTitle()
        {
            string title = driver.Title;
            ExtentReportHelpers.AddTestInfo(2, "RETURN: " + title);

            return title;
        }

        public string GetURL()
        {
            string url = driver.Url;
            ExtentReportHelpers.AddTestInfo(2, "RETURN: " + url);

            return url;
        }
        #endregion

        #region OtherMethods
        public bool VerifyDownloadFile(string filename)
        {
            bool exist = false;
            string Path = System.Environment.GetEnvironmentVariable("USERPROFILE") + "\\Downloads";
            string[] filePaths = Directory.GetFiles(Path);
            foreach (string p in filePaths)
            {
                if (p.Contains(filename))
                {
                    FileInfo thisFile = new FileInfo(p);
                    if (thisFile.LastWriteTime.ToShortTimeString() == DateTime.Now.ToShortTimeString() ||
                    thisFile.LastWriteTime.AddMinutes(1).ToShortTimeString() == DateTime.Now.ToShortTimeString() ||
                    thisFile.LastWriteTime.AddMinutes(2).ToShortTimeString() == DateTime.Now.ToShortTimeString() ||
                    thisFile.LastWriteTime.AddMinutes(3).ToShortTimeString() == DateTime.Now.ToShortTimeString())
                        exist = true;
                    File.Delete(p);
                    break;
                }
            }
            return exist;
        }

        public bool VerifyContains(By locator, string looking4)
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(locator));
            IWebElement element = driver.FindElement(locator);
            String value = element.GetAttribute("value");
            Stopwatch sw = new Stopwatch();
            sw.Start();

            while (!value.Contains(looking4) && sw.Elapsed.TotalSeconds < 30)
            {
                value = element.GetAttribute("value");
            }
            sw.Stop();

            Assert.IsTrue(value.Contains(looking4));
            return true;

        }

        protected bool WaitElementDisapear(By locator)
        {
            WaitForElement(locator);
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(locator));

        }

        protected void WaitElementEnable(By locator)
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(locator));
            IWebElement element = driver.FindElement(locator);
            wait.Until(driver => element.Enabled);

        }

        protected void CBOptions(By locator, string text)
        {
            IList<IWebElement> listaelementos = WaitForElements(locator);
            foreach (var element in listaelementos)
            {
                if (element.Text.Equals(text))
                {
                    element.Click();
                }
            }
        }

        
        #endregion
    }
}
