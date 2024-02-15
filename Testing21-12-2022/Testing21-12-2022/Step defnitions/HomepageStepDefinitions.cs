using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using TechTalk.SpecFlow;

namespace Valoremweb
{
    [Binding]
    public class HomepageStepDefinitions
    {
        IWebDriver driver = new ChromeDriver();
        Homepagepom Homepage => new(driver);
        //Actions actions = new Actions(driver);

        [Given(@"User is navigated to the valorem website")]
        public void GivenUserIsNavigatedToTheValoremWebsite()
        {


            driver.Navigate().GoToUrl("https://www.valoremreply.com/");
            driver.Manage().Window.Maximize();
            //string urltotest = driver.Url;
            //string url = "https://www.valoremreply.com/";
            //Assert.AreEqual(url, urltotest);
        }

        [When(@"user land to the homepage")]
        public void WhenUserLandToTheHomepage()
        {
            string urltotest = driver.Url;
            string url = "https://www.valoremreply.com/";
            Assert.AreEqual(url, urltotest);
        }

        [Then(@"User verifies logo is displayed")]
        public void ThenUserVerifiesLogoIsDisplayed()
        {
            Console.WriteLine("logo is displayed:yes" + Homepage.logo.Displayed);
        }

        [Then(@"user verifies careers is displayed")]
        public void ThenUserVerifiesCareersIsDisplayed()
        {
            Console.WriteLine("logo is displayed:yes" + Homepage.careers.Displayed);
        }

        [Then(@"user verifies solutions is displayed")]
        public void ThenUserVerifiesSolutionsIsDisplayed()
        {
            Console.WriteLine("logo is displayed:yes" + Homepage.solutions.Displayed);
        }

        [Then(@"user verifies work is displayed")]
        public void ThenUserVerifiesWorkIsDisplayed()
        {
            Console.WriteLine("logo is displayed:yes" + Homepage.work.Displayed);
        }

        [Then(@"user verifies about is displayed")]
        public void ThenUserVerifiesAboutIsDisplayed()
        {
            Console.WriteLine("logo is displayed:yes" + Homepage.about.Displayed);
        }

        [Then(@"user verifies connect is displayed")]
        public void ThenUserVerifiesConnectIsDisplayed()
        {
            Console.WriteLine("logo is displayed:yes" + Homepage.about.Displayed);
        }
    }
}
