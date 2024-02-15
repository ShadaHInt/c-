using NoonProject2.Page;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using TechTalk.SpecFlow;

namespace NoonProject2
{
    [Binding]
    public class VerifyCategoriesStepDefinitions:BaseClass
    {
        VerifyCategories verifyCategories;
        public VerifyCategoriesStepDefinitions()
        {
            verifyCategories = new(driver);
        }

        Actions actions = new Actions(driver);

        [Given(@"user navigated to noon application ""([^""]*)""")]
        public void GivenUserNavigatedToNoonApplication(string url)
        {
            driver.Navigate().GoToUrl(url);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(7);
            CmnMethod.AssertMethod();
        }

        [When(@"all categories are displayed")]
        public void WhenAllCategoriesAreDisplayed()
        {
            Assert.IsTrue(verifyCategories.Electronics.Displayed);
            Console.WriteLine("The category2 displayed: " + verifyCategories.Men.Displayed);
            Console.WriteLine("The category3 displayed: " + verifyCategories.Women.Displayed);
            Console.WriteLine("The category4 displayed: " + verifyCategories.Home.Displayed);
            Console.WriteLine("The category5 displayed: " + verifyCategories.BeautynFragrance.Displayed);
            Console.WriteLine("The category6 displayed: " + verifyCategories.BabynToys.Displayed);
            Console.WriteLine("The category7 displayed: " + verifyCategories.Sports.Displayed);
            Console.WriteLine("The category8 displayed: " + verifyCategories.BestSellers.Displayed);
            Console.WriteLine("The category9 displayed: " + verifyCategories.SellonNoon.Displayed);            
        }

        [Then(@"mouse hover on Women dropdown")]
        public void ThenMouseHoverOnWomenDropdown()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(2));
            wait.Until(ExpectedConditions.ElementExists(By.XPath("//div[contains(@class,'swiper-slide')]//following::div[2]")));
            actions.MoveToElement(verifyCategories.Women).Perform();
        }
    }
}
