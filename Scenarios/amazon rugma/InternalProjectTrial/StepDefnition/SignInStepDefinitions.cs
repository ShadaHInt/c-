using InternalProjectTrial.CommonMethods;
using InternalProjectTrial.JsonFile;
using InternalProjectTrial.Page;
using OpenQA.Selenium.Interactions;
using TechTalk.SpecFlow;
using ThirdParty.Json.LitJson;

namespace InternalProjectTrial
{
    [Binding]
    public class SignInStepDefinitions:BaseClass
    {
        AddToCart addToCart;

        public SignInStepDefinitions()
        {
            addToCart = new(driver);
        }
        public List<JsonClass> homeReader = new List<JsonClass>();
        public static StreamReader r = new StreamReader(@"C:\Users\rugmap\OneDrive - Valorem Reply\Desktop\C#\InternalProjectTrial\InternalProjectTrial\JsonFile/Json.json");
        public static string testData = r.ReadToEnd();
        public static JsonClass inputValue = JsonMapper.ToObject<JsonClass>(testData);

        [Given(@"user navigated Amazon url ""([^""]*)""")]
        public void GivenUserNavigatedAmazonUrl(string url)
        {
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            string Url = driver.Url;
            string UrlToTest = "https://www.amazon.in/";
            Assert.AreEqual(Url, UrlToTest);
        }

        [When(@"user click on sign in")]
        public void WhenUserClickOnSignIn()
        {
            Actions actions = new Actions(driver);
            actions.MoveToElement(addToCart.AccountsNLists).Perform();
            addToCart.SignIn.Click();
        }

        [When(@"user enter mobileone and click continue")]
        public void WhenUserEnterMobileoneAndClickContinue()
        {
            CmnMthd.Email(inputValue.mobileone);
        }

        [Then(@"user enter passwordone and click sign in")]
        public void ThenUserEnterPasswordoneAndClickSignIn()
        {
            CmnMthd.Password(inputValue.passwordone);
        }

        [When(@"user ente mobiletwo and clicks continue")]
        public void WhenUserEnteMobiletwoAndClicksContinue()
        {
            CmnMthd.Email(inputValue.mobiletwo);
        }

        [Then(@"user enter passwordtwo and click sign in")]
        public void ThenUserEnterPasswordtwoAndClickSignIn()
        {
            CmnMthd.Password(inputValue.passwordtwo);
        }

        [When(@"user enter mobilethree and click continue")]
        public void WhenUserEnterMobilethreeAndClickContinue()
        {
            CmnMthd.Email(inputValue.mobilethree);
        }

        [Then(@"user enters passwordthree and clicks sign in")]
        public void ThenUserEntersPasswordthreeAndClicksSignIn()
        {
            CmnMthd.Password(inputValue.passwordthree);

        }

    }
}
