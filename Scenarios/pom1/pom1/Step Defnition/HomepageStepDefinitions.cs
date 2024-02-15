using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using System;
using TechTalk.SpecFlow;

namespace pom1
{
    [Binding]
    public class HomepageStepDefinitions
    {
        IWebDriver driver = new EdgeDriver();
        [Given(@"The user is navigated to bigbasket")]
        public void GivenTheUserIsNavigatedToBigbasket()
        {
            Homepage homepage = new(driver);
            driver.Navigate().GoToUrl("https://www.bigbasket.com/");
            driver.Manage().Window.Maximize();
            string url = driver.Url;
            string urltotest = "https://www.bigbasket.com/";
            Assert.AreEqual(url, urltotest);

        }

        [When(@"the shopby category is located")]
        public void WhenTheShopbyCategoryIsLocated()
        {
            Homepage homepage = new(driver);
            homepage.shopb.Click();

        }

        [Then(@"category displayed is verified")]
        public void ThenCategoryDisplayedIsVerified()
        {
            Homepage homepage = new(driver);
            Console.WriteLine("verified" + homepage.shopb.Displayed);

        }

        [When(@"verifying the pincode is displayed")]
        public void WhenVerifyingThePincodeIsDisplayed()
        {
            Homepage homepage = new(driver);
            Console.WriteLine("pincode displayed" + homepage.pincode.Displayed);

        }

        [Then(@"extract the pincode")]
        public void ThenExtractThePincode()
        {
            Homepage homepage = new(driver);
            string pin = homepage.pincode.Text;
            Console.WriteLine(pin);

        }

        [When(@"Click on Shop By Category->Beverages")]
        public void WhenClickOnShopByCategory_Beverages()
        {
            Homepage homepage = new(driver);
            homepage.shopb.Click();
            homepage.bvg.Click();

        }

        [Then(@"open the first product and display the price and rating os first product")]
        public void ThenOpenTheFirstProductAndDisplayThePriceAndRatingOsFirstProduct()
        {
            Homepage homepage = new(driver);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0, 500)");
            Thread.Sleep(TimeSpan.FromSeconds(5));
            homepage.red.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
            string txt = homepage.redtxt.Text;
            Console.WriteLine(txt);
            string ratingp = homepage.rating.Text;
            Console.WriteLine(ratingp);

        }

        [When(@"Click on Shop by category ->Cleaning and household")]
        public void WhenClickOnShopByCategory_CleaningAndHousehold()
        {
            Homepage homepage = new(driver);
            driver.Navigate().GoToUrl("https://www.bigbasket.com/");
            homepage.shopb.Click();
            homepage.cleaning.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));

        }

        [Then(@"Print price of first product and add to cart")]
        public void ThenPrintPriceOfFirstProductAndAddToCart()
        {
            Homepage homepage = new(driver);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0, 500)");
            Thread.Sleep(TimeSpan.FromSeconds(5));
            homepage.harpic.Click();
            string pricep1 = homepage.priceh.Text;
            Console.WriteLine("price is" + homepage.priceh);
            homepage.cart.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));

        }

        [When(@"Click on my cart")]
        public void WhenClickOnMyCart()
        {
            Homepage homepage = new(driver);
            homepage.mycart.Click();

        }

        [Then(@"print the price present in it")]
        public void ThenPrintThePricePresentInIt()
        {
            Homepage homepage = new(driver);
            Console.WriteLine("price in cart is" + homepage.priceh);

        }

        [When(@"The user clicks on offer button")]
        public void WhenTheUserClicksOnOfferButton()
        {
            Homepage homepage = new(driver);
            driver.Navigate().GoToUrl("https://www.bigbasket.com/");
            homepage.offerbt.Click();
            Thread.Sleep(TimeSpan.FromSeconds(10));
        }

        [Then(@"user prints the price of second product")]
        public void ThenUserPrintsThePriceOfSecondProduct()
        {
            Homepage homepage = new(driver);
            Thread.Sleep(TimeSpan.FromSeconds(10));
            homepage.maggi.Click();
            string pricep12 = homepage.pricemag.Text;
            Console.WriteLine("price is" + pricep12);
        }
    }
}
