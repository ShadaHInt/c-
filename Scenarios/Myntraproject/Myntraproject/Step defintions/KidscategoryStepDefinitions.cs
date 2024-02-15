
using OpenQA.Selenium.Interactions;

using TechTalk.SpecFlow;

namespace Myntraproject
{
    [Binding]
    public class KidscategoryStepDefinitions : BaseClass
    {
      Kidscategory3 kidscategory  => new(driver);
        [Given(@"user is navigated to the homepage of myntra")]
        public void GivenUserIsNavigatedToTheHomepageOfMyntra()
        {
            driver.Navigate().GoToUrl("https://www.myntra.com/");
           
        }

        [When(@"user mouse hover over kids category")]
        public void WhenUserMouseHoverOverKidsCategory()
        {
            Actions actions = new Actions(driver);
            actions.MoveToElement(kidscategory.kid).Perform();
        }

        [Then(@"user verifies on Tshirt under Boys clothing is displayed and validate whether equal")]
        public void ThenUserVerifiesOnTshirtUnderBoysClothingIsDisplayedAndValidateWhetherEqual()
        {
            Console.WriteLine("Tshirt displayed:" + kidscategory.tshirt.Displayed);
            string text1 = kidscategory.tshirt.Text;
            string text2 = "T-Shirts";
            Assert.AreEqual(text1, text2);

        }

        [When(@"user verifies Tops under Girls clothing is displayed")]
        public void WhenUserVerifiesTopsUnderGirlsClothingIsDisplayed()
        {
            Console.WriteLine("Top displayed:" + kidscategory.top.Displayed);
        }

        [Then(@"user verifies Casual shoes under footwear is diaplayed and validate whether equal")]
        public void ThenUserVerifiesCasualShoesUnderFootwearIsDiaplayedAndValidateWhetherEqual()
        {
            Console.WriteLine("Shoes displayed:" + kidscategory.shoes.Displayed);
            string text3 = kidscategory.shoes.Text;
            string text4 = "Casual Shoes";
            Assert.AreEqual(text3, text4);
        }

        [When(@"user verifies Body suit under Infant is displayed")]
        public void WhenUserVerifiesBodySuitUnderInfantIsDisplayed()
        {
            Console.WriteLine("Infant  displayed:" + kidscategory.bsuit.Displayed);

        }

        [Then(@"user clicks on Body suit and print text Kids Wear Online Store")]
        public void ThenUserClicksOnBodySuitAndPrintTextKidsWearOnlineStore()
        {
            kidscategory.bsuit.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(12);
            Console.WriteLine("The textis:"+kidscategory.bsuittitle.Text);
        }
    }
}
