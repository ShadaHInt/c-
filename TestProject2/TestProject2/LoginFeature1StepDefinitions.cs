using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace TestProject2
{
    [Binding]
    public class LoginFeature1StepDefinitions
    {
        public IWebDriver driver;
        [Given(@"User is at the Home Page")]
        public void GivenUserIsAtTheHomePage()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.store.demoqa.com";
        }

        [Given(@"Navigate to LogIn Page")]
        public void GivenNavigateToLogInPage()
        {
            driver.FindElement(By.XPath(".//*[@id='account']/a")).Click();
            
        }

        [When(@"The user enter UserName and Password")]
        public void WhenTheUserEnterUserNameAndPassword()
        {
            driver.FindElement(By.Id("log")).SendKeys("testuser_1");
            driver.FindElement(By.Id("pwd")).SendKeys("Test@123");
            
        }

        [When(@"Click on the LogIn button")]
        public void WhenClickOnTheLogInButton()
        {
            driver.FindElement(By.Id("login")).Click();
        }

        [Then(@"Successful LogIN message should display")]
        public void ThenSuccessfulLogINMessageShouldDisplay()
        {
            throw new PendingStepException();
        }
    }
}
