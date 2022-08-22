using Newtonsoft.Json;

namespace HuduAPI.Records
{
    /// <summary>
    /// This internal class is used to help read the returned json from the HuduAPI endpoint. As the
    /// data contains a company element, there is a parent wrapper object, which this is.
    /// </summary>
    /// <seealso cref="HuduAPI.Records.IRecord" />
    internal class CompanyRoot : IRecord
    {
        public CompanyRoot(Company company)
        {
            Company = company;
        }

        public Company Company { get; set; }
    }

    /// <summary>
    /// Companies represents the list of companies returned from a call to the Companies Endpoint.
    /// </summary>
    /// <remarks>
    /// Companies is a very simple object that contains a List of <see
    /// cref="T:HuduAPI.Records.Company">Company</see> objects. Along with a Indexer to allow easy
    /// access to individual companies based on Company ID.
    /// </remarks>
    public class Companies : IRecord
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Companies" /> class with the supplied list
        /// of <see cref="Company" /> objects.
        /// </summary>
        /// <param name="companyList">
        /// The list of <see cref="Company" /> objects.
        /// </param>
        public Companies(IList<Company> companyList)
        {
            CompanyList = companyList;
        }

        [JsonProperty("Companies")]
        public IList<Company> CompanyList { get; set; }

        /// <summary>
        /// Gets the <see cref="System.Nullable{Company}" /> with the a company ID of value index.
        /// If a company does not existing with this ID, then null is returend.
        /// </summary>
        /// <param name="id">
        /// The company ID of the required company
        /// </param>
        /// <returns>
        /// A <see cref="Company" /> with the company id of the value supplied to index.
        /// </returns>
        public Company? this[int id]
        {
            get => CompanyList.FirstOrDefault(c => c.ID == id);
        }
    }

    /// <summary>
    /// Represents a Hudu Company and all its attributes as provided by the Hudu API
    /// </summary>
    public class Company : IRecord
    {
        [JsonProperty("address_line_1")]
        public string? AddressLine1 { get; set; }

        [JsonProperty("address_line_2")]
        public string? AddressLine2 { get; set; }

        public bool? Archived { get; set; } = false;

        public string? City { get; set; }

        public string? CompanyType { get; set; }

        public string? CountryName { get; set; }

        public DateTime? CreatedAt { get; set; }

        public string? FaxNumber { get; set; }

        public string? FullUrl { get; set; }

        public int? ID { get; set; }

        [JsonProperty("id_number")]
        public string? IDNumber { get; set; }

        public IList<Integration>? Integrations { get; set; }

        public string? KnowledgeBaseUrl { get; set; }

        public string? Name { get; set; }

        public string? Nickname { get; set; }

        public string? Notes { get; set; }

        public string? ObjectType { get; set; }

        public int? ParentCompanyId { get; set; }

        public string? ParentCompanyName { get; set; }

        public string? PasswordsUrl { get; set; }

        public string? PhoneNumber { get; set; }

        public string? Slug { get; set; }

        public string? State { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public string? Url { get; set; }

        public string? Website { get; set; }

        public string? Zip { get; set; }

        /// <summary>
        /// Any API integrations that may be enabled for the company
        /// </summary>
        public class Integration
        {
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

            public int? ID { get; set; }

            public string? Identifier { get; set; }
            public int? IntegratorID { get; set; }

            public string? IntegratorName { get; set; }

            public string? Name { get; set; }
            public int? SyncID { get; set; }
        }
    }
}