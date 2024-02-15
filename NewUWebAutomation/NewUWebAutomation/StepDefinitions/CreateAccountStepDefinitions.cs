
using TechTalk.SpecFlow;
using ThirdParty.Json.LitJson;

namespace NewUWebAutomation
{
    [Binding]
    public class CreateAccountStepDefinitions:BaseClass
    {
        CreateAccount createAccount => new(driver);

        public List<Readjson> homeReader = new List<Readjson>();
        public static StreamReader r = new StreamReader(@"C:\Users\amalsanthosh\OneDrive - Valorem Reply\Desktop\C# programs\NewUWebAutomation\NewUWebAutomation\TestData/Myjson.json");
        public static string testData = r.ReadToEnd();
        public static Readjson searchInput = JsonMapper.ToObject<Readjson>(testData);

        [When(@"the user clicks on Create an account")]
        public void WhenTheUserClicksOnCreateAnAccount()
        {
            CommonCodes.Rest();
            createAccount.User.Click();
            createAccount.CreateAccountt.Click();   
        }

        [Then(@"the user provides invalid first name and last name")]
        public void ThenTheUserProvidesInvalidFirstNameAndLastName()
        {
            CommonCodes.Rest();
            createAccount.FirstName.SendKeys(searchInput.InvalidFirstName);
            createAccount.LastName.SendKeys(searchInput.InvalidLastName);
           
        }

        [When(@"the user provides invalid email and password")]
        public void WhenTheUserProvidesInvalidEmailAndPassword()
        {
            CommonCodes.Rest();
            createAccount.Email.SendKeys(searchInput.InavlidEmail);
            createAccount.Password.SendKeys(searchInput.InvalidPassword);
        }

        [Then(@"the user prints the error message")]
        public void ThenTheUserPrintsTheErrorMessage()
        {
            createAccount.CreatAcc.Click();
            Console.WriteLine(createAccount.ErrorMsg.Text);
        }

        [Then(@"the user provides valid first name and last name")]
        public void ThenTheUserProvidesValidFirstNameAndLastName()
        {
            CommonCodes.Rest();
            createAccount.FirstName.SendKeys(searchInput.ValidFirstName);
            createAccount.LastName.SendKeys(searchInput.ValidLastName);
        }

        [When(@"the user provides valid email and password")]
        public void WhenTheUserProvidesValidEmailAndPassword()
        {
            CommonCodes.Rest();
            createAccount.Email.SendKeys(searchInput.ValidEmail);
            createAccount.Password.SendKeys(searchInput.ValidPassword);
            createAccount.CreatAcc.Click();
        }

        [Then(@"the user clicks on user icon")]
        public void ThenTheUserClicksOnUserIcon()
        {
            CommonCodes.Rest();
           
           createAccount.User.Click();
           // createAccount.Google.Click();
        }
    }
}
