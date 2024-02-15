using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Threading;

namespace Test1
{
    [TestClass]
    public class ActionDemoClass
    {
        [TestMethod]
        public void KeyDownandUpAction()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demoqa.com/automation-practice-form");
            driver.Manage().Window.Maximize();

            IWebElement element = driver.FindElement(By.Id("firstName"));

            Actions action = new Actions(driver);

            //action.KeyDown(element, Keys.Shift).Perform();
            //action.SendKeys("Test").Perform();
            //action.KeyUp(Keys.Shift).Perform();

            action = action.KeyDown(element, Keys.Shift).SendKeys("Test").KeyUp(Keys.Shift);
            action.Build().Perform();

            Thread.Sleep(TimeSpan.FromSeconds(5));
        }

        [TestMethod]
        public void KeyboardEventsUsingActions()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demoqa.com/text-box");
            driver.Manage().Window.Maximize();
            Actions actions = new Actions(driver);

            // Enter the Current Address
            IWebElement currentAddress = driver.FindElement(By.Id("currentAddress"));

            currentAddress.SendKeys("43 School Lane London EC71 9GO");

            Thread.Sleep(TimeSpan.FromSeconds(3));


            // Select the Current Address
            actions.KeyDown(Keys.Control).SendKeys("a").KeyUp(Keys.Control).Build().Perform();

            Thread.Sleep(TimeSpan.FromSeconds(3));

            // Copy the Current Address
            actions.KeyDown(Keys.Control).SendKeys("c").KeyUp(Keys.Control).Build().Perform();

            //Press the TAB Key to Switch Focus to Permanent Address
            actions.SendKeys(Keys.Tab).Build().Perform();

            Thread.Sleep(TimeSpan.FromSeconds(3));

            //Paste the Address in the Permanent Address field
            actions.KeyDown(Keys.Control).SendKeys("v").KeyUp(Keys.Control).Build().Perform();

            Thread.Sleep(TimeSpan.FromSeconds(3));

            //Compare Text of current Address and Permanent Address
            IWebElement permanentAddress = driver.FindElement(By.Id("permanentAddress"));
            Assert.AreEqual(currentAddress.GetAttribute("value"), permanentAddress.GetAttribute("value"));


            driver.Close();
        }

        [TestMethod]
        public void ClickAction()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demoqa.com/buttons");
            driver.Manage().Window.Maximize();
            Actions actions = new Actions(driver);

            IWebElement rightClickElement = driver.FindElement(By.Id("rightClickBtn"));
            IWebElement doubleClickElement = driver.FindElement(By.Id("doubleClickBtn"));

            actions.ContextClick(rightClickElement).Perform();

            Thread.Sleep(TimeSpan.FromSeconds(3));

            actions.DoubleClick(doubleClickElement).Perform();

            Thread.Sleep(TimeSpan.FromSeconds(3));
        }

        [TestMethod]
        public void DragAndDropAction()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demoqa.com/droppable/");
            driver.Manage().Window.Maximize();

            Actions actions = new Actions(driver);

            IWebElement source = driver.FindElement(By.Id("draggable"));
            IWebElement target = driver.FindElement(By.Id("droppable"));

            actions.DragAndDrop(source, target).Perform();

            //int xOffset = 100;
            //int yOffset = 150;

            //actions.DragAndDropToOffset(source, xOffset, yOffset).Perform();

            Thread.Sleep(TimeSpan.FromSeconds(5));

            //string text = target.Text;
            //if (text.Equals("Dropped!"))
            //{
            //    Console.WriteLine("source is dropped to target");
            //}
            //else
            //{
            //    Console.WriteLine("Failed to drop source to target");
            //}
        }

        [TestMethod]
        public void MouseHoverAction()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demoqa.com/menu/");
            driver.Manage().Window.Maximize();

            Actions actions = new Actions(driver);

            IWebElement menuOption = driver.FindElement(By.XPath("//a[contains(text(),'Main Item 2')]"));
            actions.MoveToElement(menuOption).Perform();

            Thread.Sleep(TimeSpan.FromSeconds(3));

            IWebElement subMenuOption = driver.FindElement(By.XPath("//a[contains(text(),'SUB SUB LIST')]"));
            actions.MoveToElement(subMenuOption).Perform();
            Thread.Sleep(TimeSpan.FromSeconds(3));
        }

        [TestMethod]
        public void MouseHoverByOffsetAction()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demoqa.com/slider/");
            driver.Manage().Window.Maximize();
            Actions actions = new Actions(driver);

            Thread.Sleep(TimeSpan.FromSeconds(3));

            IWebElement slider = driver.FindElement(By.Id("sliderContainer"));
            actions.MoveToElement(slider, 68, 0).Perform();
            slider.Click();

            Thread.Sleep(TimeSpan.FromSeconds(3));
        }
    }
}
