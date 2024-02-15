using InternalProject.Page;
using InternalProjectTrial;
using InternalProjectTrial.JsonFile;
using OpenQA.Selenium.Interactions;
using TechTalk.SpecFlow;
using ThirdParty.Json.LitJson;

namespace InternalProject
{
    [Binding]
    public class CreateAccountStepDefinitions:BaseClass
    {
        CreateAccount createAccount;

        public CreateAccountStepDefinitions()
        {
            createAccount = new(driver);
        }

        public List<JsonClass> homeReader = new List<JsonClass>();
        public static StreamReader r = new StreamReader(@"C:\Users\rugmap\OneDrive - Valorem Reply\Desktop\C#\InternalProjectTrial\InternalProjectTrial\JsonFile/Json.json");
        public static string testData = r.ReadToEnd();
        public static JsonClass inputValue = JsonMapper.ToObject<JsonClass>(testData);

        [Given(@"User navigate the url ""([^""]*)""")]
        public void GivenUserNavigateTheUrl(string url)
        {
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            string Url = driver.Url;
            string UrlToTest = "https://www.amazon.in/";
            Assert.AreEqual(Url, UrlToTest);
        }

        [When(@"user clicks sign in")]
        public void WhenUserClicksSignIn()
        {
            Actions actions = new Actions(driver);
            actions.MoveToElement(createAccount.AccountsNLists).Perform();
            createAccount.SignIn.Click();
        }

        [When(@"user clicks create account")]
        public void WhenUserClicksCreateAccount()
        {
            createAccount.CreateAcc.Click();
        }

        [When(@"user enters name, mobile no, password")]
        public void WhenUserEntersNameMobileNoPassword()
        {
            createAccount.Name.Click();
            createAccount.Name.SendKeys(inputValue.name);
            Thread.Sleep(1000);
            createAccount.MobileNo.Click();
            createAccount.MobileNo.SendKeys(inputValue.mobNo);
            Thread.Sleep(1000);
            createAccount.Password.Click();
            createAccount.Password.SendKeys(inputValue.passwordthree);
            Thread.Sleep(1000);
        }

        [Then(@"user clicks continue")]
        public void ThenUserClicksContinue()
        {
            createAccount.Continue.Click();
            Thread.Sleep(2000);
        }
    }
}
