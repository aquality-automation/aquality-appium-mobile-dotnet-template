using Aquality.Appium.Mobile.Screens;
using Aquality.Appium.Mobile.Template.Screens.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;

namespace Aquality.Appium.Mobile.Template.Screens.Android
{
    public class ChooseViewScreen : AndroidScreen, IChooseViewScreen
    {
        private const string ScreenName = "Choose An Awesome View";

        public ChooseViewScreen() : base(By.XPath($"//android.widget.TextView[@text='{ScreenName}']"), ScreenName)
        {
        }

        public void OpenView(string viewName) => ElementFactory.GetLabel(MobileBy.AccessibilityId(viewName), $"Choose {viewName} view").Click();
    }
}
