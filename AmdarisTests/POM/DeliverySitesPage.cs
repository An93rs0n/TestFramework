using NUnit.Framework;
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
    public class DeliverySitesPage
    {
        public IWebDriver _webDriver { get; }
        public WebDriverWait _wait { get; }

        public DeliverySitesPage(IWebDriver driver, WebDriverWait wait)
        {
            _webDriver = driver;
            _wait = wait;
        }

        public IWebElement openAmdarisMd => _webDriver.FindElement(By.XPath("//a [@href = '/delivery-sites/3']"));
        public IWebElement openPublicHolidays => _webDriver.FindElement(By.XPath("//a [@href = '/delivery-sites/3/holidays']"));

        public void OpenAmdarisMd()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(openAmdarisMd)).Click();
        }
        public void OpenPublicHolidays()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(openPublicHolidays)).Click();
        }
    }
}
