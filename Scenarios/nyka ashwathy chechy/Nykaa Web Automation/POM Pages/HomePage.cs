using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nykaa_Web_Automation.POM_Pages
{
    public class HomePage
    {

        IWebDriver Webdriver;
        WebDriverWait wait => new WebDriverWait(Webdriver, TimeSpan.FromSeconds(50));
        public HomePage(in IWebDriver driver) => Webdriver = driver;
        public IWebElement HeaderLogo => wait.Until(x => x.FindElement(By.CssSelector("a.logo")));
     
    }
}
