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
        /// Initializes a new instance of the <see cref="GetAssetLayouts" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the Asset Layout to get.
        /// </param>
        /// <param name="page">
        /// The page to get when paging throw results.
        /// </param>
        public GetAssetLayouts([Optional] string? name, [Optional] int? page)
        {
            Name = name;
            Page = page;
        }

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
    }
}