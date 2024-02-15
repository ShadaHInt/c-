//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Microsoft.VisualStudio.TestTools.LoadTesting;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace LoadTestProject
//{
//    [TestClass]
//    public class LoadTestAutomation
//    {
//        [TestMethod]
//        public void RunLoadTest()
//        {
//            // create a load test scenario
//            LoadTestScenario scenario = new LoadTestScenario();

//            // add a web test to the scenario
//            WebTestRequest webRequest = new WebTestRequest("http://www.example.com");
//            scenario.Add(webRequest);

//            // set load test settings
//            LoadTest test = new LoadTest(scenario);
//            test.TestMix = new TestMix(TestMixPercentage.Percent50);
//            test.RampUpTime = TimeSpan.FromMinutes(5);
//            test.Duration = TimeSpan.FromMinutes(30);
//            test.MaxUsers = 100;
//            test.NetworkEmulationEnabled = true;
//            test.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/89.0.4389.82 Safari/537.36";

//            // run the load test
//            test.Run();

//            // wait for the load test to complete
//            test.WaitForCompletion();

//            // assert that the load test was successful
//            Assert.AreEqual(LoadTestState.Completed, test.State);
//        }
//    }
//}
