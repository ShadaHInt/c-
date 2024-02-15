using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.MarkupUtils;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using Serilog;
using Serilog.Core;
using Serilog.Events;
using TechTalk.SpecFlow;


namespace Appiumtestingjeep
{
    [Binding]
    public sealed class Hooks1 : BaseClass
    {

        private static AventStack.ExtentReports.ExtentReports? extent;
        private static ExtentTest? scenario;
        //private static AventStack.ExtentReports.ExtentTest? feature;

        private static ExtentTest step;
        private static ExtentTest featureName;
        
        [BeforeTestRun]
        [Obsolete]
        public static void Report()
        {
            var htmlReporter = new ExtentV3HtmlReporter(@"D:\Screenshots\MobileAutionTestReport.html");
            htmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Standard;
            htmlReporter.Config.DocumentTitle = "Automation Testing Report";
            htmlReporter.Config.ReportName = "Jeep Testing Report";
            extent = new AventStack.ExtentReports.ExtentReports();
            extent.AttachReporter(htmlReporter);
            extent.AddSystemInfo("<font style='color:blue'>" + "Mobile Automation", "<font style='color:orange'>Jeep App Testing</font>");
            extent.AddSystemInfo("<font style='color:blue'>" + "Tested By:", "<font style='color:orange'>Akhila Jose</font>");
            extent.AddSystemInfo("<font style='color:blue'> " + "Environment", "<font style='color:orange'>QA</font>");
            extent.AddSystemInfo("<font style='color:blue'>" + "Machine", "<font style='color:orange'>" + Environment.MachineName);
            extent.AddSystemInfo("<font style='color:blue'>" + "OS", "<font style='color:orange'>" + Environment.OSVersion.VersionString);
        }
        [AfterTestRun]
        [Obsolete]
        public static void TearDownReport()
        {

            extent.Flush();

            

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
        public static void BeforeFeature()
        {
            //Create dynamic feature name
            featureName = extent.CreateTest<Feature>(FeatureContext.Current.FeatureInfo.Title);
            
        }

        [AfterStep]
        [Obsolete]
        public void InsertReportingSteps(ScenarioContext ScenarioContext)
        {
            var Step_Info = ScenarioContext.StepContext.StepInfo;

            var step_Type = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();

            var media = CaptureScreenshot(ScenarioContext.ScenarioInfo.Title.Trim());

            if (ScenarioContext.Current.TestError == null)
            {

                if (step_Type == "Given")
                {

                    scenario.CreateNode<Given>("<b><i><font style='color:slateblue'>" + ScenarioStepContext.Current.StepInfo.Text).Pass("", media)
                       .AssignCategory("<i>Step</i>");

                }

                else if (step_Type == "When")
                    scenario.CreateNode<When>("<b><i><font style ='color:slateblue'>" + ScenarioStepContext.Current.StepInfo.Text).Pass("", media)
                        .AssignCategory("<i>Step</i>");

                else if (step_Type == "Then")
                    scenario.CreateNode<Then>("<b><i><font style ='color:slateblue'>" + ScenarioStepContext.Current.StepInfo.Text).Pass("", media)
                        .AssignCategory("<i>Step</i>");

               // Serilog.Log.Information("Selecting steps {0} to run", ScenarioStepContext.Current.StepInfo.Text);

            }
            else if (ScenarioContext.Current.TestError != null)
            {

                if (step_Type == "Given")
                {
                    scenario.CreateNode<Given>("<b><i><font style ='color:red'>" + ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message, media)
                        .AssignCategory("<i>Step</i>");

                }
                else if (step_Type == "When")
                    scenario.CreateNode<When>("<b><i> <font style ='color:red'>" + ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message, media)
                        .AssignCategory("<i>Step</i>");
                else if (step_Type == "Then")
                    scenario.CreateNode<Then>("<b><i><font style ='color:red'>" + ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message, media)
                        .AssignCategory("<i>Step</i>");
                //Serilog.Log.Error("Test step failed | " + ScenarioContext.Current.TestError.Message);
            }
        }
        [BeforeScenario]
        [Obsolete]
        public void Initialize(ScenarioContext context)
        {
            AndroidDriver<AndroidElement> driver;
            
            scenario = featureName.CreateNode<Scenario>(ScenarioContext.Current.ScenarioInfo.Title);
            

    }
       
        [AfterScenario]
        public void AfterScenario()
        {
            Console.WriteLine("After Scenario");
            
        }
        
        
    }

}