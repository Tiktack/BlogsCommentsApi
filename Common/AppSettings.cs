using Microsoft.Extensions.Configuration;

namespace Common
{
    public class AppSettings : IAppSettings
    {
        private readonly IConfiguration _configuration;

        public AppSettings(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GetValue(string paramName)
        {
            return _configuration.GetSection(paramName).Value;
        }
    }
}
