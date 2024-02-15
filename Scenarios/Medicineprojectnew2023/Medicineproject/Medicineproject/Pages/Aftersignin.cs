using OpenQA.Selenium;


namespace Medicineproject
{
    public class Aftersignin:BaseClass1
    {
        IWebDriver WebDriver;
        public Aftersignin(in IWebDriver driver)

        {

            WebDriver = driver;
            Assert.IsNotNull(WebDriver, "NO Driver instance provided");


        }
        public IWebElement signin => WebDriver.FindElement(By.CssSelector(".header.panel.show-icon-tablet > .header.links > .authorization-link.link > a"));
        public IWebElement emaila => WebDriver.FindElement(By.CssSelector("input#email"));
        public IWebElement passa => WebDriver.FindElement(By.CssSelector("fieldset #pass"));
        public IWebElement signbt => WebDriver.FindElement(By.XPath("//button[@id='send2']"));
        public IWebElement stext => WebDriver.FindElement(By.CssSelector(".header.panel.show-icon-tablet > .header.links > .greet.welcome > .logged-in"));



        /*First aid*/
        public IWebElement category1 => WebDriver.FindElement(By.CssSelector("a[title='Category']"));
        public IWebElement firstaid => WebDriver.FindElement(By.CssSelector("a[title='First Aid & Health Care']"));
        public IWebElement flu => WebDriver.FindElement(By.CssSelector("a[title='Cough, Cold & Flu']"));
        public IWebElement fluelement => WebDriver.FindElement(By.CssSelector("[class='item product product-item nth-child-2n'] [tabindex]"));
        public IWebElement text1 => WebDriver.FindElement(By.CssSelector("//.base"));
        public IWebElement price1 => WebDriver.FindElement(By.CssSelector(".price-wrapper > .price"));
        public IWebElement qnty => WebDriver.FindElement(By.CssSelector(".qty-inc"));
        public IWebElement addc => WebDriver.FindElement(By.CssSelector("button#product-addtocart-button"));
        public IWebElement des1 => WebDriver.FindElement(By.CssSelector("div#description  .value"));

       
        /*share*/
        public IWebElement google => WebDriver.FindElement(By.CssSelector(".share-links > a:nth-of-type(4)"));
        public IWebElement mail => WebDriver.FindElement(By.CssSelector("input#identifierId"));
        public IWebElement mailnxt => WebDriver.FindElement(By.XPath("//span[text()='Next']"));
        public IWebElement pass => WebDriver.FindElement(By.XPath("//input[@aria-label='Enter your password']"));
        public IWebElement nextbt => WebDriver.FindElement(By.XPath("//span[text()='Next']"));

        
        /*Homeo*/
        public IWebElement homeo => WebDriver.FindElement(By.CssSelector("a[title='Homeopathic Medicine']"));
        public IWebElement ele3 => WebDriver.FindElement(By.CssSelector("[class='item product product-item nth-child-2np1 nth-child-3n'] [tabindex]"));
        public IWebElement des2 => WebDriver.FindElement(By.CssSelector(".product-info-main [itemprop='description']"));



        /*Baby care*/
        public IWebElement babycare => WebDriver.FindElement(By.CssSelector("a[title='Baby Care']"));
        public IWebElement gripe => WebDriver.FindElement(By.CssSelector("a[title = 'baby gripe water']"));
        public IWebElement elementgripe => WebDriver.FindElement(By.CssSelector(".photo.product.product-item-photo > a"));
        public IWebElement sprice => WebDriver.FindElement(By.CssSelector(".special-price > .price-container.price-final_price.tax.weee > .price-wrapper > .price"));

        /*Protein*/
        public IWebElement protein => WebDriver.FindElement(By.CssSelector("a[title='Protein, Diet & Vitamins']"));
        public IWebElement wloss => WebDriver.FindElement(By.CssSelector("div:nth-of-type(1) > div[role='tabpanel'] > ol > li:nth-of-type(1) > a[rel='nofollow']"));
        public IWebElement range1 => WebDriver.FindElement(By.CssSelector("li:nth-of-type(1) > a[rel='nofollow']"));
        public IWebElement milab => WebDriver.FindElement(By.CssSelector(".item.nth-child-2np1.nth-child-3np1.nth-child-4np1.nth-child-5np1.nth-child-6np1.nth-child-7np1.nth-child-8np1.product.product-item > .product-item-info.type1 > .photo.product.product-item-photo > a"));


        //Disease
        public IWebElement disease => WebDriver.FindElement(By.CssSelector("a[title='Diseases']"));
        public IWebElement children => WebDriver.FindElement(By.CssSelector("a[title='Children']"));
        public IWebElement range2 => WebDriver.FindElement(By.CssSelector("li:nth-of-type(2) > a[rel='nofollow']"));
        public IWebElement hele=> WebDriver.FindElement(By.CssSelector(".item.nth-child-2np1.nth-child-3np1.nth-child-4np1.nth-child-5np1.nth-child-6np1.nth-child-7np1.nth-child-8np1.product.product-item > .product-item-info.type1 > .photo.product.product-item-photo > a"));
        public IWebElement bag => WebDriver.FindElement(By.CssSelector(".cart-design-2.minicart-wrapper > .action.showcart"));



        //Checkout
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
        public IWebElement next3 => WebDriver.FindElement(By.CssSelector(".action.button.continue.primary"));
        public IWebElement rpay => WebDriver.FindElement(By.CssSelector("input#razorpay"));
        public IWebElement proceed => WebDriver.FindElement(By.XPath("//span[text()='Pay with Razorpay']"));
        //.action.action-show-popup
        public IWebElement newadd => WebDriver.FindElement(By.CssSelector(".action.action-show-popup"));
        public IWebElement chkbox => WebDriver.FindElement(By.CssSelector("input#shipping-save-in-address-book"));
        public IWebElement shiphere => WebDriver.FindElement(By.CssSelector(".action.action-save-address.primary > span"));

        //Health device
        public IWebElement hdevice => WebDriver.FindElement(By.CssSelector("a[title='Health Device ']"));
        public IWebElement hinstru => WebDriver.FindElement(By.CssSelector("a[title='Health Instruments']"));
        public IWebElement thermo => WebDriver.FindElement(By.CssSelector("a[title='Thermometer']"));
        public IWebElement thermoele => WebDriver.FindElement(By.CssSelector(".item.nth-child-2n.product.product-item > .product-item-info.type1 > .photo.product.product-item-photo > a"));
        public IWebElement addc2 => WebDriver.FindElement(By.CssSelector("#product-addtocart-button"));
        public IWebElement next4 => WebDriver.FindElement(By.CssSelector("div#shipping-method-buttons-container span"));








































































    }
}
