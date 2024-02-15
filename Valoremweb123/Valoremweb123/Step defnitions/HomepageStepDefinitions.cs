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
        Homepage Homepage => new(driver);
        

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
            Console.WriteLine("career is displayed:yes" + Homepage.careers.Displayed);
        }

        [Then(@"user verifies solutions is displayed")]
        public void ThenUserVerifiesSolutionsIsDisplayed()
        {
            Console.WriteLine("solutions is displayed:yes" + Homepage.solutions.Displayed);
            Actions actions = new Actions(driver);
            actions.MoveToElement(Homepage.solutions).Perform();
            actions.Build().Perform();
        }

        [Then(@"user verifies work is displayed")]
        public void ThenUserVerifiesWorkIsDisplayed()
        {
            Console.WriteLine("work is displayed:yes" + Homepage.work.Displayed);
        }

        [Then(@"user verifies about is displayed")]
        public void ThenUserVerifiesAboutIsDisplayed()
        {
            Console.WriteLine("about is displayed:yes" + Homepage.about.Displayed);
            Actions actions = new Actions(driver);
            actions.MoveToElement(Homepage.about).Perform();
            actions.Build().Perform();
        }

        [Then(@"user verifies connect is displayed")]
        public void ThenUserVerifiesConnectIsDisplayed()
        {
            Console.WriteLine("connect is displayed:yes" + Homepage.about.Displayed);

        }

        [Then(@"user clicks on learn more button")]
        public void ThenUserClicksOnLearnMoreButton()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0,800)");
            Homepage.learnmore.Click();
        }

    }
}
