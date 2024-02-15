using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newprojectspecflow
{
    public class Homepage: BaseClass
    {
        public Homepage(in IWebDriver driver)
        {

        }
        public IWebElement search => driver.FindElement(By.Id("twotabsearchtextbox"));
        public IWebElement searchbutton => driver.FindElement(By.Id("nav-search-submit-button"));
        public IWebElement bestseller => driver.FindElement(By.XPath("//div[@id='nav-xshop']/a[@href='/gp/bestsellers/?ref_=nav_cs_bestsellers']"));
        public IWebElement electronics => driver.FindElement(By.XPath("//*[text()=' Electronics ']"));
        public IWebElement payondelivery => driver.FindElement(By.XPath("//span[text()='Eligible for Pay On Delivery']"));
        
    }
}
