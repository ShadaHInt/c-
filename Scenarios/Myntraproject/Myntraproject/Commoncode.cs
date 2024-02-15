using OpenQA.Selenium;


namespace Myntraproject
{
    public class Commoncode:BaseClass
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


    }
}
