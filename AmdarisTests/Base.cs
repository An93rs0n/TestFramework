/* using AmdarisTests.POM;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Threading;

namespace AmdarisTests
{
    public class Base : Preconditions
    {

        [SetUp]
        public void Setup()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--start-maximized");
            options.AddArguments("--disable-extensions");
            options.AddArguments("--incognito");

            _webDriver = new ChromeDriver(options);
            LoginPrecondition();
            DeliverySitesPrecondition();
        }

        [TearDown]
        public void TearDown()
        {
            _webDriver.Close();
            _webDriver.Quit();
        }
    }
} */