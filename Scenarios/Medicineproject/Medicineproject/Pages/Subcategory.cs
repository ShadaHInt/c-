using OpenQA.Selenium;

namespace Medicineproject
{
    public class Subcategory:BaseClass1
    {
        IWebDriver WebDriver;
        public Subcategory(in IWebDriver driver)

        {

            WebDriver = driver;
            Assert.IsNotNull(WebDriver, "NO Driver instance provided");


        }
        /* Category*/
        public IWebElement category1 => WebDriver.FindElement(By.CssSelector("a[title='Category']"));
        public IWebElement firstaid => WebDriver.FindElement(By.CssSelector("a[title='First Aid & Health Care']"));
        public IWebElement pain => WebDriver.FindElement(By.CssSelector("li:nth-of-type(1) > .subchildmenu  a[title='Pain Management']"));
        public IWebElement volini => WebDriver.FindElement(By.CssSelector(".photo.product.product-item-photo > a"));
        public IWebElement flu => WebDriver.FindElement(By.CssSelector("a[title='Cough, Cold & Flu']"));
        public IWebElement flufirst => WebDriver.FindElement(By.CssSelector(".item.nth-child-2np1.nth-child-3np1.nth-child-4np1.nth-child-5np1.nth-child-6np1.nth-child-7np1.nth-child-8np1.product.product-item > .product-item-info.type1 > .photo.product.product-item-photo > a"));
        public IWebElement addc1 => WebDriver.FindElement(By.CssSelector("button#product-addtocart-button"));
        public IWebElement stomach => WebDriver.FindElement(By.CssSelector("a[title='Stomach & Acid re flux']"));
        public IWebElement sfirst => WebDriver.FindElement(By.CssSelector(".item.nth-child-2np1.nth-child-3np1.nth-child-4np1.nth-child-5np1.nth-child-6np1.nth-child-7np1.nth-child-8np1.product.product-item > .product-item-info.type1 > .photo.product.product-item-photo > a"));
        public IWebElement addc2 => WebDriver.FindElement(By.CssSelector("button#product-addtocart-button"));
        public IWebElement fcare => WebDriver.FindElement(By.CssSelector("a[title='First Aid & Care']"));
        public IWebElement gelpad => WebDriver.FindElement(By.CssSelector(".item.nth-child-2np1.nth-child-3np1.nth-child-4np1.nth-child-5np1.nth-child-6np1.nth-child-7np1.nth-child-8np1.product.product-item > .product-item-info.type1 > .photo.product.product-item-photo > a"));









        /*Proteins Diets and Vitamins*/
        public IWebElement protein => WebDriver.FindElement(By.CssSelector("a[title='Protein, Diet & Vitamins']"));
        public IWebElement weightloss => WebDriver.FindElement(By.CssSelector("a[title='Weight Loss']"));
        public IWebElement milab => WebDriver.FindElement(By.CssSelector(".item.nth-child-2np1.nth-child-3np1.nth-child-4np1.nth-child-5np1.nth-child-6np1.nth-child-7np1.nth-child-8np1.product.product-item > .product-item-info.type1 > .photo.product.product-item-photo > a"));
        public IWebElement multivitamin => WebDriver.FindElement(By.CssSelector("a[title='Multivitamins']"));
        public IWebElement multifirstele => WebDriver.FindElement(By.CssSelector(".photo.product.product-item-photo > a"));
        public IWebElement calcium => WebDriver.FindElement(By.CssSelector("a[title='Calcium & Minerals']"));
        public IWebElement calciumfirst => WebDriver.FindElement(By.CssSelector(".photo.product.product-item-photo > a"));










        /*Diabetes*/
        public IWebElement diabetes => WebDriver.FindElement(By.CssSelector("a[title='Diabetes']"));
        public IWebElement mdevice => WebDriver.FindElement(By.CssSelector("li:nth-of-type(4) > .subchildmenu  a[title='Monitoring Devices']"));
        public IWebElement accu => WebDriver.FindElement(By.CssSelector(".item.nth-child-2np1.nth-child-3np1.nth-child-4np1.nth-child-5np1.nth-child-6np1.nth-child-7np1.nth-child-8np1.product.product-item > .product-item-info.type1 > .photo.product.product-item-photo > a"));
        public IWebElement testingsupplies => WebDriver.FindElement(By.CssSelector("a[title='Testing Supplies']"));
        public IWebElement elementsup => WebDriver.FindElement(By.CssSelector(".item.nth-child-2np1.nth-child-3np1.nth-child-4np1.nth-child-5np1.nth-child-6np1.nth-child-7np1.nth-child-8np1.product.product-item > .product-item-info.type1 > .photo.product.product-item-photo > a"));
        public IWebElement lancet => WebDriver.FindElement(By.CssSelector("a[title='Lancet']"));
        public IWebElement lancetele => WebDriver.FindElement(By.CssSelector(".photo.product.product-item-photo > a"));









