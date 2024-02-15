using InternalProjectTrial.JsonFile;
using InternalProjectTrial.Page;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using TechTalk.SpecFlow;
using ThirdParty.Json.LitJson;

namespace InternalProjectTrial
{
    [Binding]
    public class HomePageVerificationStepDefinitions:BaseClass
    {
        HomePage homePage;
        
        public HomePageVerificationStepDefinitions()
        {
            homePage = new(driver);
        }
        public List<JsonClass> homeReader = new List<JsonClass>();
        public static StreamReader r = new StreamReader(@"C:\Users\rugmap\OneDrive - Valorem Reply\Desktop\C#\InternalProjectTrial\InternalProjectTrial\JsonFile/Json.json");
        public static string testData = r.ReadToEnd();
        public static JsonClass inputValue = JsonMapper.ToObject<JsonClass>(testData);

        [Given(@"user navigated to url ""([^""]*)""")]
        public void GivenUserNavigatedToUrl(string url)
        {
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        [When(@"verify the AMAZON logo")]
        public void WhenVerifyTheAMAZONLogo()
        {
            Console.WriteLine("The amazon logo displayed: " + homePage.AmazonLogo.Displayed);
        }

        [When(@"verify the Select your address is displayed")]
        public void WhenVerifyTheSelectYourAddressIsDisplayed()
        {
            Console.WriteLine("The Select your address displayed: " + homePage.SelectYourAddress.Displayed);
        }

        [When(@"verify the Returns and orders is displayed")]
        public void WhenVerifyTheReturnsAndOrdersIsDisplayed()
        {
            Console.WriteLine("The Returns and orders displayed: " + homePage.ReturnsnOrders.Displayed);
        }
        [When(@"verify the functionality of forward and backward button")]
        public void WhenVerifyTheFunctionalityOfForwardAndBackwardButton()
        {
            homePage.ForwardButton.Click();
            WebDriverWait waits = new WebDriverWait(driver, TimeSpan.FromSeconds(2));
            waits.Until(ExpectedConditions.ElementExists(By.XPath("//i[@class='a-icon a-icon-next-rounded']")));
            homePage.BackwardButton.Click();
        }

        [When(@"verify if search bar is enabled")]
        public void WhenVerifyIfSearchBarIsEnabled()
        {
            homePage.SearchBar.Click();
        }

        [Then(@"user type pen in search and click search")]
        public void ThenUserTypePenInSearchAndClickSearch()
        {
            homePage.SearchBar.SendKeys(inputValue.search);
            homePage.SearchButton.Click();
        }









    }
}

