
using RestSharp;

namespace API_test.Hooks
{
    public class ApiClient
    {
        private readonly RestClient client;

        public ApiClient(string baseUrl)
        {
            client = new RestClient(baseUrl);
        }

        public RestResponse PerformRequest(string resource, Method method, object requestBody = null)
        {
            var request = new RestRequest(resource, method);

            //Headers
            // request.AddHeader("Authorization", "Bearer YOUR_ACCESS_TOKEN");

            if (requestBody != null)
            {
                request.AddJsonBody(requestBody);
            }

            RestResponse response = client.Execute(request);
            return response;
        }
    }
}