using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment5
{
    public class Homepage
    {
        IWebDriver WebDriver;
        public Homepage(in IWebDriver driver)
        {

            WebDriver = driver;
            Assert.IsNotNull(WebDriver, "NO Driver instance provided");


        }
        //button[@id='wzrk-confirm']
        public IWebElement pop1 => WebDriver.FindElement(By.XPath("//button[@id='wzrk-confirm']"));
        ////a[@href='javascript:void(0);']
        public IWebElement pop2 => WebDriver.FindElement(By.CssSelector("a.wzrkClose"));
        //.DesktopHeader__logoHolder
        public IWebElement logo => WebDriver.FindElement(By.CssSelector(".DesktopHeader__logoHolder"));
        //div:nth-of-type(1) > .BankBanner__center
        public IWebElement coupon => WebDriver.FindElement(By.CssSelector("div:nth-of-type(1) > .BankBanner__center"));
        public IWebElement west => WebDriver.FindElement(By.CssSelector("div:nth-of-type(1) > .QuickLinks__quickLinkImageHolder > .QuickLinks__imageHolder > .Image__base > img[alt='No Image']"));
        public IWebElement womenswear => WebDriver.FindElement(By.CssSelector("div:nth-of-type(2) > .QuickLinks__quickLinkImageHolder > .QuickLinks__imageHolder > .Image__base > img[alt='No Image']"));

        public IWebElement beauty => WebDriver.FindElement(By.CssSelector("div:nth-of-type(3) > .QuickLinks__quickLinkImageHolder > .QuickLinks__imageHolder > .Image__base > img[alt='No Image']"));

        public IWebElement footwear => WebDriver.FindElement(By.CssSelector("div:nth-of-type(4) > .QuickLinks__quickLinkImageHolder > .QuickLinks__imageHolder > .Image__base > img[alt='No Image']"));
        public IWebElement men => WebDriver.FindElement(By.CssSelector("div:nth-of-type(5) > .QuickLinks__quickLinkImageHolder > .QuickLinks__imageHolder > .Image__base > img[alt='No Image']"));

        //.DesktopHeader__leftTabHolder > div:nth-of-type(1)
        public IWebElement category => WebDriver.FindElement(By.CssSelector(".DesktopHeader__leftTabHolder > div:nth-of-type(1)"));

        public IWebElement kids => WebDriver.FindElement(By.CssSelector(".DesktopHeader__categoriesHolder > div:nth-of-type(1) > div:nth-of-type(3)"));

         public IWebElement boy => WebDriver.FindElement(By.CssSelector(".DesktopHeader__subCategoryDetailsHolder > a:nth-of-type(14)"));
    }
}
