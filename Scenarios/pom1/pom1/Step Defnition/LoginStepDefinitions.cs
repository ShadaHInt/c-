using System;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;



namespace pom1
{
    [Binding]
    public class LoginStepDefinitions
    {
        IWebDriver driver = new ChromeDriver();
        [When(@"the user is navigated to bigbasket it is validated")]
        public void WhenTheUserIsNavigatedToBigbasketItIsValidated()
        {
            Loginpage loginpage = new(driver);
            driver.Navigate().GoToUrl("https://www.bigbasket.com/");
            driver.Manage().Window.Maximize();
            string url = driver.Url;
            string urltotest = "https://www.bigbasket.com/";
            Assert.AreEqual(url, urltotest);
        }

        [Then(@"the user Click on Login button")]
        public void ThenTheUserClickOnLoginButton()
        {
            Loginpage loginpage = new(driver);
            loginpage.loginbt.Click();

        }

        [When(@"the user Create negative cases to test signin functionality mobile number as  (.*)")]
        public void WhenTheUserCreateNegativeCasesToTestSigninFunctionalityMobileNumberAs(string MobileNumber)
        {
            Loginpage loginpage = new(driver);
            loginpage.bt.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            loginpage.ibt.SendKeys(MobileNumber);
            Thread.Sleep(TimeSpan.FromSeconds(2));
            loginpage.contbt.Click();

        }

        [Then(@"the Validations are needed for each of these tests")]
        public void ThenTheValidationsAreNeededForEachOfTheseTests()
        {
            Loginpage loginpage = new(driver);
            Console.WriteLine("error message displayed while login" + loginpage.loginbt.Displayed);
        }
    }
}
