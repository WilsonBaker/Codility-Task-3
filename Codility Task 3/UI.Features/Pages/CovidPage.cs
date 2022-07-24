using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Codility_Task_3.UI.Features.Pages
{
    class CovidPage
    {
        [FindsBy(How = How.Id, Using = "welcome_text")]
        private IWebElement WelcomeText { get; set; }

        [FindsBy(How = How.Id, Using = "news")]
        private IWebElement EnterAtOwnRiskButton { get; set; }


        private readonly IWebDriver _driver;

        public CovidPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        public void ClickEnterAtOwnRiskButton()
        {
            EnterAtOwnRiskButton.Click();
        }

    }
}
