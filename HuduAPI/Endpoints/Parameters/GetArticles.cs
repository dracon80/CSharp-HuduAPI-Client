using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Runtime.InteropServices;

namespace HuduAPI.Endpoints.Parameters
{
    /// <summary>
    /// Paramaters to get a
    /// </summary>
    /// <seealso cref="HuduAPI.Endpoints.Parameters.IParameters" />
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class GetArticles : IParameters
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetArticles" /> class used to filter
        /// results on a call to the articles endpoint.
        /// </summary>
        /// <param name="name">
        /// The name of the article to filter by.
        /// </param>
        /// <param name="companyID">
        /// The company id identifier articles by.
        /// </param>
        /// <param name="page">
        /// The page to retrive when using pagation.
        /// </param>
        /// <param name="pageSize">
        /// The number of results on each page.
        /// </param>
        public GetArticles([Optional] string? name, [Optional] int? companyID, [Optional] int? page, [Optional] int? pageSize)
        {
            Name = name;
            CompanyID = companyID;
            Page = page;
            PageSize = pageSize;
        }

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