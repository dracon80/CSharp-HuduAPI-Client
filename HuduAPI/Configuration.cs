using Flurl.Http;
using Flurl.Http.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuduAPI
{
    internal sealed class Configuration
    {
        private static readonly Configuration _instance = new();
        private static bool _serializerConfigured = false;
        private static readonly object _lock = new();

        static Configuration()
        {
        }

        private Configuration()
        { }

        public static void ConfigFurlSerializer()
        {
            if (!_serializerConfigured)
            {
                lock (_lock)
                {
                    DefaultContractResolver contractResolver = new()
                    {
                        NamingStrategy = new SnakeCaseNamingStrategy()
                    };

                    FlurlHttp.Configure(settings =>
                    {
                        var jsonSettings = new JsonSerializerSettings
                        {
                            NullValueHandling = NullValueHandling.Ignore,
                            ContractResolver = contractResolver,
                            Formatting = Formatting.Indented
                        };
                        settings.JsonSerializer = new NewtonsoftJsonSerializer(jsonSettings);
                    });

                    _serializerConfigured = true;
                }
            }
        }
    }
}