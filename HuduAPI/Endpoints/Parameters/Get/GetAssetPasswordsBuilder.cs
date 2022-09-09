namespace HuduAPI.Endpoints.Parameters
{
    /// <summary>
    /// Builder for the class <see cref="GetAssetPasswords">GetAssetPasswords</see>
    /// </summary>
    public class GetAssetPasswordsBuilder
    {
        private int? _companyID;
        private string? _name;
        private int? _page;
        private int? _pageSize;

        /// <summary>
        /// Create a new instance for the <see cref="GetAssetPasswordsBuilder">GetAssetPasswordsBuilder</see>
        /// </summary>
        public GetAssetPasswordsBuilder()
        {
            Reset();
        }

        /// <summary>
        /// Build a class of type <see cref="GetAssetPasswords">GetAssetPasswords</see> with all the
        /// defined values
        /// </summary>
        /// <returns>
        /// Returns a <see cref="GetAssetPasswords">GetAssetPasswords</see> class
        /// </returns>
        public GetAssetPasswords Build()
        {
            return new GetAssetPasswords
            {
                CompanyID = _companyID,
                Name = _name,
                Page = _page,
                PageSize = _pageSize
            };
        }

        /// <summary>
        /// Reset all properties' to the default value
        /// </summary>
        /// <returns>
        /// Returns the <see cref="GetAssetPasswordsBuilder">GetAssetPasswordsBuilder</see> with the
        /// properties reseted
        /// </returns>
        public GetAssetPasswordsBuilder Reset()
        {
            _name = default;
            _companyID = default;
            _page = default;
            _pageSize = default;

            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="int" /> for the property <paramref name="companyId">companyId</paramref>
        /// </summary>
        /// <param name="companyId">
        /// A value of type <typeparamref name="int" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="GetAssetPasswordsBuilder">GetAssetPasswordsBuilder</see> with the
        /// property <paramref name="companyId">companyId</paramref> defined
        /// </returns>
        public GetAssetPasswordsBuilder WithCompanyID(int companyId)
        {
            this._companyID = companyId;
            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="string" /> for the property <paramref name="name">name</paramref>
        /// </summary>
        /// <param name="name">
        /// A value of type <typeparamref name="string" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="GetAssetPasswordsBuilder">GetAssetPasswordsBuilder</see> with the
        /// property <paramref name="name">name</paramref> defined
        /// </returns>
        public GetAssetPasswordsBuilder WithName(string name)
        {
            this._name = name;
            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="int?" /> for the property <paramref name="page">page</paramref>
        /// </summary>
        /// <param name="page">
        /// A value of type <typeparamref name="int" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="GetAssetPasswordsBuilder">GetAssetPasswordsBuilder</see> with the
        /// property <paramref name="page">page</paramref> defined
        /// </returns>
        public GetAssetPasswordsBuilder WithPage(int page)
        {
            this._page = page;
            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="int?" /> for the property <paramref name="pageSize">pageSize</paramref>
        /// </summary>
        /// <param name="pageSize">
        /// A value of type <typeparamref name="int?" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="GetAssetPasswordsBuilder">GetAssetPasswordsBuilder</see> with the
        /// property <paramref name="pageSize">pageSize</paramref> defined
        /// </returns>
        public GetAssetPasswordsBuilder WithPageSize(int pageSize)
        {
            this._pageSize = pageSize;
            return this;
        }
    }
}