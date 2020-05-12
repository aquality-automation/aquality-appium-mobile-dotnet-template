using Aquality.Appium.Mobile.Elements.Interfaces;
using Aquality.Appium.Mobile.Screens;
using Aquality.Appium.Mobile.Template.Screens.Interfaces;
using OpenQA.Selenium.Appium;

namespace Aquality.Appium.Mobile.Template.Screens.IOS
{
    public class LoginScreen : IOSScreen, ILoginScreen
    {
        private const string ScreenName = "Login";

        private readonly ITextBox usernameTxb;
        private readonly ITextBox passwordTxb;
        private readonly IButton loginBtn;

        public LoginScreen() : base(MobileBy.AccessibilityId(ScreenName), ScreenName)
        {
            usernameTxb = ElementFactory.GetTextBox(MobileBy.IosNSPredicate("type == 'XCUIElementTypeTextField' AND name == 'username'"), "Username");
            passwordTxb = ElementFactory.GetTextBox(MobileBy.IosNSPredicate("type == 'XCUIElementTypeSecureTextField' AND name == 'password'"), "Password");
            loginBtn = ElementFactory.GetButton(MobileBy.IosClassChain("**/XCUIElementTypeOther[`name == 'loginBtn'`][2]"), "Login");
        }

        public ILoginScreen SetUsername(string username)
        {
            usernameTxb.SendKeys(username);
            return this;
        }

        public ILoginScreen SetPassword(string password)
        {
            passwordTxb.TypeSecret(password);
            return this;
        }

        public void TapLogin() => loginBtn.Click();
    }
}
