using OpenQA.Selenium;


namespace InternalProjectTrial.Page
{
    public class AddToCart
    {
        IWebDriver WebDriver;
        public AddToCart(in IWebDriver driver)
        {
            WebDriver = driver;
            Assert.IsNotNull(WebDriver, "No driver instance provided");
        }

        //Assigning webelement location to Iwebelements
        public IWebElement AccountsNLists  => WebDriver.FindElement(By.XPath("//span[@class='nav-line-2 ']"));
        public IWebElement SignIn => WebDriver.FindElement(By.XPath("//span[@class='nav-action-inner']"));
        public IWebElement EmailOrMobile => WebDriver.FindElement(By.XPath("//input[@id='ap_email']"));                
        public IWebElement Continue => WebDriver.FindElement(By.XPath("//input[@id='continue']"));
        public IWebElement Password => WebDriver.FindElement(By.XPath("//input[@id='ap_password']"));
        public IWebElement SignInButton => WebDriver.FindElement(By.XPath("//input[@id='signInSubmit']"));
        public IWebElement SearchBar => WebDriver.FindElement(By.XPath("//input[@id='twotabsearchtextbox']"));
        public IWebElement SearchButton => WebDriver.FindElement(By.XPath("//input[@id='nav-search-submit-button']"));
        public IWebElement FirstProduct => WebDriver.FindElement(By.CssSelector("div.a-section.a-spacing-small.puis-padding-left-micro.puis-padding-right-micro>div:nth-of-type(2)"));
        public IWebElement ReviewStar => WebDriver.FindElement(By.CssSelector("i.a-icon.a-icon-popover"));
        public IWebElement AllReviews => WebDriver.FindElement(By.CssSelector("a.a-size-base.a-link-emphasis"));
        public IWebElement CustomerReview => WebDriver.FindElement(By.XPath("//div[@id='customer_review-RWQN8SB8CWNO9']"));
        public IWebElement SelectDropdown => WebDriver.FindElement(By.XPath("//select[@id='native_dropdown_selected_size_name']"));
        public IWebElement AddToCartButton => WebDriver.FindElement(By.XPath("//input[@title='Add to Shopping Cart']"));
        public IWebElement GoToCart => WebDriver.FindElement(By.XPath("//a[@href='/gp/cart/view.html?ref_=sw_gtc']"));
        public IWebElement ProductTitle => WebDriver.FindElement(By.XPath("//span[@class='a-truncate-cut']")); 
       





    }
}

