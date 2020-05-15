using Aquality.Appium.Mobile.Applications;
using Aquality.Appium.Mobile.Screens.ScreenFactory;
using OpenQA.Selenium;

namespace Aquality.Appium.Mobile.Template.Screens.Android
{
    [ScreenType(PlatformName.Android)]
    public sealed class Alert : Base.Alert
    {
        public Alert() : base(By.Id("android:id/alertTitle"))
        {
        }

        protected override By MessageLblLoc => By.Id("android:id/message");

        protected override By OkBtnLoc => By.Id("android:id/button1");
    }
}
