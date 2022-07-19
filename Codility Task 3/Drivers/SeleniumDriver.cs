using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;

namespace Codility_Task_3.Drivers
{
    class SeleniumDriver
    {
        private IWebDriver driver;

        private readonly ScenarioContext _scenarioContext;
        
        public SeleniumDriver(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        public IWebDriver Setup()
        {
            var chromeOptions = new ChromeOptions();

            driver = new RemoteWebDriver(new Uri("https://responsivefight.herokuapp.com/"), chromeOptions.ToCapabilities());

            _scenarioContext.Set(driver, "WebDriver");

            driver.Manage().Window.Maximize();

            return driver;
        }
    }
}
