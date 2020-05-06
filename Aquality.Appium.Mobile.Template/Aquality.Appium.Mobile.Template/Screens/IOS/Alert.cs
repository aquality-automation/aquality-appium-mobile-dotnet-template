using Aquality.Appium.Mobile.Screens;
using OpenQA.Selenium.Appium;

namespace Aquality.Appium.Mobile.Template.Screens.IOS
{
    public class Alert : IOSScreen, Interfaces.IAlert
    {
        public Alert() : base(MobileBy.IosNSPredicate("type == 'XCUIElementTypeAlert' AND name == 'Alert'"), "Alert")
        {
        }

        public string Message => ElementFactory.GetLabel(MobileBy.IosClassChain("**/XCUIElementTypeOther[$name == 'Alert'$]/XCUIElementTypeStaticText[2]"), "Message").Text;

        public void TapOk() => ElementFactory.GetButton(MobileBy.AccessibilityId("OK"), "OK").Click();
    }
}
