using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuduAPI.Endpoints.Parameters
{
    /// <summary> Builder for the class <see cref="GetCompanies">GetCompanies</see> <summary>
    public class GetCompaniesBuilder
    {
        private int? _page;
        private int? _pageSize;
        private string? _name;
        private string? _phoneNumber;
        private string? _website;
        private string? _city;
        private string? _idNumber;
        private string? _state;
        private string? _integrationID;

        /// <summary> Create a new instance for the <see
        /// cref="GetCompaniesBuilder">GetCompaniesBuilder</see> <summary>
        public GetCompaniesBuilder()
        {
            Reset();
        }

        /// <summary> Reset all properties' to the default value <summary> <returns>Returns the <see
        /// cref="GetCompaniesBuilder">GetCompaniesBuilder</see> with the properties reseted</returns>
        public GetCompaniesBuilder Reset()
        {
            _page = default;
            _pageSize = default;
            _name = default;
            _phoneNumber = default;
            _website = default;
            _city = default;
            _idNumber = default;
            _state = default;
            _integrationID = default;

            return this;
        }

        /// <summary> Set a value of type <typeparamref name="int"/> for the property <paramref
        /// name="page">page</paramref> <summary> <param name="page">A value of type <typeparamref
        /// name="int"/> will the defined for the property</param> <returns>Returns the <see
        /// cref="GetCompaniesBuilder">GetCompaniesBuilder</see> with the property <paramref
        /// name="page">page</paramref> defined</returns>
        public GetCompaniesBuilder WithPage(int page)
        {
            this._page = page;
            return this;
        }

        /// <summary> Set a value of type <typeparamref name="int"/> for the property <paramref
        /// name="pageSize">pageSize</paramref> <summary> <param name="pageSize">A value of type
        /// <typeparamref name="int"/> will the defined for the property</param> <returns>Returns
        /// the <see cref="GetCompaniesBuilder">GetCompaniesBuilder</see> with the property
        /// <paramref name="pageSize">pageSize</paramref> defined</returns>
        public GetCompaniesBuilder WithPageSize(int pageSize)
        {
            this._pageSize = pageSize;
            return this;
        }

        /// <summary> Set a value of type <typeparamref name="string"/> for the property <paramref
        /// name="name">name</paramref> <summary> <param name="name">A value of type <typeparamref
        /// name="string"/> will the defined for the property</param> <returns>Returns the <see
        /// cref="GetCompaniesBuilder">GetCompaniesBuilder</see> with the property <paramref
        /// name="name">name</paramref> defined</returns>
        public GetCompaniesBuilder WithName(string name)
        {
            this._name = name;
            return this;
        }

        /// <summary> Set a value of type <typeparamref name="string"/> for the property <paramref
        /// name="phoneNumber">phoneNumber</paramref> <summary> <param name="phoneNumber">A value of
        /// type <typeparamref name="string"/> will the defined for the property</param>
        /// <returns>Returns the <see cref="GetCompaniesBuilder">GetCompaniesBuilder</see> with the
        /// property <paramref name="phoneNumber">phoneNumber</paramref> defined</returns>
        public GetCompaniesBuilder WithPhoneNumber(string phoneNumber)
        {
            this._phoneNumber = phoneNumber;
            return this;
        }

        /// <summary> Set a value of type <typeparamref name="string"/> for the property <paramref
        /// name="website">website</paramref> <summary> <param name="website">A value of type
        /// <typeparamref name="string"/> will the defined for the property</param> <returns>Returns
        /// the <see cref="GetCompaniesBuilder">GetCompaniesBuilder</see> with the property
        /// <paramref name="website">website</paramref> defined</returns>
        public GetCompaniesBuilder WithWebsite(string website)
        {
            this._website = website;
            return this;
        }

        /// <summary> Set a value of type <typeparamref name="string"/> for the property <paramref
        /// name="city">city</paramref> <summary> <param name="city">A value of type <typeparamref
        /// name="string"/> will the defined for the property</param> <returns>Returns the <see
        /// cref="GetCompaniesBuilder">GetCompaniesBuilder</see> with the property <paramref
        /// name="city">city</paramref> defined</returns>
        public GetCompaniesBuilder WithCity(string city)
        {
            this._city = city;
            return this;
        }

        /// <summary> Set a value of type <typeparamref name="string"/> for the property <paramref
        /// name="idNumber">idNumber</paramref> <summary> <param name="idNumber">A value of type
        /// <typeparamref name="string"/> will the defined for the property</param> <returns>Returns
        /// the <see cref="GetCompaniesBuilder">GetCompaniesBuilder</see> with the property
        /// <paramref name="idNumber">idNumber</paramref> defined</returns>
        public GetCompaniesBuilder WithIDNumber(string idNumber)
        {
            this._idNumber = idNumber;
            return this;
        }

        /// <summary> Set a value of type <typeparamref name="string"/> for the property <paramref
        /// name="state">state</paramref> <summary> <param name="state">A value of type
        /// <typeparamref name="string"/> will the defined for the property</param> <returns>Returns
        /// the <see cref="GetCompaniesBuilder">GetCompaniesBuilder</see> with the property
        /// <paramref name="state">state</paramref> defined</returns>
        public GetCompaniesBuilder WithState(string state)
        {
            this._state = state;
            return this;
        }

        /// <summary> Set a value of type <typeparamref name="string"/> for the property <paramref
        /// name="integrationId">integrationId</paramref> <summary> <param name="integrationId">A
        /// value of type <typeparamref name="string"/> will the defined for the property</param>
        /// <returns>Returns the <see cref="GetCompaniesBuilder">GetCompaniesBuilder</see> with the
        /// property <paramref name="integrationId">integrationId</paramref> defined</returns>
        public GetCompaniesBuilder WithIntegrationID(string integrationId)
        {
            this._integrationID = integrationId;
            return this;
        }

        /// <summary> Build a class of type <see cref="GetCompanies">GetCompanies</see> with all the
        /// defined values <summary> <returns>Returns a <see cref="GetCompanies">GetCompanies</see> class</returns>
        public GetCompanies Build()
        {
            return new GetCompanies(_page, _pageSize, _name, _phoneNumber, _website, _city, _idNumber, _state, _integrationID);
        }
    }
}