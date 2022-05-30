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
    public class Tests : Base
    {

        [Test]
        public void CreateHoliday()
        {
            PublicHolidaysSubPage publicHolidaysSubPage = new PublicHolidaysSubPage(_webDriver, _wait);
            publicHolidaysSubPage.PressAddHolidayButton();
            publicHolidaysSubPage.OpenCalendar();
            publicHolidaysSubPage.ChooseDate();
            publicHolidaysSubPage.WriteText("Test holiday by Todos Alexandru");
            publicHolidaysSubPage.PressSaveButton();
            publicHolidaysSubPage.VerifyIfHolidayCreated("Holiday was added successfully");
        }

        [Test]
        public void SearchHoliday()
        {
            PublicHolidaysSubPage publicHolidaysSubPage = new PublicHolidaysSubPage(_webDriver, _wait);
            publicHolidaysSubPage.SearchHoliday("Todos");
            publicHolidaysSubPage.VerifyIfHolidayExist("Test holiday by Todos Alexandru");
        }

        [Test]
        public void ModifyHoliday()
        {
            PublicHolidaysSubPage publicHolidaysSubPage = new PublicHolidaysSubPage(_webDriver, _wait);
            publicHolidaysSubPage.SearchHoliday("Todos");
            publicHolidaysSubPage.PressEditButton();
            publicHolidaysSubPage.WriteText(" edited");
            publicHolidaysSubPage.PressSaveButton();
            publicHolidaysSubPage.VerifyIfHolidayUpdated("Holiday was updated successfully");
        }

        [Test]
        public void DeleteHoliday()
        {
            PublicHolidaysSubPage publicHolidaysSubPage = new PublicHolidaysSubPage(_webDriver, _wait);
            publicHolidaysSubPage.SearchHoliday("Todos");
            publicHolidaysSubPage.PressDeleteButton();
            publicHolidaysSubPage.ConfirmDelete();
            publicHolidaysSubPage.VerifyIfHolidayDeleted("Public holiday deleted successfully");
        }

        [Test]
        public void ExceedLimit()
        {
            PublicHolidaysSubPage publicHolidaysSubPage = new PublicHolidaysSubPage(_webDriver, _wait);
            publicHolidaysSubPage.PressAddHolidayButton();
            publicHolidaysSubPage.OpenCalendar();
            publicHolidaysSubPage.ChooseDate();
            publicHolidaysSubPage.WriteText("Test holiday by Todos Alexandru Test holiday by Todos Alexandru Test holiday by Todos Alexandru Test holiday by Todos Alexandru");
            publicHolidaysSubPage.PressOnHeader();
            publicHolidaysSubPage.VerifyError("The length must not exceed 50 characters.");
        }
    }
} */