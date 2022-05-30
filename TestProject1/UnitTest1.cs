using NUnit.Framework;

namespace TestProject1
{
    public class Tests
    {
        private IWebDriver _webDriver;
        [SetUp]
        public void Setup()
        {
                _webDriver = new ChromeDriver();

                _webDriver.Navigate().GoToUrl("https://projectplanappweb-stage.azurewebsites.net/login");

                Thread.Sleep(2000);
                _webDriver.FindElement(By.XPath("//div[@class='button']")).Click();

                Thread.Sleep(2000);
                _webDriver.FindElement(By.XPath("//input[@type = 'email']")).SendKeys("automation.pp@amdaris.com");
                _webDriver.FindElement(By.XPath("//input[@type = 'submit'][@value = 'Next']")).Click();

                Thread.Sleep(2000);
                _webDriver.FindElement(By.XPath("//input[@type = 'password']")).SendKeys("10704-observe-MODERN-products-STRAIGHT-69112");
                _webDriver.FindElement(By.XPath("//input[@type = 'submit'][@value = 'Sign in']")).Click();

                Thread.Sleep(2000);
                _webDriver.FindElement(By.XPath("//input[@type = 'submit'][@value = 'Yes']")).Click();
            }
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}