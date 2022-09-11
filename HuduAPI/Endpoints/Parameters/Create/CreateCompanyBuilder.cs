using HuduAPI.Endpoints.Parameters.AbstractBases;

namespace HuduAPI.Endpoints.Parameters
{
    /// <summary>
    /// Builder for the class <see cref="CreateCompany">CreateCompany</see>
    /// </summary>
    public class CreateCompanyBuilder : CompanyBuilder<CreateCompany, CreateCompanyBuilder>, IParameters
    {
        /// <summary>
        /// Creates a new instance of the builder object with the required company name.
        /// </summary>
        /// <param name="name">
        /// </param>
        public CreateCompanyBuilder(string name) : base(name)
        {
        }

        /// <summary>
        /// Build a class of type <see cref="CreateCompany">CreateCompany</see> with all the defined values
        /// </summary>
        /// <returns>
        /// Returns a <see cref="CreateCompany">CreateCompany</see> class
        /// </returns>
        public override CreateCompany Build()
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
    }
}