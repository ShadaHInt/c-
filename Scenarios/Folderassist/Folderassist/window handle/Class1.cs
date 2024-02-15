using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace window_handle_demo
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://uitestpractice.com/Students/Switchto");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.LinkText("Opens in a new window")).Click();
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            Console.WriteLine(driver.FindElement(By.Id("draggable")).Text);
            Thread.Sleep(3000);
            driver.SwitchTo().Window(driver.WindowHandles[0]);
            Thread.Sleep(2000);
            driver.Quit();









        }
        [TestMethod]

        public void TestMethod2()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://uitestpractice.com/Students/Switchto");
            driver.Manage().Window.Maximize();
            driver.SwitchTo().Frame("iframe_a");
            driver.FindElement(By.XPath("//input[@id='name']")).SendKeys("abc");
            driver.SwitchTo().DefaultContent();
            driver.FindElement(By.LinkText("Opens in a new window")).Click();
            driver.Quit();


        }

    }
}