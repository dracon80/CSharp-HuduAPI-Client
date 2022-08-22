using Newtonsoft.Json;

namespace HuduAPI.Records
{
    /// <summary>
    /// Represents the objects returned from the Hudu endpoint Expirations
    /// </summary>
    /// <seealso cref="HuduAPI.Records.IRecord" />
    public class Expiration : IRecord
    {
        [JsonProperty("account_id")]
        public int AccountID { get; set; }

        [JsonProperty("asset_field_id")]
        public int? AssetFieldID { get; set; }

        [JsonProperty("asset_layout_field_id")]
        public object AssetLayoutFieldID { get; set; }

        [JsonProperty("company_id")]
        public int CompanyID { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("discarded_at")]
        public object DiscardedAt { get; set; }

        [JsonProperty("expirationable_id")]
        public int ExpirationableID { get; set; }

        [JsonProperty("expirationable_type")]
        public string ExpirationableType { get; set; }

        [JsonProperty("expiration_type")]
        public string ExpirationType { get; set; }

        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("sync_id")]
        public int? SyncID { get; set; }

        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }
    }
}