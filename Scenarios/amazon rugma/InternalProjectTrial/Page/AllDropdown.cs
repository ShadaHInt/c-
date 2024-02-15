using OpenQA.Selenium;


namespace InternalProjectTrial.Page
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
        public IWebElement All => WebDriver.FindElement(By.XPath("//a[@id='nav-hamburger-menu']"));
        public IWebElement BestSellers => WebDriver.FindElement(By.XPath("(//a[text()='Best Sellers'])[2]"));
        public IWebElement KindleReaders => WebDriver.FindElement(By.XPath("//a[@data-menu-id='4']"));                //div[text()='Kindle E-Readers & eBooks']
        public IWebElement AllNewKindle => WebDriver.FindElement(By.XPath("//a[text()='All-new Kindle']"));
        




    }
}

