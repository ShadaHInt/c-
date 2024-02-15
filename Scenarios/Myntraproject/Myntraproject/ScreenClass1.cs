using AventStack.ExtentReports;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myntraproject
{
    public class ScreenClass1:BaseClass
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
