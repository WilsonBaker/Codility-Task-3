using Codility_Task_3.Drivers;
using Codility_Task_3.UI.Features.Pages;
using NUnit.Framework;
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
        private IWebDriver _driver;
        private CovidPage covidPageObject;
        private HomePage homePageObject;
        private NewsPage newsPageObject;

        public UserPlayChallengesSteps(ScenarioContext scenarioContext)
        {
            _driver = scenarioContext.Get<IWebDriver>("seleniumDriver");
        }

        [Given(@"User clicks start game button")]
        [When(@"User clicks start game button")]
        public void UserClicksStartGameButton()
        {
            homePageObject = new HomePage(_driver);
            homePageObject.ClickStartGameButton();
        }

        [Given(@"User clicks Enter at your own risk button")]
        public void GivenUserClicksEnterAtYourOwnRiskButton()
        {
            covidPageObject = new CovidPage(_driver);
            System.Threading.Thread.Sleep(2000);
            covidPageObject.ClickEnterAtOwnRiskButton();
        }

        [Given(@"User clicks start button")]
        public void GivenUserClicksStartButton()
        {
            newsPageObject = new NewsPage(_driver);
            System.Threading.Thread.Sleep(2000);
            newsPageObject.ClickStartButton();
        }

        [When(@"User chooses correct answer")]
        public void WhenUserChoosesCorrectAnswer()
        {
            System.Threading.Thread.Sleep(2000);
            newsPageObject.ClickCorrectAnswerButton();
        }

        [Then(@"User should see message saying they are correct")]
        public void ThenUserShouldSeeMessageSayingTheyAreCorrect()
        {
            newsPageObject.ClickCorrectAnswerButton();
            var result = newsPageObject.CheckPostAnswerMessage("That is correct!");
            Assert.IsTrue(result);
        }


    }
}
