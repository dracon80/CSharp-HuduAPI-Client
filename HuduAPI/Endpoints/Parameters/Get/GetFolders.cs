using Newtonsoft.Json;

namespace HuduAPI.Endpoints.Parameters
{
    /// <summary>
    /// Provides the parameters to get a filtered list of Folders from the Hudu API endpoint api/v1/folders
    /// </summary>
    public class GetFolders : IParameters
    {
        /// <summary>
        /// filter by company_id.
        /// </summary>
        [JsonProperty("company_id")]
        public int? CompanyId { get; set; }

        /// <summary>
        /// Filter by folder name.
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