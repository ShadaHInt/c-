using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace TestMstest
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

        }
    }
}