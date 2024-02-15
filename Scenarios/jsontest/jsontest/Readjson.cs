using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jsontest
{
    public class Readjson
    {
        public static void  ReadJsonFile(string TextFile)
        {

            dynamic jsonFile = JsonConvert.DeserializeObject(File.ReadAllText(TextFile));

            Console.WriteLine($"Today's Video is: {jsonFile["today_video"]}");
        }
    }
}
