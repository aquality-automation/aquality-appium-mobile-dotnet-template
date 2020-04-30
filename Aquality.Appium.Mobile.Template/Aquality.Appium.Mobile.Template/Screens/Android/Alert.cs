using Aquality.Appium.Mobile.Screens;
using OpenQA.Selenium;

namespace Aquality.Appium.Mobile.Template.Screens.Android
{
    public class Alert : AndroidScreen, Interfaces.IAlert
    {
        public Alert() : base(By.Id("android:id/alertTitle"), "Alert")
        {
        }

        public string Message => ElementFactory.GetLabel(By.Id("android:id/message"), "Message").Text;

        public void TapOk() => ElementFactory.GetButton(By.Id("android:id/button1"), "OK").Click();
    }
}
