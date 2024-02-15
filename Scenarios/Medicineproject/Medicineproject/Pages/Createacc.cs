using OpenQA.Selenium;


namespace Medicineproject
{
    
        public class Createacc: BaseClass1
        {
            IWebDriver WebDriver;
            public Createacc (in IWebDriver driver)

            {

                WebDriver = driver;
                Assert.IsNotNull(WebDriver, "NO Driver instance provided");


            }
             public IWebElement createicon => WebDriver.FindElement(By.LinkText("Create an Account"));
             public IWebElement firstname => WebDriver.FindElement(By.CssSelector("input#firstname"));
             public IWebElement lastname => WebDriver.FindElement(By.CssSelector("input#lastname"));
             public IWebElement email => WebDriver.FindElement(By.CssSelector("input#email_address"));
             public IWebElement passw => WebDriver.FindElement(By.CssSelector("input#password"));
             public IWebElement cpassw => WebDriver.FindElement(By.CssSelector("input#password-confirmation"));
             public IWebElement createbt => WebDriver.FindElement(By.CssSelector("button[title='Create an Account']"));


         }




}
