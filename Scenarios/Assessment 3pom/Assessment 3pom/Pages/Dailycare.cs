using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_3pom
{
    public class Dailycare
    {
        IWebDriver WebDriver;
        public Dailycare(in IWebDriver driver)
        {

            WebDriver = driver;
            Assert.IsNotNull(WebDriver, "NO Driver instance provided");


        }
        public IWebElement shopb => WebDriver.FindElement(By.XPath("//img[@src='https://static.hopscotch.in/fstatic/product/202107/c8b58423-15df-41f4-88f8-bf809f529db9_full.jpg?version=1625641522126&tr=w-480,c-at_max,dpr-2,n-medium']"));
        public IWebElement allp => WebDriver.FindElement(By.XPath("//span[@class='sortbar-list']"));
       
        public IWebElement daily => WebDriver.FindElement(By.XPath("//span[text()='Daily Care']"));
    }
}
