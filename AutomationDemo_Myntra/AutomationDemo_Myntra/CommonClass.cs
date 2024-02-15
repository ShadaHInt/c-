using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationDemo_Myntra
{
    public class CommonClass : BaseClass
    {

        public static void scrollbar(int a, int b)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(" + a + "," + b + ")");

        }

        public static void Maximise()
        {
            driver.Manage().Window.Maximize();
        }


        public static void Window()
        {
            driver.SwitchTo().Window(driver.WindowHandles[1]);
        }

        public static void Action(IWebElement a)
        {
            Actions actions = new Actions(driver);
            actions.MoveToElement(a).Perform();
            actions.Build().Perform();
        }

    }
}
