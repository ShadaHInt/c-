using NoonProject2.Page;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using TechTalk.SpecFlow;
using ThirdParty.Json.LitJson;

namespace NoonProject2
{
    [Binding]
    public class AddToCartStepDefinitions:BaseClass
    {
        AddToCart addToCart;
        public AddToCartStepDefinitions()
        {
            addToCart = new(driver);
        }
        //json
        public List<JsonClass> homeReader = new List<JsonClass>();
        public static StreamReader r = new StreamReader(@"C:\Users\rugmap\OneDrive - Valorem Reply\Desktop\C#\MYDesignation\MYDesignation\Json/Json.json");
        public static string testData = r.ReadToEnd();
        public static JsonClass inputValue = JsonMapper.ToObject<JsonClass>(testData);

        [Given(@"user navigate ""([^""]*)""")]
        public void GivenUserNavigate(string url)
        {
            driver.Navigate().GoToUrl(url);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(7);
            CmnMethod.AssertMethod();
        }

        [When(@"user clicks sign in symbol")]
        public void WhenUserClicksSignInSymbol()
        {
            addToCart.LoginSymbol.Click();
        }

        [When(@"user enters fields and clicks sign in button")]
        public void WhenUserEntersFieldsAndClicksSignInButton()
        {
            CmnMethod.Signin(inputValue.email, inputValue.password);
        }

        [When(@"user searches for shoes for men")]
        public void WhenUserSearchesForShoesForMen()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementExists(By.Id("searchBar")));
            addToCart.SearchBar.Click();
            addToCart.SearchBar.SendKeys(inputValue.search2);
            addToCart.Option.Click();
        }

        [When(@"user selects size and sorts by rating and clicks on first product")]
        public void WhenUserSelectsSizeAndSortsByRatingAndClicksOnFirstProduct()
        {
            Thread.Sleep(10000);
            addToCart.SizeDrop.Click();
            addToCart.SizeSelect.Click();
            Thread.Sleep(5000);
            addToCart.SortBy.Click();
            addToCart.Rating.Click();
            Thread.Sleep(5000);
            addToCart.Product.Click();
        }         

        [When(@"user clicks on rating ang prints review")]
        public void WhenUserClicksOnRatingAngPrintsReview()
        {            
            Thread.Sleep(2000);
            CmnMethod.scroll(0, 100);
            addToCart.Review.Click();
            Thread.Sleep(1000);
            Console.WriteLine("The review details: " + addToCart.ReviewDetails.Text);
            CmnMethod.scroll(600, 0);
        }

        [When(@"user add to cart")]
        public void WhenUserAddToCart()
        {
            Thread.Sleep(2000);
            addToCart.AddCart.Click();
        }

        [Then(@"user clicks checkout and removes product from cart")]
        public void ThenUserClicksCheckoutAndRemovesProductFromCart()
        {
            Thread.Sleep(2000);
            addToCart.Checkout.Click();
            Thread.Sleep(1000);
            addToCart.Remove.Click();
        }
    }
}
