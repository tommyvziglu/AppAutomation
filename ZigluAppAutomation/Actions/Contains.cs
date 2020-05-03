using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.PageObjects.Attributes;

namespace TestTheApp.Actions
{
    public static class Check
    {
      
        public static bool MatchingText(AppiumDriver<AndroidElement> driver, By element, string value)
        {
            var expected = driver.FindElement(element);
            bool result = expected.Text.Contains(value);
            return result;
        }
    }
}