using Allure.Commons;
using Aquality.Appium.Mobile.Applications;
using Aquality.Appium.Mobile.Template.Utilities;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Aquality.Appium.Mobile.Template.SpecFlow.Hooks
{
    [Binding]
    public class ScreenshotHooks
    {
        private readonly ScenarioContext scenarioContext;
        private readonly IScreenshotProvider screenshotProvider;

        public ScreenshotHooks(ScenarioContext scenarioContext, IScreenshotProvider screenshotProvider)
        {
            this.scenarioContext = scenarioContext;
            this.screenshotProvider = screenshotProvider;
        }

        [AfterScenario(Order = 0)]
        public void TakeScreenshot()
        {
            if (scenarioContext.ScenarioExecutionStatus != ScenarioExecutionStatus.OK
                && AqualityServices.IsApplicationStarted)
            {
                var pathToScreenshot = screenshotProvider.TakeScreenshot();
                TestContext.AddTestAttachment(pathToScreenshot);
                AllureLifecycle.Instance.AddAttachment(pathToScreenshot, "Screenshot");
            }
        }
    }
}
