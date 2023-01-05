using Newtonsoft.Json;

namespace HuduAPI.Endpoints.Parameters
{
    public class UpdateMatcher : IParameters
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMatcher"/> class with the required
        /// matcher ID to be updated.
        /// </summary>
        /// <param name="id">The ID of the matcher to update.</param>
        public UpdateMatcher(int id)
        {
            this.Id = id;
        }

        /// <summary>
        /// Gets or sets the hudu company id to make a match for.
        /// </summary>
        /// <value>The company identifier.</value>
        [JsonProperty("company_id")]
        public int CompanyId { get; set; }

        /// <summary>
        /// Gets the identifier for this matcher.
        /// </summary>
        [JsonIgnore]
        public int Id { get; private set; }

        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        [JsonIgnore]
        public string PayloadType
        {
            get
            {
                return "matcher";
            }
        }

        /// <summary>
        /// The suggested hudu company that hudu thinks would match
        /// </summary>
        /// <value>The potential company identifier.</value>
        [JsonProperty("potential_company_id")]
        public int PotentialCompanyId { get; set; }

        /// <summary>
        /// This seems to be the company Identifier in the source data. e.g. Connectwise company ID.
        /// </summary>
        /// <value>The synchronize identifier.</value>
        [JsonProperty("sync_id")]
        public string SyncId { get; set; }
    }
}