using Aquality.Appium.Mobile.Applications;
using Aquality.Appium.Mobile.Template.Utilities;
using Aquality.Selenium.Core.Applications;
using Aquality.Selenium.Core.Configurations;
using Aquality.Selenium.Core.Localization;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Aquality.Appium.Mobile.Template.Applications
{
    public class CustomStartup : MobileStartup
    {
        public override IServiceCollection ConfigureServices(IServiceCollection services, Func<IServiceProvider, IApplication> applicationProvider, ISettingsFile settings = null)
        {
            settings = settings ?? GetSettings();
            base.ConfigureServices(services, applicationProvider, settings);
            //The logic is related to Allure.If you don't plan to use Allure, delete the following code:
            services.AddSingleton<ILocalizedLogger, AllureBasedLocalizedLogger>();
            //End of Allure Logic
            return services;
        }
    }
}
