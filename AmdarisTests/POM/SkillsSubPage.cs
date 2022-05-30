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
    public class SkillsSubPage
    {
        public IWebDriver _webDriver;
        public WebDriverWait _wait;

        public SkillsSubPage(IWebDriver driver, WebDriverWait wait)
        {
            _webDriver = driver;
            _wait = wait;
        }

        private IWebElement addSkill => _webDriver.FindElement(By.XPath("//i [@class='fas fa-plus-circle fs-16 dark']"));
        private IWebElement writeSkillName => _webDriver.FindElement(By.XPath("//input [@id = 'name']"));
        private IWebElement openSkillCategoryList => _webDriver.FindElement(By.XPath("//span [@class='mat-select-placeholder ng-tns-c116-23 ng-star-inserted']"));
        private IWebElement selectSkillCategory => _webDriver.FindElement(By.XPath("//mat-option[12]/span"));
        private IWebElement saveSkill => _webDriver.FindElement(By.XPath("//button [@type = 'submit']"));
        private By validateCreation => By.XPath("//simple-snack-bar/span");

        public void AddSkill()
        {
            addSkill.Click();
        }
        public void WriteSkillName()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(writeSkillName)).SendKeys("Selenium skillss");
        }
        public void OpenSkillCategoryList()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(openSkillCategoryList)).Click();
        }
        public void SelectSkillCategory()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(selectSkillCategory)).Click();
        }
        public void SaveSkill()
        {
            saveSkill.Click();
        }
        public void ValidateCreation(string expectedResult)
        {
            var actualResult = _wait.Until(ExpectedConditions.ElementIsVisible(validateCreation)).Text;
            Assert.AreEqual(actualResult, expectedResult);
        }
    }
}
