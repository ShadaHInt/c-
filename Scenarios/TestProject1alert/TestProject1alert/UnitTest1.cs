using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AlertDemo
{
    [TestClass]
    public class UnitTest1
    {
        IWebDriver driver = new ChromeDriver();

        [TestMethod]
        public void AlertAccept()
        {
            driver.Navigate().GoToUrl("https://nxtgenaiacademy.com/alertandpopup/");

            IWebElement Alert = driver.FindElement(By.XPath("//button[text()='Alert Box']"));
            Alert.Click();
            Thread.Sleep(2000);
            driver.SwitchTo().Alert().Accept();
            Thread.Sleep(2000);
            driver.Quit();

        }
        [TestMethod]
        public void AlertText()
        {
            driver.Navigate().GoToUrl("https://nxtgenaiacademy.com/alertandpopup/");

            IWebElement Alert = driver.FindElement(By.XPath("//button[text()='Alert Box']"));
            Alert.Click();
            Thread.Sleep(2000);
            string alertText = driver.SwitchTo().Alert().Text;
            Console.WriteLine("The text in alert box is: " + alertText);
            Thread.Sleep(2000);
            driver.Quit();
        }
        [TestMethod]
        public void AlertDismiss()
        {
            driver.Navigate().GoToUrl("https://nxtgenaiacademy.com/alertandpopup/");

            IWebElement ConfirmAlert = driver.FindElement(By.XPath("//button[text()='Confirm Alert Box']"));
            ConfirmAlert.Click();
            Thread.Sleep(2000);
            driver.SwitchTo().Alert().Dismiss();
            Thread.Sleep(2000);
            driver.Quit();
        }
        [TestMethod]
        public void AlertSendKey()
        {
            driver.Navigate().GoToUrl("https://nxtgenaiacademy.com/alertandpopup/");

            IWebElement PromptAlert = driver.FindElement(By.XPath("//button[text()='Prompt Alert Box']"));
            PromptAlert.Click();
            Thread.Sleep(2000);
            //driver.SwitchTo().Alert().SendKeys("Yes");
            //Thread.Sleep(2000);
            driver.SwitchTo().Alert().SendKeys("No");
            Thread.Sleep(2000);
            driver.SwitchTo().Alert().Accept();
            Thread.Sleep(2000);
            driver.Quit();

        }

    }
}