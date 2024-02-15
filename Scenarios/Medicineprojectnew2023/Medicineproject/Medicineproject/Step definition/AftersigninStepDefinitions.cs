using OpenQA.Selenium.Interactions;
using System;
using TechTalk.SpecFlow;
using ThirdParty.Json.LitJson;

namespace Medicineproject
{
    [Binding]
    public class AftersigninStepDefinitions:BaseClass1
    {

        Aftersignin afters => new(driver);
        Actions actions = new Actions(driver);
        public List<Class1> homeReader = new List<Class1>();
        public static StreamReader r = new StreamReader(@"C:\\Users\\shadan\\Desktop\\C#\\Scenarios\\Medicineproject\\Medicineproject\\Test/jsconfig1.json");
        public static string testdata = r.ReadToEnd();
        public static Class1 searchInput = JsonMapper.ToObject<Class1>(testdata);
        [When(@"when user sign in")]
        public void WhenWhenUserSignIn()
        {
            afters.signin.Click();
            afters.emaila.SendKeys(searchInput.ValidData[2]);
            afters.passa.SendKeys(searchInput.ValidData[3]);

            Thread.Sleep(1000);
            Common.scrollbar(0, 500);
            afters.signbt.Click();
        }

        [Then(@"user verifies whether welcome message is printed")]
        public void ThenUserVerifiesWhetherWelcomeMessageIsPrinted()
        {
            string stringToTest = "Welcome, Shad xxx!";
            StringAssert.Contains(stringToTest, "Shad");
            Console.WriteLine("Welcome text:" + afters.stext.Text);
        }

        [When(@"user mouse hover on categories")]
        public void WhenUserMouseHoverOnCategories()
        {
            Common.Action(afters.category1);
            Common.Action(afters.firstaid);
        }

        [Then(@"user mouse hover on the first aid and health care an then on cough cold an flu")]
        public void ThenUserMouseHoverOnTheFirstAidAndHealthCareAnThenOnCoughColdAnFlu()
        {
            
            actions.MoveToElement(afters.flu).Perform();
            afters.flu.Click();
            afters.fluelement.Click();

        }

        [When(@"user clicks on quantity button and prints product details and price")]
        public void WhenUserClicksOnQuantityButtonAndPrintsProductDetailsAndPrice()
        {
            Thread.Sleep(1000);
            afters.qnty.Click();
            Console.WriteLine("Price is:" +afters. price1.Text);
            Console.WriteLine("Product details:" +afters. des1.Text);
            Common.scrollbar(0, 200);
        }

        [Then(@"user add the item to cart")]
        public void ThenUserAddTheItemToCart()
        {
            afters.addc.Click();
        }

        [When(@"user mouse hover on homeo and select an element print description price and add it to cart")]
        public void WhenUserMouseHoverOnHomeoAndSelectAnElementPrintDescriptionPriceAndAddItToCart()
        {
            actions.MoveToElement(afters.homeo).Perform();
            afters.homeo.Click();
            afters.ele3.Click();
            Common.scrollbar(0, 400);
            Thread.Sleep(2000);
            Console.WriteLine("Price is:" + afters.price1.Text);
            Console.WriteLine("Product details:" + afters.des1.Text);
            afters.addc.Click();
        }

        [Then(@"user again mouse hover on category and then baby care and then over baby gripe water")]
        public void ThenUserAgainMouseHoverOnCategoryAndThenBabyCareAndThenOverBabyGripeWater()
        {
            Common.Action(afters.category1);
            Common.Action(afters.babycare);
            actions.MoveToElement(afters.gripe).Perform();
            afters.gripe.Click();
            afters.elementgripe.Click();



        }

        [When(@"user prints price description and add it to cart")]
        public void WhenUserPrintsPriceDescriptionAndAddItToCart()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Price is:" + afters.sprice.Text);
            Console.WriteLine("Product details:" + afters.des1.Text);
            afters.addc2.Click();
        }

        [Then(@"user mouse hover on category then protein and on weight loss")]
        public void ThenUserMouseHoverOnCategoryThenProteinAndOnWeightLoss()
        {
            Common.Action(afters.category1);
            Common.Action(afters.protein);
            afters.protein.Click();
            afters.wloss.Click();

        }

