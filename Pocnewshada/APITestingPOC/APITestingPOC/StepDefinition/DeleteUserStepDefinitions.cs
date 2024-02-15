using APITestingPOC.HelperClass;
using RestSharp;
using System;
using System.Net;
using TechTalk.SpecFlow;

namespace APITestingPOC.StepDefinition
{
    [Binding]
    public class DeleteUserStepDefinitions
    {
        APIHelper<IRestResponse> deleteUser = new APIHelper<IRestResponse>();
        RestClient restClient { get; set; }

        RestRequest restRequest { get; set; }
        IRestResponse restResponse { get; set; }

        [Given(@"User set the Delete User Endpoint")]
        public void GivenUserSetTheDeleteUserEndpoint()
        {
            restClient = deleteUser.SetUrl("api/users/2");
        }

        [When(@"user send DELETE Request")]
        public void WhenUserSendDELETERequest()
        {
            restRequest = deleteUser.CreateDeleteRequest();
        }

        [Then(@"User verfies the status code in response")]
        public void ThenUserVerfiesTheStatusCodeInResponse()
        {
            restResponse = deleteUser.GetResponse(restClient, restRequest);
            HttpStatusCode statusCode = restResponse.StatusCode;

            Console.WriteLine((int)statusCode);
        }
    }
}
