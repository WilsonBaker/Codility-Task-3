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
            if (LoginTitle.Displayed == true && LoginTitleUsername.Text == givenUsername)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public void EnterUsernameAndPasswordRegistration(string givenUsername, string givenPassword)
        {

        }
    }
}
