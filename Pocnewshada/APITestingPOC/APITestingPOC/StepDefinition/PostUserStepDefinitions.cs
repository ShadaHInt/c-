using APITestingPOC.DTO;
using APITestingPOC.HelperClass;
using RestSharp;
using System;
using TechTalk.SpecFlow;

namespace APITestingPOC.StepDefinition
{
    [Binding]
    public class PostUserStepDefinitions
    {

        APIHelper<CreateUserDTO> createUsers = new APIHelper<CreateUserDTO>();

        RestClient restClient { get; set; }
        RestRequest restRequest { get; set; }
        IRestResponse restResponse { get; set; }
        string payload;


        [Given(@"User set the Post User Endpoint")]
        public void GivenUserSetThePostUserEndpoint()
        {
            restClient = createUsers.SetUrl("api/users");
        }

        [When(@"User provides payload")]
        public void WhenUserProvidesPayload()
        {
            payload = @"{
                ""name"": ""morpheus"",
                ""job"": ""leader""
                }";
        }

        [When(@"user send POST Request")]
        public void WhenUserSendPOSTRequest()
        {
            restRequest = createUsers.CreatePostRequest(payload);
        }

        [Then(@"User verfies if correct name and jobid recieved in response")]
        public void ThenUserVerfiesIfCorrectNameAndJobidRecievedInResponse()
        {
            restResponse = createUsers.GetResponse(restClient, restRequest);
            CreateUserDTO content = createUsers.GetContent<CreateUserDTO>(restResponse);
            Assert.IsNotNull(content);
            Assert.AreEqual("morpheus", content.name);
            Console.WriteLine("Name :" + content.name +
                               "\nJob :" + content.job);
        }
    }
}
