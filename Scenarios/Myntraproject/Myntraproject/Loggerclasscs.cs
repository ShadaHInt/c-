using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myntraproject
{
    public  class Loggerclasscs:BaseClass
    {
        
        public static void Writelogger(string message)
        {
            string logpath = ConfigurationManager.AppSettings["logpath"];
            using (StreamWriter writer = new StreamWriter(logpath,true))
            {
                writer.WriteLine($"{DateTime.Now}:{message}");
            }
        }
    }
}
