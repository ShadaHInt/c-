using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentPharmeasy
{
    public class Delivery
    {
        IWebDriver WebDriver;
        public Delivery(in IWebDriver driver)
        {
            WebDriver = driver;
            Assert.IsNotNull(WebDriver, "No driver instance provided");
        }

        //Assigning webelement location to Iwebelements
        public IWebElement DeliverButton => WebDriver.FindElement(By.XPath("//span[text()='Select Pincode']"));  //span[contains(@class,'c-kkmdlQ-igGXvru-css')]
        public IWebElement EnterPin => WebDriver.FindElement(By.XPath("//input[@type='text']"));
        public IWebElement CheckButton => WebDriver.FindElement(By.XPath("//span[contains(@class, 'c-kkmdlQ-ijDBPnN-css')]"));
        public IWebElement ErrorMessage => WebDriver.FindElement(By.XPath("//span[text()='Enter Valid Pincode']"));
        public IWebElement PinDisplay => WebDriver.FindElement(By.XPath("//span[text()='673001 Kozhikode-2']"));



    }
}
