using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternalProject.Page
{
    public class CreateAccount
    {
        IWebDriver WebDriver;
        public CreateAccount(in IWebDriver driver)
        {
            WebDriver = driver;
            Assert.IsNotNull(WebDriver, "No driver instance provided");
        }

        //Assigning webelement location to Iwebelements

        public IWebElement AccountsNLists => WebDriver.FindElement(By.XPath("//span[@class='nav-line-2 ']"));
        public IWebElement SignIn => WebDriver.FindElement(By.XPath("//span[@class='nav-action-inner']")); 
        public IWebElement CreateAcc => WebDriver.FindElement(By.XPath("//a[@id='createAccountSubmit']"));
        public IWebElement Name => WebDriver.FindElement(By.XPath("//input[@id='ap_customer_name']"));
        public IWebElement MobileNo => WebDriver.FindElement(By.XPath("//input[@id='ap_phone_number']"));
        public IWebElement Password => WebDriver.FindElement(By.XPath("//input[@id='ap_password']"));
        public IWebElement Continue => WebDriver.FindElement(By.XPath("//input[@id='continue']"));
        
    }
}

