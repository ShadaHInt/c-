using OpenQA.Selenium;


namespace Myntraproject
{
    public class AddToCartPage:BaseClass
    {
        IWebDriver WebDriver;
        public AddToCartPage(in IWebDriver driver)
        {

            WebDriver = driver;
            Assert.IsNotNull(WebDriver, "NO Driver instance provided");


        }




        public IWebElement kids => WebDriver.FindElement(By.CssSelector("div:nth-of-type(3) > .desktop-navLink > .desktop-main"));

        public IWebElement addbag => WebDriver.FindElement(By.CssSelector(".pdp-add-to-bag.pdp-button.pdp-center.pdp-flex"));

        public IWebElement men => WebDriver.FindElement(By.CssSelector(".desktop-navLinks .desktop-navContent:nth-of-type(1) .desktop-main"));
        //div:nth-of-type(1) > .desktop-navLink > .desktop-backdropStyle > .desktop-paneContent > .desktop-categoryContainer > li:nth-of-type(1) > .desktop-navBlock > li:nth-of-type(3) > .desktop-categoryLink
        public IWebElement casual => WebDriver.FindElement(By.CssSelector("div:nth-of-type(1) > .desktop-navLink > .desktop-backdropStyle > .desktop-paneContent > .desktop-categoryContainer > li:nth-of-type(1) > .desktop-navBlock > li:nth-of-type(3) > .desktop-categoryLink"));
        ////img[@alt='Roadster Men Black & Grey Checked Pure Cotton Casual Shirt']//parent::picture[1]
        public IWebElement firstele => WebDriver.FindElement(By.CssSelector("//img[@alt='Roadster Men Black & Grey Checked Pure Cotton Casual Shirt']//parent::picture[1]"));
        public IWebElement women => WebDriver.FindElement(By.CssSelector("div:nth-of-type(2) > .desktop-navLink > .desktop-main"));
        public IWebElement kurta => WebDriver.FindElement(By.LinkText("Kurtas & Suits"));
        ////img[@alt='Roadster Men Black & Grey Checked Pure Cotton Casual Shirt']//parent::picture[1]
        public IWebElement firstmen => WebDriver.FindElement(By.XPath("//ul[@class='results-base']//child::li[1]"));

        //.pdp-productDescriptorsContainer div:nth-of-type(1) .pdp-product-description-content

        public IWebElement detail1 => WebDriver.FindElement(By.CssSelector(".pdp-productDescriptorsContainer div:nth-of-type(1) .pdp-product-description-content"));
        //div:nth-of-type(1) > .size-buttons-buttonContainer > .size-buttons-size-button.size-buttons-size-button-default > .size-buttons-unified-size
        public IWebElement size1 => WebDriver.FindElement(By.XPath("//div[@class='size-buttons-size-buttons']//child::div[1]"));
        public IWebElement firstw => WebDriver.FindElement(By.XPath("//ul[@class='results-base']//child::li[1]"));

        //.size-buttons-size-buttons .size-buttons-tipAndBtnContainer:nth-of-type(1) .size-buttons-size-button-default
        public IWebElement size2 => WebDriver.FindElement(By.XPath("//div[@class='size-buttons-size-buttons']//child::div[1]"));

        //div:nth-of-type(1) > .user-review-main.user-review-showRating > .user-review-reviewTextWrapper
        public IWebElement review1 => WebDriver.FindElement(By.CssSelector("div:nth-of-type(1) > .user-review-main.user-review-showRating > .user-review-reviewTextWrapper"));

        public IWebElement firstk => WebDriver.FindElement(By.XPath("//img[@alt='A T U N Boys Yellow Classic Striped Casual Shirt']//parent::picture[1]"));
        //.size-buttons-size-buttons .size-buttons-tipAndBtnContainer:nth-of-type(1) .size-buttons-unified-size
        public IWebElement size3 => WebDriver.FindElement(By.CssSelector(".size-buttons-size-buttons .size-buttons-tipAndBtnContainer:nth-of-type(1) .size-buttons-unified-size"));

        //.pdp-productDescriptorsContainer div:nth-of-type(1) .pdp-product-description-content

        public IWebElement detail2 => WebDriver.FindElement(By.CssSelector(".pdp-productDescriptorsContainer div:nth-of-type(1) .pdp-product-description-content"));

        public IWebElement shirts => WebDriver.FindElement(By.CssSelector(".desktop-navLinks .desktop-navContent:nth-of-type(3) .desktop-oddColumnContent:nth-of-type(1) li:nth-of-type(3) .desktop-categoryLink"));

        public IWebElement bag => WebDriver.FindElement(By.CssSelector(".desktop-cart > .desktop-userTitle"));
        //.desktop-cart > .desktop-userTitle
        //div:nth-of-type(3) > button[role='button'] > .css-xjhrni

        public IWebElement placeorder => WebDriver.FindElement(By.CssSelector("div:nth-of-type(3) > button[role='button'] > .css-xjhrni"));



    }
}
