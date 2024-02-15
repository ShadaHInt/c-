using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testingpharmeasy
{
    public class Homepage
    {
        IWebDriver WebDriver;
        public Homepage(in IWebDriver driver)
        {

            WebDriver = driver;
            //Assert.IsNotNull(WebDriver, "NO Driver instance provided");


        }
        public IWebElement pincode => WebDriver.FindElement(By.XPath("//span[text()='Select Pincode']"));
       // c-hyTvNG c-hyTvNG-igUUjPu-css
        public IWebElement pincodeenter => WebDriver.FindElement(By.CssSelector(".c-hyTvNG.c-hyTvNG-igUUjPu-css"));
        //.c-gjdJOs.c-gjdJOs-iceOcKg-css
        public IWebElement pinchk => WebDriver.FindElement(By.CssSelector(".c-gjdJOs.c-gjdJOs-iceOcKg-css"));
        //.c-cZuCZG.c-cZuCZG-dmsdwv-rotate-up.c-cZuCZG-hNOgxQ-size-medium.c-cZuCZG-idqjUdJ-css
        public IWebElement closebt => WebDriver.FindElement(By.CssSelector(".c-cZuCZG.c-cZuCZG-dmsdwv-rotate-up.c-cZuCZG-hNOgxQ-size-medium.c-cZuCZG-idqjUdJ-css"));

        public IWebElement searchbx => WebDriver.FindElement(By.CssSelector(".c-bXbWpx-icOztnM-css .c-cZuCZG-gtZKQU-size-large"));
        public IWebElement searchbxe => WebDriver.FindElement(By.CssSelector("#topBarInput"));

        //.c-bXbWpx-icOztnM-css .c-bXbWpx-lfylVv-direction-row

        //.c-iWbDBM:nth-of-type(3) .c-kkmdlQ-fFohXj-structure-body2
        public IWebElement shampoo => WebDriver.FindElement(By.CssSelector(".c-iWbDBM:nth-of-type(3) .c-kkmdlQ-fFohXj-structure-body2"));
        public IWebElement himalaya => WebDriver.FindElement(By.CssSelector(".c-iWbDBM:nth-of-type(3) .c-bXbWpx-bZJlhX-direction-column"));
        public IWebElement cart => WebDriver.FindElement(By.XPath("//*[@id='__next']/main/div[1]/div[1]/div/div/div[3]/div/div/a/svg"));
        // ._2Saml._9Rsw_.jss41.undefined
        //public IWebElement cartselect => WebDriver.FindElement(By.CssSelector(" ._2Saml._9Rsw_.jss41.undefined"));


    }
}
