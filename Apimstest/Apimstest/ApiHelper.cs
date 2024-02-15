using Intuit.Ipp.Core.Configuration;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apimstest
{
    public class ApiHelper
    {
        public RestClient client;
        public RestRequest request;
        public string Baseurl = "https://reqres.in/";


        public RestClient SetUrl(string endpoint)
        {
            var url = Path.Combine(Baseurl, endpoint);
            var client = new RestClient(url);
            return client;
        }

        public RestRequest Createpost(string payload)
        {
            var request = new RestRequest(Method.Post);
            request.AddHeader("Accept", "application/json");
            request.AddParameter("application/json", payload, ParameterType.RequestBody);
            return request;
        }




    }

}
