using Aquality.Appium.Mobile.Screens;

namespace Aquality.Appium.Mobile.Template.Screens.Interfaces
{
    public interface ILoginScreen : IScreen
    {
        ILoginScreen SetUsername(string username);

        ILoginScreen SetPassword(string password);

        void TapLogin();
    }
}
