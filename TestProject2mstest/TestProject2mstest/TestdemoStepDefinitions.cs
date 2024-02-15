using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Chrome;

namespace TestProject2mstest
{
    [Binding]
    public class TestdemoStepDefinitions
    {
        IWebDriver driver = new ChromeDriver ();
        [Given(@"I have navigated to ""([^""]*)""")]
        public void GivenIHaveNavigatedTo(string url)
        {
            driver.Navigate().GoToUrl(url);
            
        }

        [When(@"I navigated to ""([^""]*)""")]
        public void WhenINavigatedTo(string url)
        {
            driver.Navigate().GoToUrl(url);
            
        }

        [Then(@"I can back navigate to ""([^""]*)""")]
        public void ThenICanBackNavigateTo(string urlTotest)
        {
            driver.Navigate().Back();
            string url = driver.Url;
            Assert.AreEqual(url, urlTotest);
            Thread.Sleep(TimeSpan.FromSeconds(2));
        }

        [Then(@"I can forward navigate to ""([^""]*)""")]
        public void ThenICanForwardNavigateTo(string urlTotest)
        {
            driver.Navigate().Forward();
            Thread.Sleep(TimeSpan.FromSeconds(2));

        }

        [Then(@"I can refresh the page")]
        public void ThenICanRefreshThePage()
        {
            driver.Navigate().Refresh();
        }
    }
}
