using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Purplle_Web_Automation.StepDefenitions
{
    [Binding]
    public class HomepageStepDefinitions :BaseClass
    {
        Homepage homepage => new(WebDriver);
        //Homepage homepage;
        //public HomepageStepDefinitions()
        //{

        //}


        //IWebDriver driver = new ChromeDriver();
        [Given(@"the user is Navigated to url ""([^""]*)""")]
        public void GivenTheUserIsNavigatedToUrl(string url)
        {
            WebDriver.Navigate().GoToUrl(url);
            WebDriver.Manage().Window.Maximize();
        }

        [When(@"the user verifies wheather navigated to correct url")]
        public void WhenTheUserVerifiesWheatherNavigatedToCorrectUrl()
        {
            string url1 = WebDriver.Url;
            string ExpectedUrl = "https://www.purplle.com/";
            Assert.AreEqual(ExpectedUrl, url1);
        }
        [Then(@"the user verifies the USECODE APPFIRST displayed")]
        public void ThenTheUserVerifiesTheUSECODEAPPFIRSTDisplayed()
        {
            Console.WriteLine("USECODE APPFIRST displayed:" + homepage.Usecode.Displayed);
        }
        [When(@"user checks the main banner is displayed")]
        public void WhenUserChecksTheMainBannerIsDisplayed()
        {

            Console.WriteLine("The main Banner is displayed:"+homepage.MainBanner.Displayed);
        }
        [Then(@"the user clicks on support and prints  Hi How can we help")]
        public void ThenTheUserClicksOnSupportAndPrintsHiHowCanWeHelp()
        {
            homepage.Support.Click();
            Thread.Sleep(1000);
            Console.WriteLine("The text is:"+homepage.SupportText.Text);
        }
        [When(@"the user Navigates back and checks logo is present")]
        public void WhenTheUserNavigatesBackAndChecksLogoIsPresent()
        {
            WebDriver.Navigate().Back();
            Console.WriteLine("The Logo is present:"+homepage.Logo.Displayed);
        }
        [Then(@"click on the cart button and verify it is empty")]
        public void ThenClickOnTheCartButtonAndVerifyItIsEmpty()
        {
            //Commoncodes.scroll();
            homepage.Cart.Click();
            Thread.Sleep(1000);
            Console.WriteLine("The cart is empty:" + homepage.EmptyCart.Displayed);
            Console.WriteLine(homepage.EmptyCart.Text);
            WebDriver.Quit();
        }





    }
}
