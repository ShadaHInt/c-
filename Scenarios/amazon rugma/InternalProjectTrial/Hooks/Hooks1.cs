using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Serilog;
using Serilog.Core;
using Serilog.Events;
using System.Reflection;
using TechTalk.SpecFlow;

namespace InternalProjectTrial.Hooks
{
    [Binding]
    public sealed class Hooks1 : BaseClass
    {
        
        private static ExtentTest? featureName;
        private static ExtentTest? scenario;
        private static ExtentReports? extent;


        [BeforeTestRun]        
        public static void BeforeTestRun()
        {
            
           //extent report
            var htmlReporter = new ExtentV3HtmlReporter(@"D:/CustomizedProjectReport.html");
            htmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Standard;

            extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);

            htmlReporter.Config.DocumentTitle = "Automation Report";
            htmlReporter.Config.ReportName = "Amazon Application Testing";
           
            extent.AddSystemInfo("Tested By:", "Rugma P");
            extent.AddSystemInfo("Application", "Amazon");
            extent.AddSystemInfo("Environment", "QA");
            extent.AddSystemInfo("Machine", Environment.MachineName);
            extent.AddSystemInfo("OS", Environment.OSVersion.VersionString);
            //log
            LoggingLevelSwitch levelSwitch = new LoggingLevelSwitch(LogEventLevel.Debug);
            Serilog.Log.Logger = new LoggerConfiguration().MinimumLevel.ControlledBy(levelSwitch)
            .WriteTo.File(@"D:\Logs", outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff} | {Level:u3} | {Message} {NewLine}",
             rollingInterval: RollingInterval.Day).CreateLogger();
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
            driver = new ChromeDriver();
           
            //extent report

            scenario = featureName.CreateNode<Scenario>(ScenarioContext.Current.ScenarioInfo.Title);
            Serilog.Log.Information("Selecting scenario {0} to run ", ScenarioContext.Current.ScenarioInfo.Title);

        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();
        }

       
        [BeforeFeature]       
        public static void BeforeFeature()
        {
            //Create dynamic feature name
            featureName = extent.CreateTest<Feature>(FeatureContext.Current.FeatureInfo.Title);
            Serilog.Log.Information("Selecting feature file {0} to run", FeatureContext.Current.FeatureInfo.Title);
        }

        [AfterStep]        
        public void InsertReportingSteps(ScenarioContext scenarioContext)
        {
            var StepInfo = scenarioContext.StepContext.StepInfo;
            var stepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();



            PropertyInfo PInfo = typeof(ScenarioContext).GetProperty("ScenarioExecutionStatus", BindingFlags.Instance | BindingFlags.Public);
            MethodInfo Getter = PInfo.GetGetMethod(nonPublic: true);
            Object TestResult = Getter.Invoke(ScenarioContext.Current, null);




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
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);

                Screenshot Ss = ((ITakesScreenshot)driver).GetScreenshot();
                string screenshot = "image";

                Ss.SaveAsFile(@"D:\" + screenshot + ".png", ScreenshotImageFormat.Png);

                List<ScenarioExecutionStatus> FailTypes = new List<ScenarioExecutionStatus>();
                FailTypes.Add(ScenarioExecutionStatus.BindingError);
                FailTypes.Add(ScenarioExecutionStatus.TestError);
                FailTypes.Add(ScenarioExecutionStatus.UndefinedStep);

            }

            //Pending Status
            if (TestResult.ToString() == "StepDefinitionPending")
            {
                if (stepType == "Given")
                {
                    scenario.CreateNode<Given>(stepType + " " + ScenarioStepContext.Current.StepInfo.Text).Skip("Step Definition Pending");
                }

                else if (stepType == "When")
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Skip("Step Definition Pending");
                else if (stepType == "Then")
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Skip("Step Definition Pending");

            }
            Serilog.Log.Information("After the step: {0} ", ScenarioStepContext.Current.Status);
        }

        [BeforeStep]
        public void BeforeStep()
        {
            Serilog.Log.Information("Selecting steps {0} to run", ScenarioStepContext.Current.StepInfo.Text);
        }
        [BeforeScenarioBlock]
        public void BeforeScenarioBlock()
        {
            Console.WriteLine("In method before Scenario block");
        }
        [AfterScenarioBlock]
        public void AfterascenarioBlock()
        {
            Console.WriteLine("In method after Scenario block");
        }
        [BeforeScenario("@tag1")]
        public void BeforeScenarioWithTag()
        {
            Console.WriteLine("In method before Scenario with tag");
        }

    }
}