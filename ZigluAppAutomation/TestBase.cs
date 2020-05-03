using System;
using Microsoft.Extensions.Configuration;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.iOS;
using OpenQA.Selenium.Appium.Service;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;
using TestTheApp.Configuration;
using TestTheApp.Context;

namespace TestTheApp
{
    [Binding]
    public abstract class TestBase
    {
        public static StepContext Context;
        public static AppSettingsController AppsettingsController;
        public static AppiumLocalService _AppiumLocalService;

        static TestBase()
        {
            Context = new StepContext();
            AppsettingsController = new AppSettingsController(new ConfigurationBuilder());
        }

        [BeforeTestRun]
        public static void SetUp()
        {
            var stringforUrl =  );

            InitAppium();

            Context.AndroidDriver = new AndroidDriver<AndroidElement>(
                new Uri(AppsettingsController.GetAppSettingsValue("localUrlForDriver")), AndroidAppiumOptions());

            Context.AndroidDriver.LaunchApp();
        }

        public static void AndroidLauncher()
        {
            var stringforUrl = new Uri(AppsettingsController.GetAppSettingsValue("localUrlForDriver"));
            Context.IosDriver = new IOSDriver<IOSElement>(_AppiumLocalService.ServiceUrl, AndroidAppiumOptions());
            //hippotech.bank.ios
        }

        public static void IPhoneLauncher()
        {
            var stringforUrl = new Uri(AppsettingsController.GetAppSettingsValue("localUrlForDriver"));
            Context.IosDriver = new IOSDriver<IOSElement>(_AppiumLocalService.ServiceUrl, AndroidAppiumOptions());
            //hippotech.bank.ios
        }

        [AfterTestRun]
        //teardown
        public static void TearItDown()
        {
            Context.AndroidDriver?.CloseApp();
            Context.AndroidDriver?.Quit();
        }

        private static void InitAppium()
        {
            _AppiumLocalService = new AppiumServiceBuilder().UsingAnyFreePort().Build();
            _AppiumLocalService.Start();

            if (!_AppiumLocalService.IsRunning)
            {
                throw new Exception("Appium is not up and running.");
            }
        }

        private static DesiredCapabilities AndroidAppiumOptions(string deviceName = null)
        {
            //move to separate json config.
            if (!string.IsNullOrEmpty(deviceName)) throw new NotImplementedException("Need to implement drivers here");
            var appiumOptions = new DesiredCapabilities {AcceptInsecureCerts = true};
            appiumOptions.SetCapability("deviceName",
                AppsettingsController.GetAppSettingsValue("tommyAndroidEmulator"));
            appiumOptions.SetCapability("platformName", AppsettingsController.GetAppSettingsValue("automationDriver"));
            appiumOptions.SetCapability("autoGrantPermissions", true);
            appiumOptions.SetCapability("newCommandTimeout", "1800");
            appiumOptions.SetCapability("app", AppsettingsController.GetAppSettingsValue("pathToApK"));

            return appiumOptions;
        }

        private static DesiredCapabilities iosCapabilities(string deviceName = null)
        {
            //move to separate json config.
            if (!string.IsNullOrEmpty(deviceName)) throw new NotImplementedException("Need to implement drivers here");
            var appiumOptions = new DesiredCapabilities {AcceptInsecureCerts = true};
            appiumOptions.SetCapability("deviceName", AppsettingsController.GetAppSettingsValue("iPhone 11"));
            appiumOptions.SetCapability("platformName", AppsettingsController.GetAppSettingsValue("IOS"));
            appiumOptions.SetCapability("autoGrantPermissions", true);
            appiumOptions.SetCapability("newCommandTimeout", "1800");
            appiumOptions.SetCapability("appPackage", "hippotech.bank.ios"); // 
            appiumOptions.SetCapability("app", AppsettingsController.GetAppSettingsValue("pathToApK"));

            return appiumOptions;
        }
    }
}