using NoonProject2.Page;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using TechTalk.SpecFlow;

namespace NoonProject2
{
    [Binding]
    public class AllDropdownStepDefinitions:BaseClass
    {
        AllDropdown allDropdown;
        public AllDropdownStepDefinitions()
        {
            allDropdown = new(driver);
        }

        Actions actions = new Actions(driver);

        [Given(@"user navigate noon application ""([^""]*)""")]
        public void GivenUserNavigateNoonApplication(string url)
        {
            driver.Navigate().GoToUrl(url);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(7);
            CmnMethod.AssertMethod();
        }

        [When(@"user mouse hovers on all category")]
        public void WhenUserMouseHoversOnAllCategory()
        {
            actions.MoveToElement(allDropdown.All).Perform();
        }

        [When(@"user mouse hovers electronics and clicks mobiles")]
        public void WhenUserMouseHoversElectronicsAndClicksMobiles()
        {
            actions.MoveToElement(allDropdown.Electronics).Perform();
            allDropdown.Mobiles.Click();
        }

        [When(@"user clicks on tablets")]
        public void WhenUserClicksOnTablets()
        {
            DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver);
            fluentWait.Timeout = TimeSpan.FromSeconds(2);
            fluentWait.PollingInterval = TimeSpan.FromMilliseconds(100);
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            fluentWait.Message = "Element to be searched not found";
            IWebElement searchResult = fluentWait.Until(x => x.FindElement(By.XPath("//img[@alt='/tablets']")));            
            allDropdown.Tablets.Click();    
        }

        [Then(@"user clicks view all")]
        public void ThenUserClicksViewAll()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(2));
            wait.Until(ExpectedConditions.ElementExists(By.CssSelector("div.sc-hKMtZM.hDCNam")));
            allDropdown.View.Click();
        }
       
    }
}
