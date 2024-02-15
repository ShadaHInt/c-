using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using TechTalk.SpecFlow;

namespace pom1.Step_Defnition
{
    [Binding]
    public sealed class Hooks1
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            Console.WriteLine("Before test run");
            // Example of filtering hooks using tags. (in this case, this 'before scenario' hook will execute if the feature/scenario contains the tag '@tag1')
            // See https://docs.specflow.org/projects/specflow/en/latest/Bindings/Hooks.html?highlight=hooks#tag-scoping

            //TODO: implement logic that has to run before executing each scenario
        }

        [AfterTestRun]
        public static void FirstBeforeScenario()
        {
            Console.WriteLine("After test run");
            // Example of ordering the execution of hooks
            // See https://docs.specflow.org/projects/specflow/en/latest/Bindings/Hooks.html?highlight=order#hook-execution-order

            //TODO: implement logic that has to run before executing each scenario
        }
        [AfterStep]
        public void BeforeStep()
        {
            IWebDriver driver = new EdgeDriver();
            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile(@"C:\Users\shadan\Download\Image.png", ScreenshotImageFormat.Png);
        }
        //[AfterScenario]
        //public void AfterScenario()
        //{
        //    //TODO: implement logic that has to run after executing each scenario
        //}
    }
}