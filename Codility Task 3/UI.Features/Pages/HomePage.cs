using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
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
        private IWebElement SignUpButton { get; set; }

        [FindsBy(How = How.Id, Using = "login_popup")]
        private IWebElement LoginErrorPopup { get; set; }


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
            // Check that login title has been displayed and also that the username text is correct
            if (LoginTitle.Displayed == true && LoginTitleUsername.Text == givenUsername)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public void ClickRegisterButton()
        {
            RegisterBtn.Click();
        }

        public void ClickSignUpButton()
        {
            SignUpButton.Click();
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
            if (LoginErrorPopup.Displayed == true && LoginErrorPopup.Text == "Wrong username or password")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
