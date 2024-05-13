using Aquality.Appium.Mobile.Screens.ScreenFactory;
using Aquality.Appium.Mobile.Template.Models;
using Aquality.Appium.Mobile.Template.Screens.Login;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Aquality.Appium.Mobile.Template.SpecFlow.StepDefinitions
{
    [Binding]
    public class LoginSteps(IScreenFactory screenFactory)
    {
        private readonly LoginScreen loginScreen = screenFactory.GetScreen<LoginScreen>();

        [When(@"I log in with data:")]
        public void IFillInLoginForm(LoginModel loginModel)
        {
            loginScreen.SetUsername(loginModel.Username)
                .SetPassword(loginModel.Password)
                .TapLogin();
        }

        [Then(@"Login Screen is opened")]
        public void LoginScreenIsOpened()
        {
            Assert.That(loginScreen.State.WaitForDisplayed(), "Login Screen is opened");
        }

        [When(@"I save Login Screen dump")]
        public void SaveLoginScreenDump() 
        {
            loginScreen.Dump.Save();
        }

        [Then("Login Screen dump is different")]
        public void LoginScreenDumpIsDifferent() 
        {
            Assert.That(loginScreen.Dump.Compare(), Is.GreaterThan(0), "The form dump should differ");
        }
    }
}
