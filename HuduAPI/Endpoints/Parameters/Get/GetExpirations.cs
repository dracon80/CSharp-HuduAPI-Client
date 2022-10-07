using Newtonsoft.Json;
using System.Runtime.InteropServices;

namespace HuduAPI.Endpoints.Parameters
{
    /// <summary>
    /// Provides the paramaters to get a list of expirations from the Hudu endpoint api/v1/expirations
    /// </summary>
    public class GetExpirations : IParameters
    {
        /// <summary>
        /// Filter expirations by company_id.
        /// </summary>
        [JsonProperty("company_id")]
        public int? CompanyId { get; set; }

        /// <summary>
        /// Filter expirations by expiration type (undeclared, domain, ssl_certificate, warranty,
        /// asset_field, article_expiration).
        /// </summary>
        [JsonProperty("expiration_type")]
        public string? ExpirationType { get; set; }

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

        /// <summary>
        /// Filter logs by resource id. Must be coupled with resource_type.
        /// </summary>
        [JsonProperty("resource_id")]
        public int? ResourceId { get; set; }

        /// <summary>
        /// Filter logs by resource type (Asset, AssetPassword, Company, Article, etc.). Must be
        /// coupled with resource_id.
        /// </summary>
        [JsonProperty("resource_type")]
        public int? ResourceType { get; set; }

        public string PayloadType
        {
            get
            {
                return "";
            }
        }
    }
}