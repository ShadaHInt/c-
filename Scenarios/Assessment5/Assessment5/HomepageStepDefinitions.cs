using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using TechTalk.SpecFlow;


namespace Assessment5
{
    [Binding]
    public class HomepageStepDefinitions : BaseClass1
    {
        Homepage homepage => new(driver);
        Shop shop => new(driver);

        [Given(@"The user is navigated to url")]
        public void GivenTheUserIsNavigatedToUrl()
        {
            
            driver.Navigate().GoToUrl(" https://www.tatacliq.com/");
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            homepage.pop1.Click();
            Thread.Sleep(2000);

        }

        [When(@"verify the logo header")]
        public void WhenVerifyTheLogoHeader()
        {
            Console.WriteLine("verified logo" + homepage.logo.Displayed);
        }

        [Then(@"verify the discount cuopon displayed")]
        public void ThenVerifyTheDiscountCuoponDisplayed()
        {
            Thread.Sleep(2000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0, 500)");
            Console.WriteLine("verified coupon displayed" + homepage.coupon.Displayed);

        }

        [When(@"verify the options are dispalyed")]
        public void WhenVerifyTheOptionsAreDispalyed()
        {
            Console.WriteLine("verified westside" + homepage.west.Displayed);
            Console.WriteLine("verified womens wear" + homepage.womenswear.Displayed);
            Console.WriteLine("verified beauty" + homepage.beauty.Displayed);
            Console.WriteLine("verified footwear" + homepage.footwear.Displayed);
            Console.WriteLine("verified menswear" + homepage.men.Displayed);

        }

        [Then(@"Mouse hover Categories to Kid'sFashion to BoysClothing and click on Shirts and verify the text Kids Boys Clothing Shirts is displayed")]
        public void ThenMouseHoverCategoriesToKidsFashionToBoysClothingAndClickOnShirtsAndVerifyTheTextKidsBoysClothingShirtsIsDisplayed()
        {
            Actions actions = new Actions(driver);
            actions.MoveToElement(homepage.category).Perform();
            Thread.Sleep(2000);
            //actions.MoveByOffset(0, 100).Perform();
            actions.MoveToElement(homepage.kids).Perform();
            actions.MoveToElement(homepage.boy).Perform();
            Thread.Sleep(2000);
            homepage.boy.Click();
            //string actual = "Kids Boys Clothing Shirts";
            //string expected = shop.txt1.Text;
            //Thread.Sleep(2000);
            //Assert.AreEqual(expected, actual);

        }

        [Given(@"the shopage")]
        public void GivenTheShopage()
        {
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            homepage.pop1.Click();
        }

        [When(@"Select the color black")]
        public void WhenSelectTheColorBlack()
        {
            Thread.Sleep(3000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0, 500)");
            Thread.Sleep(1000);
            shop.filter.Click();
            Thread.Sleep(1000);
            shop.clr.Click();


        }

        //[Then(@"click on the second item displayed")]
        //public void ThenClickOnTheSecondItemDisplayed()
        //{
        //    throw new PendingStepException();
        //}

        //[When(@"Print the original price without Discount and select one of the available sizes")]
        //public void WhenPrintTheOriginalPriceWithoutDiscountAndSelectOneOfTheAvailableSizes()
        //{
        //    throw new PendingStepException();
        //}

        //[Then(@"Add to Bag and Go To Bag")]
        //public void ThenAddToBagAndGoToBag()
        //{
        //    throw new PendingStepException();
        //}
    }
}
