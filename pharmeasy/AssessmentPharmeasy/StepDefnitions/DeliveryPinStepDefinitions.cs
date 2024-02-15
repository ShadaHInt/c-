using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace AssessmentPharmeasy
{
    [Binding]
    public class DeliveryPinStepDefinitions
    {
        IWebDriver driver = new ChromeDriver();

        [Given(@"user navigated to ""([^""]*)""")]
        public void GivenUserNavigatedTo(string url)
        {
            driver.Navigate().GoToUrl("http://www.pharmeasy.in");
            driver.Manage().Window.Maximize();
        }

        [When(@"click on Delivery to select Pin code")]
        public void WhenClickOnDeliveryToSelectPinCode()
        {
            Delivery delivery = new(driver);
            delivery.DeliverButton.Click();
            delivery.EnterPin.Click();
        }

        [When(@"enter pin code as (.*)")]
        public void WhenEnterPinCodeAs(string code)
        {
            Delivery delivery = new(driver);
            delivery.EnterPin.SendKeys(code);
            delivery.CheckButton.Click();

        }

        [When(@"error message displayed")]
        public void WhenErrorMessageDisplayed()
        {
            Delivery delivery = new(driver);
            Console.WriteLine("The error message displayed: " + delivery.ErrorMessage.Displayed);
            Thread.Sleep(2000);
        }

        [When(@"enter valid pin code")]
        public void WhenEnterValidPinCode()
        {
            Delivery delivery = new(driver);
            delivery.EnterPin.Clear();
            delivery.EnterPin.SendKeys("673001");
            delivery.CheckButton.Click();
            Thread.Sleep(1000);

        }

        [When(@"verify new pincode")]
        public void WhenVerifyNewPincode()
        {
            Delivery delivery = new(driver);
            Console.WriteLine("The new pincode displayed: " + delivery.PinDisplay.Displayed);
        }

        [Then(@"user quits app")]
        public void ThenUserQuitsApp()
        {
            driver.Quit();
        }
    }
}
