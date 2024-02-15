using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appiumtestingjeep
{
    public class CommonCodes:BaseClass
    {
        public static void scroll(int a, int b)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(" + a + "," + b + ")");
        }
        public static void Rest()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(12);
        }
    }
}
