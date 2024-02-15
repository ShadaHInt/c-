using OpenQA.Selenium;

namespace Purplle_Web_Automation
{
    [TestClass]
    public class Homepage:BaseClass
    {



        //IWebDriver WebDWebDriver
        public Homepage(in IWebDriver driver)
        {
            WebDriver = driver;
            // Assert.IsNotNull(WebDriver, "NO Driver instance provided");
        }
        public IWebElement Usecode => WebDriver.FindElement(By.CssSelector(".bc-npk.bg-w.br2da.dib.pd10.pdb1.pdt1.vam")); 
        public IWebElement MainBanner => WebDriver.FindElement(By.CssSelector("div:nth-of-type(1)>widget")); 
        public IWebElement Support => WebDriver.FindElement(By.CssSelector("p>a:nth-of-type(2)"));
        public IWebElement SupportText => WebDriver.FindElement(By.CssSelector("p.fpsi")); 
        public IWebElement Logo => WebDriver.FindElement(By.CssSelector(".dib.mrr15.vam.w35"));
        public IWebElement Cart => WebDriver.FindElement(By.CssSelector("[class='p-basket f50 vam tx-3127']"));
        public IWebElement EmptyCart => WebDriver.FindElement(By.CssSelector("p.mrr50"));

       




    }
}