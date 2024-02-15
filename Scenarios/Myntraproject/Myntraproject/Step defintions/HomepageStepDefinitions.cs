
using TechTalk.SpecFlow;


namespace Myntraproject
{
    [Binding]
    public class HomepageStepDefinitions: BaseClass
    {

        Homepage1 homepage => new(driver);
        [Given(@"the user is navigated to myntra homepage")]
        public void GivenTheUserIsNavigatedToMyntraHomepage()
        {
            driver.Navigate().GoToUrl("https://www.myntra.com/");
            
            
        }

        [When(@"user verifies whether navigated to the correct url")]
        public void WhenUserVerifiesWhetherNavigatedToTheCorrectUrl()
        {
            string urltotest = driver.Url;
            string url = "https://onlinemedicine.com";
            Assert.AreEqual(url, urltotest);
        }

        [Then(@"user validate the myntra logo in the header")]
        public void ThenUserValidateTheMyntraLogoInTheHeader()
        {
            Console.WriteLine("Verified the logo"+homepage.logo);
        }

        [When(@"user verifies coupon code is displayed")]
        public void WhenUserVerifiesCouponCodeIsDisplayed()
        {
            Console.WriteLine("");
        }

        [Then(@"user verifies profile button is displayed")]
        public void ThenUserVerifiesProfileButtonIsDisplayed()
        {
            Console.WriteLine("Verified the profile button" );
        }

        [When(@"user verifies bag button is displayed")]
        public void WhenUserVerifiesBagButtonIsDisplayed()
        {
            Console.WriteLine("Verified the bag button" );
        }

        [Then(@"clicks on the bag button")]
        public void ThenClicksOnTheBagButton()
        {
            homepage.bag.Click();
        }
    }
}
