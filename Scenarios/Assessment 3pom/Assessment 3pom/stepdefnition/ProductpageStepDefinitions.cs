using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Assessment_3pom
{
    [Binding]
    public class ProductpageStepDefinitions
    {
        IWebDriver driver = new ChromeDriver();
        [Given(@"User navigated to the product page")]
        public void GivenUserNavigatedToTheProductPage()
        {
            Productpage productpage = new(driver);
            driver.Navigate().GoToUrl("https://www.hopscotch.in/product/1059167/mother-sparsh-plant-powered-natural-baby-shampoo-200ml");
            Thread.Sleep(5000);
            driver.Manage().Window.Maximize();
        }

        [When(@"user clicks on the check pincode")]
        public void WhenUserClicksOnTheCheckPincode()
        {
            Productpage productpage = new(driver);
            productpage.pinchk.Click();


        }

        [Then(@"user  validate it and verify it")]
        public void ThenUserValidateItAndVerifyIt()
        {
            Productpage productpage = new(driver);
            Thread.Sleep(TimeSpan.FromSeconds(2));
            productpage.pinchk1.Click();
            productpage.pinchk1.SendKeys("455 - 550");
            productpage.pinchk2.Click();
            Console.WriteLine(productpage.pinchk2.Displayed);
            Thread.Sleep(TimeSpan.FromSeconds(2));
            productpage.pinchk1.Clear();
            productpage.pinchk1.SendKeys("132- 103");
            Console.WriteLine("verified the pincode"+productpage.pinchk1.Displayed);
            productpage.pinchk2.Click();

        }

        [When(@"user clicks on the add to cart button")]
        public void WhenUserClicksOnTheAddToCartButton()
        {
            Productpage productpage = new(driver);
            Thread.Sleep(TimeSpan.FromSeconds(5));
            productpage.cart.Click();

        }

        [Then(@"user select go to cart button")]
        public void ThenUserSelectGoToCartButton()
        {
            Productpage productpage = new(driver);
            Thread.Sleep(TimeSpan.FromSeconds(5));
            productpage.cartbt.Click();
            


        }

        [When(@"user verify the count of the items left and select the quantity according to the availability")]
        public void WhenUserVerifyTheCountOfTheItemsLeftAndSelectTheQuantityAccordingToTheAvailability()
        {
            Productpage productpage = new(driver);
            Thread.Sleep(TimeSpan.FromSeconds(2));
            Console.WriteLine(productpage.ProductCount.Text);
            productpage.qty.Click();
        }

        [Then(@"user Print the Total cost and the delivery date and Remove the item and verify the message Cart is empty and There's nothing in here\.")]
        public void ThenUserPrintTheTotalCostAndTheDeliveryDateAndRemoveTheItemAndVerifyTheMessageCartIsEmptyAndTheresNothingInHere_()
        {
            Productpage productpage = new(driver);
            Thread.Sleep(TimeSpan.FromSeconds(2));
            Console.WriteLine("Arrival date is :" + productpage.arrivedate.Text);
            Console.WriteLine("Total cost is" + productpage.cost.Text);
            productpage.delete.Click();
            Thread.Sleep(3000);
            Console.WriteLine("cart is empty is displayed:" + productpage.Emptycart1.Displayed);
            Console.WriteLine(productpage.Emptycart2.Text);
            Console.WriteLine("there is nothing displayed:" + productpage.Emptycart2.Displayed);
        }

    }
}
