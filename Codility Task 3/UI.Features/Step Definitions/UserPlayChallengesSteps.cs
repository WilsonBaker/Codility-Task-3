using Codility_Task_3.Drivers;
using Codility_Task_3.UI.Features.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Codility_Task_3.UI.Features.Step_Definitions
{
    [Binding]
    public sealed class UserPlayChallengesSteps
    {

        private SeleniumDriver seleniumDriver = null;
        private IWebDriver _driver;
        private CovidPage covidPageObject;
        private HomePage homePageObject;

        public UserPlayChallengesSteps(ScenarioContext scenarioContext)
        {
            seleniumDriver = scenarioContext.Get<SeleniumDriver>("seleniumDriver");
        }

        [Given(@"User clicks start game button")]
        [When(@"User clicks start game button")]
        public void UserClicksStartGameButton()
        {
            homePageObject.ClickStartGameButton();
        }

        [When(@"Covid page loads")]
        public void WhenUserSeesCovidPage()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"User should see their username '(.*)' on the screen")]
        public void ThenUserShouldSeeTheirUsernameOnTheScreen(string p0)
        {
            ScenarioContext.Current.Pending();
        }

    }
}
