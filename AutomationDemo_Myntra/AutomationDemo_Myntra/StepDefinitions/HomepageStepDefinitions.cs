using AutomationDemo_Myntra;

using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using TechTalk.SpecFlow;

using Selenium.Axe;

namespace AutomationDemo_Myntra
{
    [Binding]
    public class HomepageStepDefinitions :BaseClass

    {
        //IWebDriver driver = new ChromeDriver();
       // CommonClass.Maximise;
        
        Homepage homepage => new(driver);

        //Actions actions = new Actions(driver);
        //DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver);

        [Given(@"User Navigated to the Homepage")]
        public void GivenUserNavigatedToTheHomepage()
        {

            driver.Navigate().GoToUrl("https://www.myntra.com/");
            string urltotest = driver.Url;
            string url = "https://www.myntra.com/";
            Assert.AreEqual(url, urltotest);
            Console.WriteLine("Verified the Myntra Homepage URL");
        }

        [When(@"User verify the Title")]
        //public void WhenUserVerifyTheTitle()
        //{   
        //    Console.WriteLine("The Title of the Application is: " + );
        //}

        [Then(@"Icon should be displayed")]
        public void ThenIconShouldBeDisplayed()
        {
            Console.WriteLine("Myntra Icon is displayed:" + homepage.MyntraIcon.Displayed);
        }

        [When(@"Wishlist is selected")]
        public void WhenWishlistIsSelected()
        {
           homepage.Wishlist.Click();
           Console.WriteLine("Navigated to Myntra Wishlist page");

        }

        [Then(@"Verify Wishlist page")]
        public void ThenVerifyWishlistPage()
        {
            string urltotest = driver.Url;
            string url = "https://www.myntra.com/wishlist";
            Assert.AreEqual(url, urltotest);
            Console.WriteLine("Verified the Myntra WishList URL");
        }

        [When(@"Cart is selected")]
        public void WhenCartIsSelected()
        {
            homepage.Cart.Click();
            Console.WriteLine("Navigated to Myntra Cart page");
        }

        [Then(@"Verify Cart page")]
        public void ThenVerifyCartPage()
        {
            string urltotest = driver.Url;
            string url = "https://www.myntra.com/checkout/cart";
            Assert.AreEqual(url, urltotest);
            Console.WriteLine("Verified the Myntra Cart URL");
        }

        [When(@"Cart Items details listed")]
        public void WhenCartItemsDetailsListed()
        {
            string Title= driver.Title;
            Console.WriteLine("The Current Title is: "+Title);
        }

        [Then(@"Display the details")]
        public void ThenDisplayTheDetails()
        {
            String message= homepage.EmptyMessage.Text;
            Console.WriteLine("The Cart is empty and shows the message: "+message);
        }
    }
}
