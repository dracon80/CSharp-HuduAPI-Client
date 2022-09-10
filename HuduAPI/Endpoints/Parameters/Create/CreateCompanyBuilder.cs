namespace HuduAPI.Endpoints.Parameters
{
    /// <summary>
    /// Builder for the class <see cref="CreateCompany">CreateCompany</see>
    /// </summary>
    public class CreateCompanyBuilder
    {
        private readonly string _name;
        private string? _addressLine1;
        private string? _addressLine2;
        private string? _city;
        private string? _companyType;
        private string? _countryName;
        private string? _faxNumber;
        private string? _idNumber;
        private string? _nickname;
        private string? _notes;
        private int? _parentCompanyId;
        private string? _phoneNumber;
        private string? _state;
        private string? _website;
        private string? _zip;

        /// <summary>
        /// Create a new instance for the <see cref="CreateCompanyBuilder">CreateCompanyBuilder</see>
        /// </summary>
        public CreateCompanyBuilder(string name)
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
        }

        /// <summary>
        /// Build a class of type <see cref="CreateCompany">CreateCompany</see> with all the defined values
        /// </summary>
        /// <returns>
        /// Returns a <see cref="CreateCompany">CreateCompany</see> class
        /// </returns>
        public CreateCompany Build()
        {
            return new CreateCompany(_name)
            {
                AddressLine1 = _addressLine1,
                AddressLine2 = _addressLine2,
                City = _city,
                CompanyType = _companyType,
                CountryName = _countryName,
                FaxNumber = _faxNumber,
                IdNumber = _idNumber,
                Nickname = _nickname,
                Notes = _notes,
                ParentCompanyId = _parentCompanyId,
                PhoneNumber = _phoneNumber,
                State = _state,
                Website = _website,
                Zip = _zip
            };
        }

        /// <summary>
        /// Set a value of type <typeparamref name="string" /> for the property <paramref name="addressLine1">addressLine1</paramref>
        /// </summary>
        /// <param name="addressLine1">
        /// A value of type <typeparamref name="string" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="CreateCompanyBuilder">CreateCompanyBuilder</see> with the
        /// property <paramref name="addressLine1">addressLine1</paramref> defined
        /// </returns>
        public CreateCompanyBuilder WithAddressLine1(string addressLine1)
        {
            _addressLine1 = addressLine1;
            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="string" /> for the property <paramref name="addressLine2">addressLine2</paramref>
        /// </summary>
        /// <param name="addressLine2">
        /// A value of type <typeparamref name="string" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="CreateCompanyBuilder">CreateCompanyBuilder</see> with the
        /// property <paramref name="addressLine2">addressLine2</paramref> defined
        /// </returns>
        public CreateCompanyBuilder WithAddressLine2(string addressLine2)
        {
            _addressLine2 = addressLine2;
            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="string" /> for the property <paramref name="city">city</paramref>
        /// </summary>
        /// <param name="city">
        /// A value of type <typeparamref name="string" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="CreateCompanyBuilder">CreateCompanyBuilder</see> with the
        /// property <paramref name="city">city</paramref> defined
        /// </returns>
        public CreateCompanyBuilder WithCity(string city)
        {
            _city = city;
            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="string" /> for the property <paramref name="companyType">companyType</paramref>
        /// </summary>
        /// <param name="companyType">
        /// A value of type <typeparamref name="string" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="CreateCompanyBuilder">CreateCompanyBuilder</see> with the
        /// property <paramref name="companyType">companyType</paramref> defined
        /// </returns>
        public CreateCompanyBuilder WithCompanyType(string companyType)
        {
            _companyType = companyType;
            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="string" /> for the property <paramref name="countryName">countryName</paramref>
        /// </summary>
        /// <param name="countryName">
        /// A value of type <typeparamref name="string" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="CreateCompanyBuilder">CreateCompanyBuilder</see> with the
        /// property <paramref name="countryName">countryName</paramref> defined
        /// </returns>
        public CreateCompanyBuilder WithCountryName(string countryName)
        {
            _countryName = countryName;
            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="string" /> for the property <paramref name="faxNumber">faxNumber</paramref>
        /// </summary>
        /// <param name="faxNumber">
        /// A value of type <typeparamref name="string" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="CreateCompanyBuilder">CreateCompanyBuilder</see> with the
        /// property <paramref name="faxNumber">faxNumber</paramref> defined
        /// </returns>
        public CreateCompanyBuilder WithFaxNumber(string faxNumber)
        {
            _faxNumber = faxNumber;
            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="string" /> for the property <paramref name="idNumber">idNumber</paramref>
        /// </summary>
        /// <param name="idNumber">
        /// A value of type <typeparamref name="string" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="CreateCompanyBuilder">CreateCompanyBuilder</see> with the
        /// property <paramref name="idNumber">idNumber</paramref> defined
        /// </returns>
        public CreateCompanyBuilder WithIdNumber(string idNumber)
        {
            _idNumber = idNumber;
            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="string" /> for the property <paramref name="nickname">nickname</paramref>
        /// </summary>
        /// <param name="nickname">
        /// A value of type <typeparamref name="string" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="CreateCompanyBuilder">CreateCompanyBuilder</see> with the
        /// property <paramref name="nickname">nickname</paramref> defined
        /// </returns>
        public CreateCompanyBuilder WithNickname(string nickname)
        {
            _nickname = nickname;
            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="string" /> for the property <paramref name="notes">notes</paramref>
        /// </summary>
        /// <param name="notes">
        /// A value of type <typeparamref name="string" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="CreateCompanyBuilder">CreateCompanyBuilder</see> with the
        /// property <paramref name="notes">notes</paramref> defined
        /// </returns>
        public CreateCompanyBuilder WithNotes(string notes)
        {
            _notes = notes;
            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="int?" /> for the property <paramref name="parentCompanyId">parentCompanyId</paramref>
        /// </summary>
        /// <param name="parentCompanyId">
        /// A value of type <typeparamref name="int?" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="CreateCompanyBuilder">CreateCompanyBuilder</see> with the
        /// property <paramref name="parentCompanyId">parentCompanyId</paramref> defined
        /// </returns>
        public CreateCompanyBuilder WithParentCompanyId(int? parentCompanyId)
        {
            _parentCompanyId = parentCompanyId;
            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="string" /> for the property <paramref name="phoneNumber">phoneNumber</paramref>
        /// </summary>
        /// <param name="phoneNumber">
        /// A value of type <typeparamref name="string" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="CreateCompanyBuilder">CreateCompanyBuilder</see> with the
        /// property <paramref name="phoneNumber">phoneNumber</paramref> defined
        /// </returns>
        public CreateCompanyBuilder WithPhoneNumber(string phoneNumber)
        {
            _phoneNumber = phoneNumber;
            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="string" /> for the property <paramref name="state">state</paramref>
        /// </summary>
        /// <param name="state">
        /// A value of type <typeparamref name="string" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="CreateCompanyBuilder">CreateCompanyBuilder</see> with the
        /// property <paramref name="state">state</paramref> defined
        /// </returns>
        public CreateCompanyBuilder WithState(string state)
        {
            _state = state;
            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="string" /> for the property <paramref name="website">website</paramref>
        /// </summary>
        /// <param name="website">
        /// A value of type <typeparamref name="string" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="CreateCompanyBuilder">CreateCompanyBuilder</see> with the
        /// property <paramref name="website">website</paramref> defined
        /// </returns>
        public CreateCompanyBuilder WithWebsite(string website)
        {
            _website = website;
            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="string" /> for the property <paramref name="zip">zip</paramref>
        /// </summary>
        /// <param name="zip">
        /// A value of type <typeparamref name="string" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="CreateCompanyBuilder">CreateCompanyBuilder</see> with the
        /// property <paramref name="zip">zip</paramref> defined
        /// </returns>
        public CreateCompanyBuilder WithZip(string zip)
        {
            _zip = zip;
            return this;
        }
    }
}