
using TechTalk.SpecFlow;
using ThirdParty.Json.LitJson;

namespace Medicineproject
{
    [Binding]
    public class SigninStepDefinitions:BaseClass1
    {
        Signin sign => new(driver);
        public List<Class1> homeReader = new List<Class1>();
        public static StreamReader r = new StreamReader(@"C:\\Users\\shadan\\Desktop\\C#\\Scenarios\\Medicineproject\\Medicineproject\\Test/jsconfig1.json");
        public static string testdata = r.ReadToEnd();
        public static Class1 searchInput = JsonMapper.ToObject<Class1>(testdata);

        [Given(@"user navigated to the online medical store homepage")]
        public void GivenUserNavigatedToTheOnlineMedicalStoreHomepage()
        {
            driver.Navigate().GoToUrl("https://www.onlinemedicalstore.com/");
        }

        [When(@"the user clicks on the sign in button")]
        public void WhenTheUserClicksOnTheSignInButton()
        {
            sign.signin.Click();
        }

        [Then(@"the user enters emailone and passone")]
        public void ThenTheUserEntersEmailoneAndPassone()
        {
            sign.emaila.SendKeys(searchInput.SignV[0]);
            sign.passa.SendKeys(searchInput.SignV[1]);

            Thread.Sleep(1000);
            Common.scrollbar(0, 500);
            
        }

        [When(@"user selects the sign in button")]
        public void WhenUserSelectsTheSignInButton()
        {
            
            sign.signbt.Click();

        }
        [Then(@"the user enters emailthree and passthree")]
        public void ThenTheUserEntersEmailthreeAndPassthree()
        {
            sign.emaila.SendKeys(searchInput.SignI[0]);
            sign.passa.SendKeys(searchInput.SignI[1]);

            Thread.Sleep(1000);
            Common.scrollbar(0, 500);
            
        }



    }
}
