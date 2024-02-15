using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practise1
{
    [TestClass]
    public class Homepagetest
    {
        [TestMethod]
        public void TestMethod1()
        {
            
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.bigbasket.com/");
            driver.Manage().Window.Maximize();
            // verifying website
            string url = driver.Url;
            string urltotest = "https://www.bigbasket.com/";
            Assert.AreEqual(url, urltotest);
            Homepage homepage = new(driver);
            Thread.Sleep(5);
            Console.WriteLine("pincode displayed" + homepage.pincode.Displayed);
            string pin = homepage.pincode.Text;
            Console.WriteLine(pin);
            Thread.Sleep(5);
        }
        
    }
}
