using HuduAPI.Endpoints.Parameters.AbstractBases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuduAPI.Endpoints.Parameters
{
    /// <summary>
    /// A builder class to help build new <see cref="UpdateCompany" /> objects with the required
    /// properties to call the hudu endpoint api/v1/companies
    /// </summary>
    public class UpdateCompanyBuilder : CompanyBuilder<UpdateCompany, UpdateCompanyBuilder>
    {
        protected int _id;

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCompanyBuilder" /> builder class to
        /// help build an <see cref="UpdateCompany" /> object.
        /// </summary>
        /// <param name="id">
        /// The identifier.
        /// </param>
        /// <param name="name">
        /// The name.
        /// </param>
        public UpdateCompanyBuilder(int id, string name) : base(name)
        {
            _id = id;
        }

        /// <summary>
        /// Builds a new instance of type <typeparamref name="TResult" />.
        /// </summary>
        /// <returns>
        /// </returns>
        public override UpdateCompany Build()
        {
            return new UpdateCompany(_id, _name)
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