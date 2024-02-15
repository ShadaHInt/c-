using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Drawing;

namespace Assignmnet21
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            // Navigate to webpage myntra
            driver.Navigate().GoToUrl("https://www.myntra.com/");
            driver.Manage().Window.Maximize();

            // verifying whether navigated to myntra itself 
            string url = driver.Url;
            string urltotest = "https://www.myntra.com/";
            Assert.AreEqual(url, urltotest);

            //Verify whether logo displayed or not
            IWebElement webElement = driver.FindElement(By.ClassName("desktop-logoContainer"));
            Console.WriteLine(webElement.Displayed);

            //// verify search bar is enabled
            IWebElement searchbar = driver.FindElement(By.ClassName("desktop-searchBar"));
            bool var = searchbar.Enabled;

            // if enabled search for shirts
            Console.WriteLine("Is searchbar enabled :" + var);
            string searchitem = "Shirts";
            searchbar.SendKeys(searchitem);
            Thread.Sleep(TimeSpan.FromSeconds(3));

            // searching by clicking search button 
            IWebElement searchbutton = driver.FindElement(By.ClassName("desktop-submit"));
            searchbutton.Click();
            Console.WriteLine("Shirts entered and Clicked on search button");

            //selecting the brand in enabled and checking checkbox selected
            //IWebElement brand1 = driver.FindElement(By.ClassName("common-checkboxIndicator"));
            //brand1.Click();
            //Console.WriteLine("checked:" + brand.Selected);
            Thread.Sleep(TimeSpan.FromSeconds(5));
            //bool status = brand.Selected;
            //bool status = brand.Selected;
            /*if(status==false)
            {
                brand1.Click();
            }
            */


            IList<IWebElement> chkBx_brand = driver.FindElements(By.ClassName("brand-list"));
            int n = chkBx_brand.Count;
            for (int i = 0; i < n; i++)
            {
                String value = chkBx_brand.ElementAt(i).GetAttribute("class");
                if (value.Equals ("vertical-filters-label"))
                {
                    chkBx_brand.ElementAt(i).Click();
                    // This will take the execution out of for loop
                    break;
                }
                if (value.Equals(""))
                {
                    chkBx_brand.ElementAt(i).Click();
                    // This will take the execution out of for loop
                    break;
                }








                /*
                //back to home page
                Thread.Sleep(TimeSpan.FromSeconds(3));
                IWebElement logo2 = driver.FindElement(By.ClassName("myntraweb-sprite"));
                logo2.Click();

                //Click on the banner
                IWebElement banner = driver.FindElement(By.ClassName("FreeShippingBanner-sidebar-content"));
                banner.Click();

                // Selecting the coupon code 
                IWebElement cp = driver.FindElement(By.ClassName("FreeShippingBanner-coupon"));

                // retrieving text from it
                string coupn = cp.Text;
                Console.WriteLine(coupn);
                Thread.Sleep(TimeSpan.FromSeconds(2));

                //Close the banner
                banner.Click();

                //Locate for bag button
                Thread.Sleep(TimeSpan.FromSeconds(3));
                IWebElement bag1 = driver.FindElement(By.ClassName("desktop-userTitle"));

                // getting attribute value
                Console.WriteLine("Attribute value : " + bag1.GetAttribute("data-reactid"));

                // getting tag name
                Console.WriteLine("Tag Name is : " + bag1.TagName);

                // Selecting bag button
                IWebElement bag = driver.FindElement(By.ClassName("sprites-headerBag"));
                bag.Click();

                //Selecting Add item from whish list
                IWebElement navbag = driver.FindElement(By.ClassName("button-base-button"));

                // taking its css values 
                Console.WriteLine("Color is : " + navbag.GetCssValue("color"));

                //location of whishlist box
                Point locate = navbag.Location;
                Console.WriteLine("Location is at : " +locate);
                Console.WriteLine(locate.X);
                Console.WriteLine(locate.Y);

                // size of whishlist box
                Size d = navbag.Size;
                Console.WriteLine("Size is : " + d);
                Console.WriteLine("Width = " + d.Width);
                Console.WriteLine("Height = " + d.Height);

                // navigate back to homepage
                IWebElement logo1 = driver.FindElement(By.ClassName("logo-inline"));
                logo1.Click();
                */
                Thread.Sleep(TimeSpan.FromSeconds(3));
                

                



            }
        }
    }
}