using InternalProjectTrial.Page;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace InternalProjectTrial.CommonMethods
{
    public class CmnMthd:BaseClass
    {
        

        public static void Email(string a)
        {
            AddToCart addToCart = new(driver);  
            addToCart.EmailOrMobile.Click();
            addToCart.EmailOrMobile.SendKeys(a);
            addToCart.Continue.Click();
        }

        public static void Password(string b)
        {
            AddToCart addToCart = new(driver);
            addToCart.Password.Click();
            addToCart.Password.SendKeys(b);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(2));
            wait.Until(ExpectedConditions.ElementExists(By.XPath("//input[@id='signInSubmit']")));
            addToCart.SignInButton.Click();
        }

        public static void scroll(int a, int b)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(" + a + "," + b + ")");
        }
    }
}
