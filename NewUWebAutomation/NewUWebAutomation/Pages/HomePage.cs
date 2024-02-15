using OpenQA.Selenium;

namespace NewUWebAutomation
{
    [TestClass]
    public class HomePage:BaseClass
    {
        public HomePage(in IWebDriver driver)
        {
          
            // Assert.IsNotNull(WebDriver, "NO Driver instance provided");
        }
        public IWebElement CloseButton => driver.FindElement(By.XPath("//button[contains(@class,'needsclick klaviyo-close-form kl-private-reset-css-Xuajs1')]"));
        public IWebElement Logo => driver.FindElement(By.XPath("//img[contains(@class,'lazyautosizes lazyloaded')]"));
        public IWebElement MainBanner => driver.FindElement(By.CssSelector("a.slide-image"));
        public IWebElement Gift => driver.FindElement(By.CssSelector("button.needsclick.kl-teaser-WSzR3J.undefined.kl-private-reset-css-Xuajs1"));
        public IWebElement Descrip => driver.FindElement(By.CssSelector("div.footer-text>p"));
        public IWebElement ContactUs => driver.FindElement(By.CssSelector("div.related-links>ul>li:nth-of-type(6)"));
        public IWebElement ContactDetails => driver.FindElement(By.CssSelector("div.info-block:nth-of-type(2)"));

        




        











    }
}