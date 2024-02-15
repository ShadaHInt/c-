using OpenQA.Selenium.Interactions;
using TechTalk.SpecFlow;

namespace NewUWebAutomation.StepDefinitions
{
    [Binding]
    public class CategoriespageStepDefinitions:BaseClass
    {
        CategoriesPage categoriesPage => new(driver);
        [When(@"the user verifies menu bar")]
        public void WhenTheUserVerifiesMenuBar()
        {
            Console.WriteLine("The menu bar is present:"+categoriesPage.MenuBar.Displayed);
        }

        [Then(@"user checks Jaquline usa is displyed and prints the text")]
        public void ThenUserChecksJaqulineUsaIsDisplyedAndPrintsTheText()
        {
            Console.WriteLine(categoriesPage.Jaque.Displayed);
            Console.WriteLine(categoriesPage.Jaque.Text);
        }

        [When(@"the user mousehover to shop makeup and clicks on foundation")]
        public void WhenTheUserMouseoverToShopMakeupAndClicksOnFoundation()
        {
            CommonCodes.Rest();
            CommonCodes.mousehover(categoriesPage.Shop);
            CommonCodes.mousehover(categoriesPage.MakeUp);
           categoriesPage.Foundation.Click();
        }

        [Then(@"the user navigates back and mousehover to hair and clicks on hair brushes")]
        public void ThenTheUserNavigatesBackAndMouseoverToHairAndClicksOnHairBrushes()
        {
            CommonCodes.Rest();
            driver.Navigate().Back();
            CommonCodes.mousehover(categoriesPage.Shop);
            CommonCodes.mousehover(categoriesPage.Hair);
            categoriesPage.HairBrush.Click();
        }
    }
}
