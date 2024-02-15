using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Assessment_3pom.stepdefnition
{
    [Binding]

    public class BabypStepDefinitions
    {
        IWebDriver driver = new ChromeDriver();
        [Given(@"user went through the website")]
        public void GivenUserWentThroughTheWebsite()
        {
            Babyp babyp = new(driver);
            driver.Navigate().GoToUrl("https://www.hopscotch.in/");
            driver.Manage().Window.Maximize();
        }

        [When(@"user goes over all and clicks daily care")]
        public void WhenUserGoesOverAllAndClicksDailyCare()
        {
            Babyp babyp = new(driver);

            babyp.allp.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            babyp.daily.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
        }

        [Then(@"user selects bath from shopby category")]
        public void ThenUserSelectsBathFromShopbyCategory()
        {
            Babyp babyp = new(driver);
            babyp.shopb.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
            
        }

        [When(@"user clicks on the dropdown price")]
        public void WhenUserClicksOnTheDropdownPrice()
        {
            Babyp babyp = new(driver);
            babyp.price1.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));

        }

        [Then(@"user selects the price")]
        public void ThenUserSelectsThePrice()
        {
            Babyp babyp = new(driver);
            babyp.pricebelow.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));

        }

        [When(@"user clicks on the first item")]
        public void WhenUserClicksOnTheFirstItem()
        {
            Babyp babyp = new(driver);
            babyp.firstele.Click();
        }

     }
}

