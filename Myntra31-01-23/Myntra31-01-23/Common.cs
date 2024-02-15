using Myntraproject;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using Selenium.Axe;

namespace Medicineproject
{

    public class Common : BaseClass
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

        //public static void Style()
        //{
        //      string htmlstringfirst = "<html><body bgcolor='red'></body><html>";


        //}

        public static void Action(IWebElement a)
        {
            Actions actions = new Actions(driver);
            actions.MoveToElement(a).Perform();
            actions.Build().Perform();
        }




    }
}
