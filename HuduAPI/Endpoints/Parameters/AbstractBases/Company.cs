using Newtonsoft.Json;

namespace HuduAPI.Endpoints.Parameters.AbstractBases
{
    /// <summary>
    /// Provides all the common properties required to create or update a company using the hudu
    /// endpoint api/v1/companies
    /// </summary>
    public abstract class Company
    {
        /// <summary>
        /// An abstract class with the only common required properties initialised.
        /// </summary>
        /// <param name="name">
        /// The name of the new company.
        /// </param>
        internal Company(string name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Gets or sets the address line 1 of the company address.
        /// </summary>
        [JsonProperty("address_line_1")]
        public string? AddressLine1 { get; set; }

        /// <summary>
        /// Gets or sets the address line 2 of the company address.
        /// </summary>
        [JsonProperty("address_line_2")]
        public string? AddressLine2 { get; set; }

        /// <summary>
        /// Gets or sets the city of the company address.
        /// </summary>
        [JsonProperty("city")]
        public string? City { get; set; }

        /// <summary>
        /// Gets or sets the type of the company.
        /// </summary>
        [JsonProperty("company_type")]
        public string? CompanyType { get; set; }

        /// <summary>
        /// Gets or sets the country of the company address.
        /// </summary>
        [JsonProperty("country_name")]
        public string? CountryName { get; set; }

        /// <summary>
        /// Gets or sets the fax number of the company.
        /// </summary>
        [JsonProperty("fax_number")]
        public string? FaxNumber { get; set; }

        /// <summary>
        /// Gets or sets an identifier number associated with the company.
        /// </summary>
        [JsonProperty("id_number")]
        public string? IdNumber { get; set; }

        /// <summary>
        /// Gets the name of the new company.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; }

        /// <summary>
        /// Gets or sets the nickname of the company.
        /// </summary>
        [JsonProperty("nickname")]
        public string? Nickname { get; set; }

        /// <summary>
        /// Gets or sets the notes about the company.
        /// </summary>
        [JsonProperty("notes")]
        public string? Notes { get; set; }

        /// <summary>
        /// Gets or sets the parent company identifier for this company.
        /// </summary>
        [JsonProperty("parent_company_id")]
        public int? ParentCompanyId { get; set; }

        /// <summary>
        /// Gets or sets the phone number of the company.
        /// </summary>
        [JsonProperty("phone_number")]
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the state of the company address.
        /// </summary>
        [JsonProperty("state")]
        public string? State { get; set; }

        /// <summary>
        /// Gets or sets the website of the company.
        /// </summary>
        [JsonProperty("website")]
        public string? Website { get; set; }

        /// <summary>
        /// Gets or sets the zip of the company address.
        /// </summary>
        [JsonProperty("zip")]
        public string? Zip { get; set; }
    }
}