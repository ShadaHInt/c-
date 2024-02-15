using TechTalk.SpecFlow;

namespace Newprojectspecflow.hooks
{
    [Binding]
    public sealed class Hooks1
    {
       

        [BeforeScenario("@tag1")]
        public void BeforeScenarioWithTag()
        {
            
        }

        [BeforeScenario]
        public void FirstBeforeScenario()
        {
            Console.WriteLine("beforescenerio");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Console.WriteLine("pass");
        }
    }
}