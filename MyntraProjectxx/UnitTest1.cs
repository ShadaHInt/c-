using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Drawing;

namespace MyntraProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Navigate to myntra
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.myntra.com/");

            //Verify whether its navigated to the website
            string url = driver.Url;
            string urlToTest = "https://www.myntra.com/";
            Assert.AreEqual(url, urlToTest);

            //Verify whether the Logo is displayed or not
            IWebElement logo = driver.FindElement(By.ClassName("myntraweb-sprite"));
            Console.WriteLine("Logo Displayed: " + logo.Displayed);

            // Verify whether the search box is enabled 
            IWebElement searchBox = driver.FindElement(By.ClassName("desktop-searchBar"));
            searchBox.Clear();
            bool search = searchBox.Enabled;

            // Search for 'Shirts'
            Console.WriteLine("Searchbox Enabled: " + search); 
            string searchItem = "Shirts";
            searchBox.SendKeys(searchItem);
            IWebElement searchButton = driver.FindElement(By.ClassName("sprites-search"));
            searchButton.Click(); 
            Thread.Sleep(500);

            // Select a brand
            IWebElement brand = driver.FindElement(By.ClassName("common-checkboxIndicator"));
            brand.Click(); 

            //verify that checkbox is selected
            Console.WriteLine("Checkbox Selected: " + brand.Selected); 

            //Navigate back to Home page
            Thread.Sleep(500);
            driver.Navigate().Back();
            driver.Navigate().Refresh();
            driver.Navigate().Back(); 

            //Click on banner
            IWebElement banner = driver.FindElement(By.ClassName("FreeShippingBanner-sidebar-content"));
            banner.Click();

            //Select text coupon code
            IWebElement couponcode = driver.FindElement(By.ClassName("FreeShippingBanner-text"));
            string coupon = couponcode.Text;
            IWebElement code = driver.FindElement(By.ClassName("FreeShippingBanner-code"));
            string cd = code.Text;
            Console.WriteLine("The Coupon code is : " + coupon + " " + cd);
            Thread.Sleep(200);

            //Close banner
            banner.Click();

            //Locate element for Bag button, print any of the attribute's value and tag name.
            IWebElement bag = driver.FindElement(By.ClassName("sprites-headerBag"));
            Console.WriteLine("Attribute value: " + bag.GetAttribute("data-reactid"));
            Console.WriteLine("Tag name: " + bag.TagName);

            //Navigate to Bag button and get any CSS value for the text "ADD ITEMS FROM WISHLIST"
            bag.Click();
            IWebElement addItem = driver.FindElement(By.ClassName("button-base-button"));
            Console.WriteLine("CSS value of color: " + addItem.GetCssValue("color"));

            //Get the location and size for "ADD ITEMS FROM WISHLIST'" box
            Size s = addItem.Size;
            Console.WriteLine("The size is : " + s);
            Point l = addItem.Location;
            Console.WriteLine("The location is: " + l);
            Thread.Sleep(200);

            //Navigate back to homepage.
            driver.Navigate().Back();

            driver.Quit();

        }

    }
}