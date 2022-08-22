using Newtonsoft.Json;

namespace HuduAPI.Records
{
    /// <summary>
    /// This internal class is used to help read the returned json from the HuduAPI endpoint. As the
    /// data contains a named element, there is a parent wrapper object, which this is.
    /// </summary>
    internal class AssetRoot : IRecord
    {
        [JsonProperty("asset")]
        public Asset Asset { get; set; }
    }

    /// <summary>
    /// Represents a single Asset returned from the Hudu API endpoint assets
    /// </summary>
    /// <seealso cref="HuduAPI.Records.IRecord" />
    public class Asset : IRecord
    {
        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("asset_layout_id")]
        public int AssetLayoutID { get; set; }

        [JsonProperty("asset_type")]
        public string AssetType { get; set; }

        [JsonProperty("company_id")]
        public int CompanyID { get; set; }

        [JsonProperty("company_name")]
        public string CompanyName { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("fields")]
        public IList<Field> Fields { get; set; }

        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("object_type")]
        public string ObjectType { get; set; }

        [JsonProperty("primary_mail")]
        public object PrimaryMail { get; set; }

        [JsonProperty("primary_manufacturer")]
        public object PrimaryManufacturer { get; set; }

        [JsonProperty("primary_model")]
        public object PrimaryModel { get; set; }

        [JsonProperty("primary_serial")]
        public string PrimarySerial { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    /// <summary>
    /// Represents a list of Assets returned from the Hudu endpoint assets
    /// </summary>
    public class Assets : IRecord
    {
        [JsonProperty("assets")]
        public IList<Asset> AssetList { get; set; }

        /// <summary>
        /// Gets the <see cref="System.Nullable{Asset}" /> with the specified identifier. Null is
        /// returned if no results are found
        /// </summary>
        /// <value>
        /// The <see cref="System.Nullable{Asset}" />.
        /// </value>
        /// <param name="id">
        /// The identifier of the asset to retrieve.
        /// </param>
        /// <returns>
        /// </returns>
        public Asset? this[int id]
        {
            get => AssetList.FirstOrDefault(t => t.ID == id);
        }

        /// <summary>
        /// Gets the <see cref="System.Nullable{Asset}" /> with the specified name. Null is returned
        /// if no results are found
        /// </summary>
        /// <value>
        /// The <see cref="System.Nullable{Asset}" />.
        /// </value>
        /// <param name="name">
        /// The name of the Asset to retrieve.
        /// </param>
        /// <returns>
        /// </returns>
        public Asset? this[string name]
        {
            get => AssetList.FirstOrDefault(t => t.Name == name);
        }
    }

    /// <summary>
    /// Represents a Field within the Asset Layout.
    /// </summary>
    public class Field
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("value")]
        public object Value { get; set; }
    }
}