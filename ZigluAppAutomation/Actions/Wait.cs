using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.UI;

namespace TestTheApp.Actions
{
    public static class Wait
    {
        public static void UntilElementIsVisible(AppiumDriver<AndroidElement> driver, By element,
            int timeOutSeconds = 3)
        {
            if (timeOutSeconds <= 0)
            {
                driver.FindElement(element);
                return;
            }

            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutSeconds));
            wait.Until(drv => drv.FindElement(element));
        }
    }
}