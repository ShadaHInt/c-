using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace testingpharmeasy
{
    [Binding]
    public class Feature1StepDefinitions
    {
        IWebDriver driver = new ChromeDriver();
        [Given(@"navigating to website")]
        public void GivenNavigatingToWebsite()
        {
            Homepage homepage=new(driver);

        }

        [When(@"website verified")]
        public void WhenWebsiteVerified()
        {
            throw new PendingStepException();
        }

        [Then(@"user clicks on search button")]
        public void ThenUserClicksOnSearchButton()
        {
            throw new PendingStepException();
        }

        [When(@"user search for shampoo")]
        public void WhenUserSearchForShampoo()
        {
            throw new PendingStepException();
        }

        [Then(@"user select the third element from dropdown")]
        public void ThenUserSelectTheThirdElementFromDropdown()
        {
            throw new PendingStepException();
        }
    }
}
