using Aquality.Appium.Mobile.Screens.ScreenFactory;
using Aquality.Appium.Mobile.Template.Screens;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Aquality.Appium.Mobile.Template.SpecFlow.StepDefinitions
{
    [Binding]
    public class CommonSteps(IScreenFactory screenFactory)
    {
        private readonly Alert alert = screenFactory.GetScreen<Alert>();

        [Then(@"'(.*)' alert appears")]
        public void AlertAppears(string alertMessage)
        {
            Assert.That(alert.State.WaitForDisplayed(), "Alert appeared");
            Assert.That(alert.Message, Is.EqualTo(alertMessage), "Alert message is correct");
        }

        [When("I accept the alert")]
        public void AcceptAlert() {
            alert.TapOk();
        }
    }
}
