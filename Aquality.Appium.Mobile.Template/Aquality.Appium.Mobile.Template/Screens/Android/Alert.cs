using Aquality.Appium.Mobile.Elements.Interfaces;
using Aquality.Appium.Mobile.Screens;
using OpenQA.Selenium;

namespace Aquality.Appium.Mobile.Template.Screens.Android
{
    public class Alert : AndroidScreen, Interfaces.IAlert
    {
        private readonly ILabel messageLbl;
        private readonly IButton okBtn;

        public Alert() : base(By.Id("android:id/alertTitle"), "Alert")
        {
            messageLbl = ElementFactory.GetLabel(By.Id("android:id/message"), "Message");
            okBtn = ElementFactory.GetButton(By.Id("android:id/button1"), "OK");
        }

        public string Message => messageLbl.Text;

        public void TapOk() => okBtn.Click();
    }
}
