using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.iOS;
using TestTheApp.Configuration;

namespace TestTheApp.Context
{
    public class StepContext
    {
        public AndroidDriver<AndroidElement> AndroidDriver { get; set; }
        
        public IOSDriver<IOSElement> IosDriver { get; set; }
        
        public AppSettingsController AppSettings { get; set; }
    }

    
}