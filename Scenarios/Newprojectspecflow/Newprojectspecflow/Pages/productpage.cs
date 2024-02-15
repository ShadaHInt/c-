using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newprojectspecflow.Pages
{
    public class productpage : BaseClass
    {
        public productpage(in IWebDriver driver)
        {
        }
        public IWebElement searchbox => driver.FindElement(By.Id("twotabsearchtextbox"));
        public IWebElement dropdwn => driver.FindElement(By.Id("searchDropdownBox"));
        public IWebElement radiob => driver.FindElement(By.ClassName("a-icon a-accordion-radio a-icon-radio-active"));
        public IWebElement addtocart => driver.FindElement(By.CssSelector("input#add-to-cart-button"));
        public IWebElement check => driver.FindElement(By.XPath("//input[@id='mbb-offeringID-2']"));
        public IWebElement checkout => driver.FindElement(By.XPath("//span[@id ='attach-sidesheet-checkout-button']"));

    }
}
