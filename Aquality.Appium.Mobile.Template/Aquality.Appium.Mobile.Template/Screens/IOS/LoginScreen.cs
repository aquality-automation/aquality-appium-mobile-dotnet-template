using Aquality.Appium.Mobile.Screens;
using Aquality.Appium.Mobile.Template.Screens.Interfaces;
using OpenQA.Selenium.Appium;

namespace Aquality.Appium.Mobile.Template.Screens.IOS
{
    public class LoginScreen : IOSScreen, ILoginScreen
    {
        public LoginScreen() : base(MobileBy.AccessibilityId("Login"), "Login")
        {
        }

        public ILoginScreen SetUsername(string username)
        {
            ElementFactory.GetTextBox(MobileBy.IosNSPredicate("type == 'XCUIElementTypeTextField' AND name == 'username'"), "Username")
                .SendKeys(username);
            return this;
        }

        public ILoginScreen SetPassword(string password)
        {
            ElementFactory.GetTextBox(MobileBy.IosNSPredicate("type == 'XCUIElementTypeSecureTextField' AND name == 'password'"), "Password")
                .TypeSecret(password);
            return this;
        }

        public void TapLogin() => ElementFactory.GetButton(MobileBy.IosClassChain("**/XCUIElementTypeOther[`name == 'loginBtn'`]"), "Login").Click();
    }
}
