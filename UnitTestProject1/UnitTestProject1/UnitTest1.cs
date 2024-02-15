using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using System;

namespace Demo
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            var client = new RestClient("https://reqres.in/");
            var request = new RestRequest("/api/users/2", Method.GET);
            request.AddHeader("Accept", "application/json");
            request.RequestFormat = DataFormat.Json;

            IRestResponse response = client.Execute(request);

            var statuscode = response.StatusCode;
        }
    }
}