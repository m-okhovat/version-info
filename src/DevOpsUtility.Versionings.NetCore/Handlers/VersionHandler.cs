using DevOpsUtility.Versionings.Core;
using LiteServer.Http.Extensions;
using LiteServer.Http.HttpContext;
using System.Threading.Tasks;

namespace DevOpsUtility.Versionings.NetCore.Handlers
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