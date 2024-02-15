using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using AventStack.ExtentReports.Reporter;
using System.Xml.Linq;
using Nykaa_Web_Automation.Hooks;

namespace Nykaa_Web_Automation.Helper_Classes
{
    public class ExtentReportHelper
    {

        public MediaEntityModelProvider CaptureScreenshot(IWebDriver driver, string screenShotName)
        {
            // string localpath = new Uri("F:\\C# programs\\Nykaa Web Automation\\Results\\Screenshot").LocalPath;
            ITakesScreenshot screenshot = (ITakesScreenshot)driver;
            var getscreenshot = screenshot.GetScreenshot().AsBase64EncodedString;
            return MediaEntityBuilder.CreateScreenCaptureFromBase64String(getscreenshot, screenShotName).Build();
        }


    }
}
