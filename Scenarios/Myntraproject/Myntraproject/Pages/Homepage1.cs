using OpenQA.Selenium;


namespace Myntraproject
{
    public class Homepage1:BaseClass
    {
        IWebDriver WebDriver;
        public Homepage1(in IWebDriver driver)
        {

            WebDriver = driver;
            Assert.IsNotNull(WebDriver, "NO Driver instance provided");


        }
        public IWebElement logo => WebDriver.FindElement(By.CssSelector(".sprites-headerLogo"));

         public IWebElement offer => WebDriver.FindElement(By.CssSelector("div.FreeShippingBanner-sidebar.FreeShippingBanner-sidebar-collapsed"));
        public IWebElement profile => WebDriver.FindElement(By.CssSelector("span.myntraweb-sprite.desktop-iconUser.sprites-headerUser"));

        //public IWebElement wishlist => WebDriver.FindElement(By.XPath("//span[text()='Wishlist']"));

        public IWebElement bag => WebDriver.FindElement(By.CssSelector(".desktop-cart > .desktop-iconBag.myntraweb-sprite.sprites-headerBag"));

    }
}
