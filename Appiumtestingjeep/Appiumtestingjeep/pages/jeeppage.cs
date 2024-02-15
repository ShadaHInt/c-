using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appiumtestingjeep.pages
{
    public class jeeppage 
    {
        AndroidDriver<AndroidElement> driver;



        /// <summary>
        ///     Create a new Navigation page 
        /// </summary>
        /// <param name="driver">Driver instance to be used</param>
        public jeeppage(in AndroidDriver<AndroidElement> MobileDriver)
        {
            driver = MobileDriver;
            Assert.IsNotNull(MobileDriver, "No MobileDriver provided.");
        }
       
        public AndroidElement continuebutton => driver.FindElement(By.XPath("//*[contains(@text,'Continue')]"));
    
        public AndroidElement demomode => driver.FindElement(By.XPath("//*[contains(@text,'Demo Mode')]"));
        public AndroidElement allow => driver.FindElement(By.Id("com.android.permissioncontroller:id/permission_allow_button"));
        public AndroidElement settings => driver.FindElement(By.Id("com.fca.myconnect.nafta:id/toolbar_ic_menu"));
        public AndroidElement about => driver.FindElement(By.Id("com.fca.myconnect.nafta:id/drawer_action_about"));
        public AndroidElement backarrow => driver.FindElement(By.Id("com.fca.myconnect.nafta:id/toolbar_back_arrow"));
        public AndroidElement demomodeinfo => driver.FindElement(By.XPath("//*[contains(@text,'Demo Mode information')]"));
        public AndroidElement aboutbackarrow => driver.FindElement(By.Id("com.fca.myconnect.nafta:id/toolbar_back_arrow"));
        public AndroidElement report => driver.FindElement(By.XPath("//*[contains(@text,'Report')]"));
        public AndroidElement chargingsystem => driver.FindElement(By.XPath("//*[contains(@text,'Charging System')]"));
        public AndroidElement safty => driver.FindElement(By.XPath("//*[contains(@text,'Safety')]"));
        public AndroidElement location => driver.FindElement(By.XPath("//*[contains(@text,'Locations')]"));
        public AndroidElement Demomode => driver.FindElement(By.XPath("//*[contains(@text,'Demo Mode')]"));



    }
}
