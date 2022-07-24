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

        [Given(@"User has a score on the leaderboard of '(.*)'")]
        public void GivenUserHasAScoreOnTheLeaderboardOf(int p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"User visits leaderbaord page")]
        public void WhenUserVisitsLeaderbaordPage()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"User should see their username '(.*)' and score of '(.*)'")]
        public void ThenUserShouldSeeTheirUsernameAndScoreOf(string p0, int p1)
        {
            ScenarioContext.Current.Pending();
        }

    }
}
