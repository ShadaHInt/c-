using OpenQA.Selenium;

namespace NoonProject2.Page
{
    public class VerifyCategories
    {
        IWebDriver WebDriver;
        public VerifyCategories(in IWebDriver driver)
        {
            WebDriver = driver;
            Assert.IsNotNull(WebDriver, "No driver instance provided");
        }

        //Assigning webelement location to Iwebelements

        public IWebElement Electronics => WebDriver.FindElement(By.XPath("//div[contains(@class,'swiper-slide')]"));
        public IWebElement Men => WebDriver.FindElement(By.XPath("//div[contains(@class,'swiper-slide')]//following::div[1]"));
        public IWebElement Women => WebDriver.FindElement(By.XPath("//div[contains(@class,'swiper-slide')]//following::div[2]"));
        public IWebElement Home => WebDriver.FindElement(By.XPath("//div[contains(@class,'swiper-slide')]//following::div[3]"));
        public IWebElement BeautynFragrance => WebDriver.FindElement(By.XPath("//div[contains(@class,'swiper-slide')]//following::div[4]"));
        public IWebElement BabynToys => WebDriver.FindElement(By.XPath("//div[contains(@class,'swiper-slide')]//following::div[5]"));
        public IWebElement Sports => WebDriver.FindElement(By.XPath("//div[contains(@class,'swiper-slide')]//following::div[6]"));
        public IWebElement BestSellers => WebDriver.FindElement(By.XPath("//div[contains(@class,'swiper-slide')]//following::div[7]"));
        public IWebElement SellonNoon => WebDriver.FindElement(By.XPath("//div[contains(@class,'swiper-slide')]//following::div[8]"));
        public IWebElement ForwardButton => WebDriver.FindElement(By.CssSelector("div.jsx-undefined.swiper-button-next"));
        public IWebElement BackwardButton => WebDriver.FindElement(By.XPath("//div[contains(@class,'swiper-slide')]//following::div[1]"));
        public IWebElement TopDeals => WebDriver.FindElement(By.XPath("//div[contains(@class,'swiper-slide')]//following::div[1]"));

    }
}
