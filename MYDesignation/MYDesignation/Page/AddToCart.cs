using OpenQA.Selenium;

namespace NoonProject2.Page
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

        public IWebElement LoginSymbol => WebDriver.FindElement(By.Id("dd_header_signInOrUp"));
        public IWebElement Email => WebDriver.FindElement(By.Id("emailInput"));
        public IWebElement Password => WebDriver.FindElement(By.Id("passwordInput"));
        public IWebElement SigninButton => WebDriver.FindElement(By.Id("login-submit"));
        public IWebElement SearchBar => WebDriver.FindElement(By.Id("searchBar"));
        public IWebElement Option => WebDriver.FindElement(By.CssSelector("div.sc-f8dbd877-4.eHpmXz>div:nth-of-type(5)"));
        public IWebElement DressOption => WebDriver.FindElement(By.XPath("//div[contains(@class,'sc-f8dbd877-5')]"));
        public IWebElement SizeDrop => WebDriver.FindElement(By.XPath("(//img[@alt='dropdown'])[3]"));
        public IWebElement SizeSelect => WebDriver.FindElement(By.CssSelector("div.sc-4e903a5d-1.hiFJsL>label"));
        public IWebElement SortBy => WebDriver.FindElement(By.XPath("//img[@alt='dropdown']"));
        public IWebElement Rating => WebDriver.FindElement(By.CssSelector("ul.sc-2bba8d59-5.dRMYXq>li:nth-of-type(5)"));
        public IWebElement Product => WebDriver.FindElement(By.CssSelector("div.sc-2f7ba0e9-10.kkzvjB>div")); 
        public IWebElement Review => WebDriver.FindElement(By.CssSelector("div.sc-53a159dc-0.iqpeOg"));
        public IWebElement ReviewDetails => WebDriver.FindElement(By.XPath("//div[@class='mainDescriptionArea']"));
        public IWebElement Qty => WebDriver.FindElement(By.CssSelector("svg.css-19bqh2r"));
        public IWebElement AddCart => WebDriver.FindElement(By.CssSelector("div.loaderCtr.inactiveLoading"));
        public IWebElement Checkout => WebDriver.FindElement(By.CssSelector("span.sc-1fa76e59-10.drzQBm"));
        public IWebElement Remove => WebDriver.FindElement(By.CssSelector("span.sc-104cca80-24.bGqdIE"));
        
    }
}
