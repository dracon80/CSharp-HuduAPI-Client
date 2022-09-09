namespace HuduAPI.Endpoints.Parameters
{
    /// <summary>
    /// Builder for the class <see cref="GetMagicDash">GetMagicDash</see>
    /// </summary>
    public class GetMagicDashBuilder
    {
        private int? _companyId;
        private int? _page;
        private int? _pageSize;
        private string? _title;

        /// <summary>
        /// Create a new instance for the <see cref="GetMagicDashBuilder">GetMagicDashBuilder</see>
        /// </summary>
        public GetMagicDashBuilder()
        {
            Reset();
        }

        /// <summary>
        /// Build a class of type <see cref="GetMagicDash">GetMagicDash</see> with all the defined values
        /// </summary>
        /// <returns>
        /// Returns a <see cref="GetMagicDash">GetMagicDash</see> class
        /// </returns>
        public GetMagicDash Build()
        {
            return new GetMagicDash
            {
                Title = _title,
                CompanyId = _companyId,
                Page = _page,
                PageSize = _pageSize,
            };
        }

        /// <summary>
        /// Reset all properties' to the default value
        /// </summary>
        /// <returns>
        /// Returns the <see cref="GetMagicDashBuilder">GetMagicDashBuilder</see> with the
        /// properties reseted
        /// </returns>
        public GetMagicDashBuilder Reset()
        {
            _title = default;
            _companyId = default;
            _page = default;
            _pageSize = default;

            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="int?" /> for the property <paramref name="companyId">companyId</paramref>
        /// </summary>
        /// <param name="companyId">
        /// A value of type <typeparamref name="int?" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="GetMagicDashBuilder">GetMagicDashBuilder</see> with the property
        /// <paramref name="companyId">companyId</paramref> defined
        /// </returns>
        public GetMagicDashBuilder WithCompanyId(int companyId)
        {
            _companyId = companyId;
            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="int?" /> for the property <paramref name="page">page</paramref>
        /// </summary>
        /// <param name="page">
        /// A value of type <typeparamref name="int?" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="GetMagicDashBuilder">GetMagicDashBuilder</see> with the property
        /// <paramref name="page">page</paramref> defined
        /// </returns>
        public GetMagicDashBuilder WithPage(int page)
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
        /// Returns the <see cref="GetMagicDashBuilder">GetMagicDashBuilder</see> with the property
        /// <paramref name="pageSize">pageSize</paramref> defined
        /// </returns>
        public GetMagicDashBuilder WithPageSize(int pageSize)
        {
            _pageSize = pageSize;
            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="string" /> for the property <paramref name="title">title</paramref>
        /// </summary>
        /// <param name="title">
        /// A value of type <typeparamref name="string" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="GetMagicDashBuilder">GetMagicDashBuilder</see> with the property
        /// <paramref name="title">title</paramref> defined
        /// </returns>
        public GetMagicDashBuilder WithTitle(string title)
        {
            _title = title;
            return this;
        }
    }
}