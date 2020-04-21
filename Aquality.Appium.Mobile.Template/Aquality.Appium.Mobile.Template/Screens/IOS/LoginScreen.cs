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

        public string Login()
        {
            return "I'm from IOS Screen";
        }
    }
}
