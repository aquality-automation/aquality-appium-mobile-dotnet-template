using Aquality.Appium.Mobile.Screens;
using OpenQA.Selenium.Appium;
using System;

namespace Aquality.Appium.Mobile.Template.Screens.IOS
{
    public class Alert : IOSScreen, Interfaces.IAlert
    {
        public Alert() : base(MobileBy.AccessibilityId("not_implemented"), "Alert")
        {
        }

        public string Message => throw new NotImplementedException("iOS screens not implemented");

        public void TapOk() => throw new NotImplementedException("iOS screens not implemented");
    }
}
