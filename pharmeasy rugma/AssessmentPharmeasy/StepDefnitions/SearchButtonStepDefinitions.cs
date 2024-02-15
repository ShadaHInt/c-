using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace AssessmentPharmeasy
{
    [Binding]
    public class SearchButtonStepDefinitions
    {
        IWebDriver driver = new ChromeDriver();

        [Given(@"navigate to ""([^""]*)""")]
        public void GivenNavigateTo(string url)
        {
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
        }

        [When(@"user serach shampoo in search box")]
        public void WhenUserSerachShampooInSearchBox()
        {
            SearchDropDown searchDropDown = new(driver);
            searchDropDown.SearchDrop.Click();
            Thread.Sleep(1000);
            searchDropDown.SearchBar.SendKeys("Shampoo");
            Thread.Sleep(2000);
        }

        [When(@"user select the third product displayed")]
        public void WhenUserSelectTheThirdProductDisplayed()
        {
            SearchDropDown searchDropDown = new(driver);
            searchDropDown.ThirdItem.Click();
        }

        [When(@"user print the name of the product")]
        public void WhenUserPrintTheNameOfTheProduct()
        {
            SearchDropDown searchDropDown = new(driver);
            Console.WriteLine("The name of product: " + searchDropDown.ProductName.Text);
        }

        [When(@"user list the details of pack sizes available")]
        public void WhenUserListTheDetailsOfPackSizesAvailable()
        {
            SearchDropDown searchDropDown = new(driver);
            Console.WriteLine("The pack sizes: " + searchDropDown.PackSize.Text);
            Thread.Sleep(1000);
        }

        [When(@"user click add to cart")]
        public void WhenUserClickAddToCart()
        {
            SearchDropDown searchDropDown = new(driver);
            searchDropDown.AddToCart.Click();
            Thread.Sleep(4000);
        }

        [When(@"user select quantity of product")]
        public void WhenUserSelectQuantityOfProduct()
        {
            SearchDropDown searchDropDown = new(driver);
            searchDropDown.Qty4.Click();
            Thread.Sleep(2000);
        }

        [When(@"user click on View Cart")]
        public void WhenUserClickOnViewCart()
        {
            SearchDropDown searchDropDown = new(driver);
            searchDropDown.ViewCart.Click();
        }

        [Then(@"user quit application")]
        public void ThenUserQuitApplication()
        {
            driver.Quit();
        }
    }
}
