using Aquality.Appium.Mobile.Applications;
using Aquality.Appium.Mobile.Screens.ScreenFactory;
using OpenQA.Selenium;

namespace Aquality.Appium.Mobile.Template.Screens.Android
{
    [ScreenType(PlatformName.Android)]
    public sealed class ChooseViewScreen : Base.ChooseViewScreen
    {
        public ChooseViewScreen() : base(By.XPath("//android.widget.TextView[@text='Choose An Awesome View']"))
        {
        }
    }
}
