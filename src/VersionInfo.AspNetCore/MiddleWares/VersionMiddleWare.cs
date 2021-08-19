using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using VersionInfo.Core;

namespace VersionInfo.AspNetCore.MiddleWares
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