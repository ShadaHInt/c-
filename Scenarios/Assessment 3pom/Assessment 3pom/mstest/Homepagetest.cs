using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_3pom
{
    [TestClass]
    public class Homepagetest
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            Homepage homepage = new(driver);
            driver.Navigate().GoToUrl("https://www.hopscotch.in/");
            driver.Manage().Window.Maximize();
            //verifying website
            string url = driver.Url;
            string urltotest = "https://www.hopscotch.in/";
            Assert.AreEqual(url, urltotest);
            Thread.Sleep(TimeSpan.FromSeconds(2));
            string text = homepage.discover.Text;
            Console.WriteLine(text);
            string text1 = homepage.discover.Text;
            Console.WriteLine(text);
            string text2 = homepage.discover.Text;
            Console.WriteLine(text);
            homepage.allp.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            homepage.daily.Click();
        }
    }
}
