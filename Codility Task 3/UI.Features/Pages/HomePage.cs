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
        private IWebElement username { get; set; }

        [FindsBy(How = How.Id, Using = "worrior_pwd")]
        private IWebElement password { get; set; }

        [FindsBy(How = How.Id, Using = "warrior")]
        private IWebElement submitBtn { get; set; }

        [FindsBy(How = How.Id, Using = "login_title")]
        private IWebElement loginTitle { get; set; }

        [FindsBy(How = How.Id, Using = "user_txt")]
        private IWebElement loginTitleUsername { get; set; }

        private readonly IWebDriver _driver;
        public HomePage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        public void clickLoginBtn()
        {
            LoginBtn.Click();
        }

        public void enterUsernameAndPassword(string givenUsername, string givenPassword)
        {
            // Clear and then enter text
            username.Clear();
            username.SendKeys(givenUsername);

            password.Clear();
            password.SendKeys(givenPassword);
        }

        public void submitDetails()
        {
            submitBtn.Click();
        }

        public bool checkLoginTitleIsDisplayedWithUsername(string givenUsername)
        {
            if (loginTitle.Displayed == true && loginTitleUsername.Text == givenUsername)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
