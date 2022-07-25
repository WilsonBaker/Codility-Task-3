using Codility_Task_3.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Codility_Task_3.UI.Features.Step_Definitions
{
    [Binding]
    public sealed class UserLeaderboardSteps
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private IWebDriver _driver;

        public UserLeaderboardSteps(ScenarioContext scenarioContext)
        {
            _driver = scenarioContext.Get<IWebDriver>("seleniumDriver");
        }

        [Given(@"User with username '(.*)' has a score on the leaderboard of '(.*)'")]
        public void GivenUserHasAScoreOnTheLeaderboardOf(string username, int score)
        {
            var result = LeaderboardHelper.CheckUserExists(username);
            if (result)
            {
                //Update user with correct score regardless of if it's correct or not
                LeaderboardHelper.UpdateUser(username, score);
            } else
            {
                //Add user with correct score
                LeaderboardHelper.AddUser(username, score);
            }
        }

        [When(@"User visits leaderbaord page")]
        public void WhenUserVisitsLeaderbaordPage()
        {
            _driver.Navigate().GoToUrl("https://responsivefight.herokuapp.com/leaderboard");
        }

        [Then(@"User should see their username '(.*)' and score of '(.*)'")]
        public void ThenUserShouldSeeTheirUsernameAndScoreOf(string p0, int p1)
        {
            ScenarioContext.Current.Pending();
        }

    }
}
