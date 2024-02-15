using OpenQA.Selenium;


namespace Myntraproject
{
    public class Searchbox
    {
        IWebDriver WebDriver;
        public Searchbox(in IWebDriver driver)
        {

            WebDriver = driver;
            Assert.IsNotNull(WebDriver, "NO Driver instance provided");


        }

        public IWebElement searche => WebDriver.FindElement(By.CssSelector(".desktop-searchBar"));
        //.desktop-searchBar
        //.index-infoBig
        public IWebElement txt => WebDriver.FindElement(By.CssSelector(".index-infoBig"));
        //.desktop-submit > .desktop-iconSearch.myntraweb-sprite.sprites-search
        public IWebElement searchb => WebDriver.FindElement(By.CssSelector(".desktop-submit > .desktop-iconSearch.myntraweb-sprite.sprites-search"));
    }
}
