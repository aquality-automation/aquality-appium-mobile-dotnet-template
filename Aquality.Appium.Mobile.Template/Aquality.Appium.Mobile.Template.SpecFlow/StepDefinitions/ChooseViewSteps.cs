using Aquality.Appium.Mobile.Screens.ScreenFactory;
using Aquality.Appium.Mobile.Template.Screens.Interfaces;
using TechTalk.SpecFlow;

namespace Aquality.Appium.Mobile.Template.SpecFlow.StepDefinitions
{
    [Binding]
    public class ChooseViewSteps
    {
        private readonly IChooseViewScreen chooseViewScreen;

        public ChooseViewSteps(IScreenFactory screenFactory)
        {
            chooseViewScreen = screenFactory.GetScreen<IChooseViewScreen>();
        }

        [Given(@"I can open '(.*)' view")]
        public void ICanOpenView(string viewName)
        {
            chooseViewScreen.OpenView(viewName);
        }
    }
}
