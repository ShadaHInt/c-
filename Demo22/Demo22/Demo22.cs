using Newtonsoft.Json;
using RestSharp;

namespace APIDemo

{
    public class Demo22
    {
        public UserList GetUsers()
        {
            var client = new RestClient("https://reqres.in/");
            var request = new RestRequest("/api/users/2", Method.Get);
            request.AddHeader("Accept", "application/json");
            request.RequestFormat = DataFormat.Json;

            RestResponse response = client.Execute(request);
            var content = response.Content;

            var users = JsonConvert.DeserializeObject<UserList>(content);
            return users;
            var statuscode = response.StatusCode;

        }
    }
}