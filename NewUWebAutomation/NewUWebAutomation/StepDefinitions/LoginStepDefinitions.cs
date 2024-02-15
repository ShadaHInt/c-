
using TechTalk.SpecFlow;
using ThirdParty.Json.LitJson;

namespace NewUWebAutomation
{
    [Binding]
    public class LoginStepDefinitions:BaseClass
    {
        Loginpage loginpage => new(driver);
        public List<Readjson> homeReader = new List<Readjson>();
        public static StreamReader r = new StreamReader(@"C:\Users\amalsanthosh\OneDrive - Valorem Reply\Desktop\C# programs\NewUWebAutomation\NewUWebAutomation\TestData/Myjson.json");
        public static string testData = r.ReadToEnd();
        public static Readjson searchInput = JsonMapper.ToObject<Readjson>(testData);

        [When(@"the user enters wrong email and password")]
        public void WhenTheUserEntersWrongEmailAndPassword()
        {
            CommonCodes.Rest();
            loginpage.Email.SendKeys(searchInput.WrongEmail);
            loginpage.Password.SendKeys(searchInput.WrongPassword);
            loginpage.LoginBtn.Click();
        }

        [Then(@"the user enters clicks on Login and verify the error message")]
        public void ThenTheUserEntersClicksOnLogimAndVerifyTheErrorMessage()
        {
            CommonCodes.Rest();
            //Thread.Sleep(5000);
            Console.WriteLine("Error Message:"+loginpage.Errormsg.Text);
        }

        [When(@"the user enters correct email and password")]
        public void WhenTheUserEntersCorrectEmailAndPassword()
        {
            CommonCodes.Rest();
            loginpage.Email.SendKeys(searchInput.CorrectEmail);
            loginpage.Password.SendKeys(searchInput.CorrectPassword);
            loginpage.LoginBtn.Click();
        }

        [Then(@"the user prints account details")]
        public void ThenTheUserPrintsAccountDetails()
        {
            //Thread.Sleep(5000);
            Console.WriteLine("Account Details :"+loginpage.AccDeatils.Text);
        }
    }
}
