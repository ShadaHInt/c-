using APITestingPOC.DTO;
using APITestingPOC.HelperClass;
using RestSharp;
using System;
using TechTalk.SpecFlow;

namespace APITestingPOC.StepDefinition
{
    [Binding]
    public class GetUserStepDefinitions
    {

        APIHelper<usersListDTO> getListofUsers = new APIHelper<usersListDTO>();

        RestClient restClient { get; set; }
        RestRequest restRequest { get; set; }
        IRestResponse restResponse { get; set; }
        
        [Given(@"User set the Get User Endpoint")]
        public void GivenUserSetTheGetUserEndpoint()
        {
            restClient = getListofUsers.SetUrl("api/users?page=2");
             
        }

        [When(@"User send GET Request")]
        public void WhenUserSendGETRequest()
        {
            restRequest = getListofUsers.CreateGetRequest();
        }

        [Then(@"User verfies the page number and first name in response")]
        public void ThenUserVerfiesThePageNumberAndFirstNameInResponse()
        {
            restResponse = getListofUsers.GetResponse(restClient, restRequest);
            usersListDTO content = getListofUsers.GetContent<usersListDTO>(restResponse);
            Assert.AreEqual(2, content.page);
            Assert.AreEqual("Michael", content.Data[0].first_name);
        }
    }
}
