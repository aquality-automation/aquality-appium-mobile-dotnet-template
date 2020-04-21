using Aquality.Appium.Mobile.Screens;
using Aquality.Appium.Mobile.Template.Screens.Interfaces;
using OpenQA.Selenium;

namespace Aquality.Appium.Mobile.Template.Screens.Android
{
    public class LoginScreen : AndroidScreen, ILoginScreen
    {
        public LoginScreen() : base(By.Id("login"), "Login")
        {
        }

        public string Login()
        {
            return "I'm from Android Screen";
        }
    }
}
