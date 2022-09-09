using Newtonsoft.Json;

namespace HuduAPI.Endpoints.Parameters
{
    public class CreateAssetLayoutField
    {
        public CreateAssetLayoutField(string label, CreateAssetLayoutFieldType fieldtype)
        {
            this.Label = label;
            this.FieldType = fieldtype;
        }

        [JsonProperty("expiration")]
        public bool Expiration { get; set; }

        [JsonProperty("field_type")]
        public CreateAssetLayoutFieldType FieldType { get; set; } = CreateAssetLayoutFieldType.TEXT;

        [JsonProperty("hint")]
        public string? Hint { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("linkable_id")]
        public int? LinkableId { get; set; }

        [JsonProperty("max")]
        public int? Max { get; set; }

        [JsonProperty("min")]
        public int? Min { get; set; }

        [JsonProperty("options")]
        public string? Options { get; set; }

        [JsonProperty("position")]
        public int? Position { get; set; }

        [JsonProperty("required")]
        public bool Required { get; set; }

        [JsonProperty("show_in_list")]
        public bool ShowInList { get; set; }
    }
}