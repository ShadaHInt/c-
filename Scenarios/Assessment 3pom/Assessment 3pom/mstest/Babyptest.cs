using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_3pom.mstest
{
    [TestClass]
    public class Babyptest
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            Babyp babyp = new(driver);
            driver.Navigate().GoToUrl("https://www.hopscotch.in/");
            driver.Manage().Window.Maximize();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            babyp.allp.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            babyp.daily.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            babyp.shopb.Click();
            //IWebElement drop = driver.FindElement(By.ClassName("hide-for-small-only"));
            //SelectElement selectprice = new SelectElement(drop);
            //selectprice.SelectByIndex(1);
            Thread.Sleep(TimeSpan.FromSeconds(2));
            babyp.price1.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            babyp.pricebelow.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            babyp.firstele.Click();
            Thread.Sleep(2000);
            var newWindowHandle = driver.WindowHandles[1];
            Assert.IsTrue(!string.IsNullOrEmpty(newWindowHandle));
            
            driver.SwitchTo().Window(newWindowHandle);
            //babyp.pinchk.Click();
            //Thread.Sleep(TimeSpan.FromSeconds(2));
            //babyp.pinchk1.Click();
            //babyp.pinchk1.SendKeys("455 - 550");
            //babyp.pinchk2.Click();

        }
    }
}
