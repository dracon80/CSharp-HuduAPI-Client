using Newtonsoft.Json;

namespace HuduAPI.Records
{
    /// <summary>
    /// Represents the returned API Info data from the Hudu API endpoint api/v1/api_info
    /// </summary>
    /// <seealso cref="HuduAPI.Records.IRecord" />
    public class APIInfo : IRecord
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }
    }
}