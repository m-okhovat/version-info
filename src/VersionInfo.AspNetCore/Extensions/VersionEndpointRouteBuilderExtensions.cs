using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using VersionInfo.AspNetCore.MiddleWares;

namespace VersionInfo.AspNetCore.Extensions
{
    public static class VersionEndpointRouteBuilderExtensions
    {
        public static IEndpointConventionBuilder MapVersion(this IEndpointRouteBuilder endpoints, string pattern)
        {
            var pipeline = endpoints.CreateApplicationBuilder()
                .UseMiddleware<VersionMiddleware>()
                .Build();

            return endpoints.Map(pattern, pipeline).WithDisplayName("Version number");
        }
    }
}