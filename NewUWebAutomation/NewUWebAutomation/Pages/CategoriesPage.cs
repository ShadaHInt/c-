using OpenQA.Selenium;


namespace NewUWebAutomation
{
    [TestClass]
    public class CategoriesPage:BaseClass
    {
        public CategoriesPage(in IWebDriver driver)
        {

            // Assert.IsNotNull(WebDriver, "NO Driver instance provided");
        }

        public IWebElement MenuBar => driver.FindElement(By.Id("sticky-wrapper"));
        public IWebElement Jaque => driver.FindElement(By.CssSelector("div.horizontal-menu>nav>ul>li>a>span"));
        public IWebElement Shop => driver.FindElement(By.CssSelector("h3.title"));
        public IWebElement MakeUp => driver.FindElement(By.CssSelector("a.menu__moblie"));
        public IWebElement Foundation => driver.FindElement(By.CssSelector("ul.site-nav-dropdown>li:nth-of-type(3)"));
        public IWebElement Hair => driver.FindElement(By.CssSelector("nav.nav-bar>ul>li:nth-of-type(3)"));
        public IWebElement HairBrush => driver.FindElement(By.LinkText("Hair Brushes"));



        




    }
}
