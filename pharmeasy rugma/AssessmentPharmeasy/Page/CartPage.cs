using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentPharmeasy
{
    public class CartPage
    {
        IWebDriver WebDriver;
        public CartPage(in IWebDriver driver)
        {
            WebDriver = driver;
            Assert.IsNotNull(WebDriver, "No driver instance provided");

        }
        //Assigning webelement location to Iwebelements
        public IWebElement PrintPrice => WebDriver.FindElement(By.XPath("//div[@class='_3t5mc']"));
        public IWebElement ApplyCoupon => WebDriver.FindElement(By.XPath("//span[text()='Apply Coupon / View Offers']"));
        public IWebElement Coupon => WebDriver.FindElement(By.XPath("(//button[@class='_2FE4Z _3W5A_ _2Jc-Z v_2r1'])[2]"));
        public IWebElement MobileInput => WebDriver.FindElement(By.XPath("//input[@id='mobileNoInput']"));
        public IWebElement SendOtp => WebDriver.FindElement(By.XPath("//button[@id='mobileNoSubmitBtn']"));
        public IWebElement ErrorNoMsg => WebDriver.FindElement(By.XPath("//div[text()='Enter a valid mobile number']"));
        public IWebElement CloseOtp => WebDriver.FindElement(By.XPath("//div[@class='_2tdEn _1pXi6 _1Hsar _1BsxZ']"));
        public IWebElement DeleteProduct => WebDriver.FindElement(By.XPath("//button[@class='_1tbAI _1LcKc']"));
        public IWebElement YesDelete => WebDriver.FindElement(By.XPath("//div[text()='Yes']"));
        public IWebElement ErrorEmptyMsg => WebDriver.FindElement(By.XPath("//div[text()='Your Cart is Empty']"));



        
    }
}
