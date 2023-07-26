using System;
using API_test.Hooks;
using NUnit.Framework;
using RestSharp;

namespace API_test
{
    [TestFixture]
    public class APITesting
    {
        private string baseURL = "https://apichallenges.herokuapp.com";
        private ApiClient apiClient;

        [SetUp]
        public void Setup()
        {
            apiClient = new ApiClient(baseURL);
        }

        // [Test]
        // public void TestGetRequest()
        // {
        //     // GET request
        //     RestResponse getResponse = apiClient.PerformRequest("/todos", Method.Get);
        //     Console.WriteLine($"GET Response: {getResponse.Content}");

        //     Assert.AreEqual(200, (int)getResponse.StatusCode); 
        // }

        // [Test]
        // public void TestPostRequest()
        // {
        //     // POST request with a request body
        //     var postRequestBody = new { key = "value" }; // Replace with your request body
        //     RestResponse postResponse = apiClient.PerformRequest("/someEndpoint", Method.Post, postRequestBody);
        //     Console.WriteLine("POST Response: " + postResponse.Content);

        //     Assert.AreEqual(201, (int)postResponse.StatusCode); // Example: Assert the response status code
        // }

    }
}
