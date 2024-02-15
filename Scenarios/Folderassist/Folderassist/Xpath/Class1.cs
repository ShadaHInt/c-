using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestProject1.XpathDemoTests
{
    [TestClass]
    public class XpathDemoTests
    {
        IWebDriver driver;

        [TestMethod]
        [TestCategory("XpathTests")]
        public void ValidateBasicXpathDemo()
        {
            Console.WriteLine(driver.FindElement(By.XPath("//a[text()='Mobiles']")).Displayed);
            driver.FindElement(By.XPath("//*[text()='Mobiles']")).Click();

            Thread.Sleep(3000);
            bool isCorrectPageLoaded = driver.FindElement(By.XPath("//*[@id='sobe_d_b_2-carousel-viewport-container']")).Displayed;
            Assert.IsTrue(isCorrectPageLoaded);
        }

        [TestMethod]
        [TestCategory("XpathTests")]
        public void ValidateXpathContainsDemo()
        {
            Console.WriteLine(driver.FindElement(By.XPath("//a[contains(text(),'Mobil')]")).Displayed);
            driver.FindElement(By.XPath("//a[contains(text(),'Mobil')]")).Click();

            Thread.Sleep(3000);
            bool isCorrectPageLoaded = driver.FindElement(By.XPath("//*[contains(@id,'sobe_d_b_2-carousel')]")).Displayed;
            Assert.IsTrue(isCorrectPageLoaded);
        }

        [TestMethod]
        [TestCategory("XpathTests")]
        public void ValidateXpathUsingAndOrDemo()
        {
            Console.WriteLine(driver.FindElement(By.XPath("//a[contains(text(),'Mobil')]")).Displayed);
            string text = driver.FindElement(By.XPath("//*[@class='nav-line-2' or @id='glow-ingress-line2']")).Text;
            Console.WriteLine(text);
            driver.FindElement(By.XPath("//a[contains(text(),'Mobil')]")).Click();

            Thread.Sleep(3000);
            bool isCorrectPageLoaded = driver.FindElement(By.XPath("//*[text()='Made for Amazon' and contains(@class,'a-size-base')]")).Displayed;
            driver.FindElement(By.XPath("//*[text()='Made for Amazon' and contains(@class,'a-size-base')]")).Click();
            Assert.IsTrue(isCorrectPageLoaded);
        }

        [TestMethod]
        [TestCategory("XpathTests")]
        public void ValidateXpathThatStartsWith()
        {
            Console.WriteLine(driver.FindElement(By.XPath("//a[starts-with(text(),'Mobil')]")).Displayed);
            string text = driver.FindElement(By.XPath("//*[starts-with(@class,'nav-line-2')]")).Text;
            Console.WriteLine(text);
            driver.FindElement(By.XPath("//a[contains(text(),'Mobil')]")).Click();
        }

        [TestMethod]
        [TestCategory("XpathAxesTests")]
        public void ValidateXpathFollowingAxes()
        {
            string text = driver.FindElement(By.XPath("//*[text()='Best Sellers']//following::a[1]")).Text;
            Console.WriteLine(text);
            Assert.AreEqual(text, "Today's Deals");
            text = driver.FindElement(By.XPath("//*[text()='Best Sellers']//following::a[2]")).Text;
            Console.WriteLine(text);
            Assert.AreEqual(text, "Mobiles");
        }

        [TestMethod]
        [TestCategory("XpathAxesTests")]
        public void ValidateXpathAncestorAxes()
        {
            string text = driver.FindElement(By.XPath("//*[@id='glow-ingress-line1']")).Text;
            Console.WriteLine("Node:" + text);
            text = driver.FindElement(By.XPath("//*[@id='glow-ingress-line1']//ancestor::div[1]")).Text;
            Console.WriteLine("Ancestor node:" + text);
        }

        [TestMethod]
        [TestCategory("XpathAxesTests")]
        public void ValidateXpathChildAxes()
        {
            string text1 = driver.FindElement(By.XPath("//*[@id='glow-ingress-block']")).Text;
            Console.WriteLine("Parent node:" + text1);
            string text = driver.FindElement(By.XPath("//*[@id='glow-ingress-block']//child::span[1]")).Text;
            Console.WriteLine("Child node 1:" + text);
            text = driver.FindElement(By.XPath("//*[@id='glow-ingress-block']//child::span[2]")).Text;
            Console.WriteLine("Child node 2:" + text);
        }

        [TestMethod]
        [TestCategory("XpathAxesTests")]
        public void ValidateXpathPrecedingAxes()
        {
            string text1 = driver.FindElement(By.XPath("//*[@id='glow-ingress-line2']")).Text;
            Console.WriteLine("Node:" + text1);
            string text = driver.FindElement(By.XPath("//*[@id='glow-ingress-line2']//preceding::span[1]")).Text;
            Console.WriteLine("Parent node:" + text);
        }

        [TestMethod]
        [TestCategory("XpathAxesTests")]
        public void ValidateXpathFollowingSiblingAxes()
        {
            string text1 = driver.FindElement(By.XPath("//*[@id='glow-ingress-line1']")).Text;
            Console.WriteLine("node:" + text1);
            string text = driver.FindElement(By.XPath("//*[@id='glow-ingress-line1']//following-sibling::span")).Text;
            Console.WriteLine("Sibling node:" + text);
        }

        [TestMethod]
        [TestCategory("XpathAxesTests")]
        public void ValidateXpathParentAxes()
        {
            string text = driver.FindElement(By.XPath("//*[@id='glow-ingress-line1']")).Text;
            Console.WriteLine("Child Node1:" + text);
            text = driver.FindElement(By.XPath("//*[@id='glow-ingress-line2']")).Text;
            Console.WriteLine("Child Node2:" + text);

            string parentNodeOfChild1 = driver.FindElement(By.XPath("//*[@id='glow-ingress-line1']//parent::div")).Text;
            Console.WriteLine("Parent Node of first child:" + parentNodeOfChild1);
            string parentNodeOfChild2 = driver.FindElement(By.XPath("//*[@id='glow-ingress-line2']//parent::div")).Text;
            Console.WriteLine("Parent Node of second child:" + parentNodeOfChild2);
            Assert.AreEqual(parentNodeOfChild1, parentNodeOfChild2);
        }

        [TestMethod]
        [TestCategory("XpathAxesTests")]
        public void ValidateXpathSelfAxes()
        {
            string text1 = driver.FindElement(By.XPath("//*[text()='Mobiles']")).Text;
            Console.WriteLine("Node:" + text1);
            string text = driver.FindElement(By.XPath("//*[text()='Mobiles']//self::a")).Text;
            Console.WriteLine("Self node:" + text);
            Assert.AreEqual(text, text1);
        }

        [TestMethod]
        [TestCategory("XpathAxesTests")]
        public void ValidateXpathDescendantAxes()
        {
            string text = driver.FindElement(By.XPath("//*[@id='nav-tools']")).Text;
            Console.WriteLine("Node:" + text);
            text = driver.FindElement(By.XPath("//*[@id='nav-tools']//descendant::a[1]")).Text;
            Console.WriteLine("Descendant node 1:" + text);
            text = driver.FindElement(By.XPath("//*[@id='nav-tools']//descendant::a[2]")).Text;
            Console.WriteLine("Descendant node 2:" + text);
            text = driver.FindElement(By.XPath("//*[@id='nav-tools']//descendant::a[3]")).Text;
            Console.WriteLine("Descendant node 3:" + text);
            text = driver.FindElement(By.XPath("//*[@id='nav-tools']//descendant::a[4]")).Text;
            Console.WriteLine("Descendant node 4:" + text);

        }



        [TestInitialize]
        public void TestInitialize()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://amazon.in");
            Console.WriteLine("*********************************************");
            Console.WriteLine("Started test execution");
            Console.WriteLine("*********************************************");
        }

        [TestCleanup]
        public void TestCleanup()
        {
            Console.WriteLine("*********************************************");
            Console.WriteLine("Completed test execution");
            Console.WriteLine("*********************************************");
            driver.Quit();
        }
    }
}
