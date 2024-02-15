//using System;
//using System.Net.Http;
//using System.Threading.Tasks;

//namespace AzureLoadTestExample
//{
//    class Program
//    {
//        static async Task Main(string[] args)
//        {
//            string loadTestUrl = "https://www.flipkart.com";

//            var client = new HttpClient();
//            var response = await client.GetAsync(loadTestUrl);

//            if (response.IsSuccessStatusCode)
//            {
//                Console.WriteLine("Load test started successfully.");
//            }
//            else
//            {
//                Console.WriteLine($"Error starting load test: {response.ReasonPhrase}");
//            }
//        }
//    }
//}
