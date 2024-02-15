using OpenQA.Selenium;


namespace Myntraproject
{
    public class Kidscategory3
    {
        IWebDriver WebDriver;
        public Kidscategory3(in IWebDriver driver)
        {

            WebDriver = driver;
            Assert.IsNotNull(WebDriver, "NO Driver instance provided");


        }
        public IWebElement kid => WebDriver.FindElement(By.CssSelector("div:nth-of-type(3) > .desktop-navLink > .desktop-main"));
        ////span[text()='Casual Shirts for Men']
        public IWebElement tshirt => WebDriver.FindElement(By.CssSelector("div:nth-of-type(3) > .desktop-navLink > .desktop-backdropStyle > .desktop-paneContent > .desktop-categoryContainer > li:nth-of-type(1) > .desktop-navBlock > li:nth-of-type(2) > .desktop-categoryLink"));

        //.desktop-navLinks .desktop-navContent:nth-of-type(3) .desktop-oddColumnContent:nth-of-type(2) li:nth-of-type(3) .desktop-categoryLink
        public IWebElement top => WebDriver.FindElement(By.CssSelector(".desktop-navLinks .desktop-navContent:nth-of-type(3) .desktop-oddColumnContent:nth-of-type(2) li:nth-of-type(3) .desktop-categoryLink"));
        //.desktop-navLinks .desktop-navContent:nth-of-type(3) .desktop-oddColumnContent:nth-of-type(3) li:nth-of-type(2) .desktop-categoryLink
        public IWebElement shoes => WebDriver.FindElement(By.CssSelector(".desktop-navLinks .desktop-navContent:nth-of-type(3) .desktop-oddColumnContent:nth-of-type(3) li:nth-of-type(2) .desktop-categoryLink"));

        //Bodysuits
        public IWebElement bsuit => WebDriver.FindElement(By.CssSelector("div:nth-of-type(3) > .desktop-navLink > .desktop-backdropStyle > .desktop-paneContent > .desktop-categoryContainer > li:nth-of-type(4) > .desktop-navBlock > li:nth-of-type(2) > .desktop-categoryLink"));
        //.title-title
        public IWebElement bsuittitle => WebDriver.FindElement(By.CssSelector(".title-title"));
    }
}
