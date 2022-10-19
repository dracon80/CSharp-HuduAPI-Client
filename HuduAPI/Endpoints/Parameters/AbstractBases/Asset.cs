using Newtonsoft.Json;
using System.ComponentModel;
using System.Text;

namespace HuduAPI.Endpoints.Parameters.AbstractBases
{
    /// <summary>
    /// An asbstract class providing all the common properties to call the hudu endpoint api/v1/companies/:company_id/assets
    /// </summary>
    public abstract class Asset
    {
        /// <summary>
        /// Absrtact constructor to build the shared minimum properties.
        /// </summary>
        /// <param name="companyId">The company identifier.</param>
        /// <param name="assetLayoutId">The asset layout identifier.</param>
        /// <param name="name">The name.</param>
        public Asset(int companyId, int assetLayoutId, string name)
        {
            CustomFields = new AssetCustomField();
            CompanyId = companyId;
            AssetLayoutId = assetLayoutId;
            Name = name;
        }

        /// <summary>
        /// Gets the asset layout identifier this asset is assocatiated with.
        /// </summary>
        [JsonProperty("asset_layout_id")]
        public int AssetLayoutId { get; protected set; }

        /// <summary>
        /// Gets the company identifier the asset should be associated with.
        /// </summary>
        [JsonProperty("company_id")]
        [JsonIgnore]
        public int CompanyId { get; protected set; }

        /// <summary>
        /// Gets or sets the custom fields dictionary. The key must be the lable of the asset_type
        /// field in lowercase.
        /// </summary>
        [JsonProperty("custom_fields")]
        public AssetCustomField CustomFields { get; set; }

        /// <summary>
        /// Gets the name of the asset.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; protected set; }

        /// <summary>
        /// Gets or sets the primary mail.
        /// </summary>
        [JsonProperty("primary_mail")]
        public string? PrimaryMail { get; set; }

        /// <summary>
        /// Gets or sets the primary manufacturer.
        /// </summary>
        [JsonProperty("primary_manufacturer")]
        public string? PrimaryManufacturer { get; set; }

        /// <summary>
        /// Gets or sets the primary model.
        /// </summary>
        [JsonProperty("primary_model")]
        public string? PrimaryModel { get; set; }

        /// <summary>
        /// Gets or sets the primary serial.
        /// </summary>
        [JsonProperty("primary_serial")]
        public string? PrimarySerial { get; set; }
    }

    [JsonConverter(typeof(AssetCustomFieldJsonConverter))]
    public class AssetCustomField : Dictionary<String, String>
    {
        /// <summary>
        /// Adds the specified key and value to the dictionary.
        /// </summary>
        /// <param name="key">The key of the element to add.</param>
        /// <param name="value">
        /// The value of the element to add. The value can be <see langword="null"/> for reference types.
        /// </param>
        public new void Add(string key, string value)
        {
            base.Add(key.ToLower(), value);
        }
    }

    public class AssetCustomFieldJsonConverter : JsonConverter<AssetCustomField>
    {
        public override AssetCustomField ReadJson(JsonReader reader, Type objectType, AssetCustomField existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            //Not used
            return new AssetCustomField();
        }

        public override void WriteJson(JsonWriter writer, AssetCustomField value, JsonSerializer serializer)
        {
            //As per the stupid way Hudu have formated the json, do not open or close an object for each value.
            //Its basically an array with 1 items that includes all the fields
            writer.WriteStartArray();
            writer.WriteStartObject();

            foreach (var item in value)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteValue(item.Value);
            }

            writer.WriteEndObject();
            writer.WriteEndArray();
        }
    }
}