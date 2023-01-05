using Newtonsoft.Json;

namespace HuduAPI.Records
{
    /// <summary>
    /// Matchers are used by integrations to match external data to internal hudu companies.
    /// </summary>
    /// <seealso cref="HuduAPI.Records.IRecord"/>
    public class Matcher : IRecord
    {
        /// <summary>
        /// Gets or sets the company identifier used within Hudu.
        /// </summary>
        [JsonProperty("company_id")]
        public object CompanyId { get; set; }

        /// <summary>
        /// Gets or sets the name of the company in hudu.
        /// </summary>
        [JsonProperty("company_name")]
        public object CompanyName { get; set; }

        /// <summary>
        /// Gets or sets the identifier for this matcher instance.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Unknown
        /// </summary>
        [JsonProperty("identifier")]
        public object Identifier { get; set; }

        /// <summary>
        /// Gets or sets the integrator ID. Can be found in the URL when editing an integration
        /// </summary>
        [JsonProperty("integrator_id")]
        public int IntegratorId { get; set; }

        [JsonProperty("integrator_name")]
        public string IntegratorName { get; set; }

        /// <summary>
        /// Gets or sets the name the integrator uses to identify the company.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the potential company hudu thinks matchers the integrated company.
        /// </summary>
        [JsonProperty("potential_company_id")]
        public int? PotentialCompanyId { get; set; }

        /// <summary>
        /// Gets or sets the ID that the integrator uses to identify the customer.
        /// </summary>
        [JsonProperty("sync_id")]
        public int SyncId { get; set; }
    }

    /// <summary>
    /// A list of Matchers items
    /// </summary>
    /// <seealso cref="HuduAPI.Records.IRecord"/>
    public class Matchers : IRecord
    {
        [JsonProperty("matchers")]
        public IList<Matcher> MatchersList { get; set; }
    }
}