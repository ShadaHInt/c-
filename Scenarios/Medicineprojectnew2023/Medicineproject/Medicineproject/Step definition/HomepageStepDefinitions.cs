using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

using TechTalk.SpecFlow;

namespace Medicineproject
{
    [Binding]
    public class HomepageStepDefinitions:BaseClass1
    {
        Homepage homepage => new(driver);
        Actions actions = new Actions(driver);
        DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver);

        [Given(@"navigated to the online medical store homepage")]
        public void GivenNavigatedToTheOnlineMedicalStoreHomepage()
        {
            driver.Navigate().GoToUrl("https://www.onlinemedicalstore.com/");
            string urltotest = driver.Url;
            string url = "https://www.onlinemedicalstore.com/";
            Assert.AreEqual(url, urltotest);

        }

        [When(@"user verifies category is displayed")]
        public void WhenUserVerifiesCategoryIsDisplayed()
        {
            Console.WriteLine("Category is displayed:" + homepage.category.Displayed);
        }

        [Then(@"user verifies ayurvedhic medicine  is displayed")]
        public void ThenUserVerifiesAyurvedhicMedicineIsDisplayed()
        {
            Console.WriteLine("Ayurvedhic medicine is displayed:" + homepage.aymedicine.Displayed);
        }

        [When(@"user user verifies homeo medicine is displayed")]
        public void WhenUserUserVerifiesHomeoMedicineIsDisplayed()
        {
            Console.WriteLine("Homepathic  medicine is displayed:" + homepage.hmmedicine.Displayed);
        }

        [Then(@"user verifies brand is displayed")]
        public void ThenUserVerifiesBrandIsDisplayed()
        {
            Console.WriteLine("Brand is displayed:" + homepage.brand.Displayed);
        }

        [When(@"user verifies blog is displayed")]
        public void WhenUserVerifiesBlogIsDisplayed()
        {
            Console.WriteLine("Blog is displayed:" + homepage.blog.Displayed);
        }

        [Then(@"user verfies coupon is displayed and prints the coupon text")]
        public void ThenUserVerfiesCouponIsDisplayedAndPrintsTheCouponText()
        {
            Console.WriteLine("Coupon is displayed:" + homepage.coupon.Displayed);
            Console.WriteLine("Coupon text is" + homepage.coupontxt.Text);
        }

        [When(@"user verifies profile button is displayed")]
        public void WhenUserVerifiesProfileButtonIsDisplayed()
        {
            Console.WriteLine("Profile button is displayed:" + homepage.profilebt.Displayed);
        }

        [Then(@"user verifies whishlist is displayed")]
        public void ThenUserVerifiesWhishlistIsDisplayed()
        {
            Console.WriteLine("Whishlist  is displayed:" + homepage.whishlist.Displayed);
        }

        [When(@"user verifies bag is displayed")]
        public void WhenUserVerifiesBagIsDisplayed()
        {
            Console.WriteLine("Bag is displayed:" + homepage.bag.Displayed);
        }

        [Then(@"user verify logo is displayed")]
        public void ThenUserVerifyLogoIsDisplayed()
        {
            Console.WriteLine("Logo displayed" + homepage.logo.Displayed);
        }


        [When(@"user selects the first element in the featured product and click on add to cart")]
        public void WhenUserSelectsTheFirstElementInTheFeaturedProductAndClickOnAddToCart()
        {
            Common.scrollbar(0, 700);
            homepage.ffirstelement.Click();
             Thread.Sleep(1000);
            
        }

        [Then(@"user selects the first element in the new arrival and click on add to cart")]
        public void ThenUserSelectsTheFirstElementInTheNewArrivalAndClickOnAddToCart()
        {
            
            Common.scrollbar(0, 1500);
            
            fluentWait.Timeout = TimeSpan.FromSeconds(2);
            fluentWait.PollingInterval = TimeSpan.FromMilliseconds(100);
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            fluentWait.Message = "Element to be searched not found";
            IWebElement searchResult = fluentWait.Until(x => x.FindElement(By.CssSelector("#latest-products div:nth-of-type(6) .actions-primary span")));
            actions.MoveToElement(homepage.nfirstelement).Perform();
            homepage.nfirstelement.Click();
            //Thread.Sleep(2000);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(12));
            wait.Until(ExpectedConditions.ElementExists((By.CssSelector(".cart-design-2.minicart-wrapper > .action.showcart"))));
        }

        //[When(@"user clicks on cart button and remove the first element")]
        //public void WhenUserClicksOnCartButtonAndRemoveTheFirstElement()
        //{
        //    homepage.bag.Click();
        //    homepage.removecart.Click();
        //    homepage.removecartok.Click();
      
        //    Thread.Sleep(2000);
        //    homepage.removecart.Click();
        //    homepage.removecartok.Click();

        //}

        [When(@"user clicks on first element in the latest news")]
        public void WhenUserClicksOnFirstElementInTheLatestNews()
        {

            homepage.blog.Click();
        }

        [Then(@"verify navigated to the correct url")]
        public void ThenVerifyNavigatedToTheCorrectUrl()
        {
            string urltotest = driver.Url;
            string url = "https://www.onlinemedicalstore.com/blog";
            Assert.AreEqual(url, urltotest);
        }

        [When(@"user prints the title of the blog")]
        public void WhenUserPrintsTheTitleOfTheBlog()
        {
            Console.WriteLine("Blog text title:" + homepage.newstitle.Text);
            string notNullString = homepage.newstitle.Text;
            Assert.IsNotNull(notNullString);
            Console.WriteLine("Content:"+homepage.news1.Text);
        }

        [Then(@"user back navigate to homepage")]
        public void ThenUserBackNavigateToHomepage()
        {
            driver.Navigate().Back();
        }
    }
}
