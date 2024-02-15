using APITestingPOC.DTO;
using APITestingPOC.HelperClass;
using RestSharp;
using System;
using TechTalk.SpecFlow;

namespace APITestingPOC.StepDefinition
{
    [Binding]
    public class PutapiStepDefinitions
    {
        APIHelper<UpdateUserDTO> putUser = new APIHelper<UpdateUserDTO>();
        RestClient restClient { get; set; }
        RestRequest restRequest { get; set; }
        IRestResponse restResponse { get; set; }
        string payload;


        [Given(@"User set the Put User Endpoint")]
        public void GivenUserSetThePutUserEndpoint()
        {
            restClient = putUser.SetUrl("api/users/2");
        }

        [When(@"User provides payload to update jobid")]
        public void WhenUserProvidesPayloadToUpdateJobid()
        {
            payload = @"{
                ""name"": ""morpheus"",
                ""job"": ""manager""
                }";
        }

        [When(@"user send PUT Request")]
        public void WhenUserSendPUTRequest()
        {
            restRequest = putUser.CreatePutRequest(payload);
        }

        [Then(@"User verfies the jobid in response")]
        public void ThenUserVerfiesTheJobidInResponse()
        {
            restResponse = putUser.GetResponse(restClient, restRequest);

            UpdateUserDTO content = putUser.GetContent<UpdateUserDTO>(restResponse);
            Assert.IsNotNull(content);
            Assert.AreEqual("manager", content.job);
            Console.WriteLine("Updated the job as {0} for the user", content.job);
        }
    }
}
