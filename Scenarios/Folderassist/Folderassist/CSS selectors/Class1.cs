using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;

namespace DemoTest
{
    [TestClass]
    public class CssSelectorsDemoTests
    {

        [TestMethod]
        [TestCategory("CssSelectors")]
        public void CssSelectorDemo()
        {
            IWebDriver driver;

            // Local Selenium WebDriver
            driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://www.amazon.com");
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--disable-popup-blocking");

            Console.WriteLine("Test started \n");

            ////css=tag#id
            //driver.FindElement(By.CssSelector("input#twotabsearchtextbox")).SendKeys("Mobiles");
            //Thread.Sleep(2000);
            //Console.WriteLine("Key Mobile passed to search box successfully");

            ////css=tag.class
            //driver.FindElement(By.CssSelector("input#twotabsearchtextbox")).SendKeys("Mobiles");
            //Thread.Sleep(2000);
            //driver.FindElement(By.CssSelector(".nav-search-submit.nav-sprite")).Click();
            //Thread.Sleep(2000);
            //Console.WriteLine("Mobiles searched");

            ////css = tag[attribute = value]
            //driver.FindElement(By.CssSelector("span[class='hm-icon-label']")).Click();
            //Thread.Sleep(2000);
            //Console.WriteLine("All menu option clicked");

            ////css=tag.class[attribute=value]
            //driver.FindElement(By.CssSelector("span[class='hm-icon-label']")).Click(); //All Menu option clicked
            //driver.FindElement(By.CssSelector("a.hmenu-item[data-menu-id='2']")).Click();
            //Thread.Sleep(3000);
            //Console.WriteLine("Amazon Music selected");

            //css contains = tag(attribute *= 'partial attribute value']
            //Thread.Sleep(3000);
            //driver.FindElement(By.CssSelector("input[data-action-params*='INGR']")).Click();
            //int count = driver.FindElements(By.CssSelector("a[href*='goldbox?ref_']")).Count;
            //Console.WriteLine("Number of elements will be displayed: " + count);
            //Thread.Sleep(3000);
            //driver.FindElement(By.CssSelector("a[href*='goldbox?ref_']")).Click();
            //Console.WriteLine("Todays deal option clicked");

            ////css contains= tag(attribute^='attribute starting value']
            //Thread.Sleep(3000);
            //driver.FindElement(By.CssSelector("input[data-action-params*='INGR']")).Click();
            //Thread.Sleep(3000);
            //driver.FindElement(By.CssSelector("a[href^='/gp/go']")).Click();
            //Console.WriteLine("Todays deal option clicked");

            ////css contains= tag(attribute$='attribute ending value'] 
            //// href = "/gp/goldbox?ref_=nav_cs_gb"
            //Thread.Sleep(3000);
            //driver.FindElement(By.CssSelector("input[data-action-params*='INGR']")).Click();
            //Thread.Sleep(3000);
            //driver.FindElement(By.CssSelector("a[href$='f_=nav_cs_gb']")).Click();
            //Thread.Sleep(3000);
            //Console.WriteLine("Todays deal option clicked");

            ////parent_locator> child_locator
            //driver.FindElement(By.CssSelector("div>input[id='twotabsearchtextbox']")).SendKeys("Laptops");
            //Thread.Sleep(3000);
            //Console.WriteLine("Key Laptops send");

            //parent css locator> child HTML tag : nth-of-type(index)
            Thread.Sleep(3000);
            driver.FindElement(By.CssSelector("input[data-action-params*='INGR']")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.CssSelector("a[href^='/gp/go']")).Click();
            Thread.Sleep(3000);
            string text = driver.FindElement(By.CssSelector("div[class^='GridFilters-module__gridFilterSe']>span:nth-of-type(3)")).Text;
            Thread.Sleep(3000);
            Console.WriteLine(text);

            Console.WriteLine("\nTest completed");
            driver.Quit();
        }
    }
}
