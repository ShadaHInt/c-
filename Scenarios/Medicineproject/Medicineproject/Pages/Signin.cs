using OpenQA.Selenium;


namespace Medicineproject
{
    public class Signin:BaseClass1
    {

        IWebDriver WebDriver;
        public Signin(in IWebDriver driver)

        {

            WebDriver = driver;
            Assert.IsNotNull(WebDriver, "NO Driver instance provided");


        }
        public IWebElement signin => WebDriver.FindElement(By.CssSelector(".header.panel.show-icon-tablet > .header.links > .authorization-link.link > a"));
        public IWebElement emaila => WebDriver.FindElement(By.CssSelector("input#email"));
        public IWebElement passa => WebDriver.FindElement(By.CssSelector("fieldset #pass"));
        public IWebElement signbt => WebDriver.FindElement(By.XPath("//button[@id='send2']"));












    }
}
