using Appiumtestingjeep.pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Interactions;
using System;
using System.Buffers.Text;
using TechTalk.SpecFlow;

namespace Appiumtestingjeep
{
    [Binding]
    public class JeepfeaturefileStepDefinitions:BaseClass
    {


        jeeppage jeepobj => new(driver);
        speedalertpage speed => new(driver);
        //AndroidDriver<AndroidElement> driver;
        public void record()
        {
            driver.StartRecordingScreen(
               AndroidStartScreenRecordingOptions.GetAndroidStartScreenRecordingOptions().WithTimeLimit(TimeSpan.FromSeconds(10)).WithBitRate(500000).WithVideoSize("720x1280"));
        }
        public void stoprecording()
        {
            string s = driver.StopRecordingScreen();
            byte[] decode = Convert.FromBase64String(s);
            //string path = @"D:\\Screenshots";
            string fileName = @"D:\Recording" + ScenarioContext.Current.ScenarioInfo + "_" + DateTime.Now.ToString("ddMMyy HHmmss") + ".mpeg";
            File.WriteAllBytes(fileName, decode);
        }

        [Given(@"Appium call to the mobile app Jeep")]
        public void GivenAppiumCallToTheMobileAppJeep()
        {
            AppiumOptions appiumOptions = new AppiumOptions();
            
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.PlatformVersion, "10.0");
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.DeviceName, "Redmi 9i");
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.Udid, "IJOVLFBIWCHATCU8");
            appiumOptions.AddAdditionalCapability("appPackage", "com.fca.myconnect.nafta");
            appiumOptions.AddAdditionalCapability("appActivity", "com.fcagroup.global.myuconnect.activity.SplashActivity");

            driver = new(new Uri("http://127.0.0.1:4723/wd/hub"), appiumOptions);
            driver.StartRecordingScreen();

        }

        [When(@"The Jeep app is opened")]
        public void WhenTheJeepAppIsOpened()
        {
           
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(10);
            //click on the continue popup
            jeepobj.continuebutton.Click();
            jeepobj.demomode.Click();
            
            jeepobj.allow.Click();
            Screenshot screenshot = driver.GetScreenshot();
            screenshot.SaveAsFile(@"D:\Screenshots\image1.Png",
            ScreenshotImageFormat.Png);
            
        }

        [When(@"Accept all the permissions")]
        public void WhenAcceptAllThePermissions()
        {
            /*
            jeepobj.settings.Click();
            jeepobj.about.Click();
            jeepobj.demomodeinfo.Click();*/
       
        }
        [When(@"navigate to the demo mode")]
        public void WhenNavigateToTheDemoMode()
        {
            
            /*jeepobj.aboutbackarrow.Click();
            jeepobj.backarrow.Click();*/

        }

        [When(@"click the report option")]
        public void WhenClickTheReportOption()
        {
            
            jeepobj.report.Click();
            jeepobj.chargingsystem.Click();
            driver.Navigate().Back();
        
        }

        [When(@"perform scroll")]
        public void WhenPerformScroll()
        {
            driver.FindElementByAndroidUIAutomator("new UiScrollable(new UiSelector().scrollable(true).instance(0)).scrollIntoView(new UiSelector().textContains(\"Safety\").instance(0))");

            Console.WriteLine("succesfully scrolled to the element Safety");
            Screenshot screenshot = driver.GetScreenshot();
            screenshot.SaveAsFile(@"D:\Screenshots\image2.Png",
            ScreenshotImageFormat.Png);

        }

        [Then(@"return back to the home page")]
        public void ThenReturnBackToTheHomePage()
        {
            driver.Navigate().Back();
        }

        [When(@"home page is opened")]
        public void WhenHomePageIsOpened()
        {
            
            speedalertpage speed = new(driver);

            var lx = jeepobj.location.Location.X;
            var ly = jeepobj.location.Location.Y;

            var dx = jeepobj.demomode.Location.X;
            var dy = jeepobj.demomode.Location.Y;

            var touchActions = new OpenQA.Selenium.Appium.MultiTouch.TouchAction(touchActionPerformer: driver);
            touchActions.Press(lx, ly).Wait(2000).MoveTo(dx, dy).Release().Perform();
        }

        [When(@"click on the speed")]
        public void WhenClickOnTheSpeed()
        {
            speed.speed.Click();
            speed.speedalert.Click();
            Console.WriteLine("clicked on the speed from home page");
               
        }

        [When(@"create new speed alert")]
        public void WhenCreateNewSpeedAlert()
        { 
            speed.Addnewalert.Click();
            speed.editname.Click();
            speed.newname.Clear();
            speed.newname.SendKeys("Testing Alert");
            speed.plusbutton.Click();
            speed.alwayson.Click();
            speed.monday.Click();
            speed.wednesday.Click();
            speed.done.Click();
            Screenshot screenshot = driver.GetScreenshot();
            screenshot.SaveAsFile(@"D:\Screenshots\image3.Png",
            ScreenshotImageFormat.Png);
       
        }
        [When(@"delete the created alert with name Testing Alert")]
        public void WhenDeleteTheCreatedAlertWithNameTestingAlert()
        {
            Boolean display = speed.editalert.Displayed;
            Console.WriteLine("new alert with name Testing alert is created", display);
            speed.editalert.Click();
            speed.delete.Click();
            speed.okbutton.Click();
            Screenshot screenshot2 = driver.GetScreenshot();
            screenshot2.SaveAsFile(@"D:\Screenshots\image4.Png",
            ScreenshotImageFormat.Png);
         
        }

        [Then(@"close the app")]
        public void ThenCloseTheApp()
        {
            driver.CloseApp();
            stoprecording();

        }

    }
}
