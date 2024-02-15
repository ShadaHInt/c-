using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newprojectspecflow.Pages
{
    public class loginpage :BaseClass
    {
        public loginpage(in IWebDriver driver)
        {
        }
        public IWebElement emailbox => driver.FindElement(By.Id("ap_email"));
        public IWebElement continuebox => driver.FindElement(By.Id("continue"));
    }
}
