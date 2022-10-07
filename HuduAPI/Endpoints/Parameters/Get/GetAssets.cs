using Newtonsoft.Json;
using System.Runtime.InteropServices;

namespace HuduAPI.Endpoints.Parameters
{
    /// <summary>
    /// Provides all the filters that can be used when calling a the get method on api/v1/assets
    /// </summary>
    public class GetAssets : IParameters
    {
        /// <summary>
        /// Set to true to only show archived results.
        /// </summary>
        [JsonProperty("archived")]
        public Boolean Archived { get; set; } = false;

        /// <summary>
        /// id of the requested asset layout.
        /// </summary>
        [JsonProperty("asset_layout_id")]
        public int? AssetLayoutId { get; set; }

        /// <summary>
        /// id of the requested parent Company.
        /// </summary>
        [JsonProperty("company_id")]
        public int? CompanyId { get; set; }

        /// <summary>
        /// id of the requested Asset
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// filter by name.
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Gets or sets the page to return when paging through results.
        /// </summary>
        [JsonProperty("page")]
        public int? Page { get; set; }

        /// <summary>
        /// The number of results to return on each page.
        /// </summary>
        [JsonProperty("page_size")]
        public int? PageSize { get; set; }

        /// <summary>
        /// filter by primary serial.
        /// </summary>
        [JsonProperty("primary_serial")]
        public string? PrimarySerial { get; set; }

        public string PayloadType
        {
            get
            {
                return "";
            }
        }
    }
}