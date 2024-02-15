using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testingpom
{
    [TestClass]
    public class Sofatest
    {


        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            Sofa sofa = new(driver);
            driver.Navigate().GoToUrl("https://www.pepperfry.com/");
            driver.Manage().Window.Maximize();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            sofa.storage.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            sofa.sofa.Click();
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0, 500)");
            sofa.pretty.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
        }
    }
}
