using AventStack.ExtentReports.MarkupUtils;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium;
using Serilog.Core;
using Serilog.Events;
using Serilog;
using TechTalk.SpecFlow;

namespace AutomationDemo_AlarmApp
{
    [Binding]
    public sealed class Hooks1 : BaseClass
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
            
            AndroidDriver<AndroidElement> driver;

            scenario_name = feature_name.CreateNode(context.ScenarioInfo.Title);
            scenario_name.AssignCategory("<i>Scenario</i>");

            Serilog.Log.Information("Selecting Scenario {0} to run ", ScenarioContext.Current.ScenarioInfo.Title);


        }



        [BeforeTestRun]
        [Obsolete]
        public static void InitializeReport()
        {

            reportpath = (@"D:\\Appium Report.html");
            var htmlReporter = new ExtentHtmlReporter(reportpath);
            htmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Standard;

            extent = new AventStack.ExtentReports.ExtentReports();
            extent.AttachReporter(htmlReporter);


            htmlReporter.Config.DocumentTitle = "Mobile Application Testing Report";
            htmlReporter.Config.ReportName = "Alarm Application";


            extent.AddSystemInfo("<font style='color:blue'>" + "Tested Site", "<font style='color:orange'>Alarm App </font>");
            extent.AddSystemInfo("<font style='color:blue'>" + "Tested By:", "<font style='color:orange'>Devu Mohanan</font>");
            extent.AddSystemInfo("<font style='color:blue'> " + "Environment", "<font style='color:orange'>QA</font>");
            extent.AddSystemInfo("<font style='color:blue'>" + "Machine", "<font style='color:orange'>" + Environment.MachineName);

            LoggingLevelSwitch levelSwitch = new LoggingLevelSwitch(LogEventLevel.Debug);
            Serilog.Log.Logger = new LoggerConfiguration()
                .MinimumLevel.ControlledBy(levelSwitch)
                .WriteTo.File(@"D:\LogsAlarmApp.txt",
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

            Thread.Sleep(1000);
            return ((ITakesScreenshot)driver).GetScreenshot().AsBase64EncodedString;
        }
        public static MediaEntityModelProvider CaptureScreenshot(String Name)
        {
            try
            {

                var screenshot = ((ITakesScreenshot)driver).GetScreenshot().AsBase64EncodedString;
                return MediaEntityBuilder.CreateScreenCaptureFromBase64String(screenshot, Name).Build();


            }
            catch (Exception e)
            {
                Console.WriteLine("skipp");
                return null;
            }
        }

            [BeforeFeature]
        [Obsolete]
        public static void BeforeFeature(FeatureContext context)
        {
            feature_name = extent.CreateTest(context.FeatureInfo.Title);

            feature_name.AssignCategory("<i>Feature</i>");
            
            Serilog.Log.Information("Selecting feature file {0} to run", FeatureContext.Current.FeatureInfo.Title);

        }

        [AfterStep]
        [Obsolete]
        public void InsertReportingSteps(ScenarioContext ScenarioContext)
        {

            var Step_Info = ScenarioContext.StepContext.StepInfo;

            var step_Type = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();

            var media = CaptureScreenshot(ScenarioContext.ScenarioInfo.Title.Trim());

            if (ScenarioContext.TestError == null)
            {
                string base64 = GetScreenshot();
                step_name.Log(Status.Pass, "<b><i><font style='color:slateblue'>" + ScenarioContext.StepContext.StepInfo.Text, MediaEntityBuilder.CreateScreenCaptureFromBase64String(base64).Build());

                step_name.Pass(MarkupHelper.CreateLabel("Passed", ExtentColor.Green));
              
            }
            else if (ScenarioContext.TestError != null)
            {
                string base64 = GetScreenshot();
                step_name.Log(Status.Fail, "<b><i><font style='color:orange'>" + ScenarioContext.StepContext.StepInfo.Text, MediaEntityBuilder.CreateScreenCaptureFromBase64String(base64).Build());

                step_name.Fail(MarkupHelper.CreateLabel("Failed", ExtentColor.Red));
               
            }

            Serilog.Log.Information("After the step: {0} ", ScenarioStepContext.Current.Status);
           
        }

        [BeforeStep]
        public void BeforeStep()
        {
            step_name = scenario_name;
            Serilog.Log.Information("Selecting steps {0} to run", ScenarioStepContext.Current.StepInfo.Text);
            
        }
    }
}
