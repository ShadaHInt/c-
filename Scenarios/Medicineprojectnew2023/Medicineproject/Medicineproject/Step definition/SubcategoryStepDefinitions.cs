using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using TechTalk.SpecFlow;

namespace Medicineproject
{
    [Binding]
    public class SubcategoryStepDefinitions:BaseClass1
    {
        Subcategory sub=> new(driver);
        Actions actions = new Actions(driver);
        DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver);
        
        [Given(@"user  navigated to the online medical store homepage")]
        public void GivenUserNavigatedToTheOnlineMedicalStoreHomepage()
        {
            driver.Navigate().GoToUrl("https://www.onlinemedicalstore.com/");
        }

        [When(@"user mouse hover on first aid")]
        public void WhenUserMouseHoverOnFirstAid()
        {
            Common.Action(sub.category1);
            Common.Action(sub.firstaid);
        }

        [Then(@"user mouse hover on pain management and click first element")]
        public void ThenUserMouseHoverOnPainManagementAndClickFirstElement()
        {
            actions.MoveToElement(sub.pain).Perform();
            sub.pain.Click();
            sub.volini.Click();
            
        }

        [When(@"user hover over cough and cold under first aid")]
        public void WhenUserHoverOverCoughAndColdUnderFirstAid()
        {
            
            Thread.Sleep(2000);
            Common.Action(sub.category1);
            Common.Action(sub.firstaid);
            actions.MoveToElement(sub.flu).Perform();
            sub.flu.Click();
        }

        [Then(@"select the first element in the first aid and click on add to cart")]
        public void ThenSelectTheFirstElementInTheFirstAidAndClickOnAddToCart()
        {
            Thread.Sleep(2000);
            sub.flufirst.Click();
            sub.addc1.Click();
        }

        [When(@"user mouse hover over stomach and acid reflux subcategory of first aid")]
        public void WhenUserMouseHoverOverStomachAndAcidRefluxSubcategoryOfFirstAid()
        {
            Common.Action(sub.category1);
            Common.Action(sub.firstaid);
            sub.stomach.Click();
        }

        [Then(@"user selects the first element and click on add to cart")]
        public void ThenUserSelectsTheFirstElementAndClickOnAddToCart()
        {
            sub.sfirst.Click();
            sub.addc1.Click();
        }

