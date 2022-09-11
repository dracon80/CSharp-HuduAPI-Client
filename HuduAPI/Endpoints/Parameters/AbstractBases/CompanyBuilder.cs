namespace HuduAPI.Endpoints.Parameters.AbstractBases
{
    /// <summary>
    /// An abstract builder for the class for the Abstract <see cref="Company" /> Class that will be
    /// implemented by both update and create classes.
    /// </summary>
    public abstract class CompanyBuilder<TResult, TBuilder>
        where TResult : Company
        where TBuilder : CompanyBuilder<TResult, TBuilder>
    {
        /// <summary>
        /// Gets the builder instance of the implmenting class type.
        /// </summary>
        private readonly TBuilder _builderInstance = null;

        protected readonly string _name;
        protected string? _addressLine1;
        protected string? _addressLine2;
        protected string? _city;
        protected string? _companyType;
        protected string? _countryName;
        protected string? _faxNumber;
        protected string? _idNumber;
        protected string? _nickname;
        protected string? _notes;
        protected int? _parentCompanyId;
        protected string? _phoneNumber;
        protected string? _state;
        protected string? _website;
        protected string? _zip;

        /// <summary>
        /// Create a new instance for the <see cref="CompanyBuilder">CreateCompanyBuilder</see>
        /// </summary>
        internal CompanyBuilder(string name)
        {
            _addressLine1 = default;
            _addressLine2 = default;
            _city = default;
            _companyType = default;
            _countryName = default;
            _faxNumber = default;
            _idNumber = default;
            _name = name;
            _nickname = default;
            _notes = default;
            _parentCompanyId = default;
            _phoneNumber = default;
            _state = default;
            _website = default;
            _zip = default;

            _builderInstance = (TBuilder)this;
        }

        /// <summary>
        /// Builds a new instance of type <typeparamref name="TResult" />.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract TResult Build();

        /// <summary>
        /// Set a value for addressLine1
        /// </summary>
        /// <param name="addressLine1">
        /// The address line1.
        /// </param>
        /// <returns>
        /// A generic Builder Object for type <typeparamref name="TBuilder" />
        /// </returns>
        public TBuilder WithAddressLine1(string addressLine1)
        {
            _addressLine1 = addressLine1;
            return _builderInstance;
        }

        /// <summary>
        /// Set a value for addressLine2
        /// </summary>
        /// <param name="addressLine2">
        /// The address line2.
        /// </param>
        /// <returns>
        /// A generic Builder Object for type <typeparamref name="TBuilder" />
        /// </returns>
        public TBuilder WithAddressLine2(string addressLine2)
        {
            _addressLine2 = addressLine2;
            return _builderInstance;
        }

        /// <summary>
        /// Set a value for city
        /// </summary>
        /// <param name="city">
        /// The city.
        /// </param>
        /// <returns>
        /// A generic Builder Object for type <typeparamref name="TBuilder" />
        /// </returns>
        public TBuilder WithCity(string city)
        {
            _city = city;
            return _builderInstance;
        }

        /// <summary>
        /// Set a value for companyType
        /// </summary>
        /// <param name="companyType">
        /// Type of the company.
        /// </param>
        /// <returns>
        /// A generic Builder Object for type <typeparamref name="TBuilder" />
        /// </returns>
        public TBuilder WithCompanyType(string companyType)
        {
            _companyType = companyType;
            return _builderInstance;
        }

        /// <summary>
        /// Set a value for countryName
        /// </summary>
        /// <param name="countryName">
        /// Name of the country.
        /// </param>
        /// <returns>
        /// A generic Builder Object for type <typeparamref name="TBuilder" />
        /// </returns>
        public TBuilder WithCountryName(string countryName)
        {
            _countryName = countryName;
            return _builderInstance;
        }

        /// <summary>
        /// Set a value for faxNumber
        /// </summary>
        /// <param name="faxNumber">
        /// The fax number.
        /// </param>
        /// <returns>
        /// A generic Builder Object for type <typeparamref name="TBuilder" />
        /// </returns>
        public TBuilder WithFaxNumber(string faxNumber)
        {
            _faxNumber = faxNumber;
            return _builderInstance;
        }

        /// <summary>
        /// Set a value for idNumber
        /// </summary>
        /// <param name="idNumber">
        /// The identifier number.
        /// </param>
        /// <returns>
        /// A generic Builder Object for type <typeparamref name="TBuilder" />
        /// </returns>
        public TBuilder WithIdNumber(string idNumber)
        {
            _idNumber = idNumber;
            return _builderInstance;
        }

        /// <summary>
        /// Set a value for nickname
        /// </summary>
        /// <param name="nickname">
        /// The nickname.
        /// </param>
        /// <returns>
        /// A generic Builder Object for type <typeparamref name="TBuilder" />
        /// </returns>
        public TBuilder WithNickname(string nickname)
        {
            _nickname = nickname;
            return _builderInstance;
        }

        /// <summary>
        /// Set a value for notes
        /// </summary>
        /// <param name="notes">
        /// The notes.
        /// </param>
        /// <returns>
        /// A generic Builder Object for type <typeparamref name="TBuilder" />
        /// </returns>
        public TBuilder WithNotes(string notes)
        {
            _notes = notes;
            return _builderInstance;
        }

        /// <summary>
        /// Set a value for parentCompanyId
        /// </summary>
        /// <param name="parentCompanyId">
        /// The parent company identifier.
        /// </param>
        /// <returns>
        /// A generic Builder Object for type <typeparamref name="TBuilder" />
        /// </returns>
        public TBuilder WithParentCompanyId(int? parentCompanyId)
        {
            _parentCompanyId = parentCompanyId;
            return _builderInstance;
        }

        /// <summary>
        /// Set a value for phoneNumber
        /// </summary>
        /// <param name="phoneNumber">
        /// The phone number.
        /// </param>
        /// <returns>
        /// A generic Builder Object for type <typeparamref name="TBuilder" />
        /// </returns>
        public TBuilder WithPhoneNumber(string phoneNumber)
        {
            _phoneNumber = phoneNumber;
            return _builderInstance;
        }

        /// <summary>
        /// Set a value for state
        /// </summary>
        /// <param name="state">
        /// The state.
        /// </param>
        /// <returns>
        /// A generic Builder Object for type <typeparamref name="TBuilder" />
        /// </returns>
        public TBuilder WithState(string state)
        {
            _state = state;
            return _builderInstance;
        }

        /// <summary>
        /// Set a value for website
        /// </summary>
        /// <param name="website">
        /// The website.
        /// </param>
        /// <returns>
        /// A generic Builder Object for type <typeparamref name="TBuilder" />
        /// </returns>
        public TBuilder WithWebsite(string website)
        {
            _website = website;
            return _builderInstance;
        }

        /// <summary>
        /// Set a value for zip
        /// </summary>
        /// <param name="zip">
        /// The zip.
        /// </param>
        /// <returns>
        /// A generic Builder Object for type <typeparamref name="TBuilder" />
        /// </returns>
        public TBuilder WithZip(string zip)
        {
            _zip = zip;
            return _builderInstance;
        }
    }
}