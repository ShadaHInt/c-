using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pom1
{
    public class Loginpage
    {
        IWebDriver WebDriver;
        public Loginpage(in IWebDriver driver)
        {

            WebDriver = driver;
            Assert.IsNotNull(WebDriver, "NO Driver instance provided");
            

        }
        public IWebElement loginbt => WebDriver.FindElement(By.LinkText("Login/Sign Up"));

        public IWebElement bt => WebDriver.FindElement(By.ClassName("form-control-placeholder"));
        public IWebElement ibt => WebDriver.FindElement(By.XPath("//input[@name='otpEmail']"));
        public IWebElement contbt => WebDriver.FindElement(By.XPath("//button[@type='submit']"));
    }
}
