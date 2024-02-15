using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testingpharmeasy
{
    [TestClass]
    public class Homepagetest
    {

        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            //navigate to website
            driver.Navigate().GoToUrl("http://www.pharmeasy.in");
            driver.Manage().Window.Maximize();
            // verifying website
            string url = driver.Url;
            string urltotest = "http://www.pharmeasy.in";
           // Assert.AreEqual(url, urltotest);

            Thread.Sleep(5);

            Homepage homepage = new(driver);
            //homepage.pincode.Click();
            //Thread.Sleep(3000);

            //homepage.pincodeenter.Click();
            //homepage.pincodeenter.SendKeys("33333");
            //homepage.pinchk.Click();

            //Thread.Sleep(3000);
            //homepage.closebt.Click();

           homepage.searchbx.Click();
            Thread.Sleep(5000);
            //Actions actions = new Actions(driver);
            //homepage.searchbxe.SendKeys("Shampoo");
            //actions.KeyDown(Keys.Control).SendKeys("a").KeyUp(Keys.Control).Build().Perform();
            //actions.KeyDown(Keys.Control).SendKeys("c").KeyUp(Keys.Control).Build().Perform();

            //// .c - bXbWpx - icOztnM - css.c - bXbWpx - lfylVv - direction - row
            homepage.searchbxe.SendKeys("Shampoo");
            Thread.Sleep(3000);
            homepage.himalaya.Click();
            Thread.Sleep(3000);

            Thread.Sleep(3000);
            //string testUrl = "https://pharmeasy.in/health-care/products/himalaya-anti-dandruff-shampoo---200ml-503683";
            //var newWindowHandle = driver.WindowHandles[0];
            //Assert.IsTrue(!string.IsNullOrEmpty(newWindowHandle));
            //string expectedNewWindowTitle = testUrl;
            //driver.SwitchTo().Window(newWindowHandle);
            ////driver.SwitchTo().Window(driver.WindowHandles[1]);
            ////Actions actions = new Actions(driver);
            ////actions.MoveToElement(homepage.shampoo).Perform();
            homepage.cart.Click();



        }
    }
}
