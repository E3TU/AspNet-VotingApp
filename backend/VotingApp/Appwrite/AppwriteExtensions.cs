using Appwrite;
using Appwrite.Services;
using Appwrite.Models;
using dotenv.net;
using Microsoft.Extensions.DependencyInjection;

namespace VotingApp.Appwrite
{
    public static class AppwriteExtensions
    {
        private static string? _endpoint;
        private static string? _projectId;
        private static string? _apiKey;

        public static string Endpoint => _endpoint ?? throw new InvalidOperationException("Appwrite not configured");
        public static string ProjectId => _projectId ?? throw new InvalidOperationException("Appwrite not configured");
        public static string ApiKey => _apiKey ?? throw new InvalidOperationException("Appwrite not configured");

        public static IServiceCollection AddAppwriteClient(this IServiceCollection services)
        {
            DotEnv.Load();

            _endpoint = System.Environment.GetEnvironmentVariable("APPWRITE_ENDPOINT");
            _projectId = System.Environment.GetEnvironmentVariable("APPWRITE_PROJECT_ID");
            _apiKey = System.Environment.GetEnvironmentVariable("APPWRITE_API_KEY");

            if (string.IsNullOrWhiteSpace(_projectId))
            {
                throw new System.InvalidOperationException("APPWRITE_PROJECT_ID environment variable is missing");
            }

            if (string.IsNullOrWhiteSpace(_endpoint))
            {
                throw new System.InvalidOperationException("APPWRITE_ENDPOINT environment variable is missing");
            }

            if (string.IsNullOrWhiteSpace(_apiKey))
            {
                throw new System.InvalidOperationException("APPWRITE_API_KEY environment variable is missing");
            }

            var client = new Client()
                .SetEndpoint(_endpoint)
                .SetProject(_projectId)
                .SetKey(_apiKey);

            services.AddSingleton(client);
            services.AddSingleton(sp => new Account(sp.GetRequiredService<Client>()));
            services.AddSingleton(sp => new Databases(sp.GetRequiredService<Client>()));

            return services;
        }

        public static Client CreateClientWithKey()
        {
            DotEnv.Load();
            
            var projectId = System.Environment.GetEnvironmentVariable("APPWRITE_PROJECT_ID");
            var apiKey = System.Environment.GetEnvironmentVariable("APPWRITE_API_KEY");
            var endpoint = System.Environment.GetEnvironmentVariable("APPWRITE_ENDPOINT");

            return new Client()
                .SetEndpoint(endpoint!)
                .SetProject(projectId!)
                .SetKey(apiKey!);
        }
    }
}
