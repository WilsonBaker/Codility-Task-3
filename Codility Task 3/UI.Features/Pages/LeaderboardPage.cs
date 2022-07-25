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

        [FindsBy(How = How.XPath, Using = "//*[@id=\"showData\"]/table/tbody")]
        private IWebElement LeaderboardTable { get; set; }

        public LeaderboardPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        public bool CheckUserDisplayedOnLeaderboardWithCorrectDetails(string username, string score)
        {
            bool result = false;
            IList<IWebElement> trCollection = LeaderboardTable.FindElements(By.TagName("tr"));
            IList<IWebElement> tdCollection;
            foreach (IWebElement element in trCollection)
            {
                tdCollection = element.FindElements(By.TagName("td"));

                if (tdCollection.Count >= 1)
                {
                    result = tdCollection[0].Text.Equals(username) ? true : false;
                    result = tdCollection[1].Text.Equals(score) ? true : false;
                }
            }
            return result;
        }
    }
}
