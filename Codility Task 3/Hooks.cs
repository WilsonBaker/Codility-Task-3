using Codility_Task_3.Drivers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Codility_Task_3
{
    [Binding]
    public sealed class Hooks
    {
        private readonly ScenarioContext _scenarioContext;

        public Hooks(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            SeleniumDriver seleniumDriver = new SeleniumDriver(_scenarioContext);
            IWebDriver _driver = seleniumDriver.Setup();
            _scenarioContext.Set(_driver, "seleniumDriver");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Console.WriteLine("Destroy selenium driver after tests");
            _scenarioContext.Get<IWebDriver>("WebDriver").Quit();
        }
    }
}
