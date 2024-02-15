using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_3pom
{
    public class Homepage
    {
       
        IWebDriver WebDriver;
        public Homepage(in IWebDriver driver)
        {

            WebDriver = driver;
            Assert.IsNotNull(WebDriver, "NO Driver instance provided");


        }
        public IWebElement discover => WebDriver.FindElement(By.LinkText("Discover"));
        public IWebElement all=> WebDriver.FindElement(By.XPath("//span[@class='sortbar-list']"));
        public IWebElement moment => WebDriver.FindElement(By.LinkText("Moments"));
        public IWebElement allp => WebDriver.FindElement(By.XPath("//span[@class='sortbar-list']"));
        //span[text()='Daily Care']
        public IWebElement daily => WebDriver.FindElement(By.XPath("//span[text()='Daily Care']"));
    }
}
