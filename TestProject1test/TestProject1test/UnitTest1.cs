
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestProject1test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            /*IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.firstcry.com/");
            string url = driver.Url;
            string urltotest = "https://www.firstcry.com/";
            Assert.AreEqual(url, urltotest);*/
            IWebDriver driver = new ChromeDriver();
            // Navigate to webpage myntra
            driver.Navigate().GoToUrl("https://www.myntra.com/");

            // verifying whether navigated to myntra itself 
            string url = driver.Url;
            string urltotest = "https://www.myntra.com/";
            Assert.AreEqual(url, urltotest);
        }
    }
}