using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Reflection;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Gherkin.Model;
using System;

namespace Purplle_Web_Automation
{
    [Binding]

    public class Hooks:BaseClass
    {

        //public ScenarioExecutionStatus ScenarioExecutionStatus { get; internal set; }


        //Global Variable for Extend report
        private static ExtentTest featureName;
        private static ExtentTest scenario;
        private static ExtentReports extent;


        //private readonly IObjectContainer _objectContainer;

        //private RemoteWebDriver _driver;

        //public Hooks(IObjectContainer objectContainer)
        //{
        //    _objectContainer = objectContainer;
        //}

        [BeforeTestRun]
        public static void InitializeReport()
        {


            var htmlReporter = new ExtentV3HtmlReporter(@"D:/extentReport5.html");
            htmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;

            extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);

            htmlReporter.Config.DocumentTitle = "Automation Testing Report";
            htmlReporter.Config.ReportName = "Chroma Testing";


            extent.AddSystemInfo("Tested By:", "Shada najeeb");

            extent.AddSystemInfo("Environment", "QA");
            extent.AddSystemInfo("Machine", Environment.MachineName);
            extent.AddSystemInfo("OS", Environment.OSVersion.VersionString);
        }

        [AfterTestRun]
        public static void TearDownReport()
        {
            //Flush report once test completes
            extent.Flush();
        }

        [BeforeFeature]
        public static void BeforeFeature()
        {
            //Create dynamic feature name
            featureName = extent.CreateTest<Feature>(FeatureContext.Current.FeatureInfo.Title);
        }

        [AfterStep]
        public void InsertReportingSteps()
        {

            var stepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();

            //PropertyInfo pInfo = typeof(ScenarioContext).GetProperty("SenarioExecutionStatus", BindingFlags.Instance | BindingFlags.Public);
            //MethodInfo getter = pInfo.GetGetMethod(nonPublic: true);
            //object TestResult = getter.Invoke(ScenarioContext.Current, null);

            //PropertyInfo pInfo = typeof(ScenarioContext).GetProperty("TestStatus", BindingFlags.Instance | BindingFlags.NonPublic);
            //MethodInfo getter = pInfo.GetGetMethod(nonPublic: true);
            //object TestResult = getter.Invoke(ScenarioContext.Current, null);

            if (ScenarioContext.Current.TestError == null)
            {
                if (stepType == "Given")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "When")
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "Then")
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "And")
                    scenario.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text);
            }
            else if (ScenarioContext.Current.TestError != null)
            {

                //var mediaEntity = _parallelConfig.CaptureScreenshotAndReturnModel(_scenarioContext.ScenarioInfo.Title.Trim());


                if (stepType == "Given")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.InnerException);
                else if (stepType == "When")
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.InnerException);
                else if (stepType == "Then")
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);
            }

            //Pending Status
            //if (TestResult.ToString() == "StepDefinitionPending")
            //{
            //    if (stepType == "Given")
            //        scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Skip("Step Definition Pending");
            //    else if (stepType == "When")
            //        scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Skip("Step Definition Pending");
            //    else if (stepType == "Then")
            //        scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Skip("Step Definition Pending");

            //}



            //if (ScenarioStepContext.Current.ToString() == "StepDefinitionPending")
            //{
            //    if (stepType == "Given")
            //        scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Skip("Step Definition Pending");
            //    else if (stepType == "When")
            //        scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Skip("Step Definition Pending");
            //    else if (stepType == "Then")
            //        scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Skip("Step Definition Pending");

            //}

        }


        [BeforeScenario]
        public void Initialize()
        {
            WebDriver = new ChromeDriver();
            scenario = featureName.CreateNode<Scenario>(ScenarioContext.Current.ScenarioInfo.Title);
        }

       



    }
}