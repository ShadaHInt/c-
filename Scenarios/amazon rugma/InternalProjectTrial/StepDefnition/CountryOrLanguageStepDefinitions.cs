using InternalProjectTrial.Page;
using OpenQA.Selenium.Interactions;
using TechTalk.SpecFlow;

namespace InternalProjectTrial
{
    [Binding]
    public class CountryOrLanguageStepDefinitions:BaseClass    
    {
        CountryOrLanguage countryOrLanguage;

        public CountryOrLanguageStepDefinitions()
        {
            countryOrLanguage = new(driver);
        }

        [Given(@"user navigate url ""([^""]*)""")]
        public void GivenUserNavigateUrl(string url)
        {
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            string Url = driver.Url;
            string UrlToTest = "https://www.amazon.in/";
            Assert.AreEqual(Url, UrlToTest);
        }

        [When(@"user mouse hovers on flag icon")]
        public void WhenUserMouseHoversOnFlagIcon()
        {
            Actions actions = new Actions(driver);
            actions.MoveToElement(countryOrLanguage.FlagIcon).Perform();
        }

        [When(@"user selects language radio button")]
        public void WhenUserSelectsLanguageRadioButton()
        {
            countryOrLanguage.Language.Click();
            Thread.Sleep(2000);
        }

        [When(@"user hovers on flag icon and clicks change country or region")]
        public void WhenUserHoversOnFlagIconAndClicksChangeCountryOrRegion()
        {
            Actions actions = new Actions(driver);
            actions.MoveToElement(countryOrLanguage.FlagIcon).Perform();
            countryOrLanguage.Change.Click();
            Thread.Sleep(2000);
        }

        [When(@"user clicks India drop down and select new country")]
        public void WhenUserClicksIndiaDropDownAndSelectNewCountry()
        {
           countryOrLanguage.CountryDrop.Click();
            Thread.Sleep(1000);
            countryOrLanguage.Italy.Click();
        }

        [Then(@"user click Go to website")]
        public void ThenUserClickGoToWebsite()
        {
            countryOrLanguage.GoToWebsite.Click();
        }
    }
}
