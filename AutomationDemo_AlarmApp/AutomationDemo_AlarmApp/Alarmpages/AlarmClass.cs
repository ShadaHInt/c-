using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Appium.Interfaces;

namespace AutomationDemo_AlarmApp.Alarmpages
{
    public class AlarmClass: BaseClass
    {
        AndroidDriver<AndroidElement> driver;

        public AlarmClass(in AndroidDriver<AndroidElement> MobileDriver)
        {
            driver = MobileDriver;
            Assert.IsNotNull(MobileDriver, "No MobileDriver provided.");
        }
      
       public AndroidElement Agree => driver.FindElement(By.Id("android:id/button1"));

        
        public AndroidElement AddButton => driver.FindElement(By.XPath("//android.widget.ImageButton[@content-desc=\"Add alarm\"]"));
       
        public AndroidElement Hour => (AndroidElement)driver.FindElement(By.Id("com.android.deskclock:id/hour"));
        //public AndroidElement Ampm => (AndroidElement)driver.FindElement(By.Id("amPm"));
        public AndroidElement minute => (AndroidElement)driver.FindElement(By.Id("com.android.deskclock:id/minute"));
        public AndroidElement Save=> (AndroidElement)driver.FindElement(By.XPath("//android.widget.Button[@content-desc=\"Confirm\"]"));


        public AndroidElement Label => (AndroidElement)driver.FindElement(By.Id("com.android.deskclock:id/edit_label"));
        //public AndroidElement EnterLabel => (AndroidElement)driver.FindElement(By.Id("com.android.deskclock:id/alarm_label"));
        public AndroidElement Ok=> (AndroidElement)driver.FindElement(By.Id("android:id/button1"));
        public AndroidElement AlarmLabel => (AndroidElement)driver.FindElement(By.XPath("//android.widget.TextView[@index=\"3\"]"));
        public AndroidElement EnterLabel => (AndroidElement)driver.FindElement(By.XPath("//android.widget.EditText[@text=\"Enter label\"]"));


        public AndroidElement EditAlarm => (AndroidElement)driver.FindElement(By.XPath("//android.widget.RelativeLayout[4]"));

        public AndroidElement Done => (AndroidElement)driver.FindElement(By.Id("com.android.deskclock:id/set_alarm_done"));
        public AndroidElement Turnoff => (AndroidElement)driver.FindElement(By.XPath("//hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout[1]/android.widget.FrameLayout/android.view.ViewGroup/androidx.viewpager.widget.ViewPager/android.widget.LinearLayout/android.view.ViewGroup/androidx.recyclerview.widget.RecyclerView/android.widget.RelativeLayout[4]/android.widget.FrameLayout/android.widget.CheckBox"));
    }




}
