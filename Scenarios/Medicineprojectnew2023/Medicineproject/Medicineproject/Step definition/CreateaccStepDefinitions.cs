using System;
using TechTalk.SpecFlow;
using ThirdParty.Json.LitJson;

namespace Medicineproject
{
    [Binding]
    public class CreateaccStepDefinitions:BaseClass1
    {
        Createacc cacc => new(driver);
        public List<Class1> homeReader = new List<Class1>();
        public static StreamReader r = new StreamReader(@"C:\\Users\\shadan\\Desktop\\C#\\Scenarios\\Medicineproject\\Medicineproject\\Test/jsconfig1.json");
        public static string testdata = r.ReadToEnd();
        public static Class1 searchInput1 = JsonMapper.ToObject<Class1>(testdata);
        [Given(@"the user is navigated to the homepage of the onlinemedical store")]
        public void GivenTheUserIsNavigatedToTheHomepageOfTheOnlinemedicalStore()
        {
            driver.Navigate().GoToUrl("https://www.onlinemedicalstore.com/");
        }

        [When(@"user clicks on Create an account icon")]
        public void WhenUserClicksOnCreateAnAccountIcon()
        {
            cacc.createicon.Click();
        }

        [Then(@"user enters firstnameone lastnameone emailone passwone and cpasswone")]
        public void ThenUserEntersFirstnameoneLastnameoneEmailonePasswoneAndCpasswone()
        {
            cacc.firstname.SendKeys(searchInput1.ValidData[0]);
            cacc.lastname.SendKeys(searchInput1.ValidData[1]);
            cacc.email.SendKeys(searchInput1.ValidData[2]); ;
            cacc.passw.SendKeys(searchInput1.ValidData[3]);
            cacc.cpassw.SendKeys(searchInput1.ValidData[4]);
            Common.scrollbar(0, 300);
        }

        [When(@"user clicks on create an account")]
        public void WhenUserClicksOnCreateAnAccount()
        {
            cacc.createbt.Click();
        }
        [Then(@"user enters firstnametwo lastnametwo emailtwo passwtwo and cpasswtwo")]
        public void ThenUserEntersFirstnametwoLastnametwoEmailtwoPasswtwoAndCpasswtwo()
        {
            cacc.firstname.SendKeys(searchInput1.InvalidData[0]);
            cacc.lastname.SendKeys(searchInput1.InvalidData[1]);
            cacc.email.SendKeys(searchInput1.InvalidData[2]);
            cacc.passw.SendKeys(searchInput1.InvalidData[3]);
            cacc.cpassw.SendKeys(searchInput1.InvalidData[4]);
            Common.scrollbar(0, 300);

        }

    }
}
