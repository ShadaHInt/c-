using OpenQA.Selenium;

namespace NoonProject2.Page
{
    public class AllDropdown
    {
        IWebDriver WebDriver;
        public AllDropdown(in IWebDriver driver)
        {
            WebDriver = driver;
            Assert.IsNotNull(WebDriver, "No driver instance provided");
        }

        //Assigning webelement location to Iwebelements
        public IWebElement All => WebDriver.FindElement(By.CssSelector("div.jsx-undefined.trigger"));
        public IWebElement Electronics => WebDriver.FindElement(By.CssSelector("span.jsx-undefined.selected>a"));
        public IWebElement Mobiles => WebDriver.FindElement(By.CssSelector("div.jsx-undefined.list.itemList>a:nth-of-type(1)"));                //div[text()='Kindle E-Readers & eBooks']
        public IWebElement Tablets => WebDriver.FindElement(By.XPath("//img[@alt='/tablets']"));
        public IWebElement Accessories => WebDriver.FindElement(By.XPath("(//img[contains(@class,'sc-crXcEl')])[3]")); ////img[@alt='/acc-store']
        public IWebElement View => WebDriver.FindElement(By.CssSelector("div.sc-hKMtZM.hDCNam")); 

    }
}
