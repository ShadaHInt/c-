using Microsoft.Extensions.Configuration;
using MongoDB.Bson.IO;
using Nykaa_Web_Automation.Configuration;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nykaa_Web_Automation.Hooks
{
    public class BaseClass
    {
        public static IWebDriver driver;
        public static ConfigSetting config;

        static string jsonpath = System.IO.Directory.GetParent(@"../../../")?.FullName
                                 + Path.DirectorySeparatorChar 
                                 + "Configuration/Config.json";
        public static ConfigSetting ReadJson()
        {
            ConfigurationBuilder builder = new ConfigurationBuilder();
            config = new ConfigSetting();
            builder.AddJsonFile(jsonpath);
            IConfigurationRoot configuration = builder.Build();
            configuration.Bind(config);
            return config;
        }
    }


}
