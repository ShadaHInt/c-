using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using SeleniumExtras.WaitHelpers;

namespace TestProject5
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void OpenBrowser()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://uitestpractice.com/");
        }

        [TestMethod]
        public void ElementClick()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://uitestpractice.com/Students/Contact");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.PartialLinkText("This is")).Click();
            string text = driver.FindElement(By.ClassName("ContactUs")).Text;
            Console.WriteLine(text.Contains("Python"));
            driver.Close();
        }

        [TestMethod]
        public void ThreadDemo()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://uitestpractice.com/Students/Contact");
            driver.FindElement(By.PartialLinkText("This is")).Click();
            Thread.Sleep(12000);
            string text = driver.FindElement(By.ClassName("ContactUs")).Text;
            Console.WriteLine(text.Contains("Python"));
            driver.Close();
        }

        [TestMethod]
        public void ImplicitWaitDemo()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(12);

            driver.Navigate().GoToUrl("http://uitestpractice.com/Students/Contact");
            driver.FindElement(By.PartialLinkText("This is")).Click();
            string text = driver.FindElement(By.ClassName("ContactUs")).Text;
            Console.WriteLine(text.Contains("Python"));
            driver.Quit();
        }


        [TestMethod]
        public void ExplicitWaitDemo()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://uitestpractice.com/Students/Contact");
            driver.FindElement(By.PartialLinkText("This is")).Click();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(12));
            wait.Until(ExpectedConditions.ElementExists(By.ClassName("ContactUs")));

            string text = driver.FindElement(By.ClassName("ContactUs")).Text;
            Console.WriteLine(text.Contains("Python"));
            driver.Close();
        }

        [TestMethod]
        public void FluentWaitDemo()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://uitestpractice.com/Students/Contact");
            driver.FindElement(By.PartialLinkText("This is")).Click();

            DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver);
            fluentWait.Timeout = TimeSpan.FromSeconds(12);
            fluentWait.PollingInterval = TimeSpan.FromMilliseconds(250);
            /* Ignore the exception - NoSuchElementException that indicates that the element is not present */
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));

            fluentWait.Message = "Element to be searched not found";
            IWebElement searchResult = fluentWait.Until(x => x.FindElement(By.ClassName("ContactUs")));

            string text = searchResult.Text;
            Console.WriteLine(text.Contains("Python"));
            driver.Close();
        }

        [TestMethod]
        public void WebDriverWaitDemo()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://uitestpractice.com/Students/Contact");
            driver.FindElement(By.PartialLinkText("This is")).Click();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            IWebElement searchResult = wait.Until(x => x.FindElement(By.ClassName("ContactUs")));

            string text = searchResult.Text;
            Console.WriteLine(text.Contains("Python"));
            driver.Close();
        }
    }
}
