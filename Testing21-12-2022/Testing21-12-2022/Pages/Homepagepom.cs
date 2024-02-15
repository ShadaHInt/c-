using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valoremweb
{
    public class Homepagepom
    {
        IWebDriver WebDriver;
        public Homepagepom(in IWebDriver driver)

        {

            WebDriver = driver;
            Assert.IsNotNull(WebDriver, "NO Driver instance provided");


        }
        public IWebElement logo => WebDriver.FindElement(By.CssSelector("div#companyLogoCt"));

        public IWebElement careers => WebDriver.FindElement(By.CssSelector("div#mainNavigationMenu > ul > li:nth-of-type(2) > a"));

        public IWebElement solutions => WebDriver.FindElement(By.CssSelector("li#capabilitiesLink > a[role='button']"));

        public IWebElement work => WebDriver.FindElement(By.CssSelector("div#mainNavigationMenu > ul > li:nth-of-type(3) > a"));

        public IWebElement about => WebDriver.FindElement(By.CssSelector("li#aboutLink > a[role='button']"));

        public IWebElement connect => WebDriver.FindElement(By.CssSelector("div#mainNavigationMenu > ul > li:nth-of-type(5) > a"));
    }
}


