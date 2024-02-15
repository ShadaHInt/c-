using Medicineproject;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using TechTalk.SpecFlow;
using ThirdParty.Json.LitJson;
using Webautomation26_01_23.Pages;

namespace Webautomation26_01_23
{
    [Binding]
    public class Feature1StepDefinitions:BaseClass1
    {
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(12));
        Page page => new(driver);
        Actions actions = new Actions(driver);
        public List<Class1> homeReader = new List<Class1>();
        public static StreamReader r = new StreamReader(@"C:\\Users\\shadan\\Desktop\\C#\\Scenarios\\Medicineproject\\Medicineproject\\Test/jsconfig1.json");
        public static string testdata = r.ReadToEnd();
        public static Class1 searchInput = JsonMapper.ToObject<Class1>(testdata);
        [Given(@"Navigate to homepage")]
        public void GivenNavigateToHomepage()
        {
            driver.Navigate().GoToUrl("https://www.onlinemedicalstore.com/");
            string urltotest = driver.Url;
            string url = "https://www.onlinemedicalstore.com/";
            Assert.AreEqual(url, urltotest);
        }

        [When(@"Signing in with credentials")]
        public void WhenSigningInWithCredentials()
        {
            page.signin.Click();
            page.emaila.SendKeys(searchInput.ValidData[2]);
            page.passa.SendKeys(searchInput.ValidData[3]);

            //Thread.Sleep(1000);
            wait.Until(ExpectedConditions.ElementExists(By.CssSelector("fieldset button")));
            Common.scrollbar(0, 500);
            page.signbt.Click();
        }

        [Then(@"mouse hover on homeopathic")]
        public void ThenMouseHoverOnHomeopathic()
        {
            wait.Until(ExpectedConditions.ElementExists(By.CssSelector("a[title='Homeopathic Medicine']")));
            actions.MoveToElement(page.homeo).Perform();
            
        }

        [When(@"click on desease and children")]
        public void WhenClickOnDeseaseAndChildren()
        {
            actions.MoveToElement(page.disease).Perform();
            actions.MoveToElement(page.children).Perform();
            page.children.Click();
            page.newhomeo.Click();

        }

        [Then(@"add item to cart")]
        public void ThenAddItemToCart()
        {
            page.addc.Click();
        }

        [When(@"click on the bag icon and on checkout")]
        public void WhenClickOnTheBagIconAndOnCheckout()
        {
            wait.Until(ExpectedConditions.ElementExists(By.CssSelector(".cart-design-2.minicart-wrapper > .action.showcart")));
            page.bag.Click();
            page.chk.Click();
        }

        [Then(@"user enters all  credentials required")]
        public void ThenUserEntersAllCredentialsRequired()
        {
            wait.Until(ExpectedConditions.ElementExists(By.CssSelector(".action.action-show-popup")));
            //Thread.Sleep(2000);
            actions.MoveToElement(page.newadd).Perform();
            wait.Until(ExpectedConditions.ElementExists(By.CssSelector(".action.action-show-popup")));
            Thread.Sleep(2000);
            page.newadd.Click();
            //Thread.Sleep(2000);
            page.cmpny.SendKeys(searchInput.Payment[0]);
            page.addre.SendKeys(searchInput.Payment[1]);
            page.street1.SendKeys(searchInput.Payment[2]);
            page.street2.SendKeys(searchInput.Payment[3]);
            Common.scrollbar(0, 300);
            page.region.Click();
            page.kerala.Click();
            page.city.SendKeys(searchInput.Payment[4]);
            page.post.SendKeys(searchInput.Payment[5]);
            page.tele.SendKeys(searchInput.Payment[6]);
            page.chkbox.Click();
            wait.Until(ExpectedConditions.ElementExists(By.CssSelector(".action.action-save-address.primary > span")));
            page.shiphere.Click();
        }

        
    }
}
