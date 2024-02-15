using Newtonsoft.Json.Linq;

using System;

using System.Collections.Generic;

using System.IO;

namespace CalculatorFramework.Utils

{

    class JClass1

    {

        public static string GetProjectRootDirectory()

        {

            string currentDirectory = Directory.GetCurrentDirectory();

            return currentDirectory.Split("bin")[0];

        }

        private static JObject GetTestDataJsonObject()

        {

            string path = Path.Combine(GetProjectRootDirectory(), "Testdata", "Data.json");

            JObject jObject = JObject.Parse(File.ReadAllText(path));

            return jObject;

        }

        public static int GetTestDataInt(string label)

        {

            var jObject = GetTestDataJsonObject();

            return Int32.Parse(jObject[label].ToString());

        }

        public static List<string> GetTestDataArray(string label)

        {

            var jObject = GetTestDataJsonObject();

            return jObject[label].ToObject<List<string>>(); ;

        }

    }

}