using Aquality.Appium.Mobile.Screens.ScreenFactory;
using Aquality.Appium.Mobile.Template.Screens;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Aquality.Appium.Mobile.Template.SpecFlow.StepDefinitions
{
    [Binding]
    public class CommonSteps
    {
        private readonly Alert alert;

        public CommonSteps(IScreenFactory screenFactory)
        {
            alert = screenFactory.GetScreen<Alert>();
        }

        [Then(@"'(.*)' alert appears")]
        public void AlertAppers(string alertMessage)
        {
            Assert.IsTrue(alert.State.WaitForDisplayed(), "Alert appeared");
            Assert.AreEqual(alertMessage, alert.Message, "Alert message is correct");
        }
    }
}
