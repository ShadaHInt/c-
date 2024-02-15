using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace BigBasketTestAutomation
{
    [TestClass]
    public class HomeValidationTests
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



            // IWebElement close = driver.FindElement(By.ClassName("arrow-marker"));
            //close.Click();
            /*IWebElement pincode = driver.FindElement(By.ClassName("hvc"));
            Console.WriteLine("pincode displayed" + pincode.Displayed);
            string pin = pincode.Text;
            Console.WriteLine(pin);
            Thread.Sleep(5);
            */

            // beverages

            //driver.Navigate().Refresh();
            //Actions actions = new Actions(driver);

            //IWebElement menuOption = driver.FindElement(By.ClassName("full-wid"));
            //actions.MoveToElement(menuOption).Perform();

            //Thread.Sleep(TimeSpan.FromSeconds(3));

            //IWebElement subMenuOption = driver.FindElement(By.LinkText("Beverages"));
            //actions.MoveToElement(subMenuOption).Perform();

            //Console.WriteLine( driver.FindElement(By.ClassName("full-wid")).Displayed);
            //driver.FindElement(By.ClassName("full-wid")).Click();
            ////Console.WriteLine("Verified" + shopb.Displayed);
            ////shopb.Click();
            //Thread.Sleep(110);
            //IWebElement beverages = driver.FindElement(By.LinkText("Beverages"));
            //beverages.Click();
            //Thread.Sleep(2);


            //IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            //js.ExecuteScript("window.scrollTo(0, 500)");
            //Thread.Sleep(TimeSpan.FromSeconds(5));

            //IWebElement dd= driver.FindElement(By.CssSelector(".form-control.sort-select.ng-pristine.ng-untouched.ng-valid.ng-not-empty"));

            //string text = driver.FindElement(By.CssSelector("select[class^='form-control']>option:nth-of-type(1)")).Text;


            // SelectElement dd1 = new SelectElement(dd);
            //bool b = dd1.IsMultiple;
            //dd1.SelectByIndex(3);
            //driver.FindElement(By.CssSelector("a[href^='/pd/266575/']")).Click();
            //IWebElement redlabel = driver.FindElement(By.XPath("//a[@href='/pd/266575/red-label-tea-250-g-carton/?nc=cl-product-list&t_pg=l1-cat-beverages&t_p=cl-beverages&t_s=cl-product-list&t_pos=4&t_ch=desktop']//child::img[1]"));
            //redlabel.Click();
            //IWebElement price = driver.FindElement(By.ClassName("IyLvo"));
            //string pricep = price.Text;
            //Console.WriteLine(pricep);
            //IWebElement rating = driver.FindElement(By.ClassName("_2Ze34"));
            //string ratingp = rating.Text;
            //Console.WriteLine(ratingp);
            //Thread.Sleep(TimeSpan.FromSeconds(5));

            //driver.Navigate().GoToUrl("https://www.bigbasket.com/");
            //IWebElement shopb1 = driver.FindElement(By.ClassName("full-wid"));

            //IWebElement displaycat = driver.FindElement(By.XPath("//ul[@id='navBarMegaNav']"));
            //String txt1 = displaycat.Text;
            //Console.WriteLine(txt1);
            //;



            //IWebElement kitchen = driver.FindElement(By.LinkText("Cleaning & Household"));
            //Thread.Sleep(TimeSpan.FromSeconds(5));
            //kitchen.Click();
            //IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            //js.ExecuteScript("window.scrollTo(0, 400)");
            //Thread.Sleep(TimeSpan.FromSeconds(7));
            //IWebElement dis = driver.FindElement(By.XPath("//a[@href='/pd/1200277/harpic-disinfectant-toilet-cleaner-liquid-original-kills-999-germs-2x1-l/?nc=cl-prod-list&t_pg=l1-cat-cleaning-household&t_p=cl-temp-1&t_s=cl-prod-list&t_pos=3&t_ch=desktop']//child::img[1]"));
            //Thread.Sleep(TimeSpan.FromSeconds(2));
            //dis.Click();
            //// IyLvo
            //IWebElement pricee = driver.FindElement(By.ClassName("IyLvo"));
            //string pricep1 = pricee.Text;
            //Console.WriteLine("price is" + pricep1);

            // IWebElement basket = driver.FindElement(By.ClassName("Cs6YO"));
            // basket.Click();
            // Thread.Sleep(TimeSpan.FromSeconds(5));

            //my cart
            //btn btn-default basket - btn - drop hidden - xs hidden - sm
            //IWebElement mycart = driver.FindElement(By.CssSelector(".btn.btn-default.basket-btn-drop.hidden-xs.hidden-sm"));
            // mycart.Click();
            //Thread.Sleep(TimeSpan.FromSeconds(5));
            //string txt = mycart.Text;
            // Console.WriteLine(txt);


            // driver.Navigate().GoToUrl("https://www.bigbasket.com/");
            // //string url1 = driver.Url;
            //// string urltotest1 = "https://www.bigbasket.com/";
            //// Assert.AreEqual(url, urltotest);

            // IWebElement offer = driver.FindElement(By.ClassName("bb-offers-link"));
            // Thread.Sleep(12);
            //offer.Click();
            //Thread.Sleep(TimeSpan.FromSeconds(5));
            ////XPath("//a[@href='/pd/40186855/colgate-strong-teeth-anticavity-toothpaste-with-amino-shakti-formula-provides-fresher-breath-500-g/?nc=Best Sellers&t_pg=offers&t_p=offers&t_s=Best Sellers&t_pos_sec=2&t_pos_item=1&t_ch=desktop']")
            //IWebElement maggi = driver.FindElement(By.LinkText("2-Minute Instant Masala Noodles - Made With Quality Spices, Goodness Of Iron"));
            //Thread.Sleep(TimeSpan.FromSeconds(5));
            //maggi.Click();

            //IWebElement pricee = driver.FindElement(By.ClassName("IyLvo"));
            //string pricep1 = pricee.Text;
            //Console.WriteLine("price is" + pricep1);


            //img - responsive blur - up lazyautosizes lazyloaded

            //LoginTests loginTests = new LoginTests();
            //loginTests.Login();






            //driver.FindElement(By.CssSelector("input[id='input']")).SendKeys("fruits");
        }
            [TestMethod]
            [TestCategory("AssertTest")]
            public void AssertEqualsWithIntValues()
            {
                int expected = 10;
                int actual = 2 * 5;
                Assert.AreEqual(expected, actual);
                // Assert.AreEqual(expected + 1, actual,"Validation failed");
                Assert.AreNotEqual(expected, actual, "Validation failed");
            }
        [TestMethod]
        public void TestIsTrue()
        {
            int a = 10, b = 20;
            Assert.IsTrue(a == 10);
            Assert.IsTrue(b == 20);
            Assert.IsFalse(a == b);
            Assert.IsTrue(a != b);

        }

    }


    }

