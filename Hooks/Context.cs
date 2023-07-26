using Microsoft.Playwright;
using RestSharp;

namespace API_test.Hooks
{
    public class Context
    {
        public IBrowserContext BrowserContext { get; set; }
        public IPage Page { get; set; }
    }
}