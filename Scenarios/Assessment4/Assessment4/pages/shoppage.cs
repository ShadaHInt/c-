using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment4
{
    public class Shoppage
    {
        IWebDriver WebDriver;
        public Shoppage(in IWebDriver driver)
        {

            WebDriver = driver;
            Assert.IsNotNull(WebDriver, "NO Driver instance provided");


        }

        public IWebElement firstip => WebDriver.FindElement(By.CssSelector("li:nth-of-type(1) > .cp-product.typ-plp h3 > a"));
       
        public IWebElement keyf => WebDriver.FindElement(By.CssSelector(".key-features-box"));

        
         public IWebElement addc => WebDriver.FindElement(By.CssSelector(".btn.btn-secondary.pdp-add-to-cart"));

        public IWebElement closebt  => WebDriver.FindElement(By.CssSelector(".close-btn.mini-cart-dialog-close-mob > svg > g path"));
        public IWebElement proceedbt => WebDriver.FindElement(By.CssSelector("button.proceed-tocart"));

        //button.proceed-tocart

        public IWebElement applyc => WebDriver.FindElement(By.CssSelector("svg.menu-click-arrow"));
        
        public IWebElement coupontxt => WebDriver.FindElement(By.CssSelector("input[name = 'coupoun']"));

        public IWebElement couponapply => WebDriver.FindElement(By.CssSelector(".coupon-apply-button"));

        //div[role = 'alert'] > .MuiAlert-message
        public IWebElement alert => WebDriver.FindElement(By.CssSelector("div.MuiAlert-message"));
    }





}
