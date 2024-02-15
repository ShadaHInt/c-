using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using TechTalk.SpecFlow;

namespace Myntraproject
{
    [Binding]
    public class AddToCartStepDefinitions : BaseClass
    {
        AddToCartPage cart => new(driver);
        IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
        Actions actions = new Actions(driver);

        [When(@"user clicks on shirts on the men category")]
        public void WhenUserClicksOnShirtsOnTheMenCategory()
        {
            
            actions.MoveToElement(cart.men).Perform();
            cart.casual.Click();

        }

        [Then(@"select the first item in the casual shirts")]
        public void ThenSelectTheFirstItemInTheCasualShirts()
        {
             
            cart.firstmen.Click();
           

        }



        [When(@"user needs to select size and user add this item to bag")]
        public void WhenUserNeedsToSelectSizeAndUserAddThisItemToBag()
        {
            driver.SwitchTo().Window(driver.WindowHandles[1]);
           
            
            cart.size1.Click();
            
            cart.addbag.Click();
            //cart.addbag.Click();
            cart.bag.Click();
            cart.placeorder.Click();
        }


        //[When(@"user clicks on casual shirts on the kids category")]
        //public void WhenUserClicksOnCasualShirtsOnTheKidsCategory()
        //{
            
        //    actions.MoveToElement(cart.kids).Perform();
            
        //    cart.shirts.Click();

        //}

        //[Then(@"select the first item in the  shirts")]
        //public void ThenSelectTheFirstItemInTheShirts()
        //{
            
        //    cart.firstk.Click();

        //}

        //[When(@"user needs to select size of the item and user add the item to bag")]
        //public void WhenUserNeedsToSelectSizeOfTheItemAndUserAddTheItemToBag()
        //{
        //    driver.SwitchTo().Window(driver.WindowHandles[1]);
        //    cart.size2.Click();
            
        //    cart.addbag.Click();
        //    cart.bag.Click();
        //    cart.placeorder.Click();

        //}


        //[When(@"user clicks on casual shirts on the women category")]
        //public void WhenUserClicksOnCasualShirtsOnTheWomenCategory()
        //{
        //    actions.MoveToElement(cart.women).Perform();
        //    cart.kurta.Click();

        //}

        //[Then(@"select the first item in the kurtas and suits")]
        //public void ThenSelectTheFirstItemInTheKurtasAndSuits()
        //{
            
        //    cart.firstw.Click();

        //}

        //[When(@"user select the size of the item and user then add item to bag")]
        //public void WhenUserSelectTheSizeOfTheItemAndUserThenAddItemToBag()
        //{
        //    driver.SwitchTo().Window(driver.WindowHandles[1]);
        //    cart.size3.Click();

        //    cart.addbag.Click();
        //}

    }
}
