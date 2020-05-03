using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using TestTheApp.Actions;

namespace TestTheApp.Tasks
{
    public class FillIn
    {
        private readonly AndroidDriver<AndroidElement> _driver;

        public FillIn(AndroidDriver<AndroidElement> driver)
        {
            _driver = driver;
        }

        public void Passcode(By element, string keys)
        {
            Enter.Text(_driver, element, keys);
        }

        public void EmailAddress(By element, string emailAddress)
        {
            Remove.Text(_driver, element);
            EmailAddress(element, emailAddress);
        }
    }
}