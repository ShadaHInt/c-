using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Assessment5
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.bigbasket.com/");

        }
    }
}