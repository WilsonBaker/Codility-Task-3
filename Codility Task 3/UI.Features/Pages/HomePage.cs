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
        private IWebElement byLoginBtn { get; set; }

        private readonly IWebDriver _driver;
        public HomePage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        public void clickLoginBtn()
        {
            byLoginBtn.Click();
        }
    }
}
