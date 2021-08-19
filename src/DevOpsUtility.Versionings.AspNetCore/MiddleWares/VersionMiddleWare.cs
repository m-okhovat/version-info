using DevOpsUtility.Versionings.Core;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace DevOpsUtility.Versionings.AspNetCore.MiddleWares
{
    public class VersionMiddleware
    {
        readonly RequestDelegate _next;

        public VersionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            context.Response.StatusCode = 200;
            var version = VersionService.GetSerializedVersion();
            await context.Response.WriteAsync(version);
        }
    }
}