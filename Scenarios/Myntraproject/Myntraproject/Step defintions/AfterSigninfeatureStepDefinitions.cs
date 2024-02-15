using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

using TechTalk.SpecFlow;

namespace Myntraproject
{
    [Binding]
    public class AfterSigninfeatureStepDefinitions : BaseClass
    {
        AfterSignPage  apage => new(driver);
        IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
        Actions actions = new Actions(driver);
        [Given(@"navigated to the myntra homepage")]
        public void GivenNavigatedToTheMyntraHomepage()
        {
            driver.Navigate().GoToUrl("https://www.myntra.com/");
            
        }

        [When(@"user navigate to kurti and suits subcategory of women category")]
        public void WhenUserNavigateToKurtiAndSuitsSubcategoryOfWomenCategory()
        {


            actions.MoveToElement(apage.women).Perform();
            apage.kurta.Click();
        }

        [Then(@"pick a color from it")]
        public void ThenPickAColorFromIt()
        {


            
            Commoncode.scrollbar(0, 500);
            

            apage.color1.Click();
        }

        [When(@"user navigate to casual shirt subcategory of men category")]
        public void WhenUserNavigateToCasualShirtSubcategoryOfMenCategory()
        {
            
            actions.MoveToElement(apage.men).Perform();
            apage.cshirts.Click();
            

        }

        [Then(@"pick a brand from it")]
        public void ThenPickABrandFromIt()
        {
            
            
            apage.brand2.Click();
        }

        [When(@"user navigate to tshirt subcategory of kids category")]
        public void WhenUserNavigateToTshirtSubcategoryOfKidsCategory()
        {
            
            actions.MoveToElement(apage.kids).Perform();
            apage.tshirt.Click();

        }

        [Then(@"pick a price range from it")]
        public void ThenPickAPriceRangeFromIt()
        {
            
            
            apage.price3.Click();
        }
    }
}
