﻿using Aquality.Appium.Mobile.Applications;
using Aquality.Appium.Mobile.Screens.ScreenFactory;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;

namespace Aquality.Appium.Mobile.Template.Screens.Android
{
    [ScreenType(PlatformName.Android)]
    public sealed class LoginScreen : Base.LoginScreen
    {
        public LoginScreen() : base(By.XPath("//android.widget.TextView[@text='Login']"))
        {
        }

        protected override By UsernameTxbLoc => MobileBy.AccessibilityId("username");

        protected override By PasswordTxbLoc => MobileBy.AccessibilityId("password");

        protected override By LoginBtnLoc => MobileBy.AccessibilityId("loginBtn");
    }
}
