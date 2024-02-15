using NoonProject2.Page;
using TechTalk.SpecFlow;
using ThirdParty.Json.LitJson;

namespace NoonProject2
{
    [Binding]
    public class SignInStepDefinitions:BaseClass
    {
        SignIn signIn;
        public SignInStepDefinitions()
        {
             signIn = new(driver);
        }
        //json
        public List<JsonClass> homeReader = new List<JsonClass>();
        public static StreamReader r = new StreamReader(@"C:\Users\rugmap\OneDrive - Valorem Reply\Desktop\C#\MYDesignation\MYDesignation\Json/Json.json");
        public static string testData = r.ReadToEnd();
        public static JsonClass inputValue = JsonMapper.ToObject<JsonClass>(testData);

        [Given(@"user navigate to ""([^""]*)""")]
        public void GivenUserNavigateTo(string url)
        {
            driver.Navigate().GoToUrl(url);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(7);
            CmnMethod.AssertMethod();
        }

        [When(@"user click sign in symbol")]
        public void WhenUserClickSignInSymbol()
        {
            signIn.LoginSymbol.Click();
        }

        [Then(@"user enters fields and clicks sign in button")]
        public void ThenUserEntersFieldsAndClicksSignInButton()
        {
            CmnMethod.InvalidSignin();
        }

        [Then(@"user enter fields and clicks sign in button")]
        public void ThenUserEnterFieldsAndClicksSignInButton()
        {
            CmnMethod.Signin(inputValue.email, inputValue.password);
        }

    }
}
