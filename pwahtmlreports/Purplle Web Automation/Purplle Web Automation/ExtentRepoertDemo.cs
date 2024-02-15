using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purplle_Web_Automation
{
    [TestClass]
    public class ExtentRepoertDemo
    {
        [TestMethod]
        public void ExtentTestCase()
        {
            var htmlReporter = new ExtentHtmlReporter("extentReport.html");
            var extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);


            extent.AddSystemInfo("Operating System:", "Windows 10");
            extent.AddSystemInfo("Hostname:", "SeleniumPC");
            extent.AddSystemInfo("Browser:", "Google Chrome");


            var test = extent.CreateTest("ExtentTestCase");
            test.Log(Status.Info,"step1: Test Case starts");
            test.Log(Status.Pass,"step2: Test Case for pass");

            test.Log(Status.Fail,"step3: Test Case failed");
            test.Pass("Screenshot",MediaEntityBuilder.CreateScreenCaptureFromPath("srceenshot.png").Build());
            test.Pass("Screenshot").AddScreenCaptureFromPath("Screenshot.png");
            extent.Flush();


        }
    }
}
