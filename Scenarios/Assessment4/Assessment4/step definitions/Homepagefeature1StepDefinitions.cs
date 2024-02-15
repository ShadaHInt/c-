using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

//using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;

namespace Assessment4
{
    [Binding]
    public class Homepagefeature1StepDefinitions
    {
        //IWebDriver driver = new EdgeDriver();
        IWebDriver driver = new ChromeDriver();
        [Given(@"the website of the page")]
        public void GivenTheWebsiteOfThePage()
        {
            Homepage homepage = new(driver);
            driver.Navigate().GoToUrl(" https://www.croma.com/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

        }

        [When(@"verify the logo header")]
        public void WhenVerifyTheLogoHeader()
        {
            Homepage homepage = new(driver);
            Console.WriteLine("verified logo" + homepage.logo.Displayed);

        }

        [Then(@"verify the coupon code displayed")]
        public void ThenVerifyTheCouponCodeDisplayed()
        {
            Homepage homepage = new(driver);
            Console.WriteLine("verified logo" + homepage.coupon.Displayed);
            Thread.Sleep(3000);

        }

        [When(@"Verify the options are displayed")]
        public void WhenVerifyTheOptionsAreDisplayed()
        {
            Homepage homepage = new(driver);
            Console.WriteLine("verified mobile" + homepage.mobile.Displayed);
            Console.WriteLine("verified televison" + homepage.televison.Displayed);
            Console.WriteLine("verified laptop" + homepage.laptop.Displayed);
            Console.WriteLine("verified audio" + homepage.audio.Displayed);
            Console.WriteLine("verified ac" + homepage.ac.Displayed);
        }

        [Then(@"user clicks on loctation button and send valid pincode and select login button and verify the pincode displayed")]
        public void ThenUserClicksOnLoctationButtonAndSendValidPincodeAndSelectLoginButtonAndVerifyThePincodeDisplayed()
        {
            Homepage homepage = new(driver);
            homepage.loc.Click();
            homepage.pinselect.Clear();
            Thread.Sleep(3000);
            homepage.pinselect.SendKeys("400049");
            Thread.Sleep(2000);
            homepage.contbt.Click();
            string actual = homepage.pinselect.Text;
            string expected = "Mumbai,400049";
            Assert.AreEqual(expected, actual);
            Console.WriteLine("verified pincode" + homepage.pinval.Displayed);


        }
        [When(@"user search icecream and verify it")]
        public void WhenUserSearchIcecreamAndVerifyIt()
        {
            Homepage homepage = new(driver);
            homepage.search.Click();
            homepage.search.SendKeys("i");
            Actions actions = new Actions(driver);

            actions.KeyDown(homepage.search, Keys.Shift).Perform();
            actions.SendKeys("c").Perform();
            actions.KeyUp(Keys.Shift).Perform();
            homepage.search.SendKeys("e");
            actions.KeyDown(homepage.search, Keys.Shift).Perform();
            actions.SendKeys("c").Perform();
            actions.KeyUp(Keys.Shift).Perform();
            homepage.search.SendKeys("r");
            actions.KeyDown(homepage.search, Keys.Shift).Perform();
            actions.SendKeys("ea").Perform();
            actions.KeyUp(Keys.Shift).Perform();
            homepage.search.SendKeys("m");
            actions.Build().Perform();
            Thread.Sleep(TimeSpan.FromSeconds(2));


            Thread.Sleep(TimeSpan.FromSeconds(1));
            Console.WriteLine("You searched for iCeCrEAm :" + homepage.search.Displayed);

        }

        [Then(@"login icon and try entering atleast three different invalid phone number combinations and verify the error message displayed (.*)")]
        public void ThenLoginIconAndTryEnteringAtleastThreeDifferentInvalidPhoneNumberCombinationsAndVerifyTheErrorMessageDisplayed(string examples)
        {
            Homepage homepage = new(driver);
            Thread.Sleep(3000);
            homepage.login.Click();
            //homepage.loginenter.Click();
            homepage.loginenter.SendKeys(examples);
            Thread.Sleep(TimeSpan.FromSeconds(2));
            homepage.cont.Click();
            Thread.Sleep(2000);
            homepage.btclose.Click();
            Thread.Sleep(3000);

        }

        [When(@"user clicks on menu")]
        public void WhenUserClicksOnMenu()
        {
            Homepage homepage = new(driver);
            homepage.menu.Click();

        }

        [Then(@"hover over phones and variables and then mobile phone ,iphone")]
        public void ThenHoverOverPhonesAndVariablesAndThenMobilePhoneIphone()
        {
            Homepage homepage = new(driver);
            Actions actions = new Actions(driver);
            actions.MoveToElement(homepage.mob).Perform();
            Thread.Sleep(5000);
            actions.MoveToElement(homepage.mobph).Perform();
            Thread.Sleep(3000);
            actions.MoveToElement(homepage.iphone).Perform();
            homepage.iphone.Click();

        }

        [When(@"Click on first product")]
        public void WhenClickOnFirstProduct()
        {
            Shoppage shoppage = new(driver);
            Thread.Sleep(5000);
            shoppage.firstip.Click();
        }

        [Then(@"display all features")]
        public void ThenDisplayAllFeatures()
        {
            Shoppage shoppage = new(driver);
            Thread.Sleep(3000);
            Console.WriteLine(shoppage.keyf.Text);

        }

        [When(@"user add to cart")]
        public void WhenUserAddToCart()
        {
            Shoppage shoppage = new(driver);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0, 800)");
            Thread.Sleep(2000);
            shoppage.addc.Click();
            shoppage.proceedbt.Click();

        }

        [Then(@"user click on apply coupon")]
        public void ThenUserClickOnApplyCoupon()
        {
            Shoppage shoppage = new(driver);
            Thread.Sleep(5000);
            shoppage.applyc.Click();
            Thread.Sleep(3000);
            shoppage.coupontxt.Click();
            shoppage.coupontxt.SendKeys("ABC1234");
            Thread.Sleep(2000);
            shoppage.couponapply.Click();
            //Thread.Sleep(3000);

        }

        [Then(@"user verify the alert message and print message")]
        public void ThenUserVerifyTheAlertMessageAndPrintMessage()
        {
            Shoppage shoppage = new(driver);
            Thread.Sleep(2000);
            Console.WriteLine(shoppage.alert.Displayed);
            //Thread.Sleep(1000);
            Console.WriteLine("The text in alert box is: " + shoppage.alert.Text);
            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            //Console.WriteLine(driver.SwitchTo().Alert().Text);

        }
    }
}
