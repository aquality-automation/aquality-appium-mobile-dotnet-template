using Aquality.Appium.Mobile.Screens;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;

namespace Aquality.Appium.Mobile.Template.Screens.Abstractions
{
    public abstract class ChooseViewScreen : Screen
    {
        public ChooseViewScreen(By locator) : base(locator, "Choose An Awesome View")
        {
        }

        public void OpenView(string viewName) => ElementFactory.GetLabel(MobileBy.AccessibilityId(viewName), $"Choose {viewName} view").Click();
    }
}
