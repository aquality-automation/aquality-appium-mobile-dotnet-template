using Aquality.Appium.Mobile.Screens;
using Aquality.Appium.Mobile.Template.Screens.Interfaces;
using OpenQA.Selenium.Appium;

namespace Aquality.Appium.Mobile.Template.Screens.IOS
{
    public class ChooseViewScreen : IOSScreen, IChooseViewScreen
    {
        private const string ScreenName = "Choose An Awesome View";

        public ChooseViewScreen() : base(MobileBy.IosNSPredicate($"name == '{ScreenName}'"), ScreenName)
        {
        }

        public void OpenView(string viewName) => ElementFactory.GetLabel(MobileBy.AccessibilityId(viewName), $"Choose {viewName} view").Click();
    }
}
