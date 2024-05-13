using TechTalk.SpecFlow;
using static Aquality.Appium.Mobile.Applications.AqualityServices;

namespace Aquality.Appium.Mobile.Template.SpecFlow.Hooks
{
    [Binding]
    public class ApplicationHooks
    {
        [AfterScenario(Order = 1)]
        public static void CloseApplication()
        {
            if (IsApplicationStarted)
            {
                Application.Terminate();
                Application.Quit();
            }
        }
    }
}
