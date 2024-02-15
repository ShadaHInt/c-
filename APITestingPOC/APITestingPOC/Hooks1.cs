using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

using System.Reflection;
using TechTalk.SpecFlow;

namespace InternalProjectTrial.Hooks
{
    [Binding]
    public sealed class Hooks1 
    {

        private static ExtentTest? featureName;
        private static ExtentTest? scenario;
        private static ExtentReports? extent;
        private static ExtentTest? step_name;


        [BeforeTestRun]
        public static void BeforeTestRun()
        {

            //extent report
            var htmlReporter = new ExtentHtmlReporter(@"D:/CustomizedProjectReport.html");
            htmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Standard;

            extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);

            htmlReporter.Config.DocumentTitle = "Api Report";
            htmlReporter.Config.ReportName = "API Report";

            extent.AddSystemInfo("Tested By:", "Arathy Raju");
            extent.AddSystemInfo("Application", "Reqres.in");
            extent.AddSystemInfo("Environment", "QA");
            extent.AddSystemInfo("Machine", Environment.MachineName);
            extent.AddSystemInfo("OS", Environment.OSVersion.VersionString);
            //log
           
        }

        [AfterTestRun]
        public static void TearDownReport()
        {
            //Flush report
            extent.Flush();
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            //driver = new ChromeDriver();

            //extent report

            scenario = featureName.CreateNode<Scenario>(ScenarioContext.Current.ScenarioInfo.Title);
            scenario.AssignCategory("<i>Scenario</i>");

        }


        [BeforeFeature]
        public static void BeforeFeature(FeatureContext context)
        {
            //Create dynamic feature name
            featureName = extent.CreateTest(context.FeatureInfo.Title);
            featureName.AssignCategory("<i>Feature</i>");
        }

        [AfterStep]
        public void InsertReportingSteps(ScenarioContext Context)
        {
            var StepInfo = Context.StepContext.StepInfo;
            var stepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();



            




            if (ScenarioContext.Current.TestError == null)
            {
                if (stepType == "Given")
                {
                    scenario.CreateNode<Given>( stepType + " " + Context.StepContext.StepInfo.Text)
                    .AssignCategory("Steps");
                    
                }

                else if (stepType == "When")
                {
                    scenario.CreateNode<When>(Context.StepContext.StepInfo.Text)
                    .AssignCategory("Steps");

                }
                else if (stepType == "Then")
                {
                    scenario.CreateNode<Then>(Context.StepContext.StepInfo.Text)
                    .AssignCategory("Steps");

                }
                else if (stepType == "And")
                {
                    scenario.CreateNode<And>(Context.StepContext.StepInfo.Text)
                    .AssignCategory("Steps");

                }
            }
            else if (ScenarioContext.Current.TestError != null)
            {

                if (stepType == "Given")
                {
                    scenario.CreateNode<Given>( stepType + " " + Context.StepContext.StepInfo.Text).Fail(Context.StepContext.TestError.Message)
                    .AssignCategory("Steps");

                }

                else if (stepType == "When")
                {
                    scenario.CreateNode<When>(Context.StepContext.StepInfo.Text).Fail(Context.StepContext.TestError.Message)
                    .AssignCategory("Steps");

                }
                else if (stepType == "Then")
                {
                    scenario.CreateNode<Then>(Context.StepContext.StepInfo.Text).Fail(Context.StepContext.TestError.Message)
                    .AssignCategory("Steps");

                }

                

                List<ScenarioExecutionStatus> FailTypes = new List<ScenarioExecutionStatus>();
                FailTypes.Add(ScenarioExecutionStatus.BindingError);
                FailTypes.Add(ScenarioExecutionStatus.TestError);
                FailTypes.Add(ScenarioExecutionStatus.UndefinedStep);

            }

            

            }
            
        }

        

    }
