using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace TestTheApp.Actions
{
    public static class Enter
    {
        public static void Text(AppiumDriver<AndroidElement> driver, By element, string text)
        {
            driver.FindElement(element).SendKeys(text);
        }
    }
}