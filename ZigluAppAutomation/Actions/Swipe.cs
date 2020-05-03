using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Interactions;

namespace TestTheApp.Actions
{
    public class Swipe
    {
        public static void Left(AppiumDriver<AndroidElement> driver, By element)
        {
            var action = new TouchActions(driver);
            // driver.FindElement(element).
        }
    }
}