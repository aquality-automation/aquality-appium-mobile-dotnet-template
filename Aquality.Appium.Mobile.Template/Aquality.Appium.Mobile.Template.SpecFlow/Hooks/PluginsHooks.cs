using Allure.Commons;
using Aquality.Appium.Mobile.Applications;
using Aquality.Appium.Mobile.Template.Applications;
using AqualityTracking.Integrations.Core;
using NUnit.Framework;
using System.Text.RegularExpressions;
using TechTalk.SpecFlow;

namespace Aquality.Appium.Mobile.Template.SpecFlow.Hooks
{
    [Binding]
    public class PluginsHooks(ScenarioContext context)
    {
        private readonly PlatformName platformName = AqualityServices.ApplicationProfile.PlatformName;

        [BeforeFeature]
        public static void RegisterCustomStartup()
        {
            AqualityServices.SetStartup(new CustomStartup());
        }

        [AfterScenario(Order = -1)]
        public void UpdateAllureTestCaseName()
        {
            context.TryGetValue(out TestResult testresult);
            AllureLifecycle.Instance.UpdateTestCase(testresult.uuid, testCase =>
            {
                testCase.name += GetScenarioNameSuffix();
                testCase.historyId = TestContext.CurrentContext.Test.FullName + platformName;
                testCase.fullName += GetScenarioNameSuffixWithPlatform();
                testCase.parameters.Add(new Parameter { name = "platform", value = platformName.ToString() });
            });
        }

        [BeforeScenario(Order = -1)]
        public void UpdateAqualityTrackingTestCaseName()
        {
            AqualityTrackingLifecycle.Instance.UpdateCurrentTest(test => test.Name += GetScenarioNameSuffixWithPlatform());
        }

        private string GetScenarioNameSuffixWithPlatform() => $"{GetScenarioNameSuffix()}: {platformName}";

        private static string GetScenarioNameSuffix()
        {
            var suffix = string.Empty;
            var testFullName = TestContext.CurrentContext.Test.FullName;
            var paramsMatch = Regex.Match(testFullName, @"(.*)(\(.*\))$");
            if (paramsMatch.Success)
            {
                suffix = $" {paramsMatch.Groups[2].Value.Replace(",null", string.Empty)}";
            }
            return suffix;
        }
    }
}
