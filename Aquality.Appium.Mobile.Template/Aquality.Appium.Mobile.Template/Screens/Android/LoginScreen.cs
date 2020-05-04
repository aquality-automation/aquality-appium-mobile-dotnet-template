using Aquality.Appium.Mobile.Screens;
using Aquality.Appium.Mobile.Template.Screens.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;

namespace Aquality.Appium.Mobile.Template.Screens.Android
{
    public class LoginScreen : AndroidScreen, ILoginScreen
    {
        public LoginScreen() : base(By.XPath("//android.widget.TextView[@text='Login']"), "Login")
        {
        }

        public ILoginScreen SetUsername(string username)
        {
            ElementFactory.GetTextBox(MobileBy.AccessibilityId("username"), "Username").SendKeys(username);
            return this;
        }

        public ILoginScreen SetPassword(string password)
        {
            ElementFactory.GetTextBox(MobileBy.AccessibilityId("password"), "Password").TypeSecret(password);
            return this;
        }

        public void TapLogin() => ElementFactory.GetButton(MobileBy.AccessibilityId("loginBtn"), "Login").Click();
    }
}
