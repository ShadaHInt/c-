using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_3pom
{
    public class Productpage
    {
        IWebDriver WebDriver;
        public Productpage(in IWebDriver driver)
        {

            WebDriver = driver;
            Assert.IsNotNull(WebDriver, "NO Driver instance provided");


        }
       
     

        public IWebElement pinchk => WebDriver.FindElement(By.CssSelector("span.css-tku32c"));

        public IWebElement pinchk1 => WebDriver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/div/div[2]/form/div/input"));
        ////descendant::img[1]
        public IWebElement pinchk2 => WebDriver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/div/div[2]/form/button"));

        public IWebElement cart => WebDriver.FindElement(By.XPath("/html/body/div/div/main/div/div[2]/div[4]/button"));
       
        public IWebElement cartbt => WebDriver.FindElement(By.CssSelector("div.css-xwjvhy"));
      
       public IWebElement qty => WebDriver.FindElement(By.CssSelector("div.select-box "));

       public IWebElement ProductCount => WebDriver.FindElement(By.CssSelector(".product-size>span:nth-of-type(3)"));
        ////div[text()='Arrives 29 Aug']
        public IWebElement arrivedate => WebDriver.FindElement(By.CssSelector("div.product-edd"));
        public IWebElement cost => WebDriver.FindElement(By.CssSelector("h4.summary-amount"));
        //icon-20 icon-delete
       public IWebElement delete => WebDriver.FindElement(By.CssSelector(".icon-20.icon-delete"));
        public IWebElement Emptycart1 => WebDriver.FindElement(By.XPath("//div[@class='cart-checkout-header']"));
        public IWebElement Emptycart2 => WebDriver.FindElement(By.XPath("//span[@class='icon-empty-cart']//following-sibling::h3"));

    }
}


