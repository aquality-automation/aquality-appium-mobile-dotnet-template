using Aquality.Appium.Mobile.Screens;
using Aquality.Appium.Mobile.Template.Screens.Interfaces;
using OpenQA.Selenium.Appium;
using System;

namespace Aquality.Appium.Mobile.Template.Screens.IOS
{
    public class ChooseViewScreen : IOSScreen, IChooseViewScreen
    {
        public ChooseViewScreen() : base(MobileBy.AccessibilityId("not_implemented"), "Choose An Awesome View")
        {
        }

        public void OpenView(string viewName) => throw new NotImplementedException("iOS screens not implemented");
    }
}
