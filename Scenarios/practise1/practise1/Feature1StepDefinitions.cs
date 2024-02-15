using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace practise1
{
    [Binding]
    public class Feature1StepDefinitions
    {
        IWebDriver driver = new ChromeDriver();
        [Given(@"The site of bigbasket")]
        public void GivenTheSiteOfBigbasket()
        {
            
        }

        [When(@"user prints the pincode")]
        public void WhenUserPrintsThePincode()
        {
            throw new PendingStepException();
        }

        [Then(@"user verify it")]
        public void ThenUserVerifyIt()
        {
            throw new PendingStepException();
        }
    }
}
