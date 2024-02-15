using NoonProject2.Page;
using OpenQA.Selenium;
using ThirdParty.Json.LitJson;

namespace NoonProject2
{
    public class CmnMethod:BaseClass
    {
        //json
        public List<JsonClass> homeReader = new List<JsonClass>();
        public static StreamReader r = new StreamReader(@"C:\Users\rugmap\OneDrive - Valorem Reply\Desktop\C#\MYDesignation\MYDesignation\Json/Json.json");
        public static string testData = r.ReadToEnd();
        public static JsonClass inputValue = JsonMapper.ToObject<JsonClass>(testData);

        public static void Max()
        {
            driver.Manage().Window.Maximize();
        }

        public static void AssertMethod()
        {
            string Url = driver.Url;
            string UrlToTest = "https://www.noon.com/";
            Assert.AreEqual(Url, UrlToTest);
        }

        public static void scroll(int a, int b)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(" + a + "," + b + ")");
        }

        public static void Reg(string a,string b,string c,string d) 
        {
            Register register = new(driver);
            register.SignUp.Click();
            register.Email.SendKeys(a);
            register.Password.SendKeys(b);
            register.FirstName.SendKeys(c);
            register.LastName.SendKeys(d);
        }

        public static void RegNegative()
        {
            Register register = new(driver); 
            register.SignUp.Click();
            register.FirstName.SendKeys(inputValue.firstname);
            register.LastName.SendKeys(inputValue.lastname);
            for (int i = 0; i < Convert.ToInt32(inputValue.invalidEmail.Count()); i++)
            {
                register.Email.Click();
                register.Email.Clear();
                register.Email.SendKeys(inputValue.invalidEmail[i]);
                register.Password.Click();
                register.Password.Clear();
                register.Password.SendKeys(inputValue.invalidPass[i]);               
                Thread.Sleep(1000);                               
            }
        }

        public static void InvalidSignin()
        {
            SignIn signIn = new(driver);

            for (int i = 0; i < Convert.ToInt32(inputValue.invalidEmail.Count()); i++)
            {
                signIn.Email.Click();
                signIn.Email.Clear();
                signIn.Email.SendKeys(inputValue.invalidEmail[i]);
                signIn.Password.Click();
                signIn.Password.Clear();
                signIn.Password.SendKeys(inputValue.invalidPass[i]);
                signIn.SigninButton.Click();
                Thread.Sleep(2000);                
                Console.WriteLine("The error message " + signIn.ErrorEmail.Text);
                Console.WriteLine("The error message " + signIn.ErrorPassword.Text);
                Thread.Sleep(1000);
            }
        }

        public static void Signin(string a, string b)
        {
            SignIn signIn = new(driver);

            signIn.Email.Click();
            signIn.Email.SendKeys(a);
            signIn.Password.Click();
            signIn.Password.SendKeys(b);
            signIn.SigninButton.Click();
            Thread.Sleep(2000);
        }

        public static void TakeScreenShot(string filename = "Screen")
        {
            Screenshot screen = ((ITakesScreenshot)driver).GetScreenshot();


            if (filename.Equals("Screen"))
            {
                filename = filename + DateTime.UtcNow.ToString("yyyy-MM-dd-mm-ss") + ".jpeg";
                screen.SaveAsFile(filename, ScreenshotImageFormat.Jpeg);

                return;
            }
            screen.SaveAsFile(filename, ScreenshotImageFormat.Jpeg);
        }
    }
}
