using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Runtime.InteropServices;

namespace HuduAPI.Endpoints.Parameters
{
    /// <summary>
    /// Paramaters to get articles from the Hudu API endpoint /api/v1/articles
    /// </summary>
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class GetArticles : IParameters
    {
        /// <summary>
        /// Filter by company_id
        /// </summary>
        [JsonProperty("company_id")]
        public int? CompanyID { get; set; }

        /// <summary>
        /// Filter by name of article
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Get this page of results when paging through results.
        /// </summary>
        [JsonProperty("page")]
        public int? Page { get; set; }

        /// <summary>
        /// Number of results to return on each page.
        /// </summary>
        [JsonProperty("page_size")]
        public int? PageSize { get; set; }
    }
}