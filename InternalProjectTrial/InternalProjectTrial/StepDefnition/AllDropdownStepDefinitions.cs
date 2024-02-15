using InternalProjectTrial.Page;
using TechTalk.SpecFlow;

namespace InternalProjectTrial
{
    [Binding]
    public class AllDropdownStepDefinitions:BaseClass
    {
        AllDropdown allDropdown;

        public AllDropdownStepDefinitions()
        {
            allDropdown = new(driver);
        }

        [Given(@"user navigate to url ""([^""]*)""")]
        public void GivenUserNavigateToUrl(string url)
        {
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            string Url = driver.Url;
            string UrlToTest = "https://www.amazon.in/";
            Assert.AreEqual(Url, UrlToTest);
        }

        [When(@"user click on All category")]
        public void WhenUserClickOnAllCategory()
        {
           
            allDropdown.All.Click();
        }

        [When(@"user clicks best sellers")]
        public void WhenUserClicksBestSellers()
        {
            allDropdown.BestSellers.Click();
            Thread.Sleep(2000);
        }

        [When(@"user clicks All category")]
        public void WhenUserClicksAllCategory()
        {
            allDropdown.All.Click();
            Thread.Sleep(2000);
        }

        [When(@"user clicks Kindle E-Readers & eBooks")]
        public void WhenUserClicksKindleE_ReadersEBooks()
        {
            allDropdown.KindleReaders.Click();
            Thread.Sleep(2000);
        }

        [Then(@"user clicks All-new Kindle")]
        public void ThenUserClicksAll_NewKindle()
        {
            allDropdown.AllNewKindle.Click();
        }
    }
}
