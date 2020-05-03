using OpenQA.Selenium;

namespace TestTheApp.Screen
{
    public static class HomePageScreen
    {
        public static By GetStarted { get; } = By.Id("to.chip.app:id/get_started_button");
    }
}