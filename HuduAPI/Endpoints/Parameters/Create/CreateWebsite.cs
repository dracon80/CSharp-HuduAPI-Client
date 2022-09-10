using Newtonsoft.Json;

namespace HuduAPI.Endpoints.Parameters
{
    /// <summary>
    /// Provides all the properties required to create a new website using the hudu endpoint api/v1/websites
    /// </summary>
    public class CreateWebsite : IParameters
    {
        /// <summary>
        /// Used to associate website with company
        /// </summary>
        [JsonProperty("company_id")]
        public int CompanyId { get; }

        /// <summary>
        /// When true, dns monitoring is paused.
        /// </summary>
        [JsonProperty("disable_dns")]
        public bool DisableDns { get; set; }

        /// <summary>
        /// When true, ssl cert monitoring is paused.
        /// </summary>
        [JsonProperty("disable_ssl")]
        public bool DisableSsl { get; set; }

        /// <summary>
        /// When true, whois monitoring is paused.
        /// </summary>
        [JsonProperty("disable_whois")]
        public bool DisableWhois { get; set; }

        /// <summary>
        /// FQND of the website to be monitored (e.g. www.example.com)
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; }

        /// <summary>
        /// used to add additional notes to a website
        /// </summary>
        [JsonProperty("notes")]
        public string? Notes { get; set; }

        /// <summary>
        /// When true, website monitoring is paused.
        /// </summary>
        [JsonProperty("paused")]
        public bool Paused { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWebsite" /> class with the minimum
        /// requried properties to get a new website.
        /// </summary>
        /// <param name="name">
        /// FQND of the website to be monitored (e.g. www.example.com)
        /// </param>
        /// <param name="companyId">
        /// The company identifier to associate the website with.
        /// </param>
        public CreateWebsite(string name, int companyId)
        {
            this.Name = name;
            this.CompanyId = companyId;
            this.Notes = default;
            this.Paused = false;
            this.DisableDns = false;
            this.DisableSsl = false;
            this.DisableWhois = false;
        }
    }
}