﻿using Aquality.Appium.Mobile.Applications;
using Aquality.Appium.Mobile.Screens.ScreenFactory;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;

namespace Aquality.Appium.Mobile.Template.Screens.IOS
{
    [ScreenType(PlatformName.IOS)]
    public sealed class LoginScreen : Base.LoginScreen
    {
        public LoginScreen() : base(MobileBy.AccessibilityId("Login"))
        {
        }

        protected override By UsernameTxbLoc => MobileBy.IosNSPredicate("type == 'XCUIElementTypeTextField' AND name == 'username'");

        protected override By PasswordTxbLoc => MobileBy.IosNSPredicate("type == 'XCUIElementTypeSecureTextField' AND name == 'password'");

        protected override By LoginBtnLoc => MobileBy.IosClassChain("**/XCUIElementTypeOther[`name == 'loginBtn'`][2]");
    }
}
