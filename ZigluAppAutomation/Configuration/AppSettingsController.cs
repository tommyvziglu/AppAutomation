using System;
using Microsoft.Extensions.Configuration;

namespace TestTheApp.Configuration
{
    public class AppSettingsController
    {
        private static IConfigurationRoot _appSettings;
        private static readonly object Padlock = new object();

        public AppSettingsController(IConfigurationBuilder configurationBuilder,
            string settingsFileName = "appsettings.json")
        {
            ReadSettingsFile(configurationBuilder, settingsFileName);
        }

        private static void ReadSettingsFile(IConfigurationBuilder configurationBuilder, string settingsFileName)
        {
            lock (Padlock)
            {
                _appSettings ??= configurationBuilder
                    .AddJsonFile(settingsFileName)
                    .Build();
            }
        }

        public string GetAppSettingsValue(string settingKey)
        {
            try
            {
                return _appSettings[settingKey];
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}