# Version-Info

This package provides a way to get semantic versioning information from a project via a http handler middleware.

# How to use:

In the case of using Asp.Net core you can simple install the package and use it:

> Install-Package VersionInfo.AspNetCore

After installing the package then add the following middleware in the configure method to the endpoints.

```charp

 app.UseEndpoints(endpoints =>
            {
                endpoints.MapVersion("/version"); // add this line of code
                endpoints.MapControllers();

            });

```


If the project does not have any http endpoint you could install `LiteServer` and then use the `Versioning` middleware.

> Install-Package LiteServer

> Install-Package VersionInfo.NetCore

then in the program class just setup `LiteServer`, then configure the `Versioning` middleware on it and then run it.

```csharp

public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureLiteServerDefaults(builder =>
                    builder.UseEndpoints(routeBuilder =>
                            routeBuilder.Map("/version", VersionHandler.GetVersion)), "http://localhost:5000/")
                ;
    }

```
