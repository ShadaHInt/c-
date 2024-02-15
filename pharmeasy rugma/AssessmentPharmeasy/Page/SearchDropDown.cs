using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentPharmeasy
{
    public class SearchDropDown
    {
        IWebDriver WebDriver;
        public SearchDropDown(in IWebDriver driver)
        {
            WebDriver = driver;
            Assert.IsNotNull(WebDriver, "No driver instance provided");
        }


        //Assigning webelement location to Iwebelements
        public IWebElement SearchDrop => WebDriver.FindElement(By.XPath("//div[contains(@class,'c-bXbWpx-icOztnM-css')]//child::div[1]"));
        
        public IWebElement SearchBar => WebDriver.FindElement(By.XPath("//input[@id='topBarInput']"));
        public IWebElement ThirdItem => WebDriver.FindElement(By.XPath("//a[@href='https://pharmeasy.in/health-care/products/upglam-onion-oil-shampoo-3639705']//following::a[2]"));
        public IWebElement ProductName => WebDriver.FindElement(By.XPath("//h1[text()='Himalaya Anti Dandruff Shampoo - 200ml']"));
        public IWebElement PackSize => WebDriver.FindElement(By.XPath("//div[@class='VariantSection_chipGrid__34r4V']"));
        public IWebElement AddToCart => WebDriver.FindElement(By.XPath("//*[@id=\"__next\"]/main/div/div[2]/div[1]/div[1]/div[2]/div[1]/div[4]/div[2]/div/button")); ////button[contains(@class,'Button_container__1m-3V')]
        public IWebElement Qty4 => WebDriver.FindElement(By.XPath("/html/body/div[4]/div[3]/ul/li[4]"));
        public IWebElement ViewCart => WebDriver.FindElement(By.XPath("//span[text()='View Cart']"));

    }
}
