using Myntraproject;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myntra31_01_23.Pages
{
    public class Cart : BaseClass
    {
        IWebDriver WebDriver;
        public Cart(in IWebDriver driver)
        {

            WebDriver = driver;
            Assert.IsNotNull(WebDriver, "NO Driver instance provided");


        }
        public IWebElement men => WebDriver.FindElement(By.CssSelector(".desktop-navLinks .desktop-navContent:nth-of-type(1) .desktop-main"));

        public IWebElement casual => WebDriver.FindElement(By.CssSelector("div:nth-of-type(1) > .desktop-navLink > .desktop-backdropStyle > .desktop-paneContent > .desktop-categoryContainer > li:nth-of-type(1) > .desktop-navBlock > li:nth-of-type(3) > .desktop-categoryLink"));

        public IWebElement firstmen => WebDriver.FindElement(By.XPath("//ul[@class='results-base']//child::li[1]"));


        public IWebElement size1 => WebDriver.FindElement(By.XPath("//div[@class='size-buttons-size-buttons']//child::div[1]"));

        public IWebElement addbag => WebDriver.FindElement(By.CssSelector(".pdp-add-to-bag.pdp-button.pdp-center.pdp-flex"));
        public IWebElement bag => WebDriver.FindElement(By.CssSelector(".desktop-cart > .desktop-userTitle"));

        public IWebElement placeorder => WebDriver.FindElement(By.CssSelector("div:nth-of-type(3) > button[role='button'] > .css-xjhrni"));

        //.desktop-searchBar

        public IWebElement searche => WebDriver.FindElement(By.CssSelector(".desktop-searchBar"));
        public IWebElement searchb => WebDriver.FindElement(By.CssSelector(".desktop-submit > .desktop-iconSearch.myntraweb-sprite.sprites-search"));

        //li:nth-of-type(1) > a[target='_blank']
        public IWebElement elem1 => WebDriver.FindElement(By.CssSelector("li:nth-of-type(1) > a[target='_blank']"));

        //div:nth-of-type(1) > .size-buttons-buttonContainer > .size-buttons-size-button.size-buttons-size-button-default


        public IWebElement elemsize => WebDriver.FindElement(By.CssSelector("div:nth-of-type(1) > .size-buttons-buttonContainer > .size-buttons-size-button.size-buttons-size-button-default"));
    }
}
