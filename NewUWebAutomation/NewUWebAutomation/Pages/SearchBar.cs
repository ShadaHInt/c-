using OpenQA.Selenium;


namespace NewUWebAutomation
{
    public class SearchBar:BaseClass
    {
        public SearchBar(in IWebDriver driver)
        {

            // Assert.IsNotNull(WebDriver, "NO Driver instance provided");
        }

        public IWebElement Search => driver.FindElement(By.CssSelector(".nav-search .header-search__input"));
        public IWebElement Logo => driver.FindElement(By.XPath("//img[contains(@class,'lazyautosizes lazyloaded')]"));







    }
}
