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
        public static StreamReader r = new StreamReader(@"C:\Users\arathyr\source\repos\Myntra31-01-23neww\Myntra31-01-23\Myntra31-01-23\Test\jsconfig1.json");
        public static string testdata = r.ReadToEnd();
        public static Class1 searchInput = JsonMapper.ToObject<Class1>(testdata);
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(12));
        Cart cart  => new(driver);
        Actions actions = new Actions(driver);

        

        [Given(@"Navigated to the myntra homepage")]
        public void GivenNavigatedToTheMyntraHomepage()
        {
            
            driver.Navigate().GoToUrl("https://www.myntra.com/");
            string urltotest = driver.Url;
            string url = "https://www.myntra.com/";
            Assert.AreEqual(url, urltotest);
        }

        [When(@"User clicks on shirts on the men category")]
        public void WhenUserClicksOnShirtsOnTheMenCategory()
        {
            actions.MoveToElement(cart.men).Perform();
            cart.casual.Click();
        }

        [When(@"User select the first item in the casual shirts")]
        public void WhenUserSelectTheFirstItemInTheCasualShirts()
        {
            cart.firstmen.Click();
        }

        [When(@"User needs to select size")]
        public void WhenUserNeedsToSelectSize()
        {
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            cart.size1.Click();
        }

        [Then(@"User add this item to bag")]
        public void ThenUserAddThisItemToBag()
        {
            cart.addbag.Click();
        }

        [When(@"User searches for kurti")]
        public void WhenUserSearchesForKurti()
        {
            cart.searche.SendKeys(searchInput.valid);
            cart.searchb.Click();
        }

        [When(@"User select the first element with size small")]
        public void WhenUserSelectTheFirstElementWithSizeSmall()
        {
            cart.elem1.Click();
            driver.SwitchTo().Window(driver.WindowHandles[2]);
            cart.elemsize.Click();
        }

        [When(@"User add this item to the bag")]
        public void WhenUserAddThisItemToTheBag()
        {
            cart.addbag.Click();
        }

        [Then(@"Click on bag to view the list of items")]
        public void ThenClickOnBagToViewTheListOfItems()
        {
            cart.bag.Click();
        }
        
    }
}
