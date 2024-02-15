using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Assessment_3pom.stepdefnition
{
    [Binding]
    public class DailycareStepDefinitions
    {
        IWebDriver driver = new ChromeDriver();
        [Given(@"user navigated to webpage")]
        public void GivenUserNavigatedToWebpage()
        {
            Dailycare dailycare = new(driver);
            driver.Navigate().GoToUrl("https://www.hopscotch.in/");
            driver.Manage().Window.Maximize();
        }

        [When(@"user clicks on all in the menu and user come to select daily care")]
        public void WhenUserClicksOnAllInTheMenuAndUserComeToSelectDailyCare()
        {
            Dailycare dailycare = new(driver);
 
            dailycare.allp.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            dailycare.daily.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));

        }

        [Then(@"user come to select bath care in shop by category")]
        public void ThenUserComeToSelectBathCareInShopByCategory()
        {
            Dailycare dailycare = new(driver);
            dailycare.shopb.Click();
        }
    }
}
