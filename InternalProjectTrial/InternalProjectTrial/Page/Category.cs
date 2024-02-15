using OpenQA.Selenium;


namespace InternalProjectTrial.Page
{
    public class Category
    {
        IWebDriver WebDriver;
        public Category(in IWebDriver driver)
        {
            WebDriver = driver;
            Assert.IsNotNull(WebDriver, "No driver instance provided");
        }

        //Assigning webelement location to Iwebelements

        public IWebElement Category1 => WebDriver.FindElement(By.XPath("//a[@id='nav-hamburger-menu']"));
        public IWebElement Category2 => WebDriver.FindElement(By.XPath("//a[@id='nav-hamburger-menu']//following::a[1]"));
        public IWebElement Category3 => WebDriver.FindElement(By.XPath("//a[@id='nav-hamburger-menu']//following::a[2]"));
        public IWebElement Category4 => WebDriver.FindElement(By.XPath("//a[@id='nav-hamburger-menu']//following::a[3]"));
        public IWebElement Category5 => WebDriver.FindElement(By.XPath("//a[@id='nav-hamburger-menu']//following::a[4]"));
        public IWebElement Category6 => WebDriver.FindElement(By.XPath("//a[@id='nav-hamburger-menu']//following::a[5]"));
        public IWebElement Category7 => WebDriver.FindElement(By.XPath("//a[@id='nav-hamburger-menu']//following::a[6]"));
        public IWebElement Category8 => WebDriver.FindElement(By.XPath("//a[@id='nav-hamburger-menu']//following::a[7]"));
        public IWebElement Category9 => WebDriver.FindElement(By.XPath("//a[@id='nav-hamburger-menu']//following::a[8]"));
        public IWebElement Category10 => WebDriver.FindElement(By.XPath("//a[@id='nav-hamburger-menu']//following::a[9]"));
        public IWebElement Category11 => WebDriver.FindElement(By.XPath("//a[@id='nav-hamburger-menu']//following::a[10]"));
        public IWebElement Category12 => WebDriver.FindElement(By.XPath("//a[@id='nav-hamburger-menu']//following::a[11]"));
        public IWebElement Category13 => WebDriver.FindElement(By.XPath("//a[@id='nav-hamburger-menu']//following::a[12]"));
       





    }
}

