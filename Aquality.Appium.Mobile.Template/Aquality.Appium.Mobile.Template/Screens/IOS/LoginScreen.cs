using System;
using Aquality.Appium.Mobile.Screens;
using Aquality.Appium.Mobile.Template.Screens.Interfaces;
using OpenQA.Selenium.Appium;

namespace Aquality.Appium.Mobile.Template.Screens.IOS
{
    public class LoginScreen : IOSScreen, ILoginScreen
    {
        public LoginScreen() : base(MobileBy.AccessibilityId("login"), "Login")
        {
        }

        public ILoginScreen SetPassword(string password) => throw new NotImplementedException("iOS screens not implemented");

        public ILoginScreen SetUsername(string username) => throw new NotImplementedException("iOS screens not implemented");

        public void TapLogin() => throw new NotImplementedException("iOS screens not implemented");
    }
}
