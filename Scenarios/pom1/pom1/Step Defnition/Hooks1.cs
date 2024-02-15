using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using TechTalk.SpecFlow;

namespace pom1.Step_Defnition
{
    [Binding]
    public sealed class Hooks1 
    {
        
        IWebDriver driver = new EdgeDriver();
        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            Console.WriteLine("Before test run");
            
        }

        [AfterTestRun]
        public static void FirstBeforeScenario()
        {
            Console.WriteLine("After test run");
            
        }
        
        [BeforeScenario]
        public void BeforeScenario()
        {

            Console.WriteLine("Before scenario");
            
        }
        [AfterScenario]
        public void AfterScenario()
        {
           
            driver.Quit();
            
        }
    }
}