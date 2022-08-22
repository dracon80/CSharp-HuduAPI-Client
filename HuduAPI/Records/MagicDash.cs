using Newtonsoft.Json;

namespace HuduAPI.Records
{
    /// <summary>
    /// Represents a single MagicDash object returned from the hudu API endpoint magic_dash
    /// </summary>
    /// <seealso cref="HuduAPI.Records.IRecord" />
    public class MagicDash : IRecord
    {
        [JsonProperty("company_id")]
        public int CompanyID { get; set; }

        [JsonProperty("company_name")]
        public string CompanyName { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("content_link")]
        public object ContentLink { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("image_url")]
        public object ImageUrl { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("shade")]
        public string Shade { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }
}