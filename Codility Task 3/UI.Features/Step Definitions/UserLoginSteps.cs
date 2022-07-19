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
        [When("User visits home page")]
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
            System.Threading.Thread.Sleep(2000);
            homePageObject.EnterUsernameAndPassword(username, password);
        }

        [When("User submits the details")]
        public void UserSubmitsDetails()
        {
            homePageObject.SubmitDetails();
        }

        [Then(@"User should see successful login title with username '(.*)'")]
        public void ThenUserShouldSeeSuccessfulLoginTitleWithUsername(string username)
        {
            var result = homePageObject.CheckLoginTitleIsDisplayedWithUsername(username);
            Assert.IsTrue(result);
        }

        [When(@"User registers with username '(.*)' and password '(.*)' and repeat password '(.*)'")]
        public void WhenUserRegistersWithUsernameAndPassword(string username, string password, string repeatPassword)
        {
            homePageObject.ClickRegisterButton();
            System.Threading.Thread.Sleep(2000);
            homePageObject.EnterUsernameAndPasswordRegistration(username, password, repeatPassword);
            homePageObject.ClickSignUpButton();
            System.Threading.Thread.Sleep(2000);
        }

        [Given(@"User clicks login button")]
        public void GivenUserClicksLoginButton()
        {
            homePageObject.ClickLoginBtn();
        }

        [Then(@"User sees login error")]
        public void ThenUserSeesLoginError()
        {
            System.Threading.Thread.Sleep(2000);
            var result = homePageObject.CheckLoginErrorDisplayed();
            Assert.IsTrue(result);
        }

        [Then(@"User sees register error '(.*)'")]
        public void ThenUserSeesRegisterError(string errorMessage)
        {
            System.Threading.Thread.Sleep(2000);
            var result = homePageObject.CheckRegisterErrorDisplayed(errorMessage);
            Assert.IsTrue(result);
        }

        [Given(@"User clicks start game button")]
        [When(@"User clicks start game button")]
        public void UserClicksStartGameButton()
        {
            homePageObject.ClickStartGameButton();
        }
    }
}
