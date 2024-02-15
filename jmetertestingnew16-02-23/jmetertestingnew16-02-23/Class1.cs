//using System;
//using System.Collections.Generic;
//using System.IO;
//using Cake.Core.Diagnostics;
//using Cake.JMeter;
//using Cake.JMeter.JMeterTest;

//class Program3
//{
//    static void Main(string[] args)
//    {
//        var jmeterHome = "path/to/jmeter/home";
//        var testFile = "path/to/my/test.jmx";
//        var logFile = "path/to/my/log/file";
//        var reportFolder = "path/to/my/report/folder";
//        var threads = "10";
//        var loops = "5";
//        var propertiesFile = "path/to/my/properties/file.properties";

//        // Create the JMeter test plan object
//        var testPlan = new JMeterTestPlan();

//        // Create an HTTP Sampler
//        var sampler = new JMeterHttpSampler
//        {
//            Domain = "www.example.com",
//            Port = 80,
//            Path = "/api/myendpoint",
//            Method = "GET",
//            Name = "My HTTP Sampler"
//        };

//        // Add the sampler to the test plan
//        var threadGroup = new JMeterThreadGroup
//        {
//            NumThreads = int.Parse(threads),
//            RampUp = int.Parse(loops),
//            Loops = int.Parse(loops)
//        };
//        threadGroup.Samplers.Add(sampler);

//        testPlan.ThreadGroups.Add(threadGroup);

//        // Save the test plan to a JMX file
//        testPlan.Save(testFile);

//        // Run the JMeter test in non-GUI mode
//        var settings = new JMeterSettings
//        {
//            JMeterHome = jmeterHome,
//            TestFile = testFile,
//            LogFile = logFile,
//            ReportFolder = reportFolder,
//            PropertiesFile = propertiesFile,
//            Arguments = new Dictionary<string, string> { { "threads", threads }, { "loops", loops } }
//        };

//        var result = JMeterAliases.RunJMeter(settings);

//        if (result != 0)
//        {
//            Console.WriteLine($"JMeter test failed with exit code {result}.");
//        }
//        else
//        {
//            Console.WriteLine("JMeter test completed.");
//        }
//    }
//}
