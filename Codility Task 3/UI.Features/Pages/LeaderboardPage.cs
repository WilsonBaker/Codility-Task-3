using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Codility_Task_3.UI.Features.Pages
{
    class LeaderboardPage
    {

        private readonly IWebDriver _driver;

        public LeaderboardPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }
    }
}
