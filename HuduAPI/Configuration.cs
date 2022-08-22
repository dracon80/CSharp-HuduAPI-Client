using Flurl.Http;
using Flurl.Http.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace HuduAPI
{
    /// <summary>
    /// Configuration just allows the caller to set the Flurl configuration once and once only, as
    /// per the requirements. Its almost like a singleton except there is now return instance, just
    /// a method to call.
    /// </summary>
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

        /// <summary>
        /// Configurations the furl serializer with a SnakeCaseNamingStrategy as is used by HuduAPI
        /// </summary>
        public static void ConfigFurlSerializer()
        {
            //If already configured then nothing to do here
            if (!_serializerConfigured)
            {
                //Otherwise create a lock so only one call can enter here
                lock (_lock)
                {
                    //Create a new naming stratergy and assign it
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