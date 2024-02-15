using OpenQA.Selenium;

namespace NoonProject2 
{
    public class HomePage
    {
        IWebDriver WebDriver;
        public HomePage(in IWebDriver driver)
        {
            WebDriver = driver;
            Assert.IsNotNull(WebDriver, "No driver instance provided");
        }

        //Assigning webelement location to Iwebelements

        public IWebElement NoonLogo => WebDriver.FindElement(By.CssSelector("div.sc-7c4627ed-7.bcCyHc>img"));
        public IWebElement LoginSymbol => WebDriver.FindElement(By.Id("dd_header_signInOrUp"));
        public IWebElement Cart => WebDriver.FindElement(By.CssSelector("span.cartTitle"));
        public IWebElement CashBackbanner => WebDriver.FindElement(By.CssSelector("div.sc-papXJ.lcvUvL"));
        public IWebElement SearchBar => WebDriver.FindElement(By.Id("searchBar"));
        public IWebElement ForwardButton => WebDriver.FindElement(By.CssSelector("div.swiper-button-circle-right"));
        public IWebElement BackwardButton => WebDriver.FindElement(By.CssSelector("div.swiper-button-circle-left"));
        public IWebElement SliderCategories => WebDriver.FindElement(By.XPath("(//div[@class='swiper-wrapper'])[3]"));

    }
}
