using System.Text.Json;
using Microsoft.Playwright;
using TechTalk.SpecFlow;
using RestSharp;
using BoDi;

namespace API_test.Hooks
{
    [Binding]
    public class ApiHook
    {
        private readonly IObjectContainer container;

        public ApiHook(IObjectContainer container)
        {
            this.container = container;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            // Initialize and register the ApiClient instance before each scenario
            container.RegisterInstanceAs(new ApiClient("https://jsonplaceholder.typicode.com"));
        }
    } 
}