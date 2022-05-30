using AmdarisTests.POM;
using TechTalk.SpecFlow;

namespace AmdarisTests.Steps
{
    [Binding]
    public class AddPublicHolidaySteps : Preconditions
    {
        [BeforeScenario]
        public void BeforeScenario()
        {
            LoginPrecondition();
            DeliverySitesPrecondition();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _webDriver.Close();
            _webDriver.Quit();
        }

        [When(@"user press add public holiday button")]
        public void WhenUserPressAddPublicHolidayButton()
        {
            PublicHolidaysSubPage publicHolidaysSubPage = new PublicHolidaysSubPage(_webDriver, _wait);
            publicHolidaysSubPage.PressAddHolidayButton();
        }

        [When(@"choose date")]
        public void WhenChooseDate()
        {
            PublicHolidaysSubPage publicHolidaysSubPage = new PublicHolidaysSubPage(_webDriver, _wait);
            publicHolidaysSubPage.OpenCalendar();
            publicHolidaysSubPage.ChooseDate();
        }

        [When(@"add a description")]
        public void WhenAddADescription()
        {
            PublicHolidaysSubPage publicHolidaysSubPage = new PublicHolidaysSubPage(_webDriver, _wait);
            publicHolidaysSubPage.WriteText("Test holiday by Todos Alexandru");
        }

        [When(@"press save button")]
        public void WhenPressSaveButton()
        {
            PublicHolidaysSubPage publicHolidaysSubPage = new PublicHolidaysSubPage(_webDriver, _wait);
            publicHolidaysSubPage.PressSaveButton();
        }

        [Then(@"holiday is created")]
        public void ThenHolidayIsCreated()
        {
            PublicHolidaysSubPage publicHolidaysSubPage = new PublicHolidaysSubPage(_webDriver, _wait);
            publicHolidaysSubPage.VerifyIfHolidayCreated("Holiday was added successfully");
        }

        [When(@"user enter search term")]
        public void WhenUserEnterSearchTerm()
        {
            PublicHolidaysSubPage publicHolidaysSubPage = new PublicHolidaysSubPage(_webDriver, _wait);
            publicHolidaysSubPage.SearchHoliday("Todos");
        }

        [Then(@"search results are shown")]
        public void ThenSearchResultsAreShown()
        {
            PublicHolidaysSubPage publicHolidaysSubPage = new PublicHolidaysSubPage(_webDriver, _wait);
            publicHolidaysSubPage.VerifyIfHolidayExist("Test holiday by Todos Alexandru");
        }

        [When(@"user press edit button on created holiday")]
        public void WhenUserPressEditButtonOnCreatedHoliday()
        {
            PublicHolidaysSubPage publicHolidaysSubPage = new PublicHolidaysSubPage(_webDriver, _wait);
            publicHolidaysSubPage.SearchHoliday("Todos");
            publicHolidaysSubPage.PressEditButton();
        }

        [When(@"change description")]
        public void WhenChangeDescription()
        {
            PublicHolidaysSubPage publicHolidaysSubPage = new PublicHolidaysSubPage(_webDriver, _wait);
            publicHolidaysSubPage.WriteText(" edited");
        }

        [Then(@"press save button")]
        public void ThenPressSaveButton()
        {
            PublicHolidaysSubPage publicHolidaysSubPage = new PublicHolidaysSubPage(_webDriver, _wait);
            publicHolidaysSubPage.PressSaveButton();
        }

        [Then(@"holiday is updated")]
        public void ThenHolidayIsUpdated()
        {
            PublicHolidaysSubPage publicHolidaysSubPage = new PublicHolidaysSubPage(_webDriver, _wait);
            publicHolidaysSubPage.VerifyIfHolidayUpdated("Holiday was updated successfully");
        }

        [When(@"user press Delete button on created holiday")]
        public void WhenUserPressDeleteButtonOnCreatedHoliday()
        {
            PublicHolidaysSubPage publicHolidaysSubPage = new PublicHolidaysSubPage(_webDriver, _wait);
            publicHolidaysSubPage.SearchHoliday("Todos");
            publicHolidaysSubPage.PressDeleteButton();
        }

        [When(@"confirm deletion")]
        public void WhenConfirmDeletion()
        {
            PublicHolidaysSubPage publicHolidaysSubPage = new PublicHolidaysSubPage(_webDriver, _wait);
            publicHolidaysSubPage.ConfirmDelete();
        }

        [Then(@"holiday is deleted")]
        public void ThenHolidayIsDeleted()
        {
            PublicHolidaysSubPage publicHolidaysSubPage = new PublicHolidaysSubPage(_webDriver, _wait);
            publicHolidaysSubPage.VerifyIfHolidayDeleted("Public holiday deleted successfully");
        }

        [When(@"add a description exceeding max length of character")]
        public void WhenAddADescriptionExceedingMaxLengthOfCharacter()
        {
            PublicHolidaysSubPage publicHolidaysSubPage = new PublicHolidaysSubPage(_webDriver, _wait);
            publicHolidaysSubPage.WriteText("Test holiday by Todos Alexandru Test holiday by Todos Alexandru Test holiday by Todos Alexandru Test holiday by Todos Alexandru");
            publicHolidaysSubPage.PressOnHeader();
        }

        [Then(@"error is shown")]
        public void ThenErrorIsShown()
        {
            PublicHolidaysSubPage publicHolidaysSubPage = new PublicHolidaysSubPage(_webDriver, _wait);
            publicHolidaysSubPage.VerifyError("The length must not exceed 50 characters.");
        }
    }
}
