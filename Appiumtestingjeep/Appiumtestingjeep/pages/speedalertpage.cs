using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appiumtestingjeep.pages
{
    public class speedalertpage
    {
        AndroidDriver<AndroidElement> driver;



        /// <summary>
        ///     Create a new Navigation page 
        /// </summary>
        /// <param name="driver">Driver instance to be used</param>
        public speedalertpage(in AndroidDriver<AndroidElement> MobileDriver)
        {
            driver = MobileDriver;
            Assert.IsNotNull(MobileDriver, "No MobileDriver provided.");
        }
        public AndroidElement speed =>driver.FindElement(By.Id("com.fca.myconnect.nafta:id/card_drive_speed_icon"));
        public AndroidElement speedalert =>driver.FindElement(By.Id("com.fca.myconnect.nafta:id/driver_detail_title"));
        public AndroidElement Addnewalert =>driver.FindElement(By.Id("com.fca.myconnect.nafta:id/driver_detail_addnew_image"));
        public AndroidElement editname =>driver.FindElement(By.Id("com.fca.myconnect.nafta:id/alert_creation_title_editicon"));
        public AndroidElement newname =>driver.FindElement(By.Id("com.fca.myconnect.nafta:id/alert_creation_title_til"));

        public AndroidElement plusbutton =>driver.FindElement(By.Id("com.fca.myconnect.nafta:id/speed_selector_plus"));
        public AndroidElement alwayson =>driver.FindElement(By.Id("com.fca.myconnect.nafta:id/alert_creation_alwayson_switch"));
        public AndroidElement monday =>driver.FindElement(By.Id("com.fca.myconnect.nafta:id/second_day_container"));
        public AndroidElement wednesday =>driver.FindElement(By.Id("com.fca.myconnect.nafta:id/fourth_day_container"));
        public AndroidElement done =>driver.FindElement(By.Id("com.fca.myconnect.nafta:id/toolbar_save"));
        public AndroidElement delete =>driver.FindElement(By.Id("com.fca.myconnect.nafta:id/alert_creation_delete_label"));
        public AndroidElement okbutton =>driver.FindElement(By.Id("android:id/button1"));

        public AndroidElement editalert =>driver.FindElement(By.XPath("//android.widget.TextView[@content-desc='Edit Opens settings for Testing Alert']"));


    }
}
