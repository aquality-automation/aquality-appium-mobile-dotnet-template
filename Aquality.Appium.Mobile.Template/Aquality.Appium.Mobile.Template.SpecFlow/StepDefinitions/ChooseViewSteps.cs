﻿using Aquality.Appium.Mobile.Screens.ScreenFactory;
using Aquality.Appium.Mobile.Template.Screens.ChooseView;
using TechTalk.SpecFlow;

namespace Aquality.Appium.Mobile.Template.SpecFlow.StepDefinitions
{
    [Binding]
    public class ChooseViewSteps
    {
        private readonly ChooseViewScreen chooseViewScreen;

        public ChooseViewSteps(IScreenFactory screenFactory)
        {
            chooseViewScreen = screenFactory.GetScreen<ChooseViewScreen>();
        }

        [When(@"I open '(.*)' view")]
        public void IOpenView(string viewName)
        {
            chooseViewScreen.OpenView(viewName);
        }
    }
}
