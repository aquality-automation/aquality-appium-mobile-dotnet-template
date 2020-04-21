namespace Aquality.Appium.Mobile.Template.Utilities.ScreenFactory
{
    public interface IScreenFactory
    {
        TAppScreen GetScreen<TAppScreen>() where TAppScreen : class;
    }
}
