using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment5
{
    public class Shop
    {
        IWebDriver WebDriver;
        public Shop(in IWebDriver driver)
        {

            WebDriver = driver;
            Assert.IsNotNull(WebDriver, "NO Driver instance provided");


        }
        ////div[@class='Plp__headerHeading']//child::h1[1]
        public IWebElement txt1 => WebDriver.FindElement(By.XPath("//h1[text()='Kids Boys Clothing Shirts']"));
        //.FilterDesktop__newFilterHolder > div:nth-of-type(6) > .Accordion__base  .Accordion__filtHeadLine > .Accordion__iconPlus
        public IWebElement filter => WebDriver.FindElement(By.CssSelector(".FilterDesktop__newFilterHolder > div:nth-of-type(6) > .Accordion__base  .Accordion__filtHeadLine > .Accordion__iconPlus"));

        //div:nth-of-type(2) > .ColourSelect__content > .ColourSelect__color
        public IWebElement clr => WebDriver.FindElement(By.CssSelector("div:nth-of-type(2) > .ColourSelect__content"));

        //a[title^='Pepe Jeans Kids Black Solid Shirt-Pepe Jeans-Apparel-TATA CL'] > .ProductModule__dummyDiv


        public IWebElement item2 => WebDriver.FindElement(By.CssSelector("a[title^='Pepe Jeans Kids Black Solid Shirt-Pepe Jeans-Apparel-TATA CL'] > .ProductModule__dummyDiv"));

        //.ProductDetailsMainCard__productPriceSection h3

        public IWebElement price => WebDriver.FindElement(By.CssSelector(".ProductDetailsMainCard__cancelPrice"));
        //div:nth-of-type(1) > .SizeSelect__base > .SizeSelect__textHolder > h4
        public IWebElement size => WebDriver.FindElement(By.CssSelector("div:nth-of-type(1) > .SizeSelect__base > .SizeSelect__textHolder > h4"));
            //div: nth - of - type(2) > .ProductDescriptionPage__buttonAddToBag > .Button__base
        public IWebElement addbag => WebDriver.FindElement(By.CssSelector("div:nth-of-type(2) > .ProductDescriptionPage__buttonAddToBag > .Button__base"));
        //div:nth-of-type(2) > .ProductDescriptionPage__buttonAddToBag > .Button__base
        public IWebElement gotobag => WebDriver.FindElement(By.CssSelector("div:nth-of-type(2) > .ProductDescriptionPage__buttonAddToBag > .Button__base"));
        //.UnderLinedButton__base
        public IWebElement pinchg => WebDriver.FindElement(By.CssSelector(".UnderLinedButton__base"));
        //.Input2__base.Input2__box > .Input2__hidePlaceholder.Input2__inputBox
        public IWebElement pinenter => WebDriver.FindElement(By.CssSelector(".Input2__base.Input2__box > .Input2__hidePlaceholder.Input2__inputBox"));
        //.BottomSlideModal__content.UnderLinedButton__base
        //.SearchAndUpdate__errorMessage
        public IWebElement emsg => WebDriver.FindElement(By.CssSelector(".SearchAndUpdate__errorMessage"));
        public IWebElement close => WebDriver.FindElement(By.CssSelector(".BottomSlideModal__header > .BottomSlideModal__cancel"));
        //.BottomSlideModal__header > .BottomSlideModal__cancel
        public IWebElement submit => WebDriver.FindElement(By.CssSelector(".BottomSlideModal__content .UnderLinedButton__base"));
        //.Coupon__base
        public IWebElement coupon2 => WebDriver.FindElement(By.CssSelector(".Coupon__base"));
        //div.SlideModal__cancel
        public IWebElement apply => WebDriver.FindElement(By.CssSelector("div:nth-of-type(1) > .CuponDetails__base .CuponDetails__uncheckBoxHolder > .CuponDetails__applyCoupon"));
        ///html//div[@id='root']/div[@class='App__base']/div[@class='CartPage__base']/div[@class='CartPage__pageCenter']//div[@class='Coupon__base']//div[@class='Coupon__couponCodeText']//h3[.='You saved extra ₹118']
        public IWebElement text => WebDriver.FindElement(By.XPath("//*[text()='You saved extra']"));

        //.CartItemForDesktop__removeLabelForCartPage
        public IWebElement remove => WebDriver.FindElement(By.CssSelector(".CartItemForDesktop__removeLabelForCartPage"));
        //.DesktopCheckout__price
        public IWebElement total => WebDriver.FindElement(By.CssSelector(".DesktopCheckout__price"));
        //div:nth-of-type(1) > .EmptyBag__bagImage.EmptyBag__button > .Button__base
        public IWebElement cotinue => WebDriver.FindElement(By.CssSelector("div:nth-of-type(1) > .EmptyBag__bagImage.EmptyBag__button > .Button__base"));
    }
}
