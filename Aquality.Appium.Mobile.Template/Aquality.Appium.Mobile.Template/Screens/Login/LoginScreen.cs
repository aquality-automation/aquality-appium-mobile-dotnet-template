using Aquality.Appium.Mobile.Elements.Interfaces;
using Aquality.Appium.Mobile.Screens;
using OpenQA.Selenium;

namespace Aquality.Appium.Mobile.Template.Screens.Login
{
    public abstract class LoginScreen : Screen
    {
        protected readonly ITextBox usernameTxb;
        protected readonly ITextBox passwordTxb;
        protected readonly IButton loginBtn;

        protected LoginScreen(By locator) : base(locator, "Login")
        {
            usernameTxb = ElementFactory.GetTextBox(UsernameTxbLoc, "Username");
            passwordTxb = ElementFactory.GetTextBox(PasswordTxbLoc, "Password");
            loginBtn = ElementFactory.GetButton(LoginBtnLoc, "Login");
        }

        protected abstract By UsernameTxbLoc { get; }

        protected abstract By PasswordTxbLoc { get; }

        protected abstract By LoginBtnLoc { get; }

        public LoginScreen SetUsername(string username)
        {
            usernameTxb.SendKeys(username);
            return this;
        }

        public LoginScreen SetPassword(string password)
        {
            passwordTxb.TypeSecret(password);
            return this;
        }

        public void TapLogin() => loginBtn.Click();
    }
}
