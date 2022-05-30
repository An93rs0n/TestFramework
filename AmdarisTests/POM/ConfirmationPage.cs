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
    public class ConfirmationPage
    {
        public IWebDriver _webDriver { get; }
        public WebDriverWait _wait { get; }

        public ConfirmationPage(IWebDriver driver, WebDriverWait wait)
        {
            _webDriver = driver;
            _wait = wait;
        }

        public IWebElement yesButton => _webDriver.FindElement(By.XPath("//input[@type = 'submit'][@value = 'Yes']"));

        public void ClickYesButton()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(yesButton)).Click();
        }
    }
}
