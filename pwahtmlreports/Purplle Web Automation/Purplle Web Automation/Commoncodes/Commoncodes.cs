using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purplle_Web_Automation
{
    public class Commoncodes:BaseClass
    {
        public static void scroll()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)WebDriver;
            js.ExecuteScript("window.scrollTo(0, 8000)");
        }
    }
}
