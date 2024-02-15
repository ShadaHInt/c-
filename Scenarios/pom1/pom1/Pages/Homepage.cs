using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pom1
{
  
    public class Homepage
    {
        IWebDriver WebDriver;
        public Homepage (in IWebDriver driver)
        {
            
            WebDriver = driver;
            Assert.IsNotNull(WebDriver, "NO Driver instance provided");


        }
        public IWebElement pincode => WebDriver.FindElement(By.ClassName("hvc"));

        public IWebElement shopb => WebDriver.FindElement(By.ClassName("full-wid"));

        public IWebElement bvg => WebDriver.FindElement(By.LinkText("Beverages"));
        public IWebElement red => WebDriver.FindElement(By.XPath("//img[@alt='Red Label Tea 250 g']"));

        public IWebElement redtxt => WebDriver.FindElement(By.ClassName("IyLvo"));

        public IWebElement rating => WebDriver.FindElement(By.ClassName("_2Ze34"));
        
        public IWebElement cleaning => WebDriver.FindElement(By.LinkText("Cleaning & Household"));
        public IWebElement harpic => WebDriver.FindElement(By.XPath("//img[@alt='Harpic Disinfectant Toilet Cleaner Liquid - Original 1 L']"));

        public IWebElement priceh => WebDriver.FindElement(By.ClassName("IyLvo"));

        public IWebElement cart => WebDriver.FindElement(By.ClassName("Cs6YO"));

        public IWebElement mycart => WebDriver.FindElement(By.ClassName("eubx4"));

        public IWebElement offerbt => WebDriver.FindElement(By.ClassName("bb-offers-link"));

        public IWebElement maggi => WebDriver.FindElement(By.XPath("//img[@src='https://www.bigbasket.com/media/uploads/p/s/266109_19-maggi-2-minute-instant-noodles-masala.jpg']"));

        public IWebElement pricemag => WebDriver.FindElement(By.ClassName("IyLvo"));





    }
}
