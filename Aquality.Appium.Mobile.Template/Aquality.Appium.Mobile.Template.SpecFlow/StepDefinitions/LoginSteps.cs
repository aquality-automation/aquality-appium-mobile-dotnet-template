using Aquality.Appium.Mobile.Screens.ScreenFactory;
using Aquality.Appium.Mobile.Template.Models;
using Aquality.Appium.Mobile.Template.Screens.Base;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Aquality.Appium.Mobile.Template.SpecFlow.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        private readonly LoginScreen loginScreen;

        public LoginSteps(IScreenFactory screenFactory)
        {
            loginScreen = screenFactory.GetScreen<LoginScreen>();
        }

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
            Assert.IsTrue(loginScreen.State.WaitForDisplayed(), "Login Screen is opened");
        }
    }
}
