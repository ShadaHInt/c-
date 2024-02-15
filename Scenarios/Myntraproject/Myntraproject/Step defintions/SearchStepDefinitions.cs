
using TechTalk.SpecFlow;
using ThirdParty.Json.LitJson;

namespace Myntraproject
{
    [Binding]
    public class SearchStepDefinitions : BaseClass
    {
        public List<Class1> homeReader = new List<Class1>();
        public static StreamReader r = new StreamReader(@"C:\\Users\\shadan\\Desktop\\C#\\Scenarios\\Myntraproject\\Myntraproject\\Test/jsconfig1.json");
        public static string testdata = r.ReadToEnd();
        public static Class1 searchInput = JsonMapper.ToObject<Class1>(testdata);
        Searchbox search => new(driver);
        [Given(@"the homepage of myntra")]
        public void GivenTheHomepageOfMyntra()
        {
            driver.Navigate().GoToUrl("https://www.myntra.com/");
            
        }

        [When(@"User verifies search box is enabled")]
        public void WhenUserVerifiesSearchBoxIsEnabled()
        {
            Console.WriteLine("Search bar enables:" + search.searche.Enabled);
            
        }

        [Then(@"user searches for invalid input")]
        public void ThenUserSearchesForInvalidInput()
        {
            search.searche.SendKeys(searchInput.invalid);
            search.searchb.Click();
           
        }

        [Then(@"user searches for valid input")]
        public void ThenUserSearchesForValidInput()
        {
            search.searche.SendKeys(searchInput.valid);
            search.searchb.Click();
            
            
        }
    }
}
