using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using TechTalk.SpecFlow;

namespace NoonProject2
{
    [Binding]
    public class HomeStepDefinitions:BaseClass
    {
        HomePage homePage;
        public HomeStepDefinitions()
        {
            homePage = new(driver);
        }

        [Given(@"user navigate to noon application ""([^""]*)""")]
        public void GivenUserNavigateToNoonApplication(string url)
        {
            driver.Navigate().GoToUrl(url);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(7);
            CmnMethod.AssertMethod();
        }

        [When(@"Noon logo displyayed")]
        public void WhenNoonLogoDisplyayed()
        {
            Console.WriteLine("The logo displayed: " + homePage.NoonLogo.Displayed);
        }

        [When(@"sign in symbol displayed")]
        public void WhenSignInSymbolDisplayed()
        {
            Console.WriteLine("The sign in displayed: " + homePage.LoginSymbol.Displayed);
        }

        [When(@"cart diplayed")]
        public void WhenCartDiplayed()
        {
            Console.WriteLine("The cart displayed: " + homePage.Cart.Displayed);
        }

        [When(@"cashback banner displayed")]
        public void WhenCashbackBannerDisplayed()
        {
            Console.WriteLine("The banner text : " + homePage.CashBackbanner.Displayed);
        }

        [When(@"search bar is enabled")]
        public void WhenSearchBarIsEnabled()
        {
            bool search = homePage.SearchBar.Enabled;
        }

        [When(@"user clicks forward and backward button")]
        public void WhenUserClicksForwardAndBackwardButton()
        {
            homePage.ForwardButton.Click();
            WebDriverWait waits = new WebDriverWait(driver, TimeSpan.FromSeconds(2));
            waits.Until(ExpectedConditions.ElementExists(By.CssSelector("div.swiper-button-circle-left")));
            homePage.BackwardButton.Click();
        }

        [Then(@"categories in slider displayed")]
        public void ThenCategoriesInSliderDisplayed()
        {
            Console.WriteLine("The slide categories displayed: " + homePage.SliderCategories.Displayed);
        }
    }
}
