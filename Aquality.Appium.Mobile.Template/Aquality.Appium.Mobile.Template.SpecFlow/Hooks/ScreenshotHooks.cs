using Allure.Commons;
using Aquality.Appium.Mobile.Applications;
using Aquality.Appium.Mobile.Template.Utilities;
using AqualityTracking.Integrations.Core;
using NUnit.Framework;
using TechTalk.SpecFlow;
using System.Collections.Generic;

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
            if (AqualityServices.IsApplicationStarted)
            {
                if (AqualityServices.Application.PlatformName == PlatformName.IOS)
                {
                    var result = AqualityServices.Application.Driver.ExecuteScript("mobile: activeAppInfo");
                    AqualityServices.LocalizedLogger.Info("loc.checkable.state", System.Text.Json.JsonSerializer.SerializeToDocument(result).ToString());
                }
                var pathToScreenshot = screenshotProvider.TakeScreenshot();
                TestContext.AddTestAttachment(pathToScreenshot);
                AllureLifecycle.Instance.AddAttachment(pathToScreenshot, "Screenshot");
                AqualityTrackingLifecycle.Instance.AddAttachment(pathToScreenshot);
                if (AqualityServices.Application.PlatformName == PlatformName.IOS)
                {
                    var result = AqualityServices.Application.Driver.ExecuteScript("mobile: activeAppInfo");
                    AqualityServices.LocalizedLogger.Info(result.GetType().ToString());
                    AqualityServices.LocalizedLogger.Info("loc.checkable.state", ((Dictionary<string, object>)result)["bundleId"].ToString());
                }
            }
        }
    }
}
