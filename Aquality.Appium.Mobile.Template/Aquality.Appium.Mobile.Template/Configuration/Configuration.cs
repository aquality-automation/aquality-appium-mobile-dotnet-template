﻿using Aquality.Selenium.Core.Configurations;

namespace Aquality.Appium.Mobile.Template.Configuration
{
    public static class Configuration
    {
        public static string ConfigurationValue => CurrentEnvironment.GetValue<string>("configurationValue");

        private static ISettingsFile CurrentEnvironment => Environment.CurrentEnvironment;
    }
}
