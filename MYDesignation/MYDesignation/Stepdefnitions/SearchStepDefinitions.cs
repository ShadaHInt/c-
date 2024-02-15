using NoonProject2.Page;
using TechTalk.SpecFlow;
using ThirdParty.Json.LitJson;

namespace NoonProject2
{
    [Binding]
    public class SearchStepDefinitions:BaseClass
    {
        Search search;
        public SearchStepDefinitions()
        {
            search = new(driver);
        }

        //json
        public List<JsonClass> homeReader = new List<JsonClass>();
        public static StreamReader r = new StreamReader(@"C:\Users\rugmap\OneDrive - Valorem Reply\Desktop\C#\MYDesignation\MYDesignation\Json/Json.json");
        public static string testData = r.ReadToEnd();
        public static JsonClass inputValue = JsonMapper.ToObject<JsonClass>(testData);

        [Given(@"user navigates the url ""([^""]*)""")]
        public void GivenUserNavigatesTheUrl(string url)
        {
            driver.Navigate().GoToUrl(url);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(7);
            CmnMethod.AssertMethod();
        }

        [When(@"user searches bag and selects women's sling bag")]
        public void WhenUserSearchesBagAndSelectsWomensSlingBag()
        {
            search.SearchBar.Click();
            search.SearchBar.SendKeys(inputValue.search1);
            search.Option.Click();            
        }

        [When(@"user clicks sort by dropdown and selects price low to high")]
        public void WhenUserClicksSortByDropdownAndSelectsPriceLowToHigh()
        {            
            Thread.Sleep(5000);
            search.SortBy.Click();
            search.Price.Click();
        }

        [When(@"user clicks display dropdown and changes per page product number")]
        public void WhenUserClicksDisplayDropdownAndChangesPerPageProductNumber()
        {            
            Thread.Sleep(5000);
            search.Display.Click();
            search.PerPage.Click();            
        }
       
        [When(@"user searches for shoes and selects shoes for men")]
        public void WhenUserSearchesForShoesAndSelectsShoesForMen()
        {
            Thread.Sleep(6000);
            search.SearchBar.Click();
            search.SearchBar.Clear();
            search.SearchBar.SendKeys(inputValue.search2);
            search.Option.Click();
        }

        [Then(@"user clicks on size dropdown and selects size")]
        public void ThenUserClicksOnSizeDropdownAndSelectsSize()
        {
            Thread.Sleep(10000);
            search.SizeDrop.Click();
            search.SizeSelect.Click();
        }

    }
}
