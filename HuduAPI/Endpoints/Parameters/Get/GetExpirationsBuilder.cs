namespace HuduAPI.Endpoints.Parameters
{
    /// <summary>
    /// Builder for the class <see cref="GetExpirations">GetExpirations</see>
    /// </summary>
    public class GetExpirationsBuilder
    {
        private int? _companyId;
        private string? _expirationType;
        private int? _page;
        private int? _pageSize;
        private int? _resourceId;
        private int? _resourceType;

        /// <summary>
        /// Create a new instance for the <see cref="GetExpirationsBuilder">GetExpirationsBuilder</see>
        /// </summary>
        public GetExpirationsBuilder()
        {
            Reset();
        }

        /// <summary>
        /// Build a class of type <see cref="GetExpirations">GetExpirations</see> with all the
        /// defined values
        /// </summary>
        /// <returns>
        /// Returns a <see cref="GetExpirations">GetExpirations</see> class
        /// </returns>
        public GetExpirations Build()
        {
            return new GetExpirations
            {
                CompanyId = _companyId,
                ExpirationType = _expirationType,
                Page = _page,
                PageSize = _pageSize,
                ResourceId = _resourceId,
                ResourceType = _resourceType
            };
        }

        /// <summary>
        /// Reset all properties' to the default value
        /// </summary>
        /// <returns>
        /// Returns the <see cref="GetExpirationsBuilder">GetExpirationsBuilder</see> with the
        /// properties reseted
        /// </returns>
        public GetExpirationsBuilder Reset()
        {
            _companyId = default;
            _expirationType = default;
            _page = default;
            _pageSize = default;
            _resourceId = default;
            _resourceType = default;

            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="int?" /> for the property <paramref name="companyId">companyId</paramref>
        /// </summary>
        /// <param name="companyId">
        /// A value of type <typeparamref name="int?" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="GetExpirationsBuilder">GetExpirationsBuilder</see> with the
        /// property <paramref name="companyId">companyId</paramref> defined
        /// </returns>
        public GetExpirationsBuilder WithCompanyId(int companyId)
        {
            _companyId = companyId;
            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="string" /> for the property <paramref name="expirationType">expirationType</paramref>
        /// </summary>
        /// <param name="expirationType">
        /// A value of type <typeparamref name="string" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="GetExpirationsBuilder">GetExpirationsBuilder</see> with the
        /// property <paramref name="expirationType">expirationType</paramref> defined
        /// </returns>
        public GetExpirationsBuilder WithExpirationType(string expirationType)
        {
            _expirationType = expirationType;
            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="int?" /> for the property <paramref name="page">page</paramref>
        /// </summary>
        /// <param name="page">
        /// A value of type <typeparamref name="int?" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="GetExpirationsBuilder">GetExpirationsBuilder</see> with the
        /// property <paramref name="page">page</paramref> defined
        /// </returns>
        public GetExpirationsBuilder WithPage(int page)
        {
            _page = page;
            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="int?" /> for the property <paramref name="pageSize">pageSize</paramref>
        /// </summary>
        /// <param name="pageSize">
        /// A value of type <typeparamref name="int?" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="GetExpirationsBuilder">GetExpirationsBuilder</see> with the
        /// property <paramref name="pageSize">pageSize</paramref> defined
        /// </returns>
        public GetExpirationsBuilder WithPageSize(int pageSize)
        {
            _pageSize = pageSize;
            return this;
        }

        /// <summary>
        /// Set a value for the property <paramref name="resourceId">resourceId</paramref> and
        /// <paramref name="resourceType">resourceType</paramref>
        /// </summary>
        /// <param name="resourceId">
        /// A value of type <typeparamref name="int" /> will the defined for the property
        /// </param>
        /// <param name="resourceType">
        /// A value of type <typeparamref name="int" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="GetExpirationsBuilder">GetExpirationsBuilder</see>.
        /// </returns>
        public GetExpirationsBuilder WithResource(int resourceId, int resourceType)
        {
            _resourceId = resourceId;
            _resourceType = resourceType;
            return this;
        }
    }
}