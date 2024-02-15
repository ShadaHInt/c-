using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium.Chrome;
using Serilog;
using Serilog.Core;
using Serilog.Events;
using TechTalk.SpecFlow;

namespace NoonProject2
{
    [Binding]
    public sealed class Hooks1:BaseClass
    { 
        private static ScenarioContext? _scenarioContext;
        private static FeatureContext? _featureContext;
        private static ExtentReports? _extentReports;
        [Obsolete]
        private static ExtentHtmlReporter? _extentHtmlReporter;
        private static ExtentTest? _feature;
        private static ExtentTest? _scenario;
        
        [BeforeTestRun]
        [Obsolete]
        public static void BeforeTestRun()
        {
            _extentHtmlReporter = new ExtentHtmlReporter(@"D:/CustomizedProjectReport3.html");
            _extentHtmlReporter.Config.ReportName = "testreport.html";
            _extentHtmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Standard;
            _extentReports = new ExtentReports();
            _extentReports.AttachReporter(_extentHtmlReporter);
             

            _extentHtmlReporter.Config.DocumentTitle = "Automation Report";
            _extentHtmlReporter.Config.ReportName = "<img src='D:/Noon logo.png'/width='80'height='40'> Noon Application Testing";


            _extentReports.AddSystemInfo("<b>Tested By:</b>", "<b>Rugma P</b>");
            _extentReports.AddSystemInfo("<i><mark>Application</mark></i>", "<i><mark>PetsWorld</mark></i>");
            _extentReports.AddSystemInfo("<i><mark>Environment</mark></i>", "<i><mark>QA</mark></i>");
            _extentReports.AddSystemInfo("<i>Machine</i>", Environment.MachineName);
            _extentReports.AddSystemInfo("<i>OS</i>", Environment.OSVersion.VersionString);

            //log
            LoggingLevelSwitch levelSwitch = new LoggingLevelSwitch(LogEventLevel.Debug);
            Serilog.Log.Logger = new LoggerConfiguration().MinimumLevel.ControlledBy(levelSwitch)
            .WriteTo.File(@"D:\Log", outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff} | {Level:u3} | {Message} {NewLine}",
             rollingInterval: RollingInterval.Day).CreateLogger();
        }

        [BeforeFeature]
        public static void BeforeFeatureStart(FeatureContext featureContext)
        {
            if (null != featureContext)
            {
                _featureContext = featureContext;
                _feature = _extentReports.CreateTest<Feature>(featureContext.FeatureInfo.Title, featureContext.FeatureInfo.Description);
            }

            Serilog.Log.Information("Selecting feature file {0} to run", FeatureContext.Current.FeatureInfo.Title);
        }

       [BeforeScenario]
        public void BeforeScenario(ScenarioContext scenarioContext)
        {
            driver = new ChromeDriver();
            CmnMethod.Max();
            if (null != scenarioContext)
            {
                _scenarioContext = scenarioContext;
                _scenario = _feature.CreateNode<Scenario>(scenarioContext.ScenarioInfo.Title, scenarioContext.ScenarioInfo.Description);
            }
            
            Serilog.Log.Information("Selecting scenario {0} to run ", ScenarioContext.Current.ScenarioInfo.Title);
            
        }

        [AfterStep]
        public void AfterEachStep()
        {

            ScenarioBlock scenarioBlock = _scenarioContext.CurrentScenarioBlock;

            switch (scenarioBlock)
            {
                case ScenarioBlock.Given:
                   
                    CreateNode<Given>();
                    break;
                case ScenarioBlock.When:
                    
                    CreateNode<When>();
                    break;
                case ScenarioBlock.Then:
                   
                    CreateNode<Then>();
                    break;
                default:
                    
                    CreateNode<And>();

                    break;
            }

            Serilog.Log.Information("After the step: {0} ", ScenarioStepContext.Current.Status);

        }

        public void CreateNode<T>() where T : IGherkinFormatterModel
        {
            

            if (_scenarioContext.TestError != null)
            {
                string name = @"D:\" + _scenarioContext.ScenarioInfo.Title.Replace(" ", "") + ".jpeg";
                CmnMethod.TakeScreenShot(name);
                _scenario.CreateNode<T>("<font style = 'color:tomato'>" + _scenarioContext.StepContext.StepInfo.Text).Fail(_scenarioContext.TestError.Message + "\n" + _scenarioContext.TestError.StackTrace)
                    .AddScreenCaptureFromPath(name);
            }
            else
            {
                string name = @"D:\" + _scenarioContext.ScenarioInfo.Title.Replace(" ", "") + ".jpeg";
                CmnMethod.TakeScreenShot(name);
                _scenario.CreateNode<T>("<font style = 'color:Violet'>" + _scenarioContext.StepContext.StepInfo.Text).Pass("").AddScreenCaptureFromPath(name);
            }
           
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Console.WriteLine("AfterScenario Hook");
            if (_scenarioContext.TestError != null)
            {
                string name = _scenarioContext.ScenarioInfo.Title.Replace(" ", "") + ".jpeg";
                CmnMethod.TakeScreenShot(name);
                Console.WriteLine(_scenarioContext.TestError.Message);
                Console.WriteLine(_scenarioContext.TestError.StackTrace);
            }
            _scenario.AssignAuthor("Tested by: Rugma");
            driver.Quit();
        }

        

        [AfterTestRun]
        public static void TearDownReport()
        {
            //Flush report
            _extentReports.Flush();
        }

       




    }
}