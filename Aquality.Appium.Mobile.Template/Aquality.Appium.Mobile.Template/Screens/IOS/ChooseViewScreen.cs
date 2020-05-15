using Aquality.Appium.Mobile.Applications;
using Aquality.Appium.Mobile.Screens.ScreenFactory;
using OpenQA.Selenium.Appium;

namespace Aquality.Appium.Mobile.Template.Screens.IOS
{
    [ScreenType(PlatformName.IOS)]
    public sealed class ChooseViewScreen : Base.ChooseViewScreen
    {
        public ChooseViewScreen() : base(MobileBy.IosNSPredicate($"name == 'Choose An Awesome View'"))
        {
        }
    }
}
