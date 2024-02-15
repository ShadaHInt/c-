using Newprojectspecflow.Pages;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Newprojectspecflow
{
    [Binding]
    public class HomepageStepDefinitions :BaseClass
    {
        Homepage homepage = new(driver);
        Secondpage secondpage = new(driver);
        productpage productpage1 = new(driver); 
        loginpage loginpage1 = new(driver);
        [Given(@"verify the given url")]
        public void GivenVerifyTheGivenUrl()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.amazon.in/");
            Console.WriteLine(driver.Title);

        }

        [When(@"the page load successfully")]
        public void WhenThePageLoadSuccessfully()
        {
            //    homepage.search.SendKeys("shirts");
            //    homepage.searchbutton.Click();
            //    driver.Navigate().Back();
            //    homepage.bestseller.Click();
            //    Console.WriteLine(driver.Title);
            CommonCodes.Maxi();
            homepage.electronics.Click();
            CommonCodes.Rest();
            CommonCodes.scroll(0,500);
            homepage.payondelivery.Click();
            //CommonCodes.mousehover(secondpage.mobileacc);
            secondpage.mobile.Click();
            //driver.Navigate().Back();
            //Thread.Sleep(3000);
            secondpage.addc.Click();
           // secondpage.firstphone.Click();
           // Console.WriteLine(driver.Title);
            
           //driver.SwitchTo().Window(driver.WindowHandles[1]);
            
           // CommonCodes.Maxi();
           // CommonCodes.scroll(0,500);
           
        }

        [Then(@"verified")]
        public void ThenVerified()
        {
            //driver.Quit(); 
        }
    }
}
