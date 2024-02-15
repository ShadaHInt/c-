using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mobileappnykaa
{
    public class Sample : BaseClass
    {
        AndroidDriver<AndroidElement> driver;

        /// <summary>
        ///     Create a new Navigation page 
        /// </summary>
        /// <param name="driver">Driver instance to be used</param>
        public Sample(in AndroidDriver<AndroidElement> MobileDriver)
        {
            driver = MobileDriver;
            Assert.IsNotNull(MobileDriver, "No MobileDriver provided.");
        }
        //Lets go
        //com.remind.drink.water.hourly:id/ia - by id
        //public AndroidElement skip => driver.FindElement(By.Id("com.fsn.nykaa:id/tvSkipButton"));

        //public AndroidElement offers => driver.FindElement(By.XPath("//*[contains(@text,'Offers')]"));

        //public AndroidElement categories => driver.FindElement(By.XPath("//*[contains(@text,'Categories')]"));

        //public AndroidElement stream => driver.FindElement(By.XPath("//*[contains(@text,'Stream')]"));

        //public AndroidElement account => driver.FindElement(By.XPath("//*[contains(@text,'Account')]"));

        //public AndroidElement offers => driver.FindElement(By.Xpath("//*[contains(@text,'Offers')]"));

        //public AndroidElement offers => driver.FindElement(By.Xpath("//*[contains(@text,'Offers')]"));


        public AndroidElement categories => driver.FindElement(By.XPath("//*[contains(@text,'Categories')]"));
        ////*[contains(@text,'Kurtas & Suits, Top & Tees, Dresses, Footwear')]

        public AndroidElement women => driver.FindElement(By.XPath("//*[contains(@text,'Kurtas & Suits, Top & Tees, Dresses, Footwear')]"));


        public AndroidElement western => driver.FindElement(By.XPath("//*[contains(@text,'Westernwear')]"));



        public AndroidElement dressjmp => driver.FindElement(By.XPath("//*[contains(@text,'Dresses & Jumpsuits')]"));

        public AndroidElement okay => driver.FindElement(By.XPath("//*[contains(@text,'OKAY, GOT IT')]"));

        public AndroidElement grp => driver.FindElement(By.XPath("//*[contains(@text,'android.view.ViewGroup')]"));

        //android.view.ViewGroup[@content-desc="TOPNAV_CAROUSEL_1_1"]/android.view.ViewGroup/android.widget.ImageView

        public AndroidElement first => driver.FindElement(By.XPath("//android.view.ViewGroup[@content-desc='TOPNAV_CAROUSEL_1_1']"));

        public AndroidElement firstele=> driver.FindElement(By.XPath("(//android.widget.TextView[@content-desc='text_brand'])[1]"));
        //(//android.widget.TextView[@content-desc="text_brand"])[1]
        ////*[contains(@text,'SASSAFRAS')]
        ////*[contains(@text,'ADD TO BAG')]

        public AndroidElement addc => driver.FindElement(By.XPath("//*[contains(@text,'ADD TO BAG')]"));
        ////android.view.ViewGroup[@content-desc="size_select_1"]

        public AndroidElement size => driver.FindElement(By.XPath("//android.view.ViewGroup[@content-desc='size_select_2']"));

        public AndroidElement done => driver.FindElement(By.XPath("//*[contains(@text,'DONE')]"));

        ////*[contains(@text,'GO TO BAG')]

        public AndroidElement gotob => driver.FindElement(By.XPath("//*[contains(@text,'GO TO BAG')]"));

      //  public AndroidElement gotob => driver.FindElement(By.XPath("//*[contains(@text,'GO TO BAG')]"));

    }
}


        //female
        //com.remind.drin