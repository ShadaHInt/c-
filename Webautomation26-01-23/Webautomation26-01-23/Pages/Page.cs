using Medicineproject;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webautomation26_01_23.Pages
{
    public class Page : BaseClass1
    {
        IWebDriver WebDriver;
        public Page(in IWebDriver driver)

        {

            WebDriver = driver;
            Assert.IsNotNull(WebDriver, "NO Driver instance provided");


        }

        public IWebElement signin => WebDriver.FindElement(By.CssSelector(".header.panel.show-icon-tablet > .header.links > .authorization-link.link > a"));
        public IWebElement emaila => WebDriver.FindElement(By.CssSelector("input#email"));
        public IWebElement passa => WebDriver.FindElement(By.CssSelector("fieldset #pass"));
        public IWebElement signbt => WebDriver.FindElement(By.CssSelector("fieldset button"));
        public IWebElement stext => WebDriver.FindElement(By.CssSelector(".header.panel.show-icon-tablet > .header.links > .greet.welcome"));



        public IWebElement homeo => WebDriver.FindElement(By.CssSelector("a[title='Homeopathic Medicine']"));
        public IWebElement disease => WebDriver.FindElement(By.CssSelector("a[title='Diseases']"));
        public IWebElement children => WebDriver.FindElement(By.CssSelector("a[title='Children']"));
        public IWebElement newhomeo => WebDriver.FindElement(By.CssSelector(".item.nth-child-2np1.nth-child-3np1.nth-child-4np1.nth-child-5np1.nth-child-6np1.nth-child-7np1.nth-child-8np1.product.product-item > .product-item-info.type1"));

        public IWebElement addc => WebDriver.FindElement(By.CssSelector("button#product-addtocart-button"));



        public IWebElement chk => WebDriver.FindElement(By.CssSelector("button#top-cart-btn-checkout"));
        public IWebElement cmpny => WebDriver.FindElement(By.CssSelector("input[name='company']"));
        public IWebElement addre => WebDriver.FindElement(By.CssSelector("input[name='street[0]']"));
        public IWebElement street1 => WebDriver.FindElement(By.CssSelector("input[name='street[1]']"));
        public IWebElement street2 => WebDriver.FindElement(By.CssSelector("input[name='street[2]']"));
        public IWebElement region => WebDriver.FindElement(By.CssSelector("select[name='region_id']"));
        public IWebElement kerala => WebDriver.FindElement(By.CssSelector("select[name='region_id'] > option[value='550']"));
        public IWebElement city => WebDriver.FindElement(By.CssSelector("input[name='city']"));
        public IWebElement post => WebDriver.FindElement(By.CssSelector("input[name='postcode']"));
        public IWebElement tele => WebDriver.FindElement(By.CssSelector("input[name='telephone']"));
        public IWebElement next3 => WebDriver.FindElement(By.CssSelector("div#shipping-method-buttons-container span"));
        public IWebElement rpay => WebDriver.FindElement(By.CssSelector("#razorpay"));
        public IWebElement proceed => WebDriver.FindElement(By.CssSelector("button[title='Pay with Razorpay']"));
        //.action.action-show-popup
        public IWebElement newadd => WebDriver.FindElement(By.XPath("//div[@id='checkout-step-shipping']/div[@class='new-address-popup']/button[@type='button']/span[.='New Address']"));
        public IWebElement chkbox => WebDriver.FindElement(By.CssSelector("input#shipping-save-in-address-book"));
        public IWebElement shiphere => WebDriver.FindElement(By.CssSelector(".action.action-save-address.primary > span"));

        public IWebElement bag => WebDriver.FindElement(By.CssSelector(".cart-design-2.minicart-wrapper > .action.showcart"));



    }
}