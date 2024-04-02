using Aquality.Appium.Mobile.Applications;
using Aquality.Appium.Mobile.Elements.Interfaces;
using Aquality.Appium.Mobile.Screens;
using Aquality.Selenium.Core.Waitings;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Interfaces;
using System;

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

        public void ClickUsername()
        {
            usernameTxb.Click();
            AqualityServices.ConditionalWait.WaitFor(driver => ((IHidesKeyboard)driver).IsKeyboardShown(), message: "Keyboard is not shown");
        }
    }
}
