using System;
using System.Linq;
using System.Reflection;

namespace Aquality.Appium.Mobile.Template.Utilities.ScreenFactory
{
    public abstract class ScreenFactory<TScreen> : IScreenFactory
        where TScreen : class
    {
        public TAppScreen GetScreen<TAppScreen>()
            where TAppScreen : class
        {
            var type = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(t => t.GetInterfaces().Contains(typeof(TAppScreen)))
                .SingleOrDefault(t => t.IsSubclassOf(typeof(TScreen)));

            if (type != null)
            {
                return (TAppScreen) Activator.CreateInstance(type);
            }

            throw new ArgumentOutOfRangeException($"It is not possible to create an instance of {typeof(TAppScreen).Name}");
        }
    }
}
