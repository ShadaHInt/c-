using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;

namespace mobileappnykaa
{
    [Binding]
    public class Feature2MyntraStepDefinitions:BaseClass
    {
        //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(12));
        Sample elements => new(driver);
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
        [Given(@"appium call to app")]
                
        public void GivenAppiumCallToApp()
        {
            AppiumOptions appiumOptions = new AppiumOptions();

            appiumOptions.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.PlatformVersion, "7");
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.DeviceName, "Redme Note 4");
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.Udid, "f5bfc2ff9804");
            appiumOptions.AddAdditionalCapability("appPackage", "com.myntra.android");
            appiumOptions.AddAdditionalCapability("appActivity", "com.myntra.android.SplashActivity");


            driver = new(new Uri("http://127.0.0.1:4723/wd/hub"), appiumOptions);
            driver.StartRecordingScreen();
        }


        [When(@"Homepage open click on categories")]
        public void WhenHomepageOpenClickOnCategories()
        {
           // wait.Until(ExpectedConditions.ElementExists((By.XPath("//*[contains(@text,'Categories')]"))));
            elements.categories.Click();
        }

        [Then(@"click on women")]
        public void ThenClickOnWomen()
        {

            elements.women.Click();
        }

        [Then(@"click on western wear")]
        public void ThenClickOnWesternWear()
        {
            elements.western.Click();
        }

        [Then(@"click on dress and jumsuits")]
        public void ThenClickOnDressAndJumsuits()
        {
            elements.dressjmp.Click();
        }

        [Then(@"click on casuals")]
        public void ThenClickOnCasuals()
        {
            elements.first.Click();
        }

        [Then(@"click on okey got it in the pop up")]
        public void ThenClickOnOkeyGotItInThePopUp()
        {
            
            elements.okay.Click();
        }

        [Then(@"click on first element")]
        public void ThenClickOnFirstElement()
        {
            elements.firstele.Click();
        }

        [Then(@"click on add to bag")]
        public void ThenClickOnAddToBag()
        {
            elements.addc.Click();
        }

        [Then(@"select size and click on done and goto bag")]
        public void ThenSelectSizeAndClickOnDoneAndGotoBag()
        {
            elements.size.Click();
            elements.done.Click();
            //elements.gotob.Click();
            Thread.Sleep(5000);
            stoprecording();
        }

    }
}
