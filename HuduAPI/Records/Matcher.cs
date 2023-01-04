using Newtonsoft.Json;

namespace HuduAPI.Records
{
    /// <summary>
    /// Matchers are used by integrations to match external data to internal hudu companies.
    /// </summary>
    /// <seealso cref="HuduAPI.Records.IRecord"/>
    public class Matcher : IRecord
    {
        [JsonProperty("company_id")]
        public object CompanyId { get; set; }

        [JsonProperty("company_name")]
        public object CompanyName { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("identifier")]
        public object Identifier { get; set; }

        [JsonProperty("integrator_id")]
        public int IntegratorId { get; set; }

        [JsonProperty("integrator_name")]
        public string IntegratorName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("potential_company_id")]
        public int? PotentialCompanyId { get; set; }

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