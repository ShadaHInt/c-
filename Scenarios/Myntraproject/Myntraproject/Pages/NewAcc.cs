using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myntraproject
{
    public class NewAcc
    {
        IWebDriver WebDriver;
        public NewAcc(in IWebDriver driver)
        {

            WebDriver = driver;
            Assert.IsNotNull(WebDriver, "NO Driver instance provided");
        }

        //Profile
        public IWebElement prof => WebDriver.FindElement(By.XPath("//span[text()='Profile']"));

        //.desktop-linkButton
        public IWebElement signup => WebDriver.FindElement(By.CssSelector(".desktop-linkButton"));

        //.form-control.mobileNumberInput
        public IWebElement mob => WebDriver.FindElement(By.CssSelector(".form-control.mobileNumberInput"));

        //.submitBottomOption
        public IWebElement cont => WebDriver.FindElement(By.CssSelector(".submitBottomOption"));

        //.otpContainer
        public IWebElement otp => WebDriver.FindElement(By.CssSelector(".otpContainer"));
    }
}