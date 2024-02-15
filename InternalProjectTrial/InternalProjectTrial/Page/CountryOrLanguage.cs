using OpenQA.Selenium;


namespace InternalProjectTrial.Page
{
    public class CountryOrLanguage
    {

        IWebDriver WebDriver;
        public CountryOrLanguage(in IWebDriver driver)
        {
            WebDriver = driver;
            Assert.IsNotNull(WebDriver, "No driver instance provided");
        }

        //Assigning webelement location to Iwebelements

        public IWebElement FlagIcon => WebDriver.FindElement(By.XPath("//span[@class='icp-nav-link-inner']"));
        public IWebElement Language => WebDriver.FindElement(By.XPath("//i[@class='icp-radio']"));
        public IWebElement Change => WebDriver.FindElement(By.XPath("//div[@class='icp-mkt-change-lnk']"));
        public IWebElement CountryDrop => WebDriver.FindElement(By.XPath("//span[@class='a-dropdown-prompt']"));
        public IWebElement Italy => WebDriver.FindElement(By.XPath("//li[@id='icp-dropdown-item-7']//following::li[1]"));
        public IWebElement GoToWebsite => WebDriver.FindElement(By.XPath("//input[@class='a-button-input']"));

            


    }
}

