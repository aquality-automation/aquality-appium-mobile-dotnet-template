using Allure.Commons;
using Aquality.Appium.Mobile.Applications;
using Aquality.Appium.Mobile.Template.Utilities;
using AqualityTracking.Integrations.Core;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Aquality.Appium.Mobile.Template.SpecFlow.Hooks
{
    [Binding]
    public class ScreenshotHooks(IScreenshotProvider screenshotProvider)
    {

        [AfterScenario(Order = 0)]
        public void TakeScreenshot()
        {
            if (AqualityServices.IsApplicationStarted)
            {
                var pathToScreenshot = screenshotProvider.TakeScreenshot();
                TestContext.AddTestAttachment(pathToScreenshot);
                AllureLifecycle.Instance.AddAttachment(pathToScreenshot, "Screenshot");
                AqualityTrackingLifecycle.Instance.AddAttachment(pathToScreenshot);
            }
        }
    }
}
