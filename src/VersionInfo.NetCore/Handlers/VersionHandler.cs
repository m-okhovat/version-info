using System.Threading.Tasks;
using LiteServer.Http.Extensions;
using LiteServer.Http.HttpContext;
using VersionInfo.Core;

namespace VersionInfo.NetCore.Handlers
{
    public class VersionHandler
    {
        public static Task GetVersion(LiteHttpContext context)
        {
            var version = VersionService.GetSerializedVersion();

            context.Response.StatusCode = 200;
            return context.Response.WriteAsync(version);
        }
    }
}