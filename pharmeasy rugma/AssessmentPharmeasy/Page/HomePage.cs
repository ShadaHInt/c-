using OpenQA.Selenium;

namespace AssessmentPharmeasy
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

        public IWebElement Category1 => WebDriver.FindElement(By.XPath("//img[@alt='Medicine UPTO 50% OFF']"));
        public IWebElement Category2 => WebDriver.FindElement(By.XPath("//img[@alt='Medicine UPTO 50% OFF']//following::div[1]"));
        public IWebElement Category3 => WebDriver.FindElement(By.XPath("//img[@alt='Medicine UPTO 50% OFF']//following::div[2]"));
        public IWebElement Category4 => WebDriver.FindElement(By.XPath("//img[@alt='Medicine UPTO 50% OFF']//following::div[3]"));
        public IWebElement Category5 => WebDriver.FindElement(By.XPath("//img[@alt='Medicine UPTO 50% OFF']//following::div[4]"));
        public IWebElement Category6 => WebDriver.FindElement(By.XPath("//img[@alt='Medicine UPTO 50% OFF']//following::div[5]"));
        public IWebElement Category7 => WebDriver.FindElement(By.XPath("//img[@alt='Medicine UPTO 50% OFF']//following::div[6]"));
        public IWebElement Category8 => WebDriver.FindElement(By.XPath("//img[@alt='Medicine UPTO 50% OFF']//following::div[7]"));
    }
}