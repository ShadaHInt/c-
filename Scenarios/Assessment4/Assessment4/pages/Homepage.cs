using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment4
{
    public class Homepage
    {
        IWebDriver WebDriver;
        public Homepage(in IWebDriver driver)
        {

            WebDriver = driver;
            Assert.IsNotNull(WebDriver, "NO Driver instance provided");


        }

        public IWebElement logo => WebDriver.FindElement(By.CssSelector(".croma-desktop-logo.custom-s-logo.logo > img[alt='Logo']"));
        public IWebElement coupon => WebDriver.FindElement(By.CssSelector("div#homedatael > div:nth-of-type(2) > div:nth-of-type(1) .StackBanner a > .blur.lazy-load-image-background.lazy-load-image-loaded > img[alt='undefined']"));
        //img[@title='Mobiles']
        public IWebElement mobile => WebDriver.FindElement(By.CssSelector("img[alt='Mobiles']"));
        public IWebElement televison => WebDriver.FindElement(By.CssSelector("img[alt='Televisions']"));

        public IWebElement laptop => WebDriver.FindElement(By.CssSelector("img[alt='Laptops']"));

        public IWebElement audio => WebDriver.FindElement(By.CssSelector("img[alt='Audio']"));
        public IWebElement ac => WebDriver.FindElement(By.CssSelector("img[alt='Air Conditioners']"));

        public IWebElement loc => WebDriver.FindElement(By.CssSelector(".mobile-display-none > svg > path"));
        //div:nth-of-type(1) > input[role = 'presentation']
     public IWebElement pinselect => WebDriver.FindElement(By.CssSelector("div:nth-of-type(1) > input[role = 'presentation']"));
        public IWebElement pinval => WebDriver.FindElement(By.CssSelector("span.pincode.custom-s-pincode"));
        
        public IWebElement contbt => WebDriver.FindElement(By.CssSelector("button#apply-pincode-btn"));

        
        //input[@id='search']
        public IWebElement search => WebDriver.FindElement(By.CssSelector("input#search"));

       // .cp-dropdown.custom-login.user-wrap svg
        public IWebElement login => WebDriver.FindElement(By.CssSelector("button.text-bold.account.font-signin"));
        //.input-login.mobile-input-box
        public IWebElement loginenter => WebDriver.FindElement(By.CssSelector(".card-input-container [type]"));

        public IWebElement cont => WebDriver.FindElement(By.CssSelector(".btn.btn-default.card-button.login-btn"));
        public IWebElement btclose => WebDriver.FindElement(By.XPath("/html/body/div[5]/div[3]/div/button"));
        //button.icon.icon-close
        public IWebElement menu => WebDriver.FindElement(By.CssSelector(".menu-icon-hamb"));

        public IWebElement mob => WebDriver.FindElement(By.XPath("//li[@id='category-Phones and Wearables']//h4[@class='text']"));

        

         public IWebElement mobph => WebDriver.FindElement(By.XPath("//li[@id='category-Mobile Phones']//span[@class='icon icon-path']"));

        public IWebElement iphone => WebDriver.FindElement(By.XPath("//div[@id='Mobile Phones']/a[@href='/phones-wearables/mobile-phones/iphones/c/97']"));





    }
}
