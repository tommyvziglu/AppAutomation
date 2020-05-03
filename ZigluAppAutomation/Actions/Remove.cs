using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace TestTheApp.Actions
{
    public static class Remove
    {
        public static void Text(AppiumDriver<AndroidElement> driver, By element)
        {
            driver.FindElement(element).Clear();
        }
    }
}