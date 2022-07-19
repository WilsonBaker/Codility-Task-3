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
    public sealed class UserLoginSteps
    {
        private SeleniumDriver seleniumDriver = null;
        private IWebDriver _driver;
        private HomePage homePageObject;

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
            homePageObject = new HomePage(_driver);
        }

        [When("User logs in with username '(.*)' and password '(.*)'")]
        public void UserClicksLoginAndEntersDetails(string username, string password)
        {
            homePageObject.clickLoginBtn();
            System.Threading.Thread.Sleep(2000);
        }

    }
}
