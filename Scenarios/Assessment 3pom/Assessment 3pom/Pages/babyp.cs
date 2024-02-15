using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_3pom
{
    public class Babyp
    {
        IWebDriver WebDriver;
        public Babyp(in IWebDriver driver)
        {

            WebDriver = driver;
            Assert.IsNotNull(WebDriver, "NO Driver instance provided");


        }
        
        public IWebElement allp => WebDriver.FindElement(By.XPath("//span[@class='sortbar-list']"));

        public IWebElement daily => WebDriver.FindElement(By.XPath("//span[text()='Daily Care']"));
        public IWebElement shopb => WebDriver.FindElement(By.XPath("//img[@src='https://static.hopscotch.in/fstatic/product/202107/c8b58423-15df-41f4-88f8-bf809f529db9_full.jpg?version=1625641522126&tr=w-480,c-at_max,dpr-2,n-medium']"));

        public IWebElement price1 => WebDriver.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div/section/hs-filter[2]/div[1]/div[2]/div[2]/filter-block/div/div"));
        ////div[@class='ng-filters-v2-wrapper']//following::div[1]
        public IWebElement pricebelow => WebDriver.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div/section/hs-filter[2]/div[1]/div[2]/div[2]/filter-block/div/div[2]/div/div/filter-item/div/div[1]/div/label"));
        //div[@class='ng-filters-v2 ng-scope']//child::div[1]
        public IWebElement firstele => WebDriver.FindElement(By.XPath("//div[@class='plp-image-container']//following::img[1]"));
        ////div[@class='plp-image-container']//child::img[1]
        ///html/body/div[1]/div[2]/div/div/div/section/product-list/div/div[1]/product/div/a/div/div[1]/div[1]/img

    }
}
