using Aquality.Appium.Mobile.Applications;
using Aquality.Appium.Mobile.Screens.ScreenFactory;
using OpenQA.Selenium;

namespace Aquality.Appium.Mobile.Template.Screens.ChooseView
{
    [ScreenType(PlatformName.Android)]
    public sealed class AndroidChooseViewScreen : ChooseViewScreen
    {
        public AndroidChooseViewScreen() : base(By.XPath("//android.widget.TextView[@text='Choose An Awesome View']"))
        {
        }
    }
}
