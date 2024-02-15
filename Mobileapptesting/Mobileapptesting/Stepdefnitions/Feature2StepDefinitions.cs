using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using System;
using TechTalk.SpecFlow;

namespace Mobileapptesting.Stepdefnitions
{
    [Binding]
    public class Feature2StepDefinitions:BaseClass
    {


        Homepage homepage => new(driver);
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

        [Given(@"Appium call to clock")]
        public void GivenAppiumCallToClock()
        {
            //AndroidDriver<AndroidElement> driver;
            AppiumOptions appiumOptions = new AppiumOptions();

            appiumOptions.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.PlatformVersion, "7");
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.DeviceName, "Redme Note 4");
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.Udid, "f5bfc2ff9804");
            appiumOptions.AddAdditionalCapability("appPackage", "com.android.deskclock");
            appiumOptions.AddAdditionalCapability("appActivity", "com.android.deskclock.DeskClockTabActivity");


            driver = new(new Uri("http://127.0.0.1:4723/wd/hub"), appiumOptions);
            driver.StartRecordingScreen();
        }

        [When(@"clock opens click on agree button")]
        public void WhenClockOpensClickOnAgreeButton()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            homepage.agreebt.Click();
        }

        [Then(@"Clock screen appears")]
        public void ThenClockScreenAppears()
        {

        }

        [When(@"click on plus icon")]
        public void WhenClickOnPlusIcon()
        {
            homepage.plusicon.Click();
        }

        [Then(@"click on tick")]
        public void ThenClickOnTick()
        {
            homepage.tick.Click();
        }

        [When(@"click on toggle to off")]
        public void WhenClickOnToggleToOff()
        {
            homepage.toggleoff.Click();
            stoprecording();
        }

        //[Then(@"click element and then on delete icon")]
        //public void ThenClickElementAndThenOnDeleteIcon()
        //{
        //    homepage.element.Click();
        //    homepage.done.Click();
        //}
    }
}
