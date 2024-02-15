using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.MarkupUtils;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Selenium.Axe;
//using OpenQA.Selenium.Edge;
using Serilog;
using Serilog.Core;
using Serilog.Events;
using System.Linq;
using System.Reflection;
using TechTalk.SpecFlow;

namespace NewUWebAutomation
{
    [Binding]
    public sealed class Hooks:BaseClass
    {
        //private static ExtentTest? featureName;
        private static ExtentTest? scenario;
        private static AventStack.ExtentReports.ExtentReports? extent;
        private static string? reportpath;
        private static AventStack.ExtentReports.ExtentTest? feature;
        private static ExtentTest? step;
        
        

        [BeforeScenario]
        [Obsolete]
        public void Initialize(ScenarioContext context)
        {
            driver = new ChromeDriver();
            //driver = new EdgeDriver();

            CommonCodes.Maxi();
            AxeResult results = driver.Analyze();
            string path = "D:\\AxeReport233.html";
            driver.CreateAxeHtmlReport(results, path);
            scenario = feature.CreateNode(context.ScenarioInfo.Title);
            Serilog.Log.Information("Selecting Scenario file {0} to run ", ScenarioContext.Current.ScenarioInfo.Title);
          
        }
        [BeforeTestRun]
        [Obsolete]
        public static void InitializeReport()
        {

            reportpath = (@"D:\Custom.html");
            var htmlReporter = new ExtentV3HtmlReporter(reportpath);
            htmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
  
            extent = new AventStack.ExtentReports.ExtentReports();
            extent.AttachReporter(htmlReporter);
           

            htmlReporter.Config.DocumentTitle = "Automation Testing Report";
            htmlReporter.Config.ReportName = "NewU Testing";


            extent.AddSystemInfo("Tested By:", "<font style='color:yellow'>"+"Amal Santhosh");

            extent.AddSystemInfo("Environment", "<font style='color:Blue'>" + "QA");
            extent.AddSystemInfo("Machine", Environment.MachineName);
            extent.AddSystemInfo("OS", Environment.OSVersion.VersionString);

            
          


            //log
            LoggingLevelSwitch levelSwitch = new LoggingLevelSwitch(LogEventLevel.Debug);
            Serilog.Log.Logger = new LoggerConfiguration()
                .MinimumLevel.ControlledBy(levelSwitch)
                .WriteTo.File(@"D:\NewULogs",
                outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff} | {Level:u3} | {Message} {NewLine}",
                rollingInterval: RollingInterval.Day).CreateLogger();

        }
        [AfterTestRun]
        public static void TearDownReport()
        {
            extent.Flush();
            
        }
        public string GetScreenshot()
        {
            return ((ITakesScreenshot)driver).GetScreenshot().AsBase64EncodedString;
        }

        [BeforeFeature]
        [Obsolete]
        public static void BeforeFeature(FeatureContext context)
        {
            //Create dynamic feature name

            feature = extent.CreateTest(context.FeatureInfo.Title);
            Serilog.Log.Information("Selecting feature file {0} to run", FeatureContext.Current.FeatureInfo.Title);
            
        }


        [AfterStep]
        [Obsolete]
        public void InsertReportingSteps(ScenarioContext Context)
        {

            if (Context.TestError == null)
            {
                string base64 = GetScreenshot();
                step.Log(Status.Pass, "<font style='color:green'>" + Context.StepContext.StepInfo.Text, MediaEntityBuilder.CreateScreenCaptureFromBase64String(base64).Build());
                step.Pass(MarkupHelper.CreateLabel("Pass", ExtentColor.Cyan));
                step.AssignCategory("<i>Step</i>");
            }
            else if (Context.TestError != null)
            {
                string base64 = GetScreenshot();
                step.Log(Status.Fail, "<font style='color:red'>" + Context.StepContext.StepInfo.Text, MediaEntityBuilder.CreateScreenCaptureFromBase64String(base64).Build());
                step.Fail(MarkupHelper.CreateLabel("Fail", ExtentColor.Orange));
                step.AssignCategory("<i>Step</i>");
            }

            Serilog.Log.Information("After the step: {0} ", ScenarioStepContext.Current.Status);
            step.AssignCategory("<i>Step</i>");

        }
        [BeforeStep]
        public void BeforeStep()
        {
            step = scenario;
            Serilog.Log.Information("Selecting steps {0} to run", ScenarioStepContext.Current.StepInfo.Text);
            step.AssignCategory("<i>Step</i>");
        }

        [AfterFeature]
        public static void AfterFeature()
        {
           driver.Quit();
        }
        [AfterScenario]
        public void AfterScenario()
        {
            step.AssignAuthor("AmalSanthosh");
            step.AssignCategory("<i>Scenario</i>");
        }
    }
}