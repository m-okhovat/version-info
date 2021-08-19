using System.Diagnostics;
using System.Reflection;
using Newtonsoft.Json;

namespace VersionInfo.Core
{
    public static class VersionService
    {
        public static string GetSerializedVersion()
        {
            var entryAssembly = Assembly.GetEntryAssembly();
            var fileVersion = FileVersionInfo.GetVersionInfo(entryAssembly.Location).FileVersion;
            var productVersion = FileVersionInfo.GetVersionInfo(entryAssembly.Location).ProductVersion;
            var versionInfo = new Models.VersionInfo()
            {
                ProductVersion = productVersion,
                FileVersion = fileVersion
            };

            return JsonConvert.SerializeObject(versionInfo);
        }
    }
}
