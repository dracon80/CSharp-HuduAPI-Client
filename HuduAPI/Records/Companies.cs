#pragma warning disable 1591

using Newtonsoft.Json;

namespace HuduAPI.Records
{
    /// <summary>
    /// Represents a Hudu Company and all its attributes as provided by the Hudu API
    /// </summary>
    public class Company : IRecord
    {
        /// <summary>
        /// Any API integrations that may be enabled for the company
        /// </summary>
        public class Integration
        {
            public int? ID { get; set; }

            public int? IntegratorID { get; set; }

            public string? IntegratorName { get; set; }

            public int? SyncID { get; set; }

            public string? Identifier { get; set; }

            public string? Name { get; set; }

            /// <summary>
            /// Initializes a new instance of the <see cref="Integration" /> class.
            /// </summary>
            /// <param name="id">
            /// The identifier.
            /// </param>
            /// <param name="integratorID">
            /// The integrator identifier.
            /// </param>
            /// <param name="integratorName">
            /// Name of the integrator.
            /// </param>
            /// <param name="name">
            /// The integration name.
            /// </param>
            public Integration(int id, int integratorID, string integratorName, string name)
            {
                this.ID = id;
                this.IntegratorID = integratorID;
                this.IntegratorName = integratorName;
                this.Name = name;
            }
        }

        public int? ID { get; set; }

        public string? Slug { get; set; }

        public string? Name { get; set; }

        public string? Nickname { get; set; }

        [JsonProperty("address_line_1")]
        public string? AddressLine1 { get; set; }

        [JsonProperty("address_line_2")]
        public string? AddressLine2 { get; set; }

        public string? City { get; set; }

        public string? State { get; set; }

        public string? Zip { get; set; }

        public string? CountryName { get; set; }

        public string? PhoneNumber { get; set; }

        public string? CompanyType { get; set; }

        public int? ParentCompanyId { get; set; }

        public string? ParentCompanyName { get; set; }

        public string? FaxNumber { get; set; }

        public string? Website { get; set; }

        public string? Notes { get; set; }

        public bool? Archived { get; set; } = false;

        public string? ObjectType { get; set; }

        [JsonProperty("id_number")]
        public string? IDNumber { get; set; }

        public string? Url { get; set; }

        public string? FullUrl { get; set; }

        public string? PasswordsUrl { get; set; }

        public string? KnowledgeBaseUrl { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public IList<Integration>? Integrations { get; set; }
    }

    /// <summary>
    /// Companies represents the list of companies returned from a call to the Companies Endpoint.
    /// </summary>
    /// <remarks>
    /// Companies is a very simple object that basically contains a List of <see cref="T:HuduAPI.Records.Company">Company</see>.
    /// </remarks>
    public class Companies : IRecord
    {
        [JsonProperty("Companies")]
        public IList<Company> CompanyList { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="Company" /> at the specified index.
        /// </summary>
        /// <param name="index">
        /// The index.
        /// </param>
        /// <value>
        /// The <see cref="Company" />.
        /// </value>
        /// <returns>
        /// <br />
        /// </returns>
        public Company this[int index]
        {
            get => CompanyList[index];
            set => CompanyList[index] = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Companies" /> class.
        /// </summary>
        /// <param name="companyList">
        /// The company list.
        /// </param>
        public Companies(IList<Company> companyList)
        {
            CompanyList = companyList;
        }
    }

    internal class CompanyRoot : IRecord
    {
        public Company Company { get; set; }

        public CompanyRoot(Company company)
        {
            Company = company;
        }
    }
}