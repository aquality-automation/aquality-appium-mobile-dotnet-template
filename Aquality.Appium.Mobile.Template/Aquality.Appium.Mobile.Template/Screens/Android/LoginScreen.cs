using Aquality.Appium.Mobile.Elements.Interfaces;
using Aquality.Appium.Mobile.Screens;
using Aquality.Appium.Mobile.Template.Screens.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;

namespace Aquality.Appium.Mobile.Template.Screens.Android
{
    public class LoginScreen : AndroidScreen, ILoginScreen
    {
        private const string ScreenName = "Login";

        private readonly ITextBox usernameTxb;
        private readonly ITextBox passwordTxb;
        private readonly IButton loginBtn;

        public LoginScreen() : base(By.XPath($"//android.widget.TextView[@text='{ScreenName}']"), ScreenName)
        {
            usernameTxb = ElementFactory.GetTextBox(MobileBy.AccessibilityId("username"), "Username");
            passwordTxb = ElementFactory.GetTextBox(MobileBy.AccessibilityId("password"), "Password");
            loginBtn = ElementFactory.GetButton(MobileBy.AccessibilityId("loginBtn"), "Login");
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
