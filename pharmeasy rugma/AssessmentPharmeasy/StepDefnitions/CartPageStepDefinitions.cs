using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace AssessmentPharmeasy
{
    [Binding]
    public class CartPageStepDefinitions
    {
        IWebDriver driver = new ChromeDriver();

        [Given(@"user navigates ""([^""]*)""")]
        public void GivenUserNavigates(string url)
        {
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
        }

        [When(@"user adds product to cart")]
        public void WhenUserAddsProductToCart()
        {
            SearchDropDown searchDropDown = new(driver);
            searchDropDown.SearchDrop.Click();
            Thread.Sleep(1000);
            searchDropDown.SearchBar.SendKeys("Shampoo");
            Thread.Sleep(2000);
            searchDropDown.ThirdItem.Click();
            Thread.Sleep(2000);
            searchDropDown.AddToCart.Click();
            Thread.Sleep(4000);
        }

        [When(@"user select product quantity")]
        public void WhenUserSelectProductQuantity()
        {
            SearchDropDown searchDropDown = new(driver);
            searchDropDown.Qty4.Click();
            Thread.Sleep(2000);
        }

        [When(@"user clicks view cart")]
        public void WhenUserClicksViewCart()
        {
            SearchDropDown searchDropDown = new(driver);
            searchDropDown.ViewCart.Click();
        }

        [When(@"user print the price")]
        public void WhenUserPrintThePrice()
        {
            CartPage cartPage = new(driver);
            Console.WriteLine("The price is :" + cartPage.PrintPrice.Text);
            Thread.Sleep(2000);
        }

        [When(@"user click on Apply coupon")]
        public void WhenUserClickOnApplyCoupon()
        {
            CartPage cartPage = new(driver);
            cartPage.ApplyCoupon.Click();
            Thread.Sleep(2000);
        }

        [When(@"user select the second coupon available")]
        public void WhenUserSelectTheSecondCouponAvailable()
        {
            CartPage cartPage = new(driver);
            cartPage.Coupon.Click();
            Thread.Sleep(2000);
        }

        [When(@"user enter an invalid phone number")]
        public void WhenUserEnterAnInvalidPhoneNumber()
        {
            CartPage cartPage = new(driver);
            cartPage.MobileInput.Click();
            Thread.Sleep(2000);
            cartPage.MobileInput.SendKeys("123");
            Thread.Sleep(2000);
        }

        [When(@"user verify the error message")]
        public void WhenUserVerifyTheErrorMessage()
        {
            CartPage cartPage = new(driver);
            cartPage.SendOtp.Click();
            Thread.Sleep(2000);
            Console.WriteLine("The error message is: " + cartPage.ErrorNoMsg.Text);
            Thread.Sleep(2000);
        }

        [When(@"user close the otp screen")]
        public void WhenUserCloseTheOtpScreen()
        {
            CartPage cartPage = new(driver);
            cartPage.CloseOtp.Click();
            Thread.Sleep(2000);
        }

        [When(@"user delete the product added")]
        public void WhenUserDeleteTheProductAdded()
        {
            CartPage cartPage = new(driver);
            cartPage.DeleteProduct.Click();
            Thread.Sleep(2000);
            cartPage.YesDelete.Click();
            Thread.Sleep(2000);
        }

        [When(@"user verifies error message")]
        public void WhenUserVerifiesErrorMessage()
        {
            CartPage cartPage = new(driver);
            Console.WriteLine("The error message displayed as: " + cartPage.ErrorEmptyMsg.Text);
        }

        [Then(@"user quit app")]
        public void ThenUserQuitApp()
        {
            driver.Quit();
        }
    }
}
