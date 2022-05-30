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
    public class PublicHolidaysSubPage
    {
        public IWebDriver _webDriver { get; }
        public WebDriverWait _wait { get; }
        public PublicHolidaysSubPage(IWebDriver driver, WebDriverWait wait)
        {
            _webDriver = driver;
            _wait = wait;
        }

        public IWebElement pressAddHolidayButton => _webDriver.FindElement(By.XPath("//i [@class = 'fas fa-plus-circle dark fs-16']"));
        public IWebElement openCalendar => _webDriver.FindElement(By.XPath("//input [@formcontrolname = 'holidayDate']"));
        public IWebElement chooseDate => _webDriver.FindElement(By.XPath("//td [@aria-label = '31 May 2022']"));
        public IWebElement writeText => _webDriver.FindElement(By.XPath("//input [@name = 'description']"));
        public IWebElement pressSaveButton => _webDriver.FindElement(By.XPath("//button [@type = 'submit']"));
        public IWebElement pressDeleteButton => _webDriver.FindElement(By.XPath("//i [@mattooltip = 'Delete']"));
        public IWebElement confirmDelete => _webDriver.FindElement(By.XPath("//button [@attr.ui-automation-id= 'confirmationPopUpYesButton']"));
        public By verifyIfHolidayDeleted => By.XPath("//span[contains(text(),'Public holiday deleted successfully')]");
        public IWebElement pressEditButton => _webDriver.FindElement(By.XPath("//i [@mattooltip ='Edit']"));
        public IWebElement searchHoliday => _webDriver.FindElement(By.XPath("//input [@aria-label = 'search']"));
        public By verifyIfHolidayCreated => By.XPath("//span[contains(text(),'Holiday was added successfully')]");
        public By verifyIfHolidayUpdated => By.XPath("//span[contains(text(),'Holiday was updated successfully')]");
        public By verifyIfHolidayExist => By.XPath("//span[contains(text(),'Todos')]");
        public By verifyError => By.XPath("//mat-error [@role = 'alert']");
        public By pressOnHeader => By.XPath("//h2 [@class = 'mat-dialog-title']");
        

        public void PressAddHolidayButton()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(pressAddHolidayButton)).Click();
        }
        public void OpenCalendar()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(openCalendar)).Click();
        }
        public void ChooseDate()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(chooseDate)).Click();
        }
        public void WriteText(string text)
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(writeText)).SendKeys(text);
        }
        public void PressSaveButton()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(pressSaveButton)).Click();
        }
        public void PressDeleteButton()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(pressDeleteButton)).Click();
        }
        public void ConfirmDelete()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(confirmDelete)).Click();
        }
        public void PressOnHeader()
        {
            _wait.Until(ExpectedConditions.ElementIsVisible(pressOnHeader)).Click();
        }
        public void VerifyIfHolidayCreated(string expectedResult)
        {
            var actualResult = _wait.Until(ExpectedConditions.ElementIsVisible(verifyIfHolidayCreated)).Text;
            StringAssert.AreEqualIgnoringCase(expectedResult, actualResult);
            Assert.AreEqual(actualResult, expectedResult);
            Assert.IsTrue(actualResult.Contains(expectedResult));
            Assert.IsNotNull(actualResult);
            Assert.IsInstanceOf(typeof(string), actualResult);
        }
        public void VerifyIfHolidayDeleted(string expectedResult)
        {
            var actualResult = _wait.Until(ExpectedConditions.ElementIsVisible(verifyIfHolidayDeleted)).Text;
            StringAssert.AreEqualIgnoringCase(expectedResult, actualResult);
            Assert.AreEqual(actualResult, expectedResult);
            Assert.IsTrue(actualResult.Contains(expectedResult));
            Assert.IsNotNull(actualResult);
            Assert.IsInstanceOf(typeof(string), actualResult);
        }
        public void VerifyIfHolidayExist(string expectedResult)
        {
            var actualResult = _wait.Until(ExpectedConditions.ElementIsVisible(verifyIfHolidayExist)).Text;
            StringAssert.AreEqualIgnoringCase(expectedResult, actualResult);
            Assert.AreEqual(actualResult, expectedResult);
            Assert.IsTrue(actualResult.Contains(expectedResult));
            Assert.IsNotNull(actualResult);
            Assert.IsInstanceOf(typeof(string), actualResult);
        }
        public void VerifyError(string expectedResult)
        {
            var actualResult = _wait.Until(ExpectedConditions.ElementIsVisible(verifyError)).Text;
            StringAssert.AreEqualIgnoringCase(expectedResult, actualResult);
            Assert.AreEqual(actualResult, expectedResult);
            Assert.IsTrue(actualResult.Contains(expectedResult));
            Assert.IsNotNull(actualResult);
            Assert.IsInstanceOf(typeof(string), actualResult);
        }

        public void PressEditButton()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(pressEditButton)).Click();
        }
        public void SearchHoliday(string search)
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(searchHoliday)).SendKeys(search);
        }
        public void VerifyIfHolidayUpdated(string expectedResult)
        {
            var actualResult = _wait.Until(ExpectedConditions.ElementIsVisible(verifyIfHolidayUpdated)).Text;
            StringAssert.AreEqualIgnoringCase(expectedResult, actualResult);
            Assert.AreEqual(actualResult, expectedResult);
            Assert.IsTrue(actualResult.Contains(expectedResult));
            Assert.IsNotNull(actualResult);
            Assert.IsInstanceOf(typeof(string), actualResult);
        }
    }
}
