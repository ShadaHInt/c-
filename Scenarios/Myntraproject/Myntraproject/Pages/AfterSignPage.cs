using OpenQA.Selenium;


namespace Myntraproject
{
    public class AfterSignPage:BaseClass
    {
        IWebDriver WebDriver;
        public AfterSignPage(in IWebDriver driver)
        {

            WebDriver = driver;
            Assert.IsNotNull(WebDriver, "NO Driver instance provided");


        }
        public IWebElement women => WebDriver.FindElement(By.LinkText("WOMEN"));

        public IWebElement kurta => WebDriver.FindElement(By.LinkText("Kurtas & Suits"));

        //.brand-list > li:nth-of-type(1) > .common-customCheckbox.vertical-filters-label > .common-checkboxIndicator
        public IWebElement brand2 => WebDriver.FindElement(By.CssSelector(".brand-list > li:nth-of-type(1) > .common-customCheckbox.vertical-filters-label"));
        //div:nth-of-type(1) > .desktop-navLink > .desktop-backdropStyle > .desktop-paneContent > .desktop-categoryContainer > li:nth-of-type(1) > .desktop-navBlock > li:nth-of-type(3) > .desktop-categoryLink
        public IWebElement cshirts => WebDriver.FindElement(By.LinkText("Casual Shirts"));
        //.price-list > li:nth-of-type(1) > .common-customCheckbox.vertical-filters-label
        public IWebElement price3 => WebDriver.FindElement(By.CssSelector(".price-list > li:nth-of-type(1) > .common-customCheckbox.vertical-filters-label"));
        //div:nth-of-type(3) > .desktop-navLink > .desktop-backdropStyle > .desktop-paneContent > .desktop-categoryContainer > li:nth-of-type(1) > .desktop-navBlock > li:nth-of-type(2) > .desktop-categoryLink
        public IWebElement tshirt => WebDriver.FindElement(By.CssSelector("div:nth-of-type(3) > .desktop-navLink > .desktop-backdropStyle > .desktop-paneContent > .desktop-categoryContainer > li:nth-of-type(1) > .desktop-navBlock > li:nth-of-type(2) > .desktop-categoryLink"));
        //div:nth-of-type(5) > ul > li:nth-of-type(2)
        public IWebElement color1 => WebDriver.FindElement(By.CssSelector("li:nth-of-type(4) > .common-customCheckbox > .colour-colorDisplay.colour-label"));

        public IWebElement men => WebDriver.FindElement(By.CssSelector(".desktop-navLinks .desktop-navContent:nth-of-type(1) .desktop-main"));
        public IWebElement kids => WebDriver.FindElement(By.CssSelector("div:nth-of-type(3) > .desktop-navLink > .desktop-main"));
    }
}
