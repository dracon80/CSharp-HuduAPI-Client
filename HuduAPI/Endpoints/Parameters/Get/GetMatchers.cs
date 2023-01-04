using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuduAPI.Endpoints.Parameters
{
    /// <summary>
    /// Provides the parameters to filter the list of matchers returned from the hudu endpoint api/v1/matchers
    /// </summary>
    /// <seealso cref="HuduAPI.Endpoints.Parameters.IParameters"/>
    public class GetMatchers : IParameters
    {
        /// <summary>
        /// Inialize a new GetMatchers parameter list with the "integration_id assiged at creation
        /// as it is required.
        /// </summary>
        /// <param name="integration_id">The integration identifier.</param>
        public GetMatchers(int integration_id)
        {
            this.IntegrationId = integration_id;
        }

        /// <summary>
        /// Filter on company id
        /// </summary>
        [JsonProperty("company_id")]
        public int CompanyId { get; set; }

        /// <summary>
        /// Filter by Identifier in the integration (if sync_id is not set). This is used if the id
        /// that the integration uses is a string.
        /// </summary>
        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        /// <summary>
        /// ID of the integration. Can be found in the URL when editing an integration
        /// </summary>
        [JsonProperty("integration_id")]
        public int IntegrationId { get; set; }

        /// <summary>
        /// Filter on whether the company already been matched
        /// </summary>
        [JsonProperty("matched")]
        public bool Matched { get; set; }

        /// <summary>
        /// get current page of results
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }

        /// <summary>
        /// Number of results to return
        /// </summary>
        [JsonProperty("page_size")]
        public int PageSize { get; set; }

        public string PayloadType
        {
            get
            {
                return "";
            }
        }

        /// <summary>
        /// Filter by ID of the record in the integration. This is used if the id that the
        /// integration uses is an integer.
        /// </summary>
        [JsonProperty("sync_id")]
        public string SyncId { get; set; }
    }
}