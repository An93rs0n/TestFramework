/* using TechTalk.SpecFlow;

namespace AmdarisTests.Hooks
{
    [Binding]
    public class Hook : Preconditions
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
    }
} */