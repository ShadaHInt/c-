using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestProject1.MSTestAnnotationsExample
{
    [TestClass]
    public class Class1
    {
        static IWebDriver driver = new ChromeDriver();

        [TestInitialize]
        public void TestInit()
        {
            Console.WriteLine("Test Initialization started");
        }

        [TestMethod]
        public void Test1()
        {
            Console.WriteLine("Test1");
        }

        [TestMethod]
        public void Test2()
        {
            Console.WriteLine("Test2");
            driver.Navigate().GoToUrl("http://www.google.com");
        }

        [TestMethod]
        [Ignore]
        public void Test3()
        {
            Console.WriteLine("Test2");
        }

        [TestCleanup]
        public void TestClean()
        {
            Console.WriteLine("Test Cleanup started");
        }

        [DataTestMethod]
        [DataRow("hi ")]
        [DataRow("hello")]
        public void PrintText(string text)
        {
            Console.WriteLine(text);
        }

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            Console.WriteLine("Inside ClassInitialize");

        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            driver.Quit();
        }

    }
}
