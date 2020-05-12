using Aquality.Appium.Mobile.Applications;
using Aquality.Appium.Mobile.Screens.ScreenFactory;
using Aquality.Appium.Mobile.Template.Utilities;
using BoDi;
using TechTalk.SpecFlow;

namespace Aquality.Appium.Mobile.Template.SpecFlow.Hooks
{
    [Binding]
    public class ObjectContainerHooks
    {
        private readonly IObjectContainer objectContainer;

        public ObjectContainerHooks(IObjectContainer objectContainer)
        {
            this.objectContainer = objectContainer;
        }

        [BeforeScenario]
        public void RegisterDependencies()
        {
            objectContainer.RegisterInstanceAs<IScreenFactory>(AqualityServices.ScreenFactory);
            objectContainer.RegisterInstanceAs<IScreenshotProvider>(new ScreenshotProvider());
        }
    }
}
