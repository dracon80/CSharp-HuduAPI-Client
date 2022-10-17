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

        [JsonProperty("archived")]
        public bool? Archived { get; set; } = false;

        [JsonProperty("city")]
        public string? City { get; set; }

        [JsonProperty("company_type")]
        public string? CompanyType { get; set; }

        [JsonProperty("country_name")]
        public string? CountryName { get; set; }

        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("fax_number")]
        public string? FaxNumber { get; set; }

        [JsonProperty("full_url")]
        public string? FullUrl { get; set; }

        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("id_number")]
        public string? IDNumber { get; set; }

        [JsonProperty("integrations")]
        public IList<Integration>? Integrations { get; set; }

        [JsonProperty("knowledge_base_url")]
        public string? KnowledgeBaseUrl { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("nickname")]
        public string? Nickname { get; set; }

        [JsonProperty("notes")]
        public string? Notes { get; set; }

        [JsonProperty("object_type")]
        public string? ObjectType { get; set; }

        [JsonProperty("parent_company_id")]
        public int? ParentCompanyId { get; set; }

        [JsonProperty("parent_company_name")]
        public string? ParentCompanyName { get; set; }

        [JsonProperty("passwords_url")]
        public string? PasswordsUrl { get; set; }

        [JsonProperty("phone_number")]
        public string? PhoneNumber { get; set; }

        [JsonProperty("slug")]
        public string? Slug { get; set; }

        [JsonProperty("state")]
        public string? State { get; set; }

        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; }

        [JsonProperty("url")]
        public string? Url { get; set; }

        [JsonProperty("website")]
        public string? Website { get; set; }

        [JsonProperty("zip")]
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

            [JsonProperty("id")]
            public int ID { get; set; }

            [JsonProperty("integrator_id")]
            public int IntegratorID { get; set; }

            [JsonProperty("integrator_name")]
            public string IntegratorName { get; set; }

            [JsonProperty("sync_id")]
            public int SyncId { get; set; }

            [JsonProperty("identifier")]
            public string Identifier { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }
        }
    }
}