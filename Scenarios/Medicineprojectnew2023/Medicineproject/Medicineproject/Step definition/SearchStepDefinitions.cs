using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

using TechTalk.SpecFlow;
using ThirdParty.Json.LitJson;

namespace Medicineproject
{
    [Binding]
    public class SearchStepDefinitions:BaseClass1
    {
        Search search => new(driver);
        public List<Class1> homeReader = new List<Class1>();
        public static StreamReader r = new StreamReader(@"C:\\Users\\shadan\\Desktop\\C#\\Scenarios\\Medicineproject\\Medicineproject\\Test/jsconfig1.json");
        public static string testdata = r.ReadToEnd();
        public static Class1 searchInput1 = JsonMapper.ToObject<Class1>(testdata);
        DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver);
        [When(@"user enters valid text in search box and click search")]
        public void WhenUserEntersValidTextInSearchBoxAndClickSearch()
        {
            Console.WriteLine("Search button is enabled" + search.searchbt.Enabled);
            search.search1.Click();
            search.search1.SendKeys(searchInput1.Search[0]);

        }

        [Then(@"click on search button")]
        public void ThenClickOnSearchButton()
        {
            search.searchbt.Click();
            fluentWait.Timeout = TimeSpan.FromSeconds(2);
            fluentWait.PollingInterval = TimeSpan.FromMilliseconds(100);
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            fluentWait.Message = "Element to be searched not found";
            IWebElement searchResult = fluentWait.Until(x => x.FindElement(By.CssSelector(".photo.product.product-item-photo > a")));

        }

        [When(@"the user select the item searched")]
        public void WhenTheUserSelectTheItemSearched()
        {
            search.volini.Click();
        }

        [Then(@"user prints the name of the product")]
        public void ThenUserPrintsTheNameOfTheProduct()
        {
            Console.WriteLine("Text is:" + search.vtext.Text);
        }


        [When(@"user enters invalid text in search box and click search")]
        public void WhenUserEntersInvalidTextInSearchBoxAndClickSearch()
        {
            search.search1.SendKeys(searchInput1.Search[1]);
            search.searchbt.Click();
        }

        [Then(@"click on search button and then prints the error message")]
        public void ThenClickOnSearchButtonAndThenPrintsTheErrorMessage()
        {
            Console.WriteLine("Text is:" + search.txt.Text);
        }

    }
}
