using System.Reflection;
using System.Text;

namespace PicPayDotnet.Utils
{
    public static class JSONExtension
    {
        public static T? GetJsonObject<T>(string content)
        {
            if (!content.NulaVazia())
            {
                byte[] bytes = Encoding.Default.GetBytes(content);
                return System.Text.Json.JsonSerializer.Deserialize<T>(Encoding.UTF8.GetString(bytes));
            }
            else
                return default;
        }

        public static string GetUserAgent()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var attribute = assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>();
            var version = attribute?.InformationalVersion;
            return $"picpay-api-dotnet/{version}";
        }
    }
}