using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuduAPI.Endpoints.Parameters
{
    /// <summary>
    /// Provides the parameters to filter the list of Websites returned from the hudu endpoint api/v1/websites
    /// </summary>
    public class GetWebsites : IParameters
    {
        /// <summary>
        /// Filter by website name.
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

        public string PayloadType
        {
            get
            {
                return "";
            }
        }
    }
}