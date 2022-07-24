using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Codility_Task_3.UI.Features.Pages
{
    class NewsPage
    {
        [FindsBy(How = How.Id, Using = "start")]
        private IWebElement startButton { get; set; }

        [FindsBy(How = How.Id, Using = "answer_1")]
        private IWebElement Answer1 { get; set; }

        [FindsBy(How = How.Id, Using = "answer_2")]
        private IWebElement Answer2 { get; set; }

        [FindsBy(How = How.Id, Using = "staticBackdropLabel")]
        private IWebElement PostAnswerMessage { get; set; }


        private readonly IWebDriver _driver;

        public NewsPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        public void ClickStartButton()
        {
            startButton.Click();
        }

        public void ClickCorrectAnswerButton()
        {
            // As the questions are currently broken I can't access what the correct answer is
            // Usually I would assert the text of the answer against something I know is correct for this question
            Answer1.Click();
        }

        public bool CheckPostAnswerMessage(string message)
        {
            // Wait for message to be loaded with a timeout of 30 secs
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("staticBackdropLabel")));
            var result = (PostAnswerMessage.Displayed && PostAnswerMessage.Text.Equals(message)) ? true : false;
            return result;
        }

    }
}
