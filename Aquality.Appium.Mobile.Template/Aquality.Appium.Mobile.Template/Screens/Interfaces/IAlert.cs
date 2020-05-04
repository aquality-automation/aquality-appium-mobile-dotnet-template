using Aquality.Appium.Mobile.Screens;

namespace Aquality.Appium.Mobile.Template.Screens.Interfaces
{
    public interface IAlert : IScreen
    {
        string Message { get; }

        void TapOk();
    }
}
