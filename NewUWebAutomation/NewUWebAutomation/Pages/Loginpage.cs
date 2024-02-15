using OpenQA.Selenium;

namespace NewUWebAutomation
{
    [TestClass]
    public class Loginpage:BaseClass
    {
        public Loginpage(in IWebDriver driver)
        {

            // Assert.IsNotNull(WebDriver, "NO Driver instance provided");
        }

        public IWebElement Email => driver.FindElement(By.XPath("//input[@class='form-control' and @type='email']"));
        public IWebElement Password => driver.FindElement(By.XPath("//input[@class='form-control' and @type='password']"));
        public IWebElement LoginBtn => driver.FindElement(By.XPath("//input[@class='btn btn-login']"));
        public IWebElement Errormsg => driver.FindElement(By.CssSelector("div.errors>ul>li"));
        public IWebElement AccDeatils => driver.FindElement(By.CssSelector("h5.acc-name"));
        public IWebElement Google => driver.FindElement(By.CssSelector("span.h_google_text"));



        





    }
}
