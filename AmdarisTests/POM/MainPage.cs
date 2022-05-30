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
    public class MainPage
    {
        public IWebDriver _webDriver { get; }
        public WebDriverWait _wait { get; }

        public MainPage(IWebDriver driver, WebDriverWait wait)
        {
            _webDriver = driver;
            _wait = wait;
        }

        public By verifyUser => By.TagName("h1");
        public IWebElement openDeliverySites => _webDriver.FindElement(By.XPath("//a [@id = 'delivery sites-tab']"));

        public void AssertText(string expectedResult)
        {
            var actualResult = _wait.Until(ExpectedConditions.ElementIsVisible(verifyUser)).Text;
            Assert.AreEqual(actualResult, expectedResult);
        }

        public void OpenDeliverySites()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(openDeliverySites)).Click();
        }
    }
}
