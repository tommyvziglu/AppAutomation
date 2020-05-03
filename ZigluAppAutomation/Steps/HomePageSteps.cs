using System.Threading;
using NUnit.Framework;
using TestTheApp.Actions;
using TestTheApp.Context;
using TestTheApp.Screen;

namespace TestTheApp.Steps
{
    public class HomePageSteps : StepBaseContext
    {
        public HomePageSteps(StepContext context) : base(context)
        {
        }

        public void GivenIOpenTheApp()
        {
            var headerText = Check.MatchingText(Context.AndroidDriver, HomePageScreen.GetStarted,
                HomePageScreenConstants.HomePageHeaderText);

            Assert.That(headerText, Is.True);   
            
            
            
        }

        public void WhenIClickSignMeUp()
        {
            Click.On(Context.AndroidDriver, HomePageScreen.GetStarted);
            
        }


        public void ThenTheUserIsSuccessfullyOnTheSignUpPage()
        {
            Thread.Sleep(3000);

            var signMeUp = Check.MatchingText(Context.AndroidDriver, HomePageScreen.GetStarted,
                HomePageScreenConstants.SignMeUp);

            Assert.That(signMeUp, Is.True);
        }
    }
}