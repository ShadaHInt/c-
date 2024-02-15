using OpenQA.Selenium;


namespace Myntraproject
{
    public class Category2
    {
        IWebDriver WebDriver;
        public Category2(in IWebDriver driver)
        {

            WebDriver = driver;
            Assert.IsNotNull(WebDriver, "NO Driver instance provided");


        }

        public IWebElement men => WebDriver.FindElement(By.CssSelector(".desktop-navLinks .desktop-navContent:nth-of-type(1) .desktop-main"));
        public IWebElement women => WebDriver.FindElement(By.CssSelector("div:nth-of-type(2) > .desktop-navLink > .desktop-main"));
        public IWebElement kids => WebDriver.FindElement(By.CssSelector("div:nth-of-type(3) > .desktop-navLink > .desktop-main"));
        public IWebElement home => WebDriver.FindElement(By.CssSelector("div:nth-of-type(4) > .desktop-navLink > .desktop-main"));
        public IWebElement beauty => WebDriver.FindElement(By.CssSelector("div:nth-of-type(5) > .desktop-navLink > .desktop-main"));
        //div:nth-of-type(5) > .desktop-navLink > .desktop-backdropStyle > .desktop-paneContent > .desktop-categoryContainer > li:nth-of-type(3) > .desktop-navBlock > li:nth-of-type(11) > .desktop-categoryLink
        public IWebElement perfume => WebDriver.FindElement(By.CssSelector("div:nth-of-type(5) > .desktop-navLink > .desktop-backdropStyle > .desktop-paneContent > .desktop-categoryContainer > li:nth-of-type(3) > .desktop-navBlock > li:nth-of-type(11) > .desktop-categoryLink"));
        public IWebElement studio => WebDriver.FindElement(By.CssSelector("div:nth-of-type(6) > .desktop-navLink > .desktop-main"));



    }
}
