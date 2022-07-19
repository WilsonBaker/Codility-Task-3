using Codility_Task_3.Drivers;
using OpenQA.Selenium;
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
        private SeleniumDriver seleniumDriver = null;
        private IWebDriver _driver;

        public UserLoginSteps(ScenarioContext scenarioContext)
        {
            seleniumDriver = scenarioContext.Get<SeleniumDriver>("seleniumDriver");
        }

        [Given("User visits home page")]
        public void UserVisitsHomePage()
        {
            _driver = seleniumDriver.Setup();
            _driver.Navigate().GoToUrl("https://responsivefight.herokuapp.com/");
            System.Threading.Thread.Sleep(2000);
        }

    }
}
