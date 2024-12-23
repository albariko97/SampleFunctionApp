using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace Carrier.Function
{
    public class CustomApp
    {
        private readonly ILogger<CustomApp> _logger;

        public CustomApp(ILogger<CustomApp> logger)
        {
            _logger = logger;
        }

        [Function("CustomApp")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            return new OkObjectResult("Welcome to Azure Functions Deployed automatically by Edge Team");
        }
    }
}
