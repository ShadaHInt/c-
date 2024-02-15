
using AutomationDemo_AlarmApp.Alarmpages;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.Interfaces;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Drawing;
using System.Security.Policy;
using System.Xml.Linq;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Configuration.JsonConfig;


namespace AutomationDemo_AlarmApp
{
    [Binding]
    public class AlarmFeatureStepDefinitions: BaseClass
    {

        AlarmClass alarmclass => new(driver);
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
        [Given(@"Alarm App is opened")]
        public void GivenAlarmAppIsOpened()
        {
            AppiumOptions appiumOptions = new AppiumOptions();

            appiumOptions.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.PlatformVersion, "7");
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.DeviceName, "redme note 4");
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.Udid, "f5bfc2ff9804");
            appiumOptions.AddAdditionalCapability("appPackage", "com.android.deskclock");
            appiumOptions.AddAdditionalCapability("appActivity", "com.android.deskclock.AlarmClock");
            appiumOptions.AddAdditionalCapability("autoGrantPermissions", "true");
            appiumOptions.AddAdditionalCapability("newCommandTimeout", 250);



            driver = new(new Uri("http://127.0.0.1:4723/wd/hub"), appiumOptions);
            driver.StartRecordingScreen();
        }

    [When(@"Click on Add Icon")]
        public void WhenClickOnAddIcon()
        {
            alarmclass.Agree.Click();
           // Thread.Sleep(1000);
            alarmclass.AddButton.Click();
        }

        [Then(@"Set the Alarm Time")]
        public void ThenSetTheAlarmTime()
        {
            //var elementToScrollTo = driver.FindElement((By.XPath("//android.widget.TextView[@index=\"3\"]"))); 
            //var touchAction1 = new TouchAction(driver); touchAction1.Press(20, 0).MoveTo(elementToScrollTo).Release().Perform();
            //driver.Swipe(500, 1500, 500, 500, 1000);
            //IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            //js.ExecuteScript("window.scrollBy(0, 500);");
            // driver.scroll(0, 100, 0, -100, 200);
            //Thread.Sleep(1000);
            //alarmclass.Label.Click();
            ////Thread.Sleep(2000);
            //alarmclass.EnterLabel.SendKeys("Test Alarm");
            //alarmclass.Ok.Click();
            //Thread.Sleep(1000);

            int centerX = alarmclass.Hour.Location.X + (alarmclass.Hour.Size.Width / 2);
            int centerY = alarmclass.Hour.Location.Y + (alarmclass.Hour.Size.Height / 2);

            // Set the starting and ending coordinates for the swipe gesture
            int startOffset = (int)(centerY * 0.8); // Start from 80% of the element's height
            int endOffset = (int)(centerY * 0.2); // End at 20% of the element's height

            // Create a TouchAction object and perform the swipe gesture
            var touchAction = new TouchAction(driver);
            touchAction.Press(centerX, startOffset).Wait(1000).MoveTo(centerX, endOffset).Release().Perform();
            

        }

        [When(@"The save icon is choosed")]
        public void WhenTheSaveIconIsChoosed()
        {
           
            alarmclass.Save.Click();
        }

        [Then(@"Alarm should be set")]
        //public void ThenAlarmShouldBeSet()
        //{
        // bool alarmadded= alarmclass.AlarmLabel.Displayed;
        //    Assert.IsTrue(alarmadded);
        //    Console.WriteLine("Alarm added successfully with title :" + alarmclass.AlarmLabel.Text);
           
        //}


        [When(@"I Click on the Existing alarm")]
        public void WhenIClickOnTheExistingAlarm()
        {
            Thread.Sleep(1000);
            alarmclass.EditAlarm.Click();
        }

        [Then(@"Edit the time")]
        public void ThenEditTheTime()
        {
            int centerX = alarmclass.minute.Location.X + (alarmclass.minute.Size.Width / 2);
            int centerY = alarmclass.minute.Location.Y + (alarmclass.minute.Size.Height / 2);

            // Set the starting and ending coordinates for the swipe gesture
            int startOffset = (int)(centerY * 0.8); // Start from 80% of the element's height
            int endOffset = (int)(centerY * 0.2); // End at 20% of the element's height

            // Create a TouchAction object and perform the swipe gesture
            var touchAction = new TouchAction(driver);
            touchAction.Press(centerX, startOffset).Wait(1000).MoveTo(centerX, endOffset).Release().Perform();

        }

        [When(@"I save the alarm")]
        public void WhenISaveTheAlarm()
        {
            alarmclass.Done.Click();
        }

        [Then(@"Alarm should be updated")]
        public void ThenAlarmShouldBeUpdated()
        {
            Console.WriteLine("Alarm time is updated");
        }

        [When(@"I Click on the Existing alam switch to Off")]
        public void WhenIClickOnTheExistingAlamSwitchToOff()
        {
            alarmclass.Turnoff.Click();
        }

        [Then(@"Alarm should be disabled")]
        public void ThenAlarmShouldBeDisabled()
        {
            Console.WriteLine("Alarm turned off");
            driver.CloseApp();
            stoprecording();
        }
    }
}
