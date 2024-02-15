using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using TechTalk.SpecFlow;

namespace Assessment5
{
    [Binding]
    public sealed class Hooks1 : BaseClass1
    {
        private static ExtentTest? featureName;
        private static ExtentTest? scenario;
        private static ExtentReports? extent;


        [BeforeTestRun]
        [Obsolete]
        public static void InitializeReport()
        {
            var htmlReporter = new ExtentV3HtmlReporter(@"D:/CustomizedProjectReport.html");
            htmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Standard;


            extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);
        }

        [AfterTestRun]
        public static void TearDownReport()
        {
            extent.Flush();
        }


        [BeforeFeature]
        [Obsolete]
        public static void BeforeFeature()
        {
            //Create dynamic feature name
            Console.WriteLine("****BeforeFeature****");
            featureName = extent.CreateTest<Feature>(FeatureContext.Current.FeatureInfo.Title);

        }

        [AfterStep]
        [Obsolete]
        public void InsertReportingSteps(ScenarioContext ScenarioContext)
        {
            var StepInfo = ScenarioContext.StepContext.StepInfo;

            var stepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();



            if (ScenarioContext.Current.TestError == null)
            {
                if (stepType == "Given")
                {
                    scenario.CreateNode<Given>(stepType + " " + ScenarioStepContext.Current.StepInfo.Text);
                }

                else if (stepType == "When")
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "Then")
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "And")
                    scenario.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text);




            }
            else if (ScenarioContext.Current.TestError != null)
            {


                if (stepType == "Given")
                {
                    scenario.CreateNode<Given>(stepType + " " + ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);
                }

                else if (stepType == "When")
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);
                else if (stepType == "Then")
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);//InnerException
            }
        }
    }
}