        /*Baby Care*/
        public IWebElement babycare => WebDriver.FindElement(By.CssSelector("a[title='Baby Care']"));
        public IWebElement skincare => WebDriver.FindElement(By.CssSelector("a[title='Skin Care']"));
        public IWebElement babyoil => WebDriver.FindElement(By.CssSelector("a[title='Babby Massage Oil']"));
        public IWebElement dabour => WebDriver.FindElement(By.CssSelector(".photo.product.product-item-photo > a"));
        public IWebElement gripe => WebDriver.FindElement(By.CssSelector("a[title = 'baby gripe water']"));
        public IWebElement elementgripe => WebDriver.FindElement(By.CssSelector(".photo.product.product-item-photo > a"));
        public IWebElement bfood => WebDriver.FindElement(By.CssSelector("a[title='baby food']"));
        public IWebElement bfoodele => WebDriver.FindElement(By.CssSelector(".item.nth-child-2np1.nth-child-3np1.nth-child-4np1.nth-child-5np1.nth-child-6np1.nth-child-7np1.nth-child-8np1.product.product-item > .product-item-info.type1 > .photo.product.product-item-photo > a"));







        /*Body Building*/
        public IWebElement bbuilding => WebDriver.FindElement(By.CssSelector("a[title='Body Building ']"));
        public IWebElement prepost => WebDriver.FindElement(By.CssSelector("a[title='Pre / Post workout']"));
        public IWebElement elementpre => WebDriver.FindElement(By.CssSelector(".item.nth-child-2np1.nth-child-3np1.nth-child-4np1.nth-child-5np1.nth-child-6np1.nth-child-7np1.nth-child-8np1.product.product-item > .product-item-info.type1 > .photo.product.product-item-photo > a"));
        public IWebElement psuppli => WebDriver.FindElement(By.CssSelector("a[title='protein supplement']"));
        public IWebElement psuppliel => WebDriver.FindElement(By.CssSelector(".item.nth-child-2n.product.product-item > .product-item-info.type1 > .photo.product.product-item-photo > a"));
        public IWebElement weight => WebDriver.FindElement(By.CssSelector("a[title='Weight Management']"));
        public IWebElement weightele => WebDriver.FindElement(By.CssSelector(".item.nth-child-2np1.nth-child-3n.product.product-item > .product-item-info.type1 > .photo.product.product-item-photo > a"));
        public IWebElement workout => WebDriver.FindElement(By.CssSelector("a[title='Workout Essentials']"));
        public IWebElement workoutele => WebDriver.FindElement(By.CssSelector(".photo.product.product-item-photo > a"));







        /*Health Device*/
        public IWebElement hdevice => WebDriver.FindElement(By.CssSelector("a[title='Health Device ']"));
        public IWebElement hinstru => WebDriver.FindElement(By.CssSelector("a[title='Health Instruments']"));
        public IWebElement thermo => WebDriver.FindElement(By.CssSelector("a[title='Thermometer']"));
        public IWebElement thermoele => WebDriver.FindElement(By.CssSelector(".item.nth-child-2n.product.product-item > .product-item-info.type1 > .photo.product.product-item-photo > a"));
        public IWebElement hmonitor => WebDriver.FindElement(By.CssSelector("li:nth-of-type(8) > .subchildmenu a[title = 'Monitoring Devices']"));
        public IWebElement bp => WebDriver.FindElement(By.CssSelector("[class='item product product-item nth-child-2n'] [tabindex]"));
        public IWebElement pmanage => WebDriver.FindElement(By.CssSelector("li:nth-of-type(8) > .subchildmenu  a[title='Pain Management']"));
        public IWebElement bsupport => WebDriver.FindElement(By.CssSelector("a[title='Body Support']"));
        

















    }
}
