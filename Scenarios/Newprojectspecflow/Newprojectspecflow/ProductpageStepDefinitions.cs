using Newprojectspecflow.Pages;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;

namespace Newprojectspecflow
{
    [Binding]
    public class ProductpageStepDefinitions :BaseClass
    {
        productpage productpage1 = new(driver);
        loginpage loginpage2 = new(driver);
        [Given(@"the new page will open")]
        public void GivenTheNewPageWillOpen()
        {
            productpage1.check.Click();
            //secondpage.radiob.Click();
            //CommonCodes.scroll(0, 500);
            
            //productpage1.dropdwn.Click();
            SelectElement selectone = new SelectElement(productpage1.dropdwn);
            /*IList<IWebelement> elements = (IList<IWebelement>)selectone.Options;
            for(int i = 0; i < elements.Count; i++)
            {
                Console.WriteLine(elements[i]);
            }*/

            selectone.SelectByText("Appliances");
            Console.WriteLine("Appliances is selectred from drop down");
            Thread.Sleep(4000);
            driver.Navigate().Refresh();
            
        }

        [When(@"the given page is loaded")]
        public void WhenTheGivenPageIsLoaded()
        {
            productpage1.addtocart.Click();
           productpage1.checkout.Click();
           // driver.SwitchTo().Window(driver.WindowHandles[1]);
        }

        [Then(@"perform the actions")]
        public void ThenPerformTheActions()
        {
            //driver.Quit();
            

        }
    }
}
