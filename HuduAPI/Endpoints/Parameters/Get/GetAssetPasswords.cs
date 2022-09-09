using Newtonsoft.Json;

namespace HuduAPI.Endpoints.Parameters
{
    /// <summary>
    /// Get a list of AssetPasswords from the Hudu API endpoint api/v1/asset_passwords using the
    /// supplied paramaters to narrow down the results.
    /// </summary>
    public class GetAssetPasswords : IParameters
    {
        /// <summary>
        /// filter by company_id.
        /// </summary>
        [JsonProperty("company_id")]
        public int? CompanyID { get; set; }

        /// <summary>
        /// filter by name of password.
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The gage number when paging through the results.
        /// </summary>
        [JsonProperty("page")]
        public int? Page { get; set; }

        /// <summary>
        /// Gets or sets the number of results to show on each page.
        /// </summary>
        [JsonProperty("page_size")]
        public int? PageSize { get; set; }
    }
}