//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Net.Http;
//using System.Threading.Tasks;

//namespace SimpleLoadTest
//{
//    class Program
//    {
//        static async Task Main(string[] args)
//        {
//            // Define the base URL of your web API
//            string baseUrl = "https://reqres.in/api/users?page=2";

//            // Define the number of requests to send
//            int numRequests = 5;

//            // Create an instance of the HttpClient class
//            HttpClient client = new HttpClient();

//            // Create a list to store the request times
//            List<long> requestTimes = new List<long>();

//            // Send the requests and record the response times
//            for (int i = 0; i < numRequests; i++)
//            {
//                // Start a stopwatch to measure the request time
//                Stopwatch stopwatch = Stopwatch.StartNew();

//                // Send an HTTP GET request to the web API
//                HttpResponseMessage response = await client.GetAsync(baseUrl + "endpoint");

//                // Stop the stopwatch and record the request time
//                stopwatch.Stop();
//                requestTimes.Add(stopwatch.ElapsedMilliseconds);

//                // Check the HTTP status code of the response
//                if (response.IsSuccessStatusCode)
//                {
//                    // Print the response content
//                    string responseContent = await response.Content.ReadAsStringAsync();
//                    Console.WriteLine(responseContent);
//                }
//                else
//                {
//                    Console.WriteLine("Error: " + response.StatusCode);
//                }
//            }

//            // Calculate and print the average request time
//            long totalRequestTime = 0;
//            foreach (long requestTime in requestTimes)
//            {
//                totalRequestTime += requestTime;
//            }
//            double averageRequestTime = (double)totalRequestTime / numRequests;
//            Console.WriteLine("Average request time: " + averageRequestTime + " ms");
//        }
//    }
//}
