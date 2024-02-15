using OpenQA.Selenium.Interactions;
using TechTalk.SpecFlow;

namespace NewUWebAutomation
{
    [Binding]
    public class AddItemsStepDefinitions:BaseClass
    {
        AddItemsPage addItemsPage => new(driver);

        [Then(@"the user adds first product to the cart")]
        public void ThenTheUserAddsFirstProductToTheCart()
        {
            CommonCodes.Rest();
            CommonCodes.scroll(0, 500);
            CommonCodes.mousehover(addItemsPage.ProdOne);
            addItemsPage.AddToBag.Click();
            addItemsPage.ContinueShopping.Click();
        }

        [When(@"the user mousehover to the shop skin and clicks on Lip balm")]
        public void WhenTheUserMouseoverToTheShopSkinAndClicksOnLipBalm()
        {
            CommonCodes.Rest();
            CommonCodes.mousehover(addItemsPage.Shop);
            CommonCodes.mousehover(addItemsPage.Skin);
            addItemsPage.LipBalm.Click();
        }

        [When(@"the user mousehover to shop bath and body and clicks on sunscreen")]
        public void WhenTheUserMousehoverToShopBathAndBodyAndClicksOnSunscreen()
        {
            CommonCodes.Rest();
            CommonCodes.mousehover(addItemsPage.Shop);
            CommonCodes.mousehover(addItemsPage.BathNbody);
            addItemsPage.Sunscreen.Click();
        }
        [When(@"the user clicks on proceed to checkout")]
        public void WhenTheUserClicksOnProceedToCheckout()
        {
            CommonCodes.Rest();
            addItemsPage.ProceedCheckout.Click();
        }

        [Then(@"the user prints the total amount")]
        public void ThenTheUserPrintsTheTotalAmount()
        {
            CommonCodes.Rest();
            Console.WriteLine("The Total Price:"+addItemsPage.Total.Text);
        }

    }
}
