using DevOpsUtility.Versionings.Core.Models;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Reflection;

namespace DevOpsUtility.Versionings.Core
{
    public static class VersionService
    {
        public static string GetSerializedVersion()
        {
            var entryAssembly = Assembly.GetEntryAssembly();
            var fileVersion = FileVersionInfo.GetVersionInfo(entryAssembly.Location).FileVersion;
            var productVersion = FileVersionInfo.GetVersionInfo(entryAssembly.Location).ProductVersion;
            var versionInfo = new VersionInfo()
            {
                ProductVersion = productVersion,
                FileVersion = fileVersion
            };

            return JsonConvert.SerializeObject(versionInfo);
        }
    }
}
