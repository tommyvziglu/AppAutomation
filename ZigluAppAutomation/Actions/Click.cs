using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace TestTheApp.Actions
{
    public static class Click
    {
        public static void On(AppiumDriver<AndroidElement> driver, By element)
        {
            driver.FindElement(element).Click();
        }
    }
}