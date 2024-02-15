using OpenQA.Selenium;


namespace InternalProjectTrial.Page
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

        public IWebElement AmazonLogo => WebDriver.FindElement(By.XPath("//a[@id='nav-logo-sprites']"));
        public IWebElement SelectYourAddress => WebDriver.FindElement(By.XPath("//span[@id='glow-ingress-line2']"));
        public IWebElement ReturnsnOrders => WebDriver.FindElement(By.XPath("//a[@id='nav-orders']"));
        public IWebElement ForwardButton => WebDriver.FindElement(By.XPath("//i[@class='a-icon a-icon-previous-rounded']"));
        public IWebElement BackwardButton => WebDriver.FindElement(By.XPath("//i[@class='a-icon a-icon-next-rounded']"));
        public IWebElement SearchBar => WebDriver.FindElement(By.XPath("//input[@id='twotabsearchtextbox']"));
        public IWebElement SearchButton => WebDriver.FindElement(By.XPath("//input[@id='nav-search-submit-button']"));




    }
}
