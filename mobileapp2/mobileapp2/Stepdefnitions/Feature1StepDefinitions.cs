using Mobileapptesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;

namespace mobileapp2
{
    [Binding]

    public class Feature1StepDefinitions:BaseClass
    {
        Elements elements => new(driver);
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
        [Given(@"Appium call to app")]
        public void GivenAppiumCallToApp()
        {
            AppiumOptions appiumOptions = new AppiumOptions();

            appiumOptions.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.PlatformVersion, "7");
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.DeviceName, "Redme Note 4");
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.Udid, "f5bfc2ff9804");
            appiumOptions.AddAdditionalCapability("appPackage", "com.remind.drink.water.hourly");
            appiumOptions.AddAdditionalCapability("appActivity", "com.remind.drink.water.hourly.SplashActivity");


            driver = new(new Uri("http://127.0.0.1:4723/wd/hub"), appiumOptions);
            driver.StartRecordingScreen();
        }

        [When(@"Screen appears click on Lets go button")]
        public void WhenScreenAppearsClickOnLetsGoButton()
        {
            elements.letsgo.Click();
        }


        [Then(@"Gender select screen appears and select female")]
        public void ThenGenderSelectScreenAppearsAndSelectFemale()
        {
            elements.female.Click();
        }

        [Then(@"Click next")]
        public void ThenClickNext()
        {
            elements.next.Click();
        }

        [When(@"User select next in  weight screen")]
        public void WhenUserSelectNextInWeightScreen()
        {
            elements.next.Click();
        }

        [Then(@"User select next in wake up time")]
        public void ThenUserSelectNextInWakeUpTime()
        {
            elements.next.Click();
        }

        [When(@"User select next in bed time")]
        public void WhenUserSelectNextInBedTime()
        {
            elements.next.Click();
        }


        [Then(@"User click on start button")]
        public void ThenUserClickOnStartButton()
        {

            // driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.ElementExists(By.Id("com.remind.drink.water.hourly:id/kj")));
            elements.start.Click();
            Thread.Sleep(3000);
            stoprecording();
        }

        





    }
}
