using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationDemo_Myntra
{
    public class Homepage:BaseClass
    {
        IWebDriver WebDriver;
        public Homepage(in IWebDriver driver)
        {

            WebDriver = driver;
            Assert.IsNotNull(WebDriver, "NO Driver instance provided");


        }
        public IWebElement MyntraIcon => WebDriver.FindElement(By.CssSelector(".desktop-logo.myntraweb-sprite.sprites-headerLogo"));
        public IWebElement Wishlist => WebDriver.FindElement(By.CssSelector(".desktop-wishlist > .desktop-userTitle"));
        public IWebElement Cart => WebDriver.FindElement(By.CssSelector(".desktop-cart > .desktop-userTitle"));
        public IWebElement EmptyMessage => WebDriver.FindElement(By.ClassName("emptyCart-base-emptyDesc"));

        
    }
}
