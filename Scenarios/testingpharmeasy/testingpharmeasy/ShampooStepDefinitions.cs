using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace testingpharmeasy
{
    [Binding]
    public class ShampooStepDefinitions
    {
        IWebDriver driver = new ChromeDriver();
        [Given(@"navigated to shampoo page")]
        public void GivenNavigatedToShampooPage()
        {
            Shampoopage shampoopage = new(driver);
            driver.Navigate().GoToUrl("https://pharmeasy.in/health-care/products/himalaya-anti-dandruff-shampoo---200ml-503683");
            driver.Manage().Window.Maximize();

        }

        [When(@"Select  ml")]
        public void WhenSelectMl()
        {
            Shampoopage shampoopage = new(driver);
            shampoopage.ml.Click();
            Thread.Sleep(3000);
            

        }

        [Then(@"click on add to cart")]
        public void ThenClickOnAddToCart()
        {
            Shampoopage shampoopage = new(driver);
            shampoopage.addc.Click();
            shampoopage.firstel.Click();
            Thread.Sleep(3000);
        }

        [When(@"click on view cart")]
        public void WhenClickOnViewCart()
        {
            Shampoopage shampoopage = new(driver);
            shampoopage.viewcc.Click();
        }

        [Then(@"print the price")]
        public void ThenPrintThePrice()
        {
            throw new PendingStepException();
        }
    }
}
