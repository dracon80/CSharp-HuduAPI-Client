using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuduAPI.Endpoints.Parameters
{
    /// <summary>
    /// Provides paramaters to filter a list of magic dash items when calling the endpoint api/v1/magic_dash
    /// </summary>
    /// <seealso cref="HuduAPI.Endpoints.Parameters.IParameters" />
    public class GetMagicDash : IParameters
    {
        /// <summary>
        /// Filter by title.
        /// </summary>
        [JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// filter by company_id.
        /// </summary>
        [JsonProperty("company_id")]
        public int? CompanyId { get; set; }

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