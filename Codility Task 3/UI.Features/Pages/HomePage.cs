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
    }
}
