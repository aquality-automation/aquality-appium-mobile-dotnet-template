using Aquality.Appium.Mobile.Template.Screens.Interfaces;
using Aquality.Appium.Mobile.Template.Utilities.ScreenFactory;
using System;
using TechTalk.SpecFlow;

namespace Aquality.Appium.Mobile.Template.SpecFlow.StepDefinitions
{
    [Binding]
    public class DemoSteps
    {
        private readonly IScreenFactory screenFactory;

        public DemoSteps(IScreenFactory screenFactory)
        {
            this.screenFactory = screenFactory;
        }

        [Given(@"I can resolve screen factory")]
        public void ICanResolveScreenFactory()
        {
            var result = screenFactory.GetScreen<ILoginScreen>().Login();
            Console.WriteLine(result);
        }
    }
}
