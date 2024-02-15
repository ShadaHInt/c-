using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace NewUWebAutomation
{
    public class CommonCodes : BaseClass
    {

        public static void scroll(int a, int b)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(" + a + "," + b + ")");
        }



        public static void Maxi()
        {
            driver.Manage().Window.Maximize();

        }

        public static void Rest()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(12);
        }
        
        public static void mousehover(IWebElement a)
        {
            Actions actions = new Actions(driver);
            actions.MoveToElement(a).Perform();
            actions.Build().Perform();
        }
       
    }
}
