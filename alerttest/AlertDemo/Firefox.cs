using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlertDemo
{
    [TestClass]
    public class Firefox
    {
        [TestMethod]
        public void FireFoxAlert()
        {
            IWebDriver driver = new FirefoxDriver();

            driver.Navigate().GoToUrl("https://nxtgenaiacademy.com/alertandpopup/");
            IWebElement PromptAlert = driver.FindElement(By.XPath("//button[text()='Prompt Alert Box']"));
            PromptAlert.Click();
            Thread.Sleep(2000);
            driver.SwitchTo().Alert().SendKeys("Yes");
            Thread.Sleep(2000);
            //driver.SwitchTo().Alert().SendKeys("No");
            //Thread.Sleep(2000);
            driver.SwitchTo().Alert().Accept();
            Thread.Sleep(2000);
            driver.Quit();
        }
    }
}
