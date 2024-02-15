using InternalProjectTrial.CommonMethods;
using InternalProjectTrial.JsonFile;
using InternalProjectTrial.Page;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using TechTalk.SpecFlow;
using ThirdParty.Json.LitJson;

namespace InternalProjectTrial
{
    [Binding]
    public class AddToCartFromSignedInAccountStepDefinitions:BaseClass
    {
        AddToCart addToCart;

        public AddToCartFromSignedInAccountStepDefinitions()
        {
            addToCart = new(driver);
        }
        public List<JsonClass> homeReader = new List<JsonClass>();
        public static StreamReader r = new StreamReader(@"C:\Users\rugmap\OneDrive - Valorem Reply\Desktop\C#\InternalProjectTrial\InternalProjectTrial\JsonFile/Json.json");
        public static string testData = r.ReadToEnd();
        public static JsonClass inputValue = JsonMapper.ToObject<JsonClass>(testData);

        [Given(@"user navigate Amazon url ""([^""]*)""")]
        public void GivenUserNavigateAmazonUrl(string url)
        {
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            string Url = driver.Url;
            string UrlToTest = "https://www.amazon.in/";
            Assert.AreEqual(Url, UrlToTest);
        }

        
        [When(@"user clicks on sign in")]
        public void WhenUserClicksOnSignIn()
        {
            Actions actions = new Actions(driver);
            actions.MoveToElement(addToCart.AccountsNLists).Perform();
            addToCart.SignIn.Click();
        }
        [When(@"user enters mobile no and click continue")]
        public void WhenUserEntersMobileNoAndClickContinue()
        {
            CmnMthd.Email(inputValue.mobilethree);
        }

        [When(@"user enters the password and click sign in")]
        public void WhenUserEntersThePasswordAndClickSignIn()
        {
            CmnMthd.Password(inputValue.passwordthree);
        }
        [When(@"user searches for Women tops")]
        public void WhenUserSearchesForWomenTops()
        {
            addToCart.SearchBar.Click();
            addToCart.SearchBar.SendKeys(inputValue.searchclothes);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(2));
            wait.Until(ExpectedConditions.ElementExists(By.XPath("//input[@id='nav-search-submit-button']")));
            addToCart.SearchButton.Click();
        }

        [When(@"user clicks on the first product and mouse hover on the review drop down and select See all customer reviews")]
        public void WhenUserClicksOnTheFirstProductAndMouseHoverOnTheReviewDropDownAndSelectSeeAllCustomerReviews()
        {
            CmnMthd.scroll(0, 20);
            addToCart.FirstProduct.Click();
            Thread.Sleep(2000);
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            Actions actions = new Actions(driver);
            actions.MoveToElement(addToCart.ReviewStar).Perform();
            addToCart.ReviewStar.Click();
            Thread.Sleep(1000);
            addToCart.AllReviews.Click();
        }

        [When(@"user select size from Select drop down")]
        public void WhenUserSelectSizeFromSelectDropDown()
        {
            CmnMthd.scroll(600, 0);
            SelectElement selectSize = new SelectElement(addToCart.SelectDropdown);
            selectSize.SelectByIndex(1);
        }

        [When(@"user click Add to cart and click go to cart button")]
        public void WhenUserClickAddToCartAndClickGoToCartButton()
        {
            addToCart.AddToCartButton.Click();
            DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver);
            fluentWait.Timeout = TimeSpan.FromSeconds(2);
            fluentWait.PollingInterval = TimeSpan.FromMilliseconds(100);
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            fluentWait.Message = "Element to be searched not found";
            IWebElement searchResult = fluentWait.Until(x => x.FindElement(By.XPath("//a[@href='/gp/cart/view.html?ref_=sw_gtc']")));
            addToCart.GoToCart.Click();
        }

        [Then(@"user prints product title")]
        public void ThenUserPrintsProductTitle()
        {
            Console.WriteLine("The product title: " + addToCart.ProductTitle.Text);
        }
    }
}
