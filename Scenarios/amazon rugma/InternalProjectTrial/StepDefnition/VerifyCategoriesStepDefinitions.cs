using InternalProjectTrial.Page;
using OpenQA.Selenium.Interactions;
using TechTalk.SpecFlow;

namespace InternalProjectTrial
{
    [Binding]
    public class VerifyCategoriesStepDefinitions : BaseClass
    {
        Category category;

        public VerifyCategoriesStepDefinitions()
        {
            category = new(driver);
        }

        [Given(@"user navigates to url ""([^""]*)""")]
        public void GivenUserNavigatesToUrl(string url)
        {
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            string Url = driver.Url;
            string UrlToTest = "https://www.amazon.in/";
            Assert.AreEqual(Url, UrlToTest);

        }

        [When(@"all categories are displayed")]
        public void WhenAllCategoriesAreDisplayed()
        {
            Assert.IsTrue(category.Category1.Displayed);
            Console.WriteLine("The category2 displayed: " + category.Category2.Displayed);
            Console.WriteLine("The category3 displayed: " + category.Category3.Displayed);
            Console.WriteLine("The category4 displayed: " + category.Category4.Displayed);
            Console.WriteLine("The category5 displayed: " + category.Category5.Displayed);
            Console.WriteLine("The category6 displayed: " + category.Category6.Displayed);
            Console.WriteLine("The category7 displayed: " + category.Category7.Displayed);
            Console.WriteLine("The category8 displayed: " + category.Category8.Displayed);
            Console.WriteLine("The category9 displayed: " + category.Category9.Displayed);
            Console.WriteLine("The category10 displayed: " + category.Category10.Displayed);
            Console.WriteLine("The category11 displayed: " + category.Category11.Displayed);
            Console.WriteLine("The category12 displayed: " + category.Category12.Displayed);
            Console.WriteLine("The category13 displayed: " + category.Category13.Displayed);
        }

        [Then(@"mouse hover on Prime dropdown")]
        public void ThenMouseHoverOnPrimeDropdown()
        {
            Actions actions = new Actions(driver);
            actions.MoveToElement(category.Category10).Perform();
        }
    }
}
