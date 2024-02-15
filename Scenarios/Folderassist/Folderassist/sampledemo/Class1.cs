using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Drawing;

namespace DemoTest
{
    [TestClass]
    public class Commands_Example
    {
        String test_url = "https://www.amazon.in/";

        [TestMethod]
        public void Commands()
        {
            IWebDriver driver;

            // Local Selenium WebDriver
            driver = new ChromeDriver();

            driver.Navigate().GoToUrl(test_url);

            driver.Manage().Window.Maximize();

            // locating webElement for Address
            IWebElement addressBox = driver.FindElement(By.Id("nav-global-location-popover-link"));

            // fetch Text from the webElement
            Console.WriteLine("Text is : " + addressBox.Text);

            // get tagName of the weElement
            Console.WriteLine("Tag Name is : " + addressBox.TagName);

            // get cssValue of color
            Console.WriteLine("Color is : " + addressBox.GetCssValue("color"));

            // get tabindex attribute's value
            Console.WriteLine("Attribute value : " + addressBox.GetAttribute("tabindex"));

            // get the size of webElement
            Size d = addressBox.Size;
            Console.WriteLine("Size is : " + d);

            Console.WriteLine("Width = " + d.Width);
            Console.WriteLine("Height = " + d.Height);

            // get the location of the webElement 
            Point point = addressBox.Location;
            Console.WriteLine("Location is at : " + point);

            Console.WriteLine(point.X);
            Console.WriteLine(point.Y);
            Size d = addressBo.Size;
            Console.WriteLine("Size is : " + d);

            Console.WriteLine("Width = " + d.Width);
            Console.WriteLine("Height = " + d.Height);


            driver.Quit();
        }
    }
}
