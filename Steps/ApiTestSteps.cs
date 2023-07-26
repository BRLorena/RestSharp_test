using Microsoft.Playwright;
using NUnit.Framework;
using TechTalk.SpecFlow;
using API_test.Models;
using API_test.Hooks;
using RestSharp;
using BoDi;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace API_test.Steps
{
    [Binding]
    public class ApiTestSteps
    {

        private readonly ApiClient apiClient;
        private readonly ScenarioContext scenarioContext;

        public ApiTestSteps(ApiClient apiClient, ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
            this.apiClient = apiClient;
        }

        [Given(@"I have the JSONPlaceholder API endpoint for posts")]
        public void GivenIHaveTheJSONPlaceholderAPIEndpointForPosts()
        {
            var response = apiClient.PerformRequest("/posts", Method.Get);
            scenarioContext["response"] = response.Content;
        }

        [When(@"I send a GET request to the endpoint")]
        public void WhenISendAGETRequestToTheEndpoint()
        {
            int status_code = (int)apiClient.PerformRequest("/posts", Method.Get).StatusCode;
            scenarioContext["status"] = status_code;
        }

        [Then(@"I receive a response with status code 200")]
        public void ThenIreceivearesponsewithstatuscode()
        {
            Assert.AreEqual(200, scenarioContext["status"]);
        }


        [Then(@"the response should contain a list of posts")]
        public void Thentheresponseshouldcontainalistofposts()
        {

            Assert.IsNotNull(scenarioContext["response"]);

        }

        [Then(@"each post in the response should have an id, title, and body")]
        public void Theneachpostintheresponseshouldhaveanidtitleandbody()
        {


            var responseContent = (string)scenarioContext["response"];
            var jsonResponse = JToken.Parse(responseContent);

            if (jsonResponse.Type == JTokenType.Array)
            {
                // Handle the case where the response is an array of posts
                foreach (var post in jsonResponse)
                {
                    Assert.IsNotNull(post["id"]);
                    Assert.IsNotNull(post["title"]);
                    Assert.IsNotNull(post["body"]);
                }
            }
            else if (jsonResponse.Type == JTokenType.Object)
            {
                // Handle the case where the response is a single post
                Assert.IsNotNull(jsonResponse["id"]);
                Assert.IsNotNull(jsonResponse["title"]);
                Assert.IsNotNull(jsonResponse["body"]);
            }
            else
            {
                Assert.Fail("Invalid JSON response format.");
            }

        }
    }
}