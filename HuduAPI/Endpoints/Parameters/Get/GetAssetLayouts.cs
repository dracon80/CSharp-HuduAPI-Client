using Newtonsoft.Json;
using System.Runtime.InteropServices;

namespace HuduAPI.Endpoints.Parameters
{
    /// <summary>
    /// Paramaters to get asset_layouts from the Hudu API endpoint /api/v1/asset_layouts
    /// </summary>
    public class GetAssetLayouts : IParameters
    {
        /// <summary>
        /// Filter by name of asset_layout
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Get this page of results when paging through results.
        /// </summary>
        [JsonProperty("page")]
        public int? Page { get; set; }

        public string PayloadType
        {
            get
            {
                return "";
            }
        }
    }
}