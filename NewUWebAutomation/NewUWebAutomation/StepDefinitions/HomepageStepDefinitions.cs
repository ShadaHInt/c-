
using TechTalk.SpecFlow;

namespace NewUWebAutomation
{
    [Binding]
    public class HomepageStepDefinitions: BaseClass
    {
        HomePage homepage => new(driver);
        [Given(@"the user is navigated to url ""([^""]*)""")]
        public void GivenTheUserIsNavigatedToUrl(string url)
        {
            driver.Navigate().GoToUrl(url);
            homepage.CloseButton.Click();
        }

        [When(@"the user verifies whether navigated to correct url")]
        public void WhenTheUserVerifiesWheatherNavigatedToCorrectUrl()
        {
            string url1 = driver.Url;
            string ExpectedUrl = "https://www.newu.in/";
            Assert.AreEqual(ExpectedUrl, url1);
        }

        [Then(@"the user verifies logo is present")]
        public void ThenTheUserVerifiesLogoIsPresent()
        {
            Console.WriteLine("The Logo is present :"+homepage.Logo.Displayed);
        }

        [When(@"the user verifies the main banner is present")]
        public void WhenTheUserVerifiesTheMainBannerIsPresent()
        {
            Console.WriteLine("The Main Banner is present :"+homepage.MainBanner.Displayed);
        }

        [Then(@"the user verifies gift icon present or not")]
        public void ThenTheUserVerifiesGiftIconPresentOrNot()
        {
            Console.WriteLine("Gift icon is present:"+homepage.Gift.Displayed);
        }

        [When(@"the user prints the description about newu at bottom of page")]
        public void WhenTheUserPrintsTheDescriptionAboutNewuAtBottomOfPage()
        {
            CommonCodes.scroll(0, 4000);
            Console.WriteLine(homepage.Descrip.Text);
        }

        [Then(@"the user clicks on contact us and prints contact details")]
        public void ThenTheUserClicksOnContactUsAndPrintsContactDetails()
        {
            string Real = homepage.ContactUs.Text;
            StringAssert.StartsWith(Real, "Contact");
            homepage.ContactUs.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(12);
            Console.WriteLine(homepage.ContactDetails.Text);
            // throw new PendingStepException();
        }
    }
}
