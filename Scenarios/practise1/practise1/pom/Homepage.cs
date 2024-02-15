using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practise1
{
    public class Homepage
    {
        IWebDriver WebDriver;

        

        public Homepage(in IWebDriver driver)
        {

            WebDriver = driver;
            Assert.IsNotNull(WebDriver, "NO Driver instance provided");


        }
        public IWebElement pincode => WebDriver.FindElement(By.ClassName("hvc"));
    }
}
