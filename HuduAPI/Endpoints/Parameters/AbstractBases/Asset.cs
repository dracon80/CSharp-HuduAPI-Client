using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

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
        public int AssetLayoutId { get; private set; }

        /// <summary>
        /// Gets the company identifier the asset should be associated with.
        /// </summary>
        [JsonProperty("company_id")]
        public int CompanyId { get; private set; }

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
        public string Name { get; private set; }

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

    public class AssetCustomField : Dictionary<String, String>
    {
    }
}