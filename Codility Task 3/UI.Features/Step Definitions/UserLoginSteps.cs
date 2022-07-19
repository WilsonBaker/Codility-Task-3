using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Codility_Task_3.UI.Features.Step_Definitions
{
    [Binding]
    public sealed class UserLoginSteps
    {

        private readonly ScenarioContext _scenarioContext;

        public UserLoginSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given("User visits login page")]
        public void UserVisitsLoginPage()
        {
            
        }

    }
}
