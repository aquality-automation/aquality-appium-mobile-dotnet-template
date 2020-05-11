using Aquality.Appium.Mobile.Elements.Interfaces;
using Aquality.Appium.Mobile.Screens;
using OpenQA.Selenium.Appium;

namespace Aquality.Appium.Mobile.Template.Screens.IOS
{
    public class Alert : IOSScreen, Interfaces.IAlert
    {
        private readonly ILabel messageLbl;
        private readonly IButton okBtn;

        public Alert() : base(MobileBy.IosNSPredicate("type == 'XCUIElementTypeAlert' AND name == 'Alert'"), "Alert")
        {
            messageLbl = ElementFactory.GetLabel(MobileBy.IosClassChain("**/XCUIElementTypeOther[$name == 'Alert'$]/XCUIElementTypeStaticText[2]"), "Message");
            okBtn = ElementFactory.GetButton(MobileBy.AccessibilityId("OK"), "OK");
        }

        public string Message => messageLbl.Text;

        public void TapOk() => okBtn.Click();
    }
}
