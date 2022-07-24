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

        [Given(@"User clicks Enter at your own risk button")]
        public void GivenUserClicksEnterAtYourOwnRiskButton()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"User clicks start button")]
        public void GivenUserClicksStartButton()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"User chooses correct answer")]
        public void WhenUserChoosesCorrectAnswer()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"User should see message saying they are correct")]
        public void ThenUserShouldSeeMessageSayingTheyAreCorrect()
        {
            ScenarioContext.Current.Pending();
        }


    }
}
