using OpenQA.Selenium;


namespace NoonProject2.Page
{
    public class SignIn
    {
        IWebDriver WebDriver;
        public SignIn(in IWebDriver driver)
        {
            WebDriver = driver;
            Assert.IsNotNull(WebDriver, "No driver instance provided");
        }

        //Assigning webelement location to Iwebelements
        public IWebElement LoginSymbol => WebDriver.FindElement(By.Id("dd_header_signInOrUp"));
        public IWebElement Email => WebDriver.FindElement(By.Id("emailInput"));
        public IWebElement Password => WebDriver.FindElement(By.Id("passwordInput"));
        public IWebElement SigninButton => WebDriver.FindElement(By.Id("login-submit"));
        public IWebElement ErrorEmail => WebDriver.FindElement(By.CssSelector("p.sc-d268662f-4.iVwRAO.error"));
        public IWebElement ErrorPassword => WebDriver.FindElement(By.CssSelector("div.error-message"));
    }
} 
