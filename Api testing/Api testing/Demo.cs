using Newtonsoft.Json;
using RestSharp;

namespace Demo1
{
    public class Demo
    {
        public UserList GetUsers()
        {
            var client = new RestClient("https://reqres.in/");
            var request = new RestRequest("/api/users/2",Method.GET);
            request.AddHeader("Accept", "application/json");
            request.RequestFormat= DataFormat.Json;

            IRestResponse response = client.Execute(request);
            var content = response.Content;

            var users = JsonConvert.DeserializeObject<UserList>(content);
            return users;
            var statuscode= response.StatusCode;

        }
    }
}