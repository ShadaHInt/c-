using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;

namespace TestProject2mstest
{
    [TestClass]
    public class UnitTest1
    {
        

        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver ();
            
            driver.Navigate().GoToUrl("https://google.com/");
            string title = driver.Title;
            driver.Navigate().GoToUrl("https://amazon.com/");
            string title1 = driver.Title;
            Console.WriteLine(title);
            string url = driver.Url;
            string PageSource = driver.PageSource;
            Console.WriteLine(url);
            driver.Navigate().Back();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            string url1 = driver.Url;
            driver.Navigate().Forward();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            driver.Navigate().Refresh();
        }
        
        
    }
}