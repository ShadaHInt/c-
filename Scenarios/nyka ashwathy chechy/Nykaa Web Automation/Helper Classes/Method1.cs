using AventStack.ExtentReports;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SpecFlow.Internal.Json;
using Microsoft.Extensions.Configuration;
using Nykaa_Web_Automation.Configuration;
using TechTalk.SpecFlow;
using AventStack.ExtentReports.Gherkin.Model;

namespace Nykaa_Web_Automation.Hooks
{
    public class Method1
    {
         public MediaEntityModelProvider CaptureScreenshot(IWebDriver driver, string screenShotName)
            {
               // string localpath = new Uri("F:\\C# programs\\Nykaa Web Automation\\Results\\Screenshot").LocalPath;
                ITakesScreenshot screenshot = (ITakesScreenshot)driver;
                var getscreenshot=screenshot.GetScreenshot().AsBase64EncodedString;
               return MediaEntityBuilder.CreateScreenCaptureFromBase64String(getscreenshot, screenShotName).Build();
            }

        public void AfterStep1(ScenarioContext scenarioContext, ExtentTest scenario, IWebDriver driver)
        {
            var steptype = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();
            DateTime time = DateTime.Now;
            String filename = "Screenshot_" + time.ToString("h_mm_ss") + ".png";


            if (scenarioContext.TestError == null)
            {
                if (steptype == "Given")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);
                else if (steptype == "When")
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text);
                else if (steptype == "Then")
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text);
            }

            else if (scenarioContext.TestError != null)
            {
                if (steptype == "Given")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Fail(scenarioContext.TestError.Message, CaptureScreenshot(driver, filename));
                else if (steptype == "When")
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Fail(scenarioContext.TestError.Message, CaptureScreenshot(driver, filename));
                else if (steptype == "Then")
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Fail(scenarioContext.TestError.Message, CaptureScreenshot(driver, filename));
                // .Log(Status.Fail, method1.CaptureScreenshot(driver, filename));

            }
        }
    }
}
