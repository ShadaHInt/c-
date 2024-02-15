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
    public class Homepagetest
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            Homepage homepage = new(driver);
            driver.Navigate().GoToUrl("https://www.pepperfry.com/");
            driver.Manage().Window.Maximize();
            // verifying website
            //string url = driver.Url;
            //string urltotest = "https://www.pepperfry.com/";
            //Assert.AreEqual(url, urltotest);
            //homepage.pop.Click();

            Thread.Sleep(TimeSpan.FromSeconds(2));
            string text = homepage.element.Text;
            Console.WriteLine(text);
            homepage.storage.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            homepage.sofa.Click(); 
            IAlert simpleAlert = driver.SwitchTo().Alert();
            simpleAlert.Dismiss();
            Thread.Sleep(5);
        }
    }
}
