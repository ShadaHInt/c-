using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using TechTalk.SpecFlow;
using ThirdParty.Json.LitJson;

namespace NewUWebAutomation
{
    [Binding]
    public class SearchBarStepDefinitions:BaseClass
    {
        SearchBar searchBar => new(driver);

        public List<Readjson> homeReader = new List<Readjson>();
        public static StreamReader r = new StreamReader(@"C:\Users\amalsanthosh\OneDrive - Valorem Reply\Desktop\C# programs\NewUWebAutomation\NewUWebAutomation\TestData/Myjson.json");
        public static string testData = r.ReadToEnd();
        public static Readjson searchInput = JsonMapper.ToObject<Readjson>(testData);

        [When(@"the user verifies searchbar is displayed")]
        public void WhenTheUserVerifiesSearchbarIsDisplyed()
        {
            //CommonCodes.Rest();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(12));
            wait.Until(ExpectedConditions.ElementExists(By.CssSelector(".nav-search .header-search__input")));
            Console.WriteLine("SearchBAr is Displayed:"+searchBar.Search.Displayed);

        }
        [Then(@"the user clicks and enters Invalid input")]
        public void ThenTheUserClicksAndEntersInvalidInput()
        {
             CommonCodes.Rest();
            
            DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver);
            fluentWait.Timeout = TimeSpan.FromSeconds(12);
            fluentWait.PollingInterval = TimeSpan.FromMilliseconds(250);
            /* Ignore the exception - NoSuchElementException that indicates that the element is not present */
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));

            fluentWait.Message = "Element to be searched not found";
            IWebElement searchResult = fluentWait.Until(x => x.FindElement(By.CssSelector(".nav-search .header-search__input")));


            searchBar.Search.Click();
            searchBar.Search.SendKeys(searchInput.InvalidSearch);
        }

        
        [When(@"the user enters valid input")]
        public void WhenTheUserEntersValidInput()
        {
            Thread.Sleep(1500);
            searchBar.Search.Clear();
            // searchBar.Search.Click();
            searchBar.Search.SendKeys(searchInput.ValidSearch);
            Actions action = new Actions(driver);
            action.KeyDown(searchBar.Search, Keys.Enter).Perform();

            action.KeyUp(Keys.Enter).Perform();
            action.Build().Perform();
        }

        [Then(@"the user clicks on the logo")]
        public void ThenTheUserClicksOnTheLogo()
        {
            searchBar.Logo.Click();
        }


       
    }
}
