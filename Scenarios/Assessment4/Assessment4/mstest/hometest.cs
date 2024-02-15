using Gherkin.Ast;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

//using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment4
{
    [TestClass]
    public class hometest
    {
        [TestMethod]
        public void TestMethod1()
        {
           // IWebDriver driver = new EdgeDriver();
            IWebDriver driver = new ChromeDriver();
            Homepage homepage = new(driver);
            driver.Navigate().GoToUrl(" https://www.croma.com/");
            driver.Manage().Window.Maximize();
            Console.WriteLine("verified logo" + homepage.coupon.Displayed);
            Thread.Sleep(3000);
            homepage.search.Click();
            homepage.search.SendKeys("i");
            Actions actions = new Actions(driver);

            actions.KeyDown(homepage.search, Keys.Shift).Perform();
            actions.SendKeys("c").Perform();
            actions.KeyUp(Keys.Shift).Perform();
            homepage.search.SendKeys("e");
            actions.KeyDown(homepage.search, Keys.Shift).Perform();
            actions.SendKeys("c").Perform();
            actions.KeyUp(Keys.Shift).Perform();
            homepage.search.SendKeys("r");
            actions.KeyDown(homepage.search, Keys.Shift).Perform();
            actions.SendKeys("ea").Perform();
            actions.KeyUp(Keys.Shift).Perform();
            homepage.search.SendKeys("m");
            actions.Build().Perform();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            Console.WriteLine("You searched for iCeCrEAm :" + homepage.search.Text);
            //Actions action = new Actions(driver);
            //action = action.KeyDown(homepage.search, Keys.Shift).SendKeys("i").KeyUp(Keys.Shift).KeyDown(homepage.search, Keys.Shift).SendKeys("C").KeyUp(Keys.Shift).KeyDown(homepage.search, Keys.Shift).SendKeys("e").KeyUp(Keys.Shift).KeyDown(homepage.search, Keys.Shift).SendKeys("C").KeyUp(Keys.Shift);
            //CeCrEAm
            //action = action.KeyDown(homepage.search, Keys.Shift).SendKeys("C").KeyUp(Keys.Shift);
            //action = action.KeyDown(homepage.search, Keys.Shift).SendKeys("e").KeyUp(Keys.Shift);
            //action = action.KeyDown(homepage.search, Keys.Shift).SendKeys("C").KeyUp(Keys.Shift);
            //action = action.KeyDown(homepage.search, Keys.Shift).SendKeys("r").KeyUp(Keys.Shift);
            //action = action.KeyDown(homepage.search, Keys.Shift).SendKeys("E").KeyUp(Keys.Shift);
            //action = action.KeyDown(homepage.search, Keys.Shift).SendKeys("A").KeyUp(Keys.Shift);
            //action = action.KeyDown(homepage.search, Keys.Shift).SendKeys("m").KeyUp(Keys.Shift);

            // action.Build().Perform();
            //Console.WriteLine("verified mobile" + homepage.mobile.Displayed);
            //Console.WriteLine("verified televison" + homepage.televison.Displayed);
            //Console.WriteLine("verified laptop" + homepage.laptop.Displayed);
            //Console.WriteLine("verified audio" + homepage.audio.Displayed);
            //Console.WriteLine("verified ac" + homepage.ac.Displayed);
            //homepage.login.Click();
            //Thread.Sleep(2000);
            ////homepage.loginenter.Click();
            //homepage.loginenter.SendKeys("2000");
            // homepage.loginenter.Click();
            //homepage.menu.Click();
            //Actions actions = new Actions(driver);
            //actions.MoveToElement(homepage.mob).Perform();
            //Thread.Sleep(5000);
            //actions.MoveToElement(homepage.mobph).Perform();
            //Thread.Sleep(3000);
            //actions.MoveToElement(homepage.iphone).Perform();
            //homepage.iphone.Click();

            //Shoppage shoppage = new(driver);
            //Thread.Sleep(5000);
            //shoppage.firstip.Click();
            //Thread.Sleep(3000);
            //Console.WriteLine(shoppage.keyf.Text);
            //IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            //js.ExecuteScript("window.scrollTo(0, 800)");
            //Thread.Sleep(2000);
            //shoppage.addc.Click();
            //Thread.Sleep(3000);
            ////shoppage.closebt.Click();
            //shoppage.proceedbt.Click();
            //Thread.Sleep(5000);
            //shoppage.applyc.Click();
            //Thread.Sleep(3000);
            //shoppage.coupontxt.Click();
            //shoppage.coupontxt.SendKeys("ABC1234");
            //Thread.Sleep(2000);
            //shoppage.couponapply.Click();
            //Thread.Sleep(3000);
            ////shoppage.alert.Click();
            ////Thread.Sleep(3000);
            ////Console.WriteLine("The text in alert box is: " +shoppage.alert);
            //string Atext = driver.SwitchTo().Alert().Text;
            //Console.WriteLine("Text in Alert : " + Atext);





        }
    }
}