        [When(@"user selects a range and select an element then added it to the cart")]
        public void WhenUserSelectsARangeAndSelectAnElementThenAddedItToTheCart()
        {
            afters.range1.Click();
            afters.milab.Click();
            afters.addc.Click();
        }

        [Then(@"user mouse hover homeo then disease and then children")]
        public void ThenUserMouseHoverHomeoThenDiseaseAndThenChildren()
        {
            actions.MoveToElement(afters.homeo).Perform();
            actions.MoveToElement(afters.disease).Perform();
            actions.MoveToElement(afters.children).Perform();
            afters.children.Click();
        }

        [When(@"user selects price range and then click on the element print price and add to cart")]
        public void WhenUserSelectsPriceRangeAndThenClickOnTheElementPrintPriceAndAddToCart()
        {
            afters.range2.Click();
            Common.scrollbar(0, 300);
            Thread.Sleep(2000);
            afters.hele.Click();
            afters.addc.Click();
        }

        [Then(@"user clicks on google icon and then selects user and enters password")]
        public void ThenUserClicksOnGoogleIconAndThenSelectsUserAndEntersPassword()
        {
            afters.google.Click();
            Common.Window();
            Thread.Sleep(2000);
            afters.mail.Click();
            afters.mail.SendKeys(searchInput.ValidData[2]);
            Thread.Sleep(3000);
            afters.mailnxt.Click();
            //afters.pass.Click();
            //afters.pass.SendKeys(searchInput.ValidData[3]);
            //Thread.Sleep(2000);
            //afters.nextbt.Click();

        }

        [Then(@"user mouse hover on categories and then on first aid and on health device")]
        public void ThenUserMouseHoverOnCategoriesAndThenOnFirstAidAndOnHealthDevice()
        {
            Common.Action(afters.category1);
            Common.Action(afters.hdevice);

        }

        [When(@"again mouse hover on health instruments and on thermometer")]
        public void WhenAgainMouseHoverOnHealthInstrumentsAndOnThermometer()
        {
            actions.MoveToElement(afters.hinstru).Perform();
            actions.MoveToElement(afters.thermo).Perform();
            afters.thermo.Click();
            Thread.Sleep(2000);
            afters.thermoele.Click();
            
        }

        [Then(@"clicks on add to cart")]
        public void ThenClicksOnAddToCart()
        {
            Common.scrollbar(0, 300);
            afters.addc.Click();
        }

        [When(@"user clcik on bag button and then on checkout button")]
        public void WhenUserClcikOnBagButtonAndThenOnCheckoutButton()
        {
            afters.bag.Click();
            afters.chk.Click();
        }

        [Then(@"user enters all the credentials required")]
        public void ThenUserEntersAllTheCredentialsRequired()
        {
            Thread.Sleep(5000);
            actions.MoveToElement(afters.newadd).Perform();
            afters.newadd.Click();
            Thread.Sleep(2000);
            afters.cmpny.SendKeys(searchInput.Payment[0]);
            afters.addre.SendKeys(searchInput.Payment[1]);
            afters.street1.SendKeys(searchInput.Payment[2]);
            afters.street2.SendKeys(searchInput.Payment[3]);
            Common.scrollbar(0, 300);
            afters.region.Click();
            afters.kerala.Click();
            afters.city.SendKeys(searchInput.Payment[4]);
            afters.post.SendKeys(searchInput.Payment[5]);
            afters.tele.SendKeys(searchInput.Payment[6]);
            afters.chkbox.Click();
            Thread.Sleep(2000);
            afters.shiphere.Click();
            

        }

        [When(@"user clicks on next option")]
        public void WhenUserClicksOnNextOption()
        {
            afters.next4.Click();
        }

        [Then(@"user selects a payment option and proceed it")]
        public void ThenUserSelectsAPaymentOptionAndProceedIt()
        {
            afters.rpay.Click();
            Thread.Sleep(3000);
            afters.proceed.Click();
        }
    }
}
