using Newprojectspecflow.Pages;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Newprojectspecflow
{
    [Binding]
    public class LoginpageStepDefinitions : BaseClass
    {

        [Given(@"the new login page window")]
        public void GivenTheNewLoginPageWindow()
        {
            loginpage loginpage1 = new(driver);
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.amazon.in/ap/signin?_encoding=UTF8&openid.assoc_handle=amazon_checkout_in&openid.claimed_id=http%3A%2F%2Fspecs.openid.net%2Fauth%2F2.0%2Fidentifier_select&openid.identity=http%3A%2F%2Fspecs.openid.net%2Fauth%2F2.0%2Fidentifier_select&openid.mode=checkid_setup&openid.ns=http%3A%2F%2Fspecs.openid.net%2Fauth%2F2.0&openid.ns.pape=http%3A%2F%2Fspecs.openid.net%2Fextensions%2Fpape%2F1.0&openid.pape.max_auth_age=0&openid.return_to=https%3A%2F%2Fwww.amazon.in%2Fgp%2Fbuy%2Fsignin%2Fhandlers%2Fcontinue.html%3Fie%3DUTF8%26brandId%3D%26cartItemIds%3D%26eGCApp%3D%26hasWorkingJavascript%3D0%26isEGCOrder%3D0%26isFresh%3D%26oldCustomerId%3D0%26oldPurchaseId%3D%26preInitiateCustomerId%3D%26purchaseInProgress%3D%26ref_%3Dcart_signin_submit%26siteDesign%3D&pageId=amazon_checkout_in&showRmrMe=0&siteState=isRegularCheckout.1%7CIMBMsgs.%7CisRedirect.1&suppressSignInRadioButtons=0");
            Console.WriteLine(driver.Title);
            loginpage1.emailbox.Click();
        }

        [When(@"the email is given the values")]
        public void WhenTheEmailIsGivenTheValues()
        {
            loginpage loginpage1 = new(driver);
            loginpage1.emailbox.SendKeys("446667");
        }

        [When(@"the continue is clicked")]
        public void WhenTheContinueIsClicked()
        {
            loginpage loginpage1 = new(driver);
            loginpage1.continuebox.Click();
        }

        [Then(@"the error message should verify")]
        public void ThenTheErrorMessageShouldVerify()
        {

        }
    }
}
