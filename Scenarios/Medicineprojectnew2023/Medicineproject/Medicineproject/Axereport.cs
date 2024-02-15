using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Selenium.Axe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medicineproject
{
    [TestClass]
    public class Axereport
    {
        [TestMethod]
        public void TestMethod()
        {
            IWebDriver driver = new ChromeDriver();
           string url = "https://www.onlinemedicalstore.com/";
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
            AxeResult results = driver.Analyze();
            string path = "D:\\AxeReport.html";
            driver.CreateAxeHtmlReport(results, path);
        }

    }
}
