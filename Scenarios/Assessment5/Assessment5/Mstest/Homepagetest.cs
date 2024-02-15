using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Drawing;

namespace MyntraProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.myntra.com/");
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);
            Console.WriteLine("mens displayed" + driver.FindElement(By.XPath("//div[text()='MEN']")));
        }
    }
}
