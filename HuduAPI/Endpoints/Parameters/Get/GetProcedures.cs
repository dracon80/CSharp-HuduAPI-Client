using Newtonsoft.Json;

namespace HuduAPI.Endpoints.Parameters
{
    /// <summary>
    /// Provides the paramters to filter the list of procedures returned from the hudu endpoint api/v1/procedures
    /// </summary>
    /// <seealso cref="HuduAPI.Endpoints.Parameters.IParameters" />
    public class GetProcedures : IParameters
    {
        /// <summary>
        /// filter by company_id.
        /// </summary>
        [JsonProperty("company_id")]
        public int? CompanyId { get; set; }

        /// <summary>
        /// filter by name of procedure.
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