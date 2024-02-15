using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace assessment2mstest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            //navigate to website
            driver.Navigate().GoToUrl("https://www.bigbasket.com/");
            driver.Manage().Window.Maximize();
            // verifying website
            string url = driver.Url;
            string urltotest = "https://www.bigbasket.com/";
            Assert.AreEqual(url, urltotest);

            Thread.Sleep(5);
            //Shop by category 
            //icon svg-header svg-arrow-down-hover svg-arrow-down-hover-dim
            //IWebElement shopbutton = driver.FindElement(By.ClassName("dropdown-toggle"));
            // shopbutton.Click();
            
            
            IWebElement close = driver.FindElement(By.ClassName("arrow-marker"));
            close.Click();
            IWebElement pincode = driver.FindElement(By.ClassName("hvc"));
            Console.WriteLine("pincode displayed" + pincode.Displayed);
            string pin = pincode.Text;
            Console.WriteLine(pin);
            Thread.Sleep(5);

            //beverages

            driver.Navigate().Refresh();

            IWebElement shopb = driver.FindElement(By.ClassName("full-wid"));
            Console.WriteLine("Verified" + shopb.Displayed);
            shopb.Click();
            Thread.Sleep(110);
            IWebElement beverages = driver.FindElement(By.LinkText("Beverages"));
            beverages.Click();
            Thread.Sleep(2);
            // https://www.bigbasket.com/pd/102871/red-label-tea-1-kg/?nc=cl-product-list&t_pg=l1-cat-beverages&t_p=cl-beverages&t_s=cl-product-list&t_pos=4&t_ch=desktop
            //IWebElement redlabel = driver.FindElement(By.ClassName("blur-up"));
           // redlabel.Click();
           /* IWebElement price = driver.FindElement(By.ClassName("IyLvo"));
            string pricep = price.Text;
            Console.WriteLine(pricep);
            IWebElement rating = driver.FindElement(By.ClassName("_2Ze34"));
            string ratingp = rating.Text;
            Console.WriteLine(ratingp);
            Thread.Sleep(5);*/
            IWebElement shopb1 = driver.FindElement(By.ClassName("full-wid"));
            shopb1.Click();
            Thread.Sleep(110);
            IWebElement kitchen = driver.FindElement(By.LinkText("Cleaning & Household"));
             kitchen.Click();
            Thread.Sleep(110);
            // my cart
            //btn btn-default basket - btn - drop hidden - xs hidden - sm
            IWebElement mycart = driver.FindElement(By.ClassName("basket-btn-drop"));
            mycart.Click();
            string txt = mycart.Text;
            Console.WriteLine(txt);

            driver.Navigate().GoToUrl("https://www.bigbasket.com/");
            string url1 = driver.Url;
            string urltotest1 = "https://www.bigbasket.com/";
            Assert.AreEqual(url, urltotest);

            IWebElement offer = driver.FindElement(By.ClassName("bb-offers-link"));
            Thread.Sleep(12);
            offer.Click();
            //IWebElement maggi = driver.FindElement(By.PartialLinkText("MAGGI"));
            //maggi.Click();
            Thread.Sleep(100);
            //img - responsive blur - up lazyautosizes lazyloaded

            

        }

        public void TestMethod2()
        {
            IWebDriver driver = new ChromeDriver();
            //navigate to website
            driver.Navigate().GoToUrl("https://www.bigbasket.com/");
            driver.Manage().Window.Maximize();

            string url = driver.Url;
            string urltotest = "https://www.bigbasket.com/";
            Assert.AreEqual(url, urltotest);
            IWebElement login = driver.FindElement(By.TagName("/auth/login/?nc=nb"));
            login.Click();

        }











        }
    }

