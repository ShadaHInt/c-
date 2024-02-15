using Myntra31_01_23.Pages;
using Myntra31_01_23.Test;
using Myntraproject;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using TechTalk.SpecFlow;
using ThirdParty.Json.LitJson;

namespace Myntra31_01_23.Stepdefnitions
{
    [Binding]
    public class Feature1StepDefinitions:BaseClass
    {
        public List<Class1> homeReader = new List<Class1>();
        public static StreamReader r = new StreamReader(@"C:\Users\shadan\Desktop\C#\Myntra31-01-23\Myntra31-01-23\Test\jsconfig1.json");
        public static string testdata = r.ReadToEnd();
        public static Class1 searchInput = JsonMapper.ToObject<Class1>(testdata);
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(12));
        Cart cart  => new(driver);
        Actions actions = new Actions(driver);
        [Given(@"navigated to the myntra homepage")]
        public void GivenNavigatedToTheMyntraHomepage()
        {
            driver.Navigate().GoToUrl("https://www.myntra.com/");
            string urltotest = driver.Url;
            string url = "https://www.myntra.com/";
            Assert.AreEqual(url, urltotest);
        }

        [When(@"user clicks on shirts on the men category")]
        public void WhenUserClicksOnShirtsOnTheMenCategory()
        {

            actions.MoveToElement(cart.men).Perform();
            cart.casual.Click();
        }

        [Then(@"select the first item in the casual shirts")]
        public void ThenSelectTheFirstItemInTheCasualShirts()
        {
            cart.firstmen.Click();
        }

        [When(@"user needs to select size and user add this item to bag")]
        public void WhenUserNeedsToSelectSizeAndUserAddThisItemToBag()
        {
            driver.SwitchTo().Window(driver.WindowHandles[1]);


            cart.size1.Click();

            cart.addbag.Click();

            

        }
        [Then(@"user searches for kurti")]
        public void ThenUserSearchesForKurti()
        {
            cart.searche.SendKeys(searchInput.valid);
            cart.searchb.Click();
           
        }

        [When(@"select the first element with size small and add it to bag")]
        public void WhenSelectTheFirstElementWithSizeSmallAndAddItToBag()
        {
            cart.elem1.Click();
            driver.SwitchTo().Window(driver.WindowHandles[2]);
            cart.elemsize.Click();
            cart.addbag.Click();
        }

        [Then(@"click on bag")]
        public void ThenClickOnBag()
        {
            cart.bag.Click();
            //Thread.Sleep(5000);
           
        }

        
    }
}
