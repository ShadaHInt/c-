using OpenQA.Selenium;

namespace NoonProject2.Page
{
    public class Search
    {
        IWebDriver WebDriver;
        public Search(in IWebDriver driver)
        {
            WebDriver = driver;
            Assert.IsNotNull(WebDriver, "No driver instance provided");
        }

        //Assigning webelement location to Iwebelements

        public IWebElement SearchBar => WebDriver.FindElement(By.Id("searchBar")); 
        public IWebElement Option => WebDriver.FindElement(By.CssSelector("div.sc-f8dbd877-4.eHpmXz>div:nth-of-type(5)"));
        public IWebElement SortBy => WebDriver.FindElement(By.XPath("//img[@alt='dropdown']"));
        public IWebElement Price => WebDriver.FindElement(By.CssSelector("ul.sc-2bba8d59-5.dRMYXq>li:nth-of-type(3)"));
        public IWebElement Display => WebDriver.FindElement(By.XPath("(//img[@alt='dropdown'])[2]"));
        public IWebElement PerPage => WebDriver.FindElement(By.CssSelector("ul.sc-2bba8d59-5.dRMYXq>li:nth-of-type(2)"));
        public IWebElement ShoeOption => WebDriver.FindElement(By.CssSelector("div.sc-f8dbd877-4.eHpmXz>div:nth-of-type(2)"));
        public IWebElement SizeDrop => WebDriver.FindElement(By.XPath("(//img[@alt='dropdown'])[3]"));
        public IWebElement SizeSelect => WebDriver.FindElement(By.CssSelector("div.sc-4e903a5d-1.hiFJsL>label"));
        public IWebElement PriceDrop => WebDriver.FindElement(By.XPath("(//img[@alt='dropdown'])[4]"));
        public IWebElement ColorDrop => WebDriver.FindElement(By.XPath("(//img[@alt='dropdown'])[5]"));
    }
}
