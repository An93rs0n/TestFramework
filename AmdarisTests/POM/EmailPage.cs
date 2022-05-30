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
    public class EmailPage
    {
        public IWebDriver _webDriver { get; }
        public WebDriverWait _wait { get; }

        public EmailPage(IWebDriver driver, WebDriverWait wait)
        {
            _webDriver = driver;
            _wait = wait;
        }

        public IWebElement emailForm => _webDriver.FindElement(By.XPath("//input[@type = 'email']"));
        public IWebElement nextButton => _webDriver.FindElement(By.XPath("//input[@type = 'submit'][@value = 'Next']"));

        public void WriteEmail(string email)
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(emailForm)).SendKeys(email);
        }
        public void ClickNextButton()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(nextButton)).Click();
        }
    }
}
