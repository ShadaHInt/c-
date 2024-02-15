using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobileapptesting.common
{
    public class CommonCodes : BaseClass
    {
        public static void Wait()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(12);
        }






    }

}
