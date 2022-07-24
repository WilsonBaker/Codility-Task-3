using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Codility_Task_3.UI.Features.Pages
{
    class HomePage
    {
        [FindsBy(How = How.Id, Using = "login")]
        private IWebElement LoginBtn { get; set; }

        [FindsBy(How = How.Id, Using = "worrior_username")]
        private IWebElement Username { get; set; }

        [FindsBy(How = How.Id, Using = "worrior_pwd")]
        private IWebElement Password { get; set; }

        [FindsBy(How = How.Id, Using = "warrior")]
        private IWebElement SubmitBtn { get; set; }

        [FindsBy(How = How.Id, Using = "login_title")]
        private IWebElement LoginTitle { get; set; }

        [FindsBy(How = How.Id, Using = "user_txt")]
        private IWebElement LoginTitleUsername { get; set; }

        [FindsBy(How = How.Id, Using = "rego")]
        private IWebElement RegisterBtn { get; set; }

        [FindsBy(How = How.Id, Using = "uname")]
        private IWebElement RegisterUsername { get; set; }

        [FindsBy(How = How.Id, Using = "pwd")]
        private IWebElement RegisterPassword { get; set; }

        [FindsBy(How = How.Id, Using = "psw-repeat")]
        private IWebElement RegisterPasswordRepeat { get; set; }

        [FindsBy(How = How.Id, Using = "signupbtn")]
        private IWebElement SignUpBtn { get; set; }

        [FindsBy(How = How.Id, Using = "login_popup")]
        private IWebElement LoginErrorPopup { get; set; }

        [FindsBy(How = How.Id, Using = "popup")]
        private IWebElement RegisterErrorPopup { get; set; }

        [FindsBy(How = How.Id, Using = "start")]
        private IWebElement StartGameBtn { get; set; }


        private readonly IWebDriver _driver;


        public HomePage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        public void ClickLoginBtn()
        {
            LoginBtn.Click();
        }

        public void EnterUsernameAndPassword(string givenUsername, string givenPassword)
        {
            // Clear and then enter text
            Username.Clear();
            Username.SendKeys(givenUsername);

            Password.Clear();
            Password.SendKeys(givenPassword);
        }

        public void SubmitDetails()
        {
            SubmitBtn.Click();
        }

        public bool CheckLoginTitleIsDisplayedWithUsername(string givenUsername)
        {
            // Wait for login title to be loaded with a timeout of 30 secs
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("user_txt")));
            // Check that login title has been displayed and also that the username text is correct
            var result = (LoginTitle.Displayed == true && LoginTitleUsername.Text == givenUsername) ? true : false;
            return result;
        }

        public void ClickRegisterButton()
        {
            RegisterBtn.Click();
        }

        public void ClickSignUpButton()
        {
            SignUpBtn.Click();
        }

        public void ClickStartGameButton()
        {
            StartGameBtn.Click();
        }

        public void EnterUsernameAndPasswordRegistration(string givenUsername, string givenPassword, string repeatedPassword)
        {
            // Clear and then enter text
            RegisterUsername.Clear();
            RegisterUsername.SendKeys(givenUsername);

            RegisterPassword.Clear();
            RegisterPassword.SendKeys(givenPassword);

            RegisterPasswordRepeat.Clear();
            RegisterPasswordRepeat.SendKeys(repeatedPassword);
        }

        public bool CheckLoginErrorDisplayed()
        {
            // Wait for error popup to be loaded with a timeout of 30 secs
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("login_popup")));
            var result = (LoginErrorPopup.Displayed == true && LoginErrorPopup.Text == "Wrong username or password") ? true : false;
            return result;
        }

        public bool CheckRegisterErrorDisplayed(string errorMessage)
        {
            // Wait for error popup to be loaded with a timeout of 30 secs
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("popup")));
            var result = (RegisterErrorPopup.Displayed == true && RegisterErrorPopup.Text == errorMessage) ? true : false;
            return result;
        }
    }
}
