using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;

namespace TestTheApp.Actions
{
    public static class Read
    {
        public static string Text(AndroidDriver<AndroidElement> driver, By element)
        {
            return driver.FindElement(element).Text;
        }
    }
}
