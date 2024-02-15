using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobileapptesting
{
    public class Homepage:BaseClass
    {
        AndroidDriver<AndroidElement> driver;

        /// <summary>
        ///     Create a new Navigation page 
        /// </summary>
        /// <param name="driver">Driver instance to be used</param>
        public Homepage(in AndroidDriver<AndroidElement> MobileDriver)
        {
            driver = MobileDriver;
            Assert.IsNotNull(MobileDriver, "No MobileDriver provided.");
        }

        public AndroidElement agreebt => driver.FindElement(By.Id("android:id/button1"));
        //android.widget.EditText
        public AndroidElement plusicon => driver.FindElement(By.Id("com.android.deskclock:id/add_alarm"));
       // public AndroidElement searchbtspotapp => driver.FindElement(By.XPath("//android.widget.LinearLayout[@content-desc="Search for'spotify app' "]/android.widget.ImageView[1]"));

        public AndroidElement tick => driver.FindElement(By.Id("android:id/button2"));

        public AndroidElement element => driver.FindElement(By.ClassName("android.widget.RelativeLayout')]"));

        public AndroidElement toggleoff => driver.FindElement(By.ClassName("android.widget.CheckBox"));

        public AndroidElement done => driver.FindElement(By.Id("com.android.deskclock:id/set_alarm_done"));
    }
}
