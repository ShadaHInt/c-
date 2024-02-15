using Nykaa_Web_Automation.Hooks;
using Nykaa_Web_Automation.POM_Pages;
using System;
using System.Security.Policy;
using TechTalk.SpecFlow;

namespace Nykaa_Web_Automation
{
    [Binding]
    public class HomePageTestStepDefinitions : BaseClass
    {
        HomePage homePage => new(driver);
      
        CreateAccount createAccount => new(driver);
      
        [Given(@"I navigated to Nykaa")]
        public void GivenINavigatedToNykaa()
        {
            driver.Navigate().GoToUrl(ReadJson().GotoURL);
            driver.Manage().Window.Maximize();
           
        }

        [When(@"I verify the whether navigated to the correct url")]
        public void WhenIVerifyTheWhetherNavigatedToTheCorrectUrl()
        {
            Assert.AreEqual(driver.Url,ReadJson().GotoURL, "Not navigated to Nykaa Homepage");
        }

        [Then(@"I must view the logo")]
        public void ThenIMustViewTheLogo()
        {
            Assert.IsTrue(homePage.HeaderLogo.Displayed, "Logo not displayed");
        }

        [When(@"I click on Account icon")]
        public void WhenIClickOnAccountIcon()
        {
            createAccount.AccountIcon.Click();
        }

        [Then(@"click onthe Phone/email button")]
        public void ThenClickOnthePhoneEmailButton()
        {
            createAccount.PhoneNumberEmailButton.Click();
        }


        [Given(@"I am in login screen")]
        public void GivenIAmInLoginScreen()
        {
            Assert.AreEqual(driver.Url, "https://www.nykaa.com/auth/verify?ptype=auth");
        }

        [When(@"I enter the invalid phone number")]
        public void WhenIEnterTheInvalidPhoneNumber()
        {
            createAccount.PhoneEmailText.SendKeys(ReadJson().Email);
        }

        [When(@"I click on the Proceed button")]
        public void WhenIClickOnTheProceedButton()
        {
            createAccount.Proceeedbutton.Click();
        }

        [Then(@"I must see  validation '([^']*)'")]
        public void ThenIMustSeeValidation(string validation)
        {
            Assert.AreEqual(validation.ToUpper(), createAccount.validation.Text.ToString().Trim());
        }
    }
}
