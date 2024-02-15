using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace AssessmentPharmeasy
{
    [Binding]
    public class HomepageStepDefinitions
    {
        IWebDriver driver = new ChromeDriver();

        [Given(@"the user is navigated to ""([^""]*)""")]
        public void GivenTheUserIsNavigatedTo(string url)
        {
            driver.Navigate().GoToUrl("http://www.pharmeasy.in");
            driver.Manage().Window.Maximize();
            
            //Verify whether its navigated to the website
            string Url = driver.Url;
            string urlToTest = "http://www.pharmeasy.in";
            //Assert.AreEqual(Url, urlToTest);
        }

        [When(@"the user can see categories")]
        public void WhenTheUserCanSeeCategories()
        {
            //create an instance of homepage
            HomePage homePage = new(driver);

            //Categories displayed
            Console.WriteLine("Category 1 is displayed: " + homePage.Category1.Displayed);
            Console.WriteLine("Category 2 is displayed: " + homePage.Category2.Displayed);
            Console.WriteLine("Category 3 is displayed: " + homePage.Category3.Displayed);
            Console.WriteLine("Category 4 is displayed: " + homePage.Category4.Displayed);
            Console.WriteLine("Category 5 is displayed: " + homePage.Category5.Displayed);
            Console.WriteLine("Category 6 is displayed: " + homePage.Category6.Displayed);
            Console.WriteLine("Category 7 is displayed: " + homePage.Category7.Displayed);
            Console.WriteLine("Category 8 is displayed: " + homePage.Category8.Displayed);
        }

        [Then(@"user quit the application")]
        public void ThenUserQuitTheApplication()
        {
            //create an instance of homepage
            HomePage homePage = new(driver);
            driver.Quit();
        }
    }
}
