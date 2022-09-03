using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

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
        /// Gets or sets the name to filter companies by.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string? Name { get; set; }

        /// <summary>
        /// Gets or sets the phone number to filter companies by.
        /// </summary>
        /// <value>
        /// The phone number.
        /// </value>
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the website to filter companies by.
        /// </summary>
        /// <value>
        /// The website.
        /// </value>
        public string? Website { get; set; }

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
        /// Gets or sets the state to filter companies by.
        /// </summary>
        /// <value>
        /// The state.
        /// </value>
        public string? State { get; set; }

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
        /// Initializes a new instance of the <see cref="GetCompanies" /> class.
        /// </summary>
        /// <param name="page">
        /// The current page to return.
        /// </param>
        /// <param name="page_size">
        /// the number of results to return.
        /// </param>
        /// <param name="name">
        /// The name to filter companies by.
        /// </param>
        /// <param name="phoneNumber">
        /// The phone number to filter companies by.
        /// </param>
        /// <param name="website">
        /// The website to filter companies by.
        /// </param>
        /// <param name="city">
        /// The city to filter companies by.
        /// </param>
        /// <param name="iDNumber">
        /// The ID number to filter companies by.
        /// </param>
        /// <param name="state">
        /// The state to filter companies by.
        /// </param>
        /// <param name="integrationID">
        /// the integration identifier in PSA/RMM/outside integration to filter companies by.
        /// </param>
        public GetCompanies([Optional] int? page, [Optional] int? page_size,
            [Optional] string? name, [Optional] string? phoneNumber, [Optional] string? website,
            [Optional] string? city, [Optional] string? iDNumber, [Optional] string? state,
            [Optional] string? integrationID)
        {
            Page = page;
            PageSize = page_size;
            Name = name;
            PhoneNumber = phoneNumber;
            Website = website;
            City = city;
            IDNumber = iDNumber;
            State = state;
            IntegrationID = integrationID;
        }
    }
}