using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.MarkupUtils;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Selenium.Axe;
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

        private static ExtentTest? scenario_name;
        private static AventStack.ExtentReports.ExtentReports? extent;
        private static string? reportpath;
        private static AventStack.ExtentReports.ExtentTest? feature_name;
        private static ExtentTest? step_name;


        [BeforeTestRun]        
        public static void BeforeTestRun()
        {
            
           //extent report
            var htmlReporter = new ExtentHtmlReporter(@"D:/CustomizedProjectReport.html");
            htmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Standard;

            extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);

            htmlReporter.Config.DocumentTitle = "Automation Report";
            htmlReporter.Config.ReportName = "Amazon Application Testing";
           
            extent.AddSystemInfo("Tested By:", "Shada Najeeb");
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

        public string GetScreenshot()
        {
            return ((ITakesScreenshot)driver).GetScreenshot().AsBase64EncodedString;
        }


        [BeforeScenario]
        public void Initialize(ScenarioContext context)
        {
            driver = new ChromeDriver();

            scenario_name = feature_name.CreateNode(context.ScenarioInfo.Title);
            scenario_name.AssignCategory("<i>Scenario</i>");
            Serilog.Log.Information("Selecting scenario {0} to run ", ScenarioContext.Current.ScenarioInfo.Title);

        }

        

        [BeforeFeature]
        public static void BeforeFeature(FeatureContext context)
        {


            feature_name = extent.CreateTest(context.FeatureInfo.Title);

            feature_name.AssignCategory("<i>Feature</i>");
            //Common.Style();
            Serilog.Log.Information("Selecting feature file {0} to run", FeatureContext.Current.FeatureInfo.Title);

        }

        [AfterStep]
        public void InsertReportingSteps(ScenarioContext Context)
        {
            if (Context.TestError == null)
            {
                string base64 = GetScreenshot();
                step_name.Log(Status.Pass, "<b><i><font style='color:slateblue'>" + Context.StepContext.StepInfo.Text, MediaEntityBuilder.CreateScreenCaptureFromBase64String(base64).Build());

                step_name.Pass(MarkupHelper.CreateLabel("Pass", ExtentColor.Green));
                //step_name.AssignCategory("<i>Step</i>");
            }
            else if (Context.TestError != null)
            {
                string base64 = GetScreenshot();
                step_name.Log(Status.Fail, "<b><i><font style='color:orange'>" + Context.StepContext.StepInfo.Text, MediaEntityBuilder.CreateScreenCaptureFromBase64String(base64).Build());

                step_name.Fail(MarkupHelper.CreateLabel("Fail", ExtentColor.Red));
                //step_name.AssignCategory("<i>Step</i>");
            }

            Serilog.Log.Information("After the step: {0} ", ScenarioStepContext.Current.Status);
            //step_name.AssignCategory("<i>Step</i>");
        }

        [BeforeStep]
        public void BeforeStep()
        {
            step_name = scenario_name;
            Serilog.Log.Information("Selecting steps {0} to run", ScenarioStepContext.Current.StepInfo.Text);
            //step_name.AssignCategory("<i>Step</i>");
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
        }
        [AfterScenario]
        public static void AfterScenario1()
        {
            //Accessbility
            Thread.Sleep(5000);
            AxeResult results = driver.Analyze();
            //Thread.Sleep(5000);
            string path = @"D:\\AxeReportamazon.html";
            driver.CreateAxeHtmlReport(results, path);
            //driver.Quit();
        }
        [AfterFeature]
        public static void AfterFeature()
        {
            Thread.Sleep(1000);
            driver.Quit();
        }
    }
}