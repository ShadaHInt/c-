

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Serilog;
using Serilog.Core;
using Serilog.Events;
using TechTalk.SpecFlow;
using AventStack.ExtentReports.MarkupUtils;
using System.Reflection;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Gherkin.Model;

using Selenium.Axe;

namespace Medicineproject
{
    [Binding]


    public sealed class Hooks1 : BaseClass1
    {

        private static ExtentTest? scenario_name;
        private static AventStack.ExtentReports.ExtentReports? extent;
        private static string? reportpath;
        private static AventStack.ExtentReports.ExtentTest? feature_name;
        private static ExtentTest? step_name;




        [BeforeScenario]
        [Obsolete]
        public void Initialize(ScenarioContext context)
        {
            driver = new ChromeDriver();
            Common.Maximise();

            scenario_name = feature_name.CreateNode(context.ScenarioInfo.Title);
            scenario_name.AssignCategory("<i>Scenario</i>");

            Serilog.Log.Information("Selecting Scenario {0} to run ", ScenarioContext.Current.ScenarioInfo.Title);


        }



        [BeforeTestRun]
        [Obsolete]
        public static void InitializeReport()
        {

            reportpath = (@"D:\index.html");
            var htmlReporter = new ExtentHtmlReporter(reportpath);
            htmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Standard;

            extent = new AventStack.ExtentReports.ExtentReports();
            extent.AttachReporter(htmlReporter);


            htmlReporter.Config.DocumentTitle = "Automation Testing Report";
            htmlReporter.Config.ReportName = "<img src ='D:/online_medical_logo.png'/width='80'height='40'>Onlinemedicine Store";




            extent.AddSystemInfo("<font style='color:blue'>" + "Tested Site", "<font style='color:orange'>OnlineMedicine Store</font>");

            extent.AddSystemInfo("<font style='color:blue'>" + "Tested By:", "<font style='color:orange'>Shada Najeeb</font>");
            extent.AddSystemInfo("<font style='color:blue'> " + "Environment", "<font style='color:orange'>QA</font>");
            extent.AddSystemInfo("<font style='color:blue'>" + "Machine", "<font style='color:orange'>" + Environment.MachineName);

            LoggingLevelSwitch levelSwitch = new LoggingLevelSwitch(LogEventLevel.Debug);
            Serilog.Log.Logger = new LoggerConfiguration()
                .MinimumLevel.ControlledBy(levelSwitch)
                .WriteTo.File(@"D:\Logs.txt",
                outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff} | {Level:u3} | {Message} {NewLine}|",
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


            feature_name = extent.CreateTest(context.FeatureInfo.Title);

            feature_name.AssignCategory("<i>Feature</i>");
            //Common.Style();
            Serilog.Log.Information("Selecting feature file {0} to run", FeatureContext.Current.FeatureInfo.Title);

        }

        [AfterStep]
        [Obsolete]
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
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
        }





        [AfterScenario]
        public static void AfterScenario()
        {
            //Accessbility
            AxeResult results = driver.Analyze();
            string path = "D:\\AxeReportmedicine.html";
            driver.CreateAxeHtmlReport(results, path);
            driver.Quit();
        }
        [AfterFeature]
        public static void AfterFeature()
        {

            Thread.Sleep(1000);
            driver.Quit();
        }


    }
}



