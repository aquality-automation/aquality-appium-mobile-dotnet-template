using Aquality.Appium.Mobile.Applications;
using TechTalk.SpecFlow;

namespace Aquality.Appium.Mobile.Template.SpecFlow.Hooks
{
    [Binding]
    public class ApplicationHooks
    {
        [AfterScenario(Order = 1)]
        public void CloseApplication()
        {
            if (AqualityServices.IsApplicationStarted)
            {
                AqualityServices.Application.Quit();
            }
        }
    }
}
