using Aquality.Appium.Mobile.Applications;
using Aquality.Appium.Mobile.Screens.ScreenFactory;
using OpenQA.Selenium.Appium;

namespace Aquality.Appium.Mobile.Template.Screens.ChooseView
{
    [ScreenType(PlatformName.IOS)]
    public sealed class IosChooseViewScreen : ChooseViewScreen
    {
        public IosChooseViewScreen() : base(MobileBy.IosNSPredicate($"name == 'Choose An Awesome View'"))
        {
        }
    }
}
