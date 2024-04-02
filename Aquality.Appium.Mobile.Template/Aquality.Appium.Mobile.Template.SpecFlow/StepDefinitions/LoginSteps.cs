using Aquality.Appium.Mobile.Screens.ScreenFactory;
using Aquality.Appium.Mobile.Template.Models;
using Aquality.Appium.Mobile.Template.Screens.Login;
using NUnit.Framework;
using System.Xml.Linq;
using System;
using TechTalk.SpecFlow;
using System.IO;
using Aquality.Appium.Mobile.Applications;
using Aquality.Appium.Mobile.Template.Utilities;
using Allure.Commons;

namespace Aquality.Appium.Mobile.Template.SpecFlow.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        private readonly LoginScreen loginScreen;
        private readonly IScreenshotProvider screenshotProvider;

        public LoginSteps(IScreenFactory screenFactory, IScreenshotProvider screenshotProvider)
        {
            loginScreen = screenFactory.GetScreen<LoginScreen>();
            this.screenshotProvider = screenshotProvider;
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

        [When(@"I save Login Screen dump")]
        public void SaveLoginScreenDump() 
        {
            loginScreen.ClickUsername();
            var filePath = "pagesource.xml";
            File.WriteAllText(filePath, AqualityServices.Application.Driver.PageSource);
            TestContext.AddTestAttachment(filePath);
            AllureLifecycle.Instance.AddAttachment(filePath, "page source");
            var screenPath = screenshotProvider.TakeScreenshot();
            TestContext.AddTestAttachment(screenPath);
            AllureLifecycle.Instance.AddAttachment(screenPath, "Screenshot");
            loginScreen.Dump.Save();
        }

        [Then("Login Screen dump is different")]
        public void LoginScreenDumpIsDifferent() 
        {
            Assert.That(loginScreen.Dump.Compare(), Is.GreaterThan(0), "The form dump should differ");
        }
    }
}
