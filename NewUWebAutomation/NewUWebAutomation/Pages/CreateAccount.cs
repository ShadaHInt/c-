using OpenQA.Selenium;



namespace NewUWebAutomation
{
    [TestClass]
    public class CreateAccount:BaseClass
    {
        public CreateAccount(in IWebDriver driver)
        {

            // Assert.IsNotNull(WebDriver, "NO Driver instance provided");
        }

        public IWebElement User => driver.FindElement(By.ClassName("customer-links"));
        public IWebElement CreateAccountt => driver.FindElement(By.ClassName("ct-register"));
        public IWebElement FirstName => driver.FindElement(By.Id("first_name"));
        public IWebElement LastName => driver.FindElement(By.Id("last_name"));
        public IWebElement Email => driver.FindElement(By.Id("email"));
        public IWebElement Password => driver.FindElement(By.Id("create_password"));
        public IWebElement CreatAcc => driver.FindElement(By.ClassName("btn-padd42"));
        public IWebElement ErrorMsg => driver.FindElement(By.ClassName("form-error"));

        //public IWebElement Google => driver.FindElement(By.CssSelector("span.h_google_text"));









    }
}
