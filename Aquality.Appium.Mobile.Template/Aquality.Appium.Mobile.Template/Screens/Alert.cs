using Aquality.Appium.Mobile.Elements.Interfaces;
using Aquality.Appium.Mobile.Screens;
using OpenQA.Selenium;

namespace Aquality.Appium.Mobile.Template.Screens
{
    public abstract class Alert : Screen
    {
        private readonly ILabel messageLbl;
        private readonly IButton okBtn;

        protected Alert(By locator) : base(locator, "Alert")
        {
            messageLbl = ElementFactory.GetLabel(MessageLblLoc, "Message");
            okBtn = ElementFactory.GetButton(OkBtnLoc, "OK");
        }

        protected abstract By MessageLblLoc { get; }

        protected abstract By OkBtnLoc { get; }

        public string Message => messageLbl.Text;

        public void TapOk() => okBtn.Click();
    }
}
