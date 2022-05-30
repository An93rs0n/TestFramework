using AmdarisTests.Pages;
using AmdarisTests.POM;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace AmdarisTests
{
    public class Preconditions
    {
        public IWebDriver _webDriver;
        public WebDriverWait _wait;

        public void LoginPrecondition()
        {
            ChromeOptions options = new ChromeOptions();

            options.AddArguments("--start-maximized");
            options.AddArguments("--disable-extensions");
            options.AddArguments("--incognito");

            _webDriver = new ChromeDriver(options);

            _webDriver.Navigate().GoToUrl("https://projectplanappweb-stage.azurewebsites.net/login");

            _webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            _wait = new WebDriverWait(_webDriver, TimeSpan.FromSeconds(30));

            LogInPage logInPage = new LogInPage(_webDriver, _wait);
            logInPage.ClickLogInButton();

            EmailPage emailPage = new EmailPage(_webDriver, _wait);
            emailPage.WriteEmail("automation.pp@amdaris.com");
            emailPage.ClickNextButton();

            PasswordPage passwordPage = new PasswordPage(_webDriver, _wait);
            passwordPage.WritePassword("10704-observe-MODERN-products-STRAIGHT-69112");
            passwordPage.ClickSignInButton();

            ConfirmationPage confirmationPage = new ConfirmationPage(_webDriver, _wait);
            confirmationPage.ClickYesButton();
        }
        public void DeliverySitesPrecondition()
        {
            MainPage mainPage = new MainPage(_webDriver, _wait);
            mainPage.OpenDeliverySites();

            DeliverySitesPage deliverySitesPage = new DeliverySitesPage(_webDriver, _wait);
            deliverySitesPage.OpenAmdarisMd();
            deliverySitesPage.OpenPublicHolidays();
        }
    }
}