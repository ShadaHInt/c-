using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newprojectspecflow.Pages
{
    public class Secondpage : BaseClass
    {
        public Secondpage(in IWebDriver driver){
            }
        //public IWebElement mobileacc => driver.FindElement(By.XPath("//a[@aria-label='Mobiles & Accessories']"));
        //public IWebElement mobile => driver.FindElement(By.XPath("//a[text()='Mobiles']"));
        //public IWebElement firstphone => driver.FindElement(By.CssSelector("img[alt^='OnePlus Nord CE 2 Lite 5G (Blue Tide, 6GB RAM, 128GB Storage']"));
        public IWebElement mobile => driver.FindElement(By.CssSelector(".celwidget.s-spacing-small.s-widget-container.s-widget-container-height-small.slot\\=MAIN.template\\=SEARCH_RESULTS.widgetId\\=search-results_2 .aok-relative.puis-spacing-small.s-height-equalized.s-padding-left-small.s-padding-right-small.s-product-image-container.s-text-center > .rush-component > .a-link-normal.s-no-outline  img[alt^='OnePlus Bullets Z2 Bluetooth Wireless in Ear Earphones with ']"));
        //input#add-to-cart-button
        public IWebElement addc => driver.FindElement(By.CssSelector("input#add-to-cart-button"));
    }
}
