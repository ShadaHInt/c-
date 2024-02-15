using OpenQA.Selenium;


namespace NewUWebAutomation
{
    [TestClass]
    public class AddItemsPage:BaseClass
    {
        public AddItemsPage(in IWebDriver driver)
        {

        }

        public IWebElement AddToBag => driver.FindElement(By.XPath("//button[@class='btn add-to-cart-btn']"));
        public IWebElement ContinueShopping => driver.FindElement(By.XPath("//a[@class='btn btn-continue']//following-sibling::a"));
        public IWebElement Shop => driver.FindElement(By.CssSelector("h3.title"));
        public IWebElement Skin => driver.FindElement(By.CssSelector("nav.nav-bar>ul>li:nth-of-type(2)"));
        public IWebElement LipBalm => driver.FindElement(By.LinkText("Lip Balm"));
        public IWebElement BathNbody => driver.FindElement(By.CssSelector("nav.nav-bar>ul>li:nth-of-type(4)"));
        public IWebElement Sunscreen => driver.FindElement(By.XPath("//a[@href='/collections/sunscreen-products']"));
        public IWebElement ProdOne => driver.FindElement(By.CssSelector("div.inner-top"));
        public IWebElement ProceedCheckout => driver.FindElement(By.CssSelector("input.btn.btn-checkout"));
        public IWebElement Total => driver.FindElement(By.CssSelector("div._1ip0g651 >p>strong"));










    }
}
