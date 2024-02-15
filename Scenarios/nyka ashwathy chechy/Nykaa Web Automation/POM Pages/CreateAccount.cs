using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Nykaa_Web_Automation.POM_Pages
{
    public class CreateAccount
    {

        IWebDriver Webdriver;
        WebDriverWait wait => new WebDriverWait(Webdriver, TimeSpan.FromSeconds(50));
        public CreateAccount(in IWebDriver driver) => Webdriver = driver;
        public IWebElement AccountIcon => wait.Until(x => x.FindElement(By.CssSelector("div.css-dwg5hz")));
        public IWebElement PhoneNumberEmailButton => wait.Until(x => x.FindElement(By.CssSelector("input.input.text-center.login-input")));
        public IWebElement PhoneEmailText => wait.Until(x => x.FindElement(By.CssSelector("input.input[name='emailMobile']")));
        public IWebElement validation => wait.Until(x => x.FindElement(By.ClassName("help-msg")));
        public IWebElement Proceeedbutton => wait.Until(x => x.FindElement(By.Id("submitVerification")));

    }
}
