using Aquality.Appium.Mobile.Applications;
using Aquality.Appium.Mobile.Template.Utilities.ScreenFactory;
using BoDi;
using TechTalk.SpecFlow;

namespace Aquality.Appium.Mobile.Template.SpecFlow.Hooks
{
    [Binding]
    public class ScreenFactoryHooks
    {
        private readonly IObjectContainer objectContainer;

        public ScreenFactoryHooks(IObjectContainer objectContainer)
        {
            this.objectContainer = objectContainer;
        }

        [BeforeScenario]
        public void InitializeScreenFactory()
        {
            if (!objectContainer.IsRegistered<IScreenFactory>())
            {
                if (AqualityServices.Application.PlatformName == PlatformName.IOS)
                {
                    objectContainer.RegisterInstanceAs<IScreenFactory>(new IOSScreenFactory());
                }
                else
                {
                    objectContainer.RegisterInstanceAs<IScreenFactory>(new AndroidScreenFactory());
                }
            }
        }
    }
}
