using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmdarisTests.Pages
{
    public class LogInPage
    {
        public IWebDriver _webDriver { get; }
        public WebDriverWait _wait { get; }
        public LogInPage(IWebDriver webDriver, WebDriverWait wait)
        {
            _webDriver = webDriver;
            _wait = wait;
        }
        public IWebElement loginButton => _webDriver.FindElement(By.XPath("//div[@class='button']"));
        public void ClickLogInButton()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(loginButton)).Click();
        }
    }
}
