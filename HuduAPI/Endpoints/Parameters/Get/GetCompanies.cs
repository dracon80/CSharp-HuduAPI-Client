using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace HuduAPI.Endpoints.Parameters
{
    /// <summary>
    /// Paramaters to get a list of companies from hudu
    /// </summary>
    /// <seealso cref="HuduAPI.Endpoints.Parameters.IParameters" />
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class GetCompanies : IParameters
    {
        /// <summary>
        /// Gets or sets the city to filter companies by.
        /// </summary>
        /// <value>
        /// The city.
        /// </value>
        public string? City { get; set; }

        /// <summary>
        /// Gets or sets the identifier number to filter companies by.
        /// </summary>
        /// <value>
        /// The identifier number.
        /// </value>
        [JsonProperty("id_number")]
        public string? IDNumber { get; set; }

        /// <summary>
        /// Gets or sets the integration identifier in PSA/RMM/outside integration to filter
        /// companies by.
        /// </summary>
        /// <value>
        /// The integration identifier.
        /// </value>
        [JsonProperty("id_in_integration")]
        public string? IntegrationID { get; set; }

        /// <summary>
        /// Gets or sets the name to filter companies by.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string? Name { get; set; }

        /// <summary>
        /// Gets or sets the current page of results.
        /// </summary>
        /// <value>
        /// The page.
        /// </value>
        public int? Page { get; set; }

        /// <summary>
        /// Gets or sets the number of results to return from the Hudu API.
        /// </summary>
        /// <value>
        /// The size of the page.
        /// </value>
        public int? PageSize { get; set; }

        /// <summary>
        /// Gets or sets the phone number to filter companies by.
        /// </summary>
        /// <value>
        /// The phone number.
        /// </value>
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the state to filter companies by.
        /// </summary>
        /// <value>
        /// The state.
        /// </value>
        public string? State { get; set; }

        /// <summary>
        /// Gets or sets the website to filter companies by.
        /// </summary>
        /// <value>
        /// The website.
        /// </value>
        public string? Website { get; set; }

        public string PayloadType
        {
            get
            {
                return "";
            }
        }
    }
}