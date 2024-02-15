using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using System.Reflection;
using Newtonsoft.Json.Serialization;
using TechTalk.SpecFlow.Bindings;
using Nykaa_Web_Automation.Helper_Classes;
using OpenQA.Selenium.DevTools;
using Microsoft.Extensions.Logging;

namespace Nykaa_Web_Automation.Hooks
{
    [Binding]

    public sealed class Hooks : BaseClass
    {
        
        public static ExtentReports extent;
        public static ExtentTest feature, scenario;
        ExtentReportHelper reportHelper = new ExtentReportHelper();
        static string reportpath = System.IO.Directory.GetParent(@"../../../")?.FullName
           + Path.DirectorySeparatorChar + "Results"
           + Path.DirectorySeparatorChar + "Result_" + DateTime.Now.ToString("ddMMyyy HHmmss") 
           + Path.DirectorySeparatorChar + @"/CustomizedReport.html";

        [BeforeTestRun]
  
        public static void CreateReport()
        {
            driver = new ChromeDriver();
            ExtentHtmlReporter htmlReport = new ExtentHtmlReporter(reportpath);
            htmlReport.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
            htmlReport.Config.DocumentTitle = "Nykaa Web Automation";
            htmlReport.Config.ReportName = "Nykaa";
            extent = new ExtentReports();
            //extent.AddSystemInfo("Tester Name: ", "Aswathy");
            //extent.AddSystemInfo("Environment", "Automation");
            extent.AttachReporter(htmlReport);

          

        }
        
        [BeforeFeature]
        public static void BeforeFeature(FeatureContext featureContext)
        {
            feature = extent.CreateTest<Feature>(featureContext.FeatureInfo.Title)
                     .AssignCategory(ReadJson().Tags[0]);
           
        }
      
        [BeforeScenario]
        public static void BeforeScenario(ScenarioContext scenarioContext)
        {
            scenario = feature.CreateNode<Scenario>(scenarioContext.ScenarioInfo.Title)
                     .AssignCategory(ReadJson().Tags[1])
                     .AssignAuthor(ReadJson().Author);
               
        }

        [AfterStep]
        public void AfterStep(ScenarioContext scenarioContext)
        {
            string steptype = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();
            string filename = "Screenshot_" + DateTime.Now.ToString("ddMMyyyHHmmss") + ".png";

            if (scenarioContext.TestError == null)
            {
                if (steptype == "Given")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text)
                        .AssignCategory(ReadJson().Tags[2]);
                else if (steptype == "When")
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text)
                        .AssignCategory(ReadJson().Tags[2]);
                else if (steptype == "Then")
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text)
                        .AssignCategory(ReadJson().Tags[2]);
            }

            else if (scenarioContext.TestError != null)
            {
                if (steptype == "Given")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text)
                        .Fail(scenarioContext.TestError.Message, reportHelper.CaptureScreenshot(driver, filename))
                        .AssignCategory(ReadJson().Tags[2]);
                else if (steptype == "When")
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text)
                        .Fail(scenarioContext.TestError.Message, reportHelper.CaptureScreenshot(driver, filename))
                        .AssignCategory(ReadJson().Tags[2]);
                else if (steptype == "Then")
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text)
                        .Fail(scenarioContext.TestError.Message, reportHelper.CaptureScreenshot(driver, filename))
                        .AssignCategory(ReadJson().Tags[2]);

            }
        }
        [AfterTestRun]
        public static void AfterTestRun()
        {
            extent.Flush();
            driver.Quit();
        }
        
    }
}