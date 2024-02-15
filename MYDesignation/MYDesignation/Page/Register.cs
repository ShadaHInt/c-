using OpenQA.Selenium;

namespace NoonProject2 
{
    public class Register
    {
        IWebDriver WebDriver;
        public Register(in IWebDriver driver)
        {
            WebDriver = driver; 
            Assert.IsNotNull(WebDriver, "No driver instance provided");
        }

        //Assigning webelement location to Iwebelements 
        public IWebElement LoginSymbol => WebDriver.FindElement(By.Id("dd_header_signInOrUp"));
        public IWebElement SignUp => WebDriver.FindElement(By.CssSelector("h3.sc-376d6e3f-7.jDQCAY")); 
        public IWebElement FirstName => WebDriver.FindElement(By.Id("firstNameInput")); 
        public IWebElement LastName => WebDriver.FindElement(By.Id("lastNameInput")); 
        public IWebElement Email => WebDriver.FindElement(By.Id("emailInput")); 
        public IWebElement Password => WebDriver.FindElement(By.Id("passwordInput"));
        public IWebElement CreateAccount => WebDriver.FindElement(By.Id("login-submit"));
        public IWebElement EmailError => WebDriver.FindElement(By.XPath("//p[text()='Invalid email']"));
        public IWebElement PasswordError => WebDriver.FindElement(By.XPath("//div[text()='Invalid password']"));

    }
}
