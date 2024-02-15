using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APITestingPOC.HelperClass
{
    public class APIHelper<T>
    {
        public RestClient restClient;
        public RestRequest restRequest;
        public string baseUrl = "https://reqres.in/";

        public RestClient SetUrl(string endpoint)
        {
            var url = Path.Combine(baseUrl, endpoint); 
            var restClient = new RestClient(url);
            return restClient;
        }

        public  RestRequest CreateGetRequest()
        {
            var restRequest = new RestRequest(Method.GET); //specifies the method of request
            restRequest.AddHeader("Accept", "/application/json"); //specifies the output format
            return restRequest;
        }

        public RestRequest CreatePostRequest(string payload)
        {
            RestRequest restRequest = new RestRequest(Method.POST);
            restRequest.AddHeader("Accept", "/application/json"); //specifies output format
            restRequest.AddParameter("application/json",payload,ParameterType.RequestBody);//specifies the format and parameter type of input
            return restRequest;
        }

        public RestRequest CreatePutRequest(string payload)
        {
            RestRequest restRequest = new RestRequest(Method.PUT);
            restRequest.AddHeader("Accept", "/application/json"); //specifies output format
            restRequest.AddParameter("application/json", payload, ParameterType.RequestBody);
            return restRequest;
        }

        public RestRequest CreateDeleteRequest()
        {
            RestRequest restRequest = new RestRequest(Method.DELETE);
            restRequest.AddHeader("Accept", "/application/json");
            return restRequest;
        }

        public IRestResponse GetResponse(RestClient restClient, RestRequest restRequest)
        {
            
            return restClient.Execute(restRequest);
        }

        public DTO GetContent<DTO>(IRestResponse response)
        {
            var content = response.Content;
            DTO dtoObject = JsonConvert.DeserializeObject<DTO>(content);
            return dtoObject;
        }
    }
}
