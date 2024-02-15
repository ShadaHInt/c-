using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace assessment2mstest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            //navigate to website
            driver.Navigate().GoToUrl("https://www.bigbasket.com/");
            driver.Manage().Window.Maximize();
            // verifying website
            string url = driver.Url;
            string urltotest = "https://www.bigbasket.com/";
            Assert.AreEqual(url, urltotest);
            IWebElement login = driver.FindElement(By.LinkText("Login/Sign Up"));
            login.Click();
            IWebElement click = driver.FindElement(By.ClassName("form-group"));
            click.Click();
            Thread.Sleep(5);
            IWebElement ccontinue = driver.FindElement(By.ClassName("login-btn"));
            ccontinue.Click();





        }
    }
}
