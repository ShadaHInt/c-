using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Assessment_3pom.stepdefnition
{
    [Binding]
    public class HomepageStepDefinitions
    {
        IWebDriver driver = new ChromeDriver();
        [Given(@"the url of the website")]
        public void GivenTheUrlOfTheWebsite()
        {
            Homepage homepage = new(driver);
            driver.Navigate().GoToUrl("https://www.hopscotch.in/");
            driver.Manage().Window.Maximize();
            string url = driver.Url;
            string urltotest = "https://www.hopscotch.in/";
            Assert.AreEqual(url, urltotest);
        }

        [When(@"Website is verified")]
        public void WhenWebsiteIsVerified()
        {
            Homepage homepage = new(driver);
            string url = driver.Url;
            string urltotest = "https://www.hopscotch.in/";
            Assert.AreEqual(url, urltotest);
        }

        [Then(@"all the elements are also verified if displayed")]
        public void ThenAllTheElementsAreAlsoVerifiedIfDisplayed()
        {
            Homepage homepage = new(driver);
            Thread.Sleep(TimeSpan.FromSeconds(2));
            string text = homepage.discover.Text;
            Console.WriteLine(text);
            Assert.AreEqual(text,"Discover");
            string text1 = homepage.all.Text;
            Console.WriteLine(text1);
           // Assert.AreEqual(text1,"All");
            string text2 = homepage.moment.Text;
            Console.WriteLine(text2);
           // Assert.AreEqual(text2,"Moments");

        }

        [When(@"user clicks all")]
        public void WhenUserClicksAll()
        {
            Homepage homepage = new(driver);
            homepage.allp.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));

        }

        [Then(@"user clicks daily care")]
        public void ThenUserClicksDailyCare()
        {
            Homepage homepage = new(driver);
            homepage.daily.Click();
        }
    }
}
