using Aquality.Appium.Mobile.Applications;
using Aquality.Selenium.Core.Configurations;
using Aquality.Selenium.Core.Utilities;
using System.Reflection;

namespace Aquality.Appium.Mobile.Template.Configuration
{
    internal static class Environment
    {
        public static ISettingsFile CurrentEnvironment
        {
            get
            {
                var envName = AqualityServices.Get<ISettingsFile>().GetValue<string>("environment");
                var pathToConfigFile = $"Resources.Environment.{envName}.config.json";
                return new JsonSettingsFile(pathToConfigFile, Assembly.GetCallingAssembly());
            }
        }
    }
}