        [When(@"user mouse hover on first aid and care and  click on hot gel pad")]
        public void WhenUserMouseHoverOnFirstAidAndCareAndClickOnHotGelPad()
        {
            Common.Action(sub.category1);
            Common.Action(sub.firstaid);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(12));
            wait.Until(ExpectedConditions.ElementExists(By.CssSelector("a[title='First Aid & Health Care']")));
            //Common.Webdriver("a[title='First Aid & Health Care']");
            sub.fcare.Click();

        }

        [Then(@"user select the first element of hot gel and pad and click on add to cart")]
        public void ThenUserSelectTheFirstElementOfHotGelAndPadAndClickOnAddToCart()
        {
            sub.gelpad.Click();
        }

        [When(@"user returns back to homepage")]
        public void WhenUserReturnsBackToHomepage()
        {

            driver.Navigate().GoToUrl("https://www.onlinemedicalstore.com/");
        }



        [When(@"user mouse hover on the proteins and vitamin")]
        public void WhenUserMouseHoverOnTheProteinsAndVitamin()
        {
            Common.Action(sub.category1);
            Common.Action(sub.protein);
        }

        [Then(@"user mouse hover and clicks on weightloss")]
        public void ThenUserMouseHoverAndClicksOnWeightloss()
        {
            actions.MoveToElement(sub.weightloss).Perform();
            sub.weightloss.Click();
        }

        [When(@"user selects the first element in the weightloss page and add it to the cart")]
        public void WhenUserSelectsTheFirstElementInTheWeightlossPageAndAddItToTheCart()
        {
            actions.MoveToElement(sub.milab).Perform();
            Thread.Sleep(2000);
            sub.milab.Click();
            sub.addc1.Click();
        }

        [Then(@"user mouse hover on the multivitamin and click it")]
        public void ThenUserMouseHoverOnTheMultivitaminAndClickIt()
        {
            Common.Action(sub.category1);
            Common.Action(sub.protein);
            actions.MoveToElement(sub.multivitamin).Perform();
            sub.multivitamin.Click();
        }

        [When(@"user selects the element in that page and add it to cart")]
        public void WhenUserSelectsTheElementInThatPageAndAddItToCart()
        {
            sub.multifirstele.Click();
            sub.addc1.Click();
        }

        [Then(@"user mouse hover on the calcium")]
        public void ThenUserMouseHoverOnTheCalcium()
        {
            Common.Action(sub.category1);
            Common.Action(sub.protein);
            actions.MoveToElement(sub.calcium).Perform();
        }

        [When(@"user clicks on first item and add it to the cart")]
        public void WhenUserClicksOnFirstItemAndAddItToTheCart()
        {
            sub.calcium.Click();
            sub.calciumfirst.Click();
            sub.addc1.Click();
        }


        [When(@"user mouse hover on diabetes the subcategory of category")]
        public void WhenUserMouseHoverOnDiabetesTheSubcategoryOfCategory()
        {
            Common.Action(sub.category1);
            Common.Action(sub.diabetes);

        }

        [Then(@"user mouse hover on monitoring device and click it")]
        public void ThenUserMouseHoverOnMonitoringDeviceAndClickIt()
        {
            actions.MoveToElement(sub.mdevice).Perform();
            sub.mdevice.Click();
        }

        [When(@"user selects the first item in the monitoring device and add it to cart")]
        public void WhenUserSelectsTheFirstItemInTheMonitoringDeviceAndAddItToCart()
        {
            sub.accu.Click();
            sub.addc1.Click();
        }

        [Then(@"user mouse hover on testing supplies and click it")]
        public void ThenUserMouseHoverOnTestingSuppliesAndClickIt()
        {
            Common.Action(sub.category1);
            Common.Action(sub.diabetes);
            actions.MoveToElement(sub.testingsupplies).Perform();
            sub.testingsupplies.Click();
        }

        [When(@"user selects the first item in the supplies and add it to cart")]
        public void WhenUserSelectsTheFirstItemInTheSuppliesAndAddItToCart()
        {
            sub.elementsup.Click();
            sub.addc1.Click();
        }

        [Then(@"user mouse hover on lancet and click it")]
        public void ThenUserMouseHoverOnLancetAndClickIt()
        {
            Common.Action(sub.category1);
            Common.Action(sub.diabetes);
            actions.MoveToElement(sub.lancet).Perform();
            sub.lancet.Click();
        }

        [When(@"user choose the element and click on add to cart")]
        public void WhenUserChooseTheElementAndClickOnAddToCart()
        {
            sub.lancetele.Click();
            
            fluentWait.Timeout = TimeSpan.FromSeconds(2);
            fluentWait.PollingInterval = TimeSpan.FromMilliseconds(100);
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            fluentWait.Message = "Element to be searched not found";
            IWebElement searchResult = fluentWait.Until(x => x.FindElement(By.CssSelector("button#product-addtocart-button")));
            sub.addc1.Click();
        }


        [When(@"user mouse hover on baby care subcategory of category")]
        public void WhenUserMouseHoverOnBabyCareSubcategoryOfCategory()
        {
            Common.Action(sub.category1);
            Common.Action(sub.babycare);

        }

        [Then(@"user mouse hover on skin care and then on baby oil")]
        public void ThenUserMouseHoverOnSkinCareAndThenOnBabyOil()
        {
            actions.MoveToElement(sub.skincare).Perform();
        }

        [When(@"user select the first item in baby oil and add it to cart")]
        public void WhenUserSelectTheFirstItemInBabyOilAndAddItToCart()
        {
            actions.MoveToElement(sub.babyoil).Perform();
            sub.babyoil.Click();
            sub.dabour.Click();
            sub.addc1.Click();
        }

        [Then(@"user mouse hover on baby gripe water")]
        public void ThenUserMouseHoverOnBabyGripeWater()
        {
            Common.Action(sub.category1);
            Common.Action(sub.babycare);
            actions.MoveToElement(sub.gripe).Perform();
            sub.gripe.Click();
        }

        [When(@"user select the item from baby gripe water and add it to the cart")]
        public void WhenUserSelectTheItemFromBabyGripeWaterAndAddItToTheCart()
        {
            sub.elementgripe.Click();
            sub.addc1.Click();
        }

        [Then(@"user mouse hover on baby food and click it")]
        public void ThenUserMouseHoverOnBabyFoodAndClickIt()
        {
            Common.Action(sub.category1);
            Common.Action(sub.babycare);
            actions.MoveToElement(sub.bfood).Perform();
            sub.bfood.Click();
        }

        [When(@"user selects the first element from baby food and add it to the cart")]
        public void WhenUserSelectsTheFirstElementFromBabyFoodAndAddItToTheCart()
        {
            sub.bfoodele.Click();
            sub.addc1.Click();
        }

        [When(@"user mouse hover on body building and hover again on pre or post workout")]
        public void WhenUserMouseHoverOnBodyBuildingAndHoverAgainOnPreOrPostWorkout()
        {
            Common.Action(sub.category1);
            Common.Action(sub.bbuilding);
            actions.MoveToElement(sub.prepost).Perform();
        }

        [Then(@"user select the element from pre or post work out and click on add it to cart")]
        public void ThenUserSelectTheElementFromPreOrPostWorkOutAndClickOnAddItToCart()
        {
            sub.prepost.Click();
            sub.elementpre.Click();
            sub.addc1.Click();
        }

        [When(@"user hover on the protein suppliment and click it")]
        public void WhenUserHoverOnTheProteinSupplimentAndClickIt()
        {
            Common.Action(sub.category1);
            Common.Action(sub.bbuilding);
            actions.MoveToElement(sub.psuppli).Perform();
            sub.psuppli.Click();

        }

        [Then(@"select the first element from suppliment add it to cart")]
        public void ThenSelectTheFirstElementFromSupplimentAddItToCart()
        {
            sub.psuppliel.Click();
            sub.addc1.Click();
        }

        [When(@"user hover on weight management and click it and select the first item and add it to cart")]
        public void WhenUserHoverOnWeightManagementAndClickItAndSelectTheFirstItemAndAddItToCart()
        {
            Common.Action(sub.category1);
            Common.Action(sub.bbuilding);
            actions.MoveToElement(sub.weight).Perform();
            sub.weight.Click();
            sub.weightele.Click();
            sub.addc1.Click();
        }

        [Then(@"user hover on workout essentials and click it and then select the item and add it to cart")]
        public void ThenUserHoverOnWorkoutEssentialsAndClickItAndThenSelectTheItemAndAddItToCart()
        {
            Common.Action(sub.category1);
            Common.Action(sub.bbuilding);
            fluentWait.Timeout = TimeSpan.FromSeconds(2);
            fluentWait.PollingInterval = TimeSpan.FromMilliseconds(100);
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            fluentWait.Message = "Element to be searched not found";
            IWebElement searchResult = fluentWait.Until(x => x.FindElement(By.CssSelector("a[title='Workout Essentials']")));
            actions.MoveToElement(sub.workout).Perform();
            sub.workout.Click();
            sub.workoutele.Click();
            sub.addc1.Click();
        }

        [When(@"user hover on health device and then on health instruments")]
        public void WhenUserHoverOnHealthDeviceAndThenOnHealthInstruments()
        {
            Common.Action(sub.category1);
            Common.Action(sub.hdevice);
            actions.MoveToElement(sub.hinstru).Perform();


        }

        [Then(@"user hover on thermometer")]
        public void ThenUserHoverOnThermometer()
        {
            actions.MoveToElement(sub.thermo).Perform();
            sub.thermo.Click();
        }

        [When(@"user select an element an add it to the cart")]
        public void WhenUserSelectAnElementAnAddItToTheCart()
        {
            sub.thermoele.Click();
            sub.addc1.Click();
        }

        [Then(@"user hover on monitoring device and clcik it")]
        public void ThenUserHoverOnMonitoringDeviceAndClcikIt()
        {
            Common.Action(sub.category1);
            Common.Action(sub.hdevice);
            actions.MoveToElement(sub.hmonitor).Perform();
            sub.hmonitor.Click();

        }

        [When(@"select the first element from monitoring device and add it to cart")]
        public void WhenSelectTheFirstElementFromMonitoringDeviceAndAddItToCart()
        {
            sub.bp.Click();
            sub.addc1.Click();
        }

        [Then(@"mouse hover on pain management and on body support and click it")]
        public void ThenMouseHoverOnPainManagementAndOnBodySupportAndClickIt()
        {
            Common.Action(sub.category1);
            Common.Action(sub.hdevice);
            actions.MoveToElement(sub.pmanage).Perform();
            sub.pmanage.Click();

        }



    }
}
