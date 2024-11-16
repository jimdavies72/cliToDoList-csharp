//dotnet add package Microsoft.Extensions.Configuration
using Microsoft.Extensions.Configuration;
//dotnet add package Microsoft.Extensions.Configuration.Json
using Microsoft.Extensions.Configuration.Json;

namespace todoCSharp.src.classes.utils
{
  public static class Configuration
  {
    public static IConfiguration GetConfiguration()
    {
      var builder = new ConfigurationBuilder()
      .SetBasePath(Directory.GetCurrentDirectory())
      .AddJsonFile("appSettings.json", optional: false, reloadOnChange: true);

      var configuration = builder.Build();
      return configuration;
    }
  }
}