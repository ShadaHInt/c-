using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace AmazonTry.SpecflowHooks
{
    [Binding]
    public sealed class Hooks1
    {
        IWebDriver driver = new ChromeDriver();

        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks
        [BeforeTestRun]
        public static void BeforTestRun()
        {
            Console.WriteLine("In method before Test run");
        }
        [AfterTestRun]
        public static void AferTestRun()
        {
            Console.WriteLine("In method after test run");
        }
        [BeforeFeature]
        public static void BeforeFeature()
        {
            Console.WriteLine("In method before feature");
        }
        [AfterFeature]
        public static void AfterFeature()
        {
            Console.WriteLine("In method after feature");
        }
        [BeforeScenario]
        public void BeforeScenario()
        {
            Console.WriteLine("In method before Scenario");
        }
        [AfterScenario]
        public void AfterScenario()
        {
            Console.WriteLine("In method after Scenario");
        }
        [BeforeScenarioBlock]
        public void BeforeScenarioBlock()
        {
            Console.WriteLine("In method before Scenario block");
        }
        [AfterScenarioBlock]
        public void AfterascenarioBlock()
        {
            Console.WriteLine("In method before Scenario block");
        }
        [BeforeStep]
        public void BeforeStep()
        {
            Console.WriteLine("In method before step");
        }
        [AfterStep]
        public void AfterStep()
        {
            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile(@"D:\p", ScreenshotImageFormat.Png);

        }


        [BeforeScenario("@manual")]
        public void BeforeScenarioWithTag()
        {
            // Example of filtering hooks using tags. (in this case, this 'before scenario' hook will execute if the feature/scenario contains the tag '@tag1')
            // See https://docs.specflow.org/projects/specflow/en/latest/Bindings/Hooks.html?highlight=hooks#tag-scoping
            Console.WriteLine("In method before Scenario with tag");
            //TODO: implement logic that has to run before executing each scenario
        }

        [BeforeScenario(Order = 1)]
        public void FirstBeforeScenario()
        {
            // Example of ordering the execution of hooks
            // See https://docs.specflow.org/projects/specflow/en/latest/Bindings/Hooks.html?highlight=order#hook-execution-order
            Console.WriteLine("In method before Scenario Order = 1!");
            //TODO: implement logic that has to run before executing each scenario
        }
        [BeforeScenario(Order =10)]
        public void SecondBeforeScenario()
        {
            Console.WriteLine("In method before Scenario Order = 10!");
        }
        
    }
}