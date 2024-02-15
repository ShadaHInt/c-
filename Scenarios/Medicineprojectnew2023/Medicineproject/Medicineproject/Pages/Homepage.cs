using OpenQA.Selenium;


namespace Medicineproject
{
    public class Homepage:BaseClass1
    {
        IWebDriver WebDriver;
        public Homepage(in IWebDriver driver)

        {

            WebDriver = driver;
            Assert.IsNotNull(WebDriver, "NO Driver instance provided");


        }

        /*Display*/
        public IWebElement category => WebDriver.FindElement(By.CssSelector("a[title='Category']"));
        public IWebElement aymedicine => WebDriver.FindElement(By.CssSelector("a[title='Ayurvedic Medicine']"));
        public IWebElement hmmedicine => WebDriver.FindElement(By.CssSelector("a[title='Homeopathic Medicine']"));
        public IWebElement brand => WebDriver.FindElement(By.CssSelector("li:nth-of-type(6) > .level-top > span"));
        public IWebElement blog => WebDriver.FindElement(By.CssSelector("li:nth-of-type(7) > .level-top"));
        public IWebElement coupon => WebDriver.FindElement(By.CssSelector("div:nth-of-type(3) .content.content-slide-2"));
        public IWebElement coupontxt => WebDriver.FindElement(By.CssSelector("div:nth-of-type(3)  .has-content-pos.justify-content-center.porto-ultimate-content-box h1"));
        public IWebElement profilebt => WebDriver.FindElement(By.CssSelector("a[title='My Account']"));
        public IWebElement whishlist => WebDriver.FindElement(By.CssSelector("a[title='Wishlist']"));
        public IWebElement bag => WebDriver.FindElement(By.CssSelector(".cart-design-2.minicart-wrapper > .action.showcart"));

        


        /*Selecting*/
        public IWebElement ffirstelement => WebDriver.FindElement(By.CssSelector("#featured-products div:nth-of-type(5) .actions-primary span"));
        public IWebElement nfirstelement => WebDriver.FindElement(By.CssSelector("#latest-products div:nth-of-type(6) .actions-primary span"));
        public IWebElement news1 => WebDriver.FindElement(By.CssSelector(".post-holder.post-holder-6 > .post-content > .post-description > .post-text-hld > p"));
        public IWebElement removecart => WebDriver.FindElement(By.CssSelector("a[title='Remove']"));
        public IWebElement removecartok => WebDriver.FindElement(By.CssSelector(".action-accept.action-primary"));
        public IWebElement newstitle => WebDriver.FindElement(By.CssSelector(".post-holder.post-holder-6 > .post-header > .post-title-holder > .post-title"));
        public IWebElement logo => WebDriver.FindElement(By.CssSelector("img[alt='Online medical store - Buy Medicines Online in India']"));
    }
}
