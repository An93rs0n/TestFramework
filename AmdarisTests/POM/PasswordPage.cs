using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmdarisTests.POM
{
    public class PasswordPage
    {
        public IWebDriver _webDriver { get; }
        public WebDriverWait _wait { get; }

        public PasswordPage(IWebDriver driver, WebDriverWait wait)
        {
            _webDriver = driver;
            _wait = wait;
        }

        public IWebElement signinButton => _webDriver.FindElement(By.XPath("//input[@type = 'submit'][@value = 'Sign in']"));

        public void WritePassword(string password)
        {
            _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//input[@type='password']"))).SendKeys(password);
        }
        public void ClickSignInButton()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(signinButton)).Click();
        }
    }
}
