using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestProject1222
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.firstcry.com/");
            
            string url = driver.Url;
            string urltotest = "https://www.firstcry.com/";
            Assert.AreEqual(url, urltotest);
            IWebElement logo = driver.FindElement(By.ClassName("fc_logo"));
            Console.WriteLine("verified:"+logo.Displayed);
            IWebElement searchbox = driver.FindElement(By.ClassName("input-text"));
            bool var = searchbox.Enabled;
            Thread.Sleep(5);
            searchbox.Clear();
            searchbox.SendKeys("baby products");
            Thread.Sleep(2);
            IWebElement searchbt = driver.FindElement(By.ClassName("search-button"));
            searchbt.Click();
            IWebElement textelement = driver.FindElement(By.ClassName("topl"));
            Console.WriteLine("text is displayed" + textelement.Displayed);
            IWebElement checkbox1 = driver.FindElement(By.TagName("javascript:void(0);"));
            checkbox1.Click();
            Thread.Sleep(3);
            Console.WriteLine("checkbox selected " + checkbox1.Selected);
           /* if (checkbox1.GetAttribute("checked") == "true")
            {
                Console.WriteLine("The checkbox is checked!");
            }
            else
            {
                Console.WriteLine("The checkbox is NOT checked!");
            }
            //IWebElement checkbox2 = driver.FindElement(By.ClassName("L14_42"));
            // checkbox2.Click();

            //bool status = checkbox1.Selected;
            //Console.WriteLine(status);
            /*IWebElement logo1 = driver.FindElement(By.ClassName("fc_logo"));
            logo1.Click();

            IWebElement toysbt = driver.FindElement(By.ClassName("M14_42"));
            Thread.Sleep(3);
            toysbt.Click();
            Thread.Sleep(3);
            IWebElement trackOrder = driver.FindElement(By.ClassName("anch"));   //Locate element for Track order button
            Console.WriteLine("Attribute value : " + trackOrder.GetAttribute("class"));
            Console.WriteLine("tag name: " + trackOrder.TagName);*/




        }
    }
}