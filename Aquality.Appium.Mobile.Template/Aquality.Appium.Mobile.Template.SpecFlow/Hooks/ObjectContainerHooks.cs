using Aquality.Appium.Mobile.Applications;
using Aquality.Appium.Mobile.Template.Utilities;
using BoDi;
using TechTalk.SpecFlow;

namespace Aquality.Appium.Mobile.Template.SpecFlow.Hooks
{
    [Binding]
    public class ObjectContainerHooks(IObjectContainer objectContainer)
    {

        [BeforeScenario]
        public void RegisterDependencies()
        {
            objectContainer.RegisterInstanceAs(AqualityServices.ScreenFactory);
            objectContainer.RegisterInstanceAs<IScreenshotProvider>(new ScreenshotProvider());
        }
    }
}
