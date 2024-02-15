using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testingpom
{
    public class Homepage
    {
        IWebDriver WebDriver;
        public Homepage(in IWebDriver driver)
        {

            WebDriver = driver;
            Assert.IsNotNull(WebDriver, "NO Driver instance provided");


        }
        public IWebElement pop => WebDriver.FindElement(By.ClassName("popup-close"));
        public IWebElement element => WebDriver.FindElement(By.XPath("//a[@href='https://www.pepperfry.com/furniture.html?type=hover-furniture']"));
        public IWebElement storage => WebDriver.FindElement(By.XPath("//a[@href='https://www.pepperfry.com/furniture.html?type=hover-furniture']"));
        public IWebElement sofa => WebDriver.FindElement(By.LinkText("Sofas and Recliners"));
    }
}
