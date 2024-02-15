using Mobileapptesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mobileapp2
{
    public class Elements : BaseClass
    {
        AndroidDriver<AndroidElement> driver;

        /// <summary>
        ///     Create a new Navigation page 
        /// </summary>
        /// <param name="driver">Driver instance to be used</param>
        public Elements(in AndroidDriver<AndroidElement> MobileDriver)
        {
            driver = MobileDriver;
            Assert.IsNotNull(MobileDriver, "No MobileDriver provided.");
        }
        //Lets go
        //com.remind.drink.water.hourly:id/ia - by id
        public AndroidElement letsgo => driver.FindElement(By.Id("com.remind.drink.water.hourly:id/ia"));

        //female
        //com.remind.drink.water.hourly:id/j_  - by id
        public AndroidElement female => driver.FindElement(By.Id("com.remind.drink.water.hourly:id/j_"));

        //next
        //com.remind.drink.water.hourly:id/btn_next   -by id
        public AndroidElement next => driver.FindElement(By.Id("com.remind.drink.water.hourly:id/btn_next"));

        ////next
        ////com.remind.drink.water.hourly:id/btn_next   -by id
        //public AndroidElement agreebt => driver.FindElement(By.Id("android:id/button1"));


        ////next
        ////com.remind.drink.water.hourly:id/btn_next   -by id
        //public AndroidElement agreebt => driver.FindElement(By.Id("android:id/button1"));

        ////next
        ////com.remind.drink.water.hourly:id/btn_next   -by id
        //public AndroidElement agreebt => driver.FindElement(By.Id("android:id/button1"));

        //com.remind.drink.water.hourly:id/kj       after creating glass appears
        public AndroidElement glassnxt => driver.FindElement(By.Id("com.remind.drink.water.hourly:id/kj"));

        //start
        //com.remind.drink.water.hourly:id/ed  by id
        public AndroidElement start => driver.FindElement(By.Id("com.remind.drink.water.hourly:id/kj"));












    }
}
