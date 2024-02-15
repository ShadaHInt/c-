using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace testingpom
{
    [Binding]
    public class SofaStepDefinitions
    {
        IWebDriver driver = new ChromeDriver();
        [Given(@"navigated to the website")]
        public void GivenNavigatedToTheWebsite()
        {
            throw new PendingStepException();
        }

        [When(@"user clicks furniture")]
        public void WhenUserClicksFurniture()
        {
            throw new PendingStepException();
        }

        [Then(@"user clicks sofa")]
        public void ThenUserClicksSofa()
        {
            throw new PendingStepException();
        }
    }
}
