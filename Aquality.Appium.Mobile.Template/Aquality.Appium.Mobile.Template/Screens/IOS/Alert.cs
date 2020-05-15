using Aquality.Appium.Mobile.Applications;
using Aquality.Appium.Mobile.Screens.ScreenFactory;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;

namespace Aquality.Appium.Mobile.Template.Screens.IOS
{
    [ScreenType(PlatformName.IOS)]
    public sealed class Alert : Abstractions.Alert
    {
        public Alert() : base(MobileBy.IosNSPredicate("type == 'XCUIElementTypeAlert' AND name == 'Alert'"))
        {
        }

        protected override By MessageLblLoc => MobileBy.IosClassChain("**/XCUIElementTypeOther[$name == 'Alert'$]/XCUIElementTypeStaticText[2]");

        protected override By OkBtnLoc => MobileBy.AccessibilityId("OK");
    }
}
