using Newtonsoft.Json;

namespace HuduAPI.Records
{
    /// <summary>
    /// Represents a single website object returned from the Hudu API endpoint websites
    /// </summary>
    public class Website
    {
        [JsonProperty("account_id")]
        public int AccountID { get; set; }

        [JsonProperty("asset_field_id")]
        public object AssetFieldID { get; set; }

        [JsonProperty("asset_type")]
        public string AssetType { get; set; }

        [JsonProperty("code")]
        public int? Code { get; set; }

        [JsonProperty("company_id")]
        public int CompanyID { get; set; }

        [JsonProperty("company_name")]
        public string CompanyName { get; set; }

        [JsonProperty("disable_dns")]
        public bool DisableDns { get; set; }

        [JsonProperty("disable_ssl")]
        public bool DisableSsl { get; set; }

        [JsonProperty("disable_whois")]
        public bool DisableWhois { get; set; }

        [JsonProperty("discarded_at")]
        public object DiscardedAt { get; set; }

        [JsonProperty("headers")]
        public object Headers { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("keyword")]
        public object Keyword { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("monitored_at")]
        public DateTime MonitoredAt { get; set; }

        [JsonProperty("monitoring_status")]
        public string MonitoringStatus { get; set; }

        [JsonProperty("monitor_type")]
        public int MonitorType { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("notes")]
        public object Notes { get; set; }

        [JsonProperty("object_type")]
        public string ObjectType { get; set; }

        [JsonProperty("paused")]
        public bool Paused { get; set; }

        [JsonProperty("refreshed_at")]
        public DateTime RefreshedAt { get; set; }

        [JsonProperty("sent_notifications")]
        public bool SentNotifications { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}