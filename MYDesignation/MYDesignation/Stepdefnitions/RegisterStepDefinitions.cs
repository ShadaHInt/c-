using System;
using TechTalk.SpecFlow;
using ThirdParty.Json.LitJson;

namespace NoonProject2
{
    [Binding] 
    public class RegisterStepDefinitions:BaseClass
    {
        Register register;

        public RegisterStepDefinitions()
        {
            register = new(driver);
        }
        //json
        public List<JsonClass> homeReader = new List<JsonClass>();
        public static StreamReader r = new StreamReader(@"C:\Users\rugmap\OneDrive - Valorem Reply\Desktop\C#\MYDesignation\MYDesignation\Json/Json.json");
        public static string testData = r.ReadToEnd();
        public static JsonClass inputValue = JsonMapper.ToObject<JsonClass>(testData);

        [Given(@"user navigates to ""([^""]*)""")]
        public void GivenUserNavigatesTo(string url)
        {
            driver.Navigate().GoToUrl(url);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(7);
            CmnMethod.AssertMethod();
        }

        [When(@"user clicks login symbol")]
        public void WhenUserClicksLoginSymbol()
        {
            register.LoginSymbol.Click();
        }

        [When(@"user selects register and enter fields")]
        public void WhenUserSelectsRegisterAndEnterFields()
        {
            CmnMethod.Reg(inputValue.email, inputValue.password, inputValue.firstname, inputValue.lastname);
        }

        [Then(@"user clicks register button")]
        public void ThenUserClicksRegisterButton()
        {
            register.CreateAccount.Click();                      
        }

        [When(@"user selects register and enters fields")]
        public void WhenUserSelectsRegisterAndEntersFields()
        {
            CmnMethod.RegNegative();
        }

        [Then(@"user click register button")]
        public void ThenUserClickRegisterButton()
        {
            register.CreateAccount.Click();
        }

    }
}
