using OpenQA.Selenium;


namespace Medicineproject
{
    public class Search:BaseClass1
    {
        IWebDriver WebDriver;
        public Search(in IWebDriver driver)

        {

            WebDriver = driver;
            Assert.IsNotNull(WebDriver, "NO Driver instance provided");


        }
        public IWebElement search1 => WebDriver.FindElement(By.CssSelector("input#search"));
        public IWebElement searchbt => WebDriver.FindElement(By.CssSelector("button[title='Search']"));
        public IWebElement txt => WebDriver.FindElement(By.CssSelector(".message.notice > div"));
        public IWebElement volini => WebDriver.FindElement(By.CssSelector(".photo.product.product-item-photo > a"));
        public IWebElement addc1 => WebDriver.FindElement(By.CssSelector("button#product-addtocart-button"));
        public IWebElement vtext => WebDriver.FindElement(By.CssSelector(".base"));
    }
}
