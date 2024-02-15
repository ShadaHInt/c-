
using OpenQA.Selenium.Interactions;

using TechTalk.SpecFlow;

namespace Myntraproject
{
    [Binding]
    public class Category1StepDefinitions : BaseClass
    {
        Category2 category => new(driver);
        Actions actions = new Actions(driver);
        [Given(@"the homepage of Myntra site")]
        public void GivenTheHomepageOfMyntraSite()
        {
            driver.Navigate().GoToUrl("https://www.myntra.com/");
            
        }

        [When(@"user verify Men category is displayed")]
        public void WhenUserVerifyMenCategoryIsDisplayed()
        {
            
            Console.WriteLine("Men category is displayed" + category.men.Displayed);

        }

        [Then(@"user verify Women category is displayed")]
        public void ThenUserVerifyWomenCategoryIsDisplayed()
        {
            Console.WriteLine("Men category is displayed" + category.women.Displayed);
        }

        [When(@"user verify Kids category is displayed")]
        public void WhenUserVerifyKidsCategoryIsDisplayed()
        {
            Console.WriteLine("Men category is displayed" + category.kids.Displayed);
        }

        [Then(@"user verifies Beauty category is displayed")]
        public void ThenUserVerifiesBeautyCategoryIsDisplayed()
        {
            Console.WriteLine("Men category is displayed" + category.beauty.Displayed);
        }

        [When(@"user verifies Home and living category is displayed and print perfume subcategory of it")]
        public void WhenUserVerifiesHomeAndLivingCategoryIsDisplayedAndPrintPerfumeSubcategoryOfIt()
        {
            Console.WriteLine("Men category is displayed" + category.home.Displayed);
            
            actions.MoveToElement(category.beauty).Perform();
            Thread.Sleep(2000);
            Console.WriteLine("Perfume displayed" + category.perfume.Text);
        }

        [Then(@"user verifies Studio category is diplayed and click")]
        public void ThenUserVerifiesStudioCategoryIsDiplayedAndClick()
        {
            Console.WriteLine("Men category is displayed" + category.studio.Displayed);
            category.studio.Click();
        }

        [When(@"back navigate to homepage")]
        public void WhenBackNavigateToHomepage()
        {
            driver.Navigate().Back();
        }
    }
}